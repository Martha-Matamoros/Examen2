using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class ProductoFrm : Form
    {
        public ProductoFrm()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;
        ProductoDA productoDA = new ProductoDA();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            operacion = "nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            codigoTxt.Enabled = true;
            descripcionTxt.Enabled = true;
            precioTxt.Enabled = true;
            existenciaTxt.Enabled = true;
            siguienteBtn.Enabled = true;
            guardarBtn.Enabled = true;
            salirBtn.Enabled = true;
            modificarBtn.Enabled = false;
        }

        private void DesabilitarControles()
        {
            codigoTxt.Enabled = false;
            descripcionTxt.Enabled = false;
            precioTxt.Enabled = false;
            existenciaTxt.Enabled = false;
            siguienteBtn.Enabled = false;
            guardarBtn.Enabled = false;
            salirBtn.Enabled = false;
            nuevoBtn.Enabled = true;
            modificarBtn.Enabled = true;

        }

        private void LimpiarControles()
        {
            codigoTxt.Clear();
            descripcionTxt.Clear();
            precioTxt.Clear();
            existenciaTxt.Clear();
            ImagenPictureBox.Image = null;
        }
        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(codigoTxt.Text))
                {
                    errorProvider1.SetError(codigoTxt, "Ingrese el código");
                    codigoTxt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(descripcionTxt.Text))
                {
                    errorProvider1.SetError(descripcionTxt, "Ingrese una descripción");
                    descripcionTxt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(precioTxt.Text))
                {
                    errorProvider1.SetError(precioTxt, "Ingrese un precio");
                    precioTxt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(existenciaTxt.Text))
                {
                    errorProvider1.SetError(existenciaTxt, "Ingrese una existencia");
                    existenciaTxt.Focus();
                    return;
                }

                Producto producto = new Producto();

                producto.Codigo = codigoTxt.Text;
                producto.Descripcion = descripcionTxt.Text;
                producto.Precio = Convert.ToDecimal(precioTxt.Text);
                producto.Existencia = Convert.ToInt32(existenciaTxt.Text);

                if (ImagenPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    ImagenPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    producto.Imagen = ms.GetBuffer();
                }

                if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(producto);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Modificado");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ImagenPictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("Producto Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                codigoTxt.Text = ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                descripcionTxt.Text = ProductosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                precioTxt.Text = ProductosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                existenciaTxt.Text = ProductosDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

                var temporal = productoDA.SeleccionarImagen(ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (temporal.Length > 0)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(temporal);
                    ImagenPictureBox.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                {
                    ImagenPictureBox.Image = null;
                }
                HabilitarControles();
                codigoTxt.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void existenciaTxt_TextChanged(object sender, EventArgs e)
        {
        }
        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


            private void ProductoFrm_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }
        private void ListarProductos()
        {
            ProductosDataGridView.DataSource = productoDA.ListarProductos();
        }

        private void precioTxt_TextChanged(object sender, EventArgs e)
        {
        }
        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(precioTxt, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void descripcionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ImagenPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
