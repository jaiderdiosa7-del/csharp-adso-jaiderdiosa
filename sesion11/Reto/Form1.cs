using Practica1;
using Microsoft.EntityFrameworkCore;

namespace Reto
{
    public partial class Form1 : Form
    {

        private int? contactoId = null;
        public Form1()
        {
            InitializeComponent();

            using (var db = new AgendaContext())
                db.Database.EnsureCreated();

            CargarContactos();
        }

        private void CargarContactos(string filtro = "")
        {
            using var db = new AgendaContext();

            dgvContactos.DataSource = db.Contactos
                .Where(c => EF.Functions.Like(c.Nombre, $"%{filtro}%"))
                .OrderBy(c => c.Nombre)
                .ToList();

            lblTotal.Text = $"{dgvContactos.Rows.Count} contactos";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarContactos(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Escribe el nombre.");
                return;
            }

            if (!txtCorreo.Text.Contains("@"))
            {
                errorProvider1.SetError(txtCorreo, "Correo inválido.");
                return;
            }

            using var db = new AgendaContext();

            db.Contactos.Add(new Contacto
            {
                Nombre = txtNombre.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            });

            db.SaveChanges();

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            CargarContactos(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow?.DataBoundItem is not Contacto contacto)
                return;

            if (MessageBox.Show(
                $"¿Eliminar a {contacto.Nombre}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using var db = new AgendaContext();

            db.Contactos.Remove(contacto);
            db.SaveChanges();

            CargarContactos(txtBuscar.Text);
        }

        private void dgvContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvContactos.Rows[e.RowIndex].DataBoundItem is not Contacto contacto)
                return;

            contactoId = contacto.Id;

            txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            txtCorreo.Text = contacto.Correo;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (contactoId == null) return;

            using var db = new AgendaContext();

            var contacto = db.Contactos.Find(contactoId);

            if (contacto == null) return;

            contacto.Nombre = txtNombre.Text.Trim();
            contacto.Telefono = txtTelefono.Text.Trim();
            contacto.Correo = txtCorreo.Text.Trim();

            db.SaveChanges();

            contactoId = null;

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            CargarContactos(txtBuscar.Text);
        }
    }
}
