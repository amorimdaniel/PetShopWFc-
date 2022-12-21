
namespace ProjetoPetShop
{
    partial class frmCadServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadServico));
            System.Windows.Forms.Label serv_codigoLabel;
            System.Windows.Forms.Label serv_descricaoLabel;
            System.Windows.Forms.Label serv_precoLabel;
            System.Windows.Forms.Label serv_tempoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new ProjetoPetShop.petshopDataSet();
            this.servicoTableAdapter = new ProjetoPetShop.petshopDataSetTableAdapters.servicoTableAdapter();
            this.tableAdapterManager = new ProjetoPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.servicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.servicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.serv_codigoLabel1 = new System.Windows.Forms.Label();
            this.serv_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.serv_precoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.serv_tempoComboBox = new System.Windows.Forms.ComboBox();
            serv_codigoLabel = new System.Windows.Forms.Label();
            serv_descricaoLabel = new System.Windows.Forms.Label();
            serv_precoLabel = new System.Windows.Forms.Label();
            serv_tempoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).BeginInit();
            this.servicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(serv_codigoLabel);
            this.groupBox1.Controls.Add(this.serv_codigoLabel1);
            this.groupBox1.Controls.Add(serv_descricaoLabel);
            this.groupBox1.Controls.Add(this.serv_descricaoTextBox);
            this.groupBox1.Controls.Add(serv_precoLabel);
            this.groupBox1.Controls.Add(this.serv_precoMaskedTextBox);
            this.groupBox1.Controls.Add(serv_tempoLabel);
            this.groupBox1.Controls.Add(this.serv_tempoComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do serviço";
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicoBindingNavigator
            // 
            this.servicoBindingNavigator.AddNewItem = null;
            this.servicoBindingNavigator.BindingSource = this.servicoBindingSource;
            this.servicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicoBindingNavigator.DeleteItem = null;
            this.servicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.servicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.servicoBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.servicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicoBindingNavigator.Name = "servicoBindingNavigator";
            this.servicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicoBindingNavigator.Size = new System.Drawing.Size(913, 39);
            this.servicoBindingNavigator.TabIndex = 1;
            this.servicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // servicoBindingNavigatorSaveItem
            // 
            this.servicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicoBindingNavigatorSaveItem.Image")));
            this.servicoBindingNavigatorSaveItem.Name = "servicoBindingNavigatorSaveItem";
            this.servicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.servicoBindingNavigatorSaveItem.Text = "Save Data";
            this.servicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicoBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(52, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // serv_codigoLabel
            // 
            serv_codigoLabel.AutoSize = true;
            serv_codigoLabel.Location = new System.Drawing.Point(237, 152);
            serv_codigoLabel.Name = "serv_codigoLabel";
            serv_codigoLabel.Size = new System.Drawing.Size(144, 29);
            serv_codigoLabel.TabIndex = 0;
            serv_codigoLabel.Text = "serv codigo:";
            // 
            // serv_codigoLabel1
            // 
            this.serv_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_codigo", true));
            this.serv_codigoLabel1.Location = new System.Drawing.Point(418, 152);
            this.serv_codigoLabel1.Name = "serv_codigoLabel1";
            this.serv_codigoLabel1.Size = new System.Drawing.Size(121, 23);
            this.serv_codigoLabel1.TabIndex = 1;
            this.serv_codigoLabel1.Text = "label1";
            // 
            // serv_descricaoLabel
            // 
            serv_descricaoLabel.AutoSize = true;
            serv_descricaoLabel.Location = new System.Drawing.Point(237, 187);
            serv_descricaoLabel.Name = "serv_descricaoLabel";
            serv_descricaoLabel.Size = new System.Drawing.Size(175, 29);
            serv_descricaoLabel.TabIndex = 2;
            serv_descricaoLabel.Text = "serv descricao:";
            // 
            // serv_descricaoTextBox
            // 
            this.serv_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_descricao", true));
            this.serv_descricaoTextBox.Location = new System.Drawing.Point(418, 184);
            this.serv_descricaoTextBox.Name = "serv_descricaoTextBox";
            this.serv_descricaoTextBox.Size = new System.Drawing.Size(121, 34);
            this.serv_descricaoTextBox.TabIndex = 3;
            // 
            // serv_precoLabel
            // 
            serv_precoLabel.AutoSize = true;
            serv_precoLabel.Location = new System.Drawing.Point(237, 227);
            serv_precoLabel.Name = "serv_precoLabel";
            serv_precoLabel.Size = new System.Drawing.Size(132, 29);
            serv_precoLabel.TabIndex = 4;
            serv_precoLabel.Text = "serv preco:";
            // 
            // serv_precoMaskedTextBox
            // 
            this.serv_precoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_preco", true));
            this.serv_precoMaskedTextBox.Location = new System.Drawing.Point(418, 224);
            this.serv_precoMaskedTextBox.Mask = "$ 99.99";
            this.serv_precoMaskedTextBox.Name = "serv_precoMaskedTextBox";
            this.serv_precoMaskedTextBox.Size = new System.Drawing.Size(121, 34);
            this.serv_precoMaskedTextBox.TabIndex = 5;
            // 
            // serv_tempoLabel
            // 
            serv_tempoLabel.AutoSize = true;
            serv_tempoLabel.Location = new System.Drawing.Point(237, 267);
            serv_tempoLabel.Name = "serv_tempoLabel";
            serv_tempoLabel.Size = new System.Drawing.Size(138, 29);
            serv_tempoLabel.TabIndex = 6;
            serv_tempoLabel.Text = "serv tempo:";
            // 
            // serv_tempoComboBox
            // 
            this.serv_tempoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_tempo", true));
            this.serv_tempoComboBox.FormattingEnabled = true;
            this.serv_tempoComboBox.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "120"});
            this.serv_tempoComboBox.Location = new System.Drawing.Point(418, 264);
            this.serv_tempoComboBox.Name = "serv_tempoComboBox";
            this.serv_tempoComboBox.Size = new System.Drawing.Size(121, 37);
            this.serv_tempoComboBox.TabIndex = 7;
            // 
            // frmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(913, 652);
            this.Controls.Add(this.servicoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadServico";
            this.Load += new System.EventHandler(this.frmCadServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).EndInit();
            this.servicoBindingNavigator.ResumeLayout(false);
            this.servicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private petshopDataSetTableAdapters.servicoTableAdapter servicoTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton servicoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Label serv_codigoLabel1;
        private System.Windows.Forms.TextBox serv_descricaoTextBox;
        private System.Windows.Forms.MaskedTextBox serv_precoMaskedTextBox;
        private System.Windows.Forms.ComboBox serv_tempoComboBox;
    }
}