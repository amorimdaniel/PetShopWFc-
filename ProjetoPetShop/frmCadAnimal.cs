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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(petshopDataSet.animal);
                groupBox1.Enabled = false;
                MessageBox.Show("Regristro salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.raca' table. You can move, or remove it, as needed.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);
            // TODO: This line of code loads data into the 'petshopDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
            // TODO: This line of code loads data into the 'petshopDataSet.animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confimar exclusão", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(petshopDataSet.animal);
                }
            }
            catch (Exception)
            {
                animalTableAdapter.Fill(petshopDataSet.animal);
                MessageBox.Show("Não pode ser excluído");
            }
        }

        private void btnFotoAnimal_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fotos (*.jgp; *.png;) | *.jpg; *.png";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar a imagem", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
