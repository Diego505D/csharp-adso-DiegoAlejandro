using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormPrincipal : Form
{
    private readonly ServicioInventario _servicio = new(new RepositorioEf());

    public FormPrincipal()
    {
        InitializeComponent();

        timer1.Interval = 1000;
        timer1.Start();

        CargarProductos();
        CargarFiltroCategorias();
    }

    private void CargarProductos(List<Producto>? productos = null)
    {
        var listaActual = productos ?? _servicio.Listar();
        dgvProductos.DataSource = null;
        dgvProductos.DataSource = listaActual;

        decimal total = listaActual.Sum(p => p.Precio * p.Stock);
        lblValor.Text = $"Valor del inventario: {total:C0}";

        lblEstadoCantidad.Text = $"Total de productos: {listaActual.Count}";
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e) =>
        CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));

    private Producto? Seleccionado() => dgvProductos.CurrentRow?.DataBoundItem as Producto;

    private void dgvProductos_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
        {
            precio.DefaultCellStyle.Format = "C0";
        }

        if (dgvProductos.Columns["CategoriaId"] is DataGridViewColumn id)
        {
            id.Visible = false;
        }

        foreach (DataGridViewRow fila in dgvProductos.Rows)
        {
            if (fila.DataBoundItem is Producto { Stock: < 5 })
            {
                fila.DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }
    }

    private void btnAgregar_Click_1(object sender, EventArgs e)
    {
        using var form = new FormProducto(_servicio.Categorias());
        if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null) return;

        try
        {
            _servicio.Agregar(form.ProductoCreado);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnVender_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            _servicio.Vender(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
        }
        catch (StockInsuficienteException ex)
        {
            MessageBox.Show(ex.Message, "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnAgregarStock_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            _servicio.AgregarStock(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
            MessageBox.Show("Stock actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto) return;

        var respuesta = MessageBox.Show($"¿Eliminar {producto.Nombre}?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            _servicio.Eliminar(producto.Codigo);
            CargarProductos();
        }
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

    private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Sistema de Inventario en Capas\nDesarrollado para la práctica de Windows Forms.",
            "Acerca de",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        lblEstadoHora.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (Seleccionado() is not Producto producto) return;

        using var form = new FormProducto(producto, _servicio.Categorias());
        if (form.ShowDialog() != DialogResult.OK) return;

        try
        {
            _servicio.Actualizar(producto.Codigo, producto.Nombre, producto.Precio);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnReportes_Click(object sender, EventArgs e)
    {
        using var formReportes = new FormReportes(_servicio);
        formReportes.ShowDialog();
        CargarProductos();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
    }

    private void DropDownList(object sender, EventArgs e)
    {

    }

    private bool _cargandoFiltros;

    private void CargarFiltroCategorias()
    {
        _cargandoFiltros = true;

        var opciones = new List<Categoria>
    {
        new() { Id = 0, Nombre = "Todas" }
    };
        opciones.AddRange(_servicio.Categorias());

        cmbFiltroCategoria.DataSource = opciones;
        cmbFiltroCategoria.DisplayMember = "Nombre";
        cmbFiltroCategoria.ValueMember = "Id";
        cmbFiltroCategoria.SelectedIndex = 0;

        _cargandoFiltros = false;
    }

    private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_cargandoFiltros) return;

        int? categoriaId = cmbFiltroCategoria.SelectedValue is int id && id > 0
            ? id
            : null;

        CargarProductos(_servicio.FiltrarPorCategoria(categoriaId));
    }

    private void btnResumenCategoria_Click(object sender, EventArgs e)
    {
        var resumen = _servicio.ResumenPorCategoria();
        if (resumen.Count == 0)
        {
            MessageBox.Show("No hay productos para resumir.", "Resumen por categoría",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var texto = string.Join(Environment.NewLine, resumen.Select(r =>
            $"{r.Categoria}: {r.CantidadProductos} prod. | Valor: {r.ValorInventario:C0}"));

        MessageBox.Show(texto, "Resumen por categoría",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}