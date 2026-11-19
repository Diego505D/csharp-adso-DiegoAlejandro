using Reto.Data;
using Reto.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Reto
{
    public partial class Form1 : Form
    {

        private int idContactoSeleccionado;
        public Form1()
        {
            InitializeComponent();

            using (var context = new AgendaContext())
            {
                context.Database.EnsureCreated();
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new AgendaContext())
            {
                db.Database.EnsureCreated();

                MessageBox.Show("Base de datos creada correctamente");
            }
        }

        private void CargarContactos()
        {
            using (AgendaContext db = new AgendaContext())
            {
                var contactos = db.Contactos
                    .AsNoTracking()
                    .OrderBy(c => c.Nombre)
                    .ToList();

                dgvContacto.DataSource = contactos;

                ActualizarTotal();
            }
        }


        private void ActualizarTotal()
        {
            using (AgendaContext db = new AgendaContext())
            {
                int total = db.Contactos.Count();

                lblTotal.Text = "Total: " + total;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            bool valido = true;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider1.SetError(txtNombre,
                    "El nombre es obligatorio");

                valido = false;
            }

            if (string.IsNullOrWhiteSpace(correo) ||
                !correo.Contains("@"))
            {
                errorProvider1.SetError(txtCorreo,
                    "Ingrese un correo válido con @");

                valido = false;
            }

            if (!valido)
            {
                return;
            }

            using (AgendaContext db = new AgendaContext())
            {
                Contacto nuevo = new Contacto
                {
                    Nombre = nombre,
                    Telefono = telefono,
                    Correo = correo
                };

                db.Contactos.Add(nuevo);
                db.SaveChanges();
            }

            MessageBox.Show("Contacto agregado correctamente");

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            CargarContactos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContacto.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un contacto");
                return;
            }

            int id = Convert.ToInt32(
                dgvContacto.CurrentRow.Cells["Id"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este contacto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                using (AgendaContext db = new AgendaContext())
                {
                    var contacto = db.Contactos.Find(id);

                    if (contacto != null)
                    {
                        db.Contactos.Remove(contacto);
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Contacto eliminado");

                CargarContactos();
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            using (AgendaContext db = new AgendaContext())
            {
                var contactos = db.Contactos
                    .AsNoTracking()
                    .Where(c => c.Nombre.Contains(busqueda))
                    .OrderBy(c => c.Nombre)
                    .ToList();

                dgvContacto.DataSource = contactos;
            }
        }

        private void dgvContacto_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvContacto.Rows[e.RowIndex];

                    idContactoSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

                    txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                    txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = fila.Cells["Correo"].Value.ToString();

                    MessageBox.Show("ID seleccionado: " + idContactoSeleccionado);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AgendaContext())
            {
                var contacto = db.Contactos.Find(idContactoSeleccionado);

                if (contacto != null)
                {
                    contacto.Nombre = txtNombre.Text;
                    contacto.Telefono = txtTelefono.Text;
                    contacto.Correo = txtCorreo.Text;

                    db.SaveChanges();

                    CargarContactos();

                    MessageBox.Show("Contacto actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto");
                }
            }
        }
    }
}
