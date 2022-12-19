using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetShop
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
                groupBox1.Enabled = false;
                MessageBox.Show("Regristro salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confimar exclusão", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(petshopDataSet.cliente);
                }
            }
            catch (Exception)
            {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Não pode ser excluído");
            }

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fotos (*.jgp; *.png;) | *.jpg; *.png";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar a imagem", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
