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
    public partial class frmCadRaca : Form
    {
        public frmCadRaca()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.racaBindingSource.EndEdit();
                racaTableAdapter.Update(petshopDataSet.raca);
                groupBox1.Enabled = false;
                MessageBox.Show("Regristro salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }

        }

        private void frmCadRaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.raca' table. You can move, or remove it, as needed.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            racaBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            racaBindingSource.CancelEdit();
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
                    racaBindingSource.RemoveCurrent();
                    racaTableAdapter.Update(petshopDataSet.raca);
                }
            }
            catch (Exception)
            {
                racaTableAdapter.Fill(petshopDataSet.raca);
                MessageBox.Show("Não pode ser excluído");
            }
        }
    }
}
