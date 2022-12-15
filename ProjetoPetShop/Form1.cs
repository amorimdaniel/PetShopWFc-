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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            { 
                Application.Exit(); 
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(cliente);
            cliente.Show();

            panelSelecao.Top = btnCliente.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
            panelSelecao.Top = btnInicio.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmCadRaca raca = new frmCadRaca();
            raca.TopLevel = false;
            raca.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(raca);
            raca.Show();

            panelSelecao.Top = btnRaca.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal animal = new frmCadAnimal();
            animal.TopLevel = false;
            animal.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(animal);
            animal.Show();

            panelSelecao.Top = btnAnimal.Top;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmCadServico servico = new frmCadServico();
            servico.TopLevel = false;
            servico.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(servico);
            servico.Show();

            panelSelecao.Top = btnServicos.Top;
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            frmCadAgendamento agendamento = new frmCadAgendamento();
            agendamento.TopLevel = false;
            agendamento.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(agendamento);
            agendamento.Show();

            panelSelecao.Top = btnAgendamento.Top;
        }
    }
}
