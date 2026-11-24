using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }
    private readonly Producto? _productoExistente;

    public FormProducto() => InitializeComponent();

    // Constructor para CREAR un producto nuevo con lista de categorías
    public FormProducto(List<Categoria> categorias) : this()
    {
        ConfigurarCategorias(categorias);
    }

    // Constructor para EDITAR un producto existente
    public FormProducto(Producto productoAEditar) : this()
    {
        _productoExistente = productoAEditar;

        txtCodigo.Text = productoAEditar.Codigo;
        txtCodigo.Enabled = false;

        txtNombre.Text = productoAEditar.Nombre;
        nudPrecio.Value = productoAEditar.Precio;
        nudStock.Value = productoAEditar.Stock;
        nudStock.Enabled = false;
    }

    // Sobrecarga útil si al editar también pasas las categorías
    public FormProducto(Producto productoAEditar, List<Categoria> categorias) : this(productoAEditar)
    {
        ConfigurarCategorias(categorias);
        if (productoAEditar.CategoriaId.HasValue)
        {
            cmbCategoria.SelectedValue = productoAEditar.CategoriaId.Value;
        }
    }

    private void ConfigurarCategorias(List<Categoria> categorias)
    {
        cmbCategoria.DataSource = categorias;
        cmbCategoria.DisplayMember = "Nombre";
        cmbCategoria.ValueMember = "Id";
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        try
        {
            int? categoriaId = cmbCategoria.SelectedValue as int?;

            if (_productoExistente is null)
            {
                ProductoCreado = new Producto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    nudPrecio.Value,
                    (int)nudStock.Value
                );

                ProductoCreado.CambiarCategoria(cmbCategoria.SelectedValue as int?);
            }
            else
            {
                _productoExistente.ActualizarDatos(txtNombre.Text, nudPrecio.Value);
                _productoExistente.CambiarCategoria(categoriaId);
                ProductoCreado = _productoExistente;
            }

            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }
}