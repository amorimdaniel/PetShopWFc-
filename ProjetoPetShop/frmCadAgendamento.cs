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
    public partial class frmCadAgendamento : Form
    {
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);
            // TODO: This line of code loads data into the 'petshopDataSet.agendamento' table. You can move, or remove it, as needed.
            this.agendamentoTableAdapter.Fill(this.petshopDataSet.agendamento);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ag_situacaoComboBox.Text = "Agendado";
            ag_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            ag_horarioMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            ag_totalTextBox.Text = "0.00";
            groupBox1.Enabled = true;
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                groupBox1.Enabled = false;
                MessageBox.Show("Agendamento salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            ag_horarioMaskedTextBox.Clear();
            ag_dataMaskedTextBox.Clear();
            ag_horarioMaskedTextBox.Clear();
            ag_situacaoComboBox.Text = "";
            ag_totalTextBox.Clear();
            agendamentoBindingSource.CancelEdit();
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
                    agendamentoBindingSource.RemoveCurrent();
                    agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                }
            }
            catch (Exception)
            {
                agendamentoTableAdapter.Fill(petshopDataSet.agendamento);
                MessageBox.Show("Não pode ser excluído");
            }
        }
    }
}
