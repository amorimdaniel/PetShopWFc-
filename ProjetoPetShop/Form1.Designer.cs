
namespace ProjetoPetShop
{
    partial class Form1
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
            this.panelLeral = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelLeral.SuspendLayout();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeral
            // 
            this.panelLeral.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLeral.Controls.Add(this.panelSelecao);
            this.panelLeral.Controls.Add(this.btnInicio);
            this.panelLeral.Controls.Add(this.btnAgendamento);
            this.panelLeral.Controls.Add(this.btnServicos);
            this.panelLeral.Controls.Add(this.btnAnimal);
            this.panelLeral.Controls.Add(this.btnRaca);
            this.panelLeral.Controls.Add(this.btnCliente);
            this.panelLeral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeral.Location = new System.Drawing.Point(0, 67);
            this.panelLeral.Name = "panelLeral";
            this.panelLeral.Size = new System.Drawing.Size(274, 652);
            this.panelLeral.TabIndex = 0;
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelSelecao.Location = new System.Drawing.Point(3, 6);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(14, 76);
            this.panelSelecao.TabIndex = 6;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(20, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(241, 76);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Location = new System.Drawing.Point(20, 540);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(241, 76);
            this.btnAgendamento.TabIndex = 4;
            this.btnAgendamento.Text = "Agendamentos";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Location = new System.Drawing.Point(20, 429);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(241, 76);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Location = new System.Drawing.Point(20, 321);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(241, 76);
            this.btnAnimal.TabIndex = 2;
            this.btnAnimal.Text = "Animais";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnRaca
            // 
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.Location = new System.Drawing.Point(20, 213);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(241, 76);
            this.btnRaca.TabIndex = 1;
            this.btnRaca.Text = "Raças";
            this.btnRaca.UseVisualStyleBackColor = true;
            this.btnRaca.Click += new System.EventHandler(this.btnRaca_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(20, 109);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(241, 76);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopo.Controls.Add(this.btnMinimizar);
            this.panelTopo.Controls.Add(this.btnFechar);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(1187, 67);
            this.panelTopo.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::ProjetoPetShop.Properties.Resources.minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1030, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(74, 67);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::ProjetoPetShop.Properties.Resources.sair;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1110, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(74, 67);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackgroundImage = global::ProjetoPetShop.Properties.Resources.cachorro;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.panelCentral.Location = new System.Drawing.Point(274, 67);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(913, 652);
            this.panelCentral.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 719);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLeral);
            this.Controls.Add(this.panelTopo);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeral.ResumeLayout(false);
            this.panelTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeral;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelSelecao;
    }
}

