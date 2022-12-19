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
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

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
    }
}
