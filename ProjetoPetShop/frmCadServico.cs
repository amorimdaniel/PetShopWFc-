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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.servicoBindingSource.EndEdit();
                servicoTableAdapter.Update(petshopDataSet.servico);
                groupBox1.Enabled = false;
                MessageBox.Show("Regristro salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }

        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.servico' table. You can move, or remove it, as needed.
            this.servicoTableAdapter.Fill(this.petshopDataSet.servico);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            servicoBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confimar exclusão", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    servicoBindingSource.RemoveCurrent();
                    servicoTableAdapter.Update(petshopDataSet.servico);
                }
            }
            catch (Exception)
            {
                servicoTableAdapter.Fill(petshopDataSet.servico);
                MessageBox.Show("Não pode ser excluído");
            }
        }
    }
}
