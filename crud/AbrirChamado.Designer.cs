
namespace crud
{
    partial class AbrirChamado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.txtCorpoMensagem = new System.Windows.Forms.TextBox();
            this.txtTituloMsg = new System.Windows.Forms.TextBox();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrirChamado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeUser);
            this.groupBox1.Controls.Add(this.txtCorpoMensagem);
            this.groupBox1.Controls.Add(this.txtTituloMsg);
            this.groupBox1.Controls.Add(this.txtEmailUser);
            this.groupBox1.Location = new System.Drawing.Point(50, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 427);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Chamado";
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Location = new System.Drawing.Point(123, 380);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(86, 23);
            this.btnAbrirChamado.TabIndex = 11;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mensagem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Enabled = false;
            this.txtNomeUser.Location = new System.Drawing.Point(21, 42);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(290, 20);
            this.txtNomeUser.TabIndex = 5;
            // 
            // txtCorpoMensagem
            // 
            this.txtCorpoMensagem.Location = new System.Drawing.Point(21, 202);
            this.txtCorpoMensagem.Multiline = true;
            this.txtCorpoMensagem.Name = "txtCorpoMensagem";
            this.txtCorpoMensagem.Size = new System.Drawing.Size(290, 172);
            this.txtCorpoMensagem.TabIndex = 2;
            // 
            // txtTituloMsg
            // 
            this.txtTituloMsg.Location = new System.Drawing.Point(21, 152);
            this.txtTituloMsg.Name = "txtTituloMsg";
            this.txtTituloMsg.Size = new System.Drawing.Size(290, 20);
            this.txtTituloMsg.TabIndex = 3;
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Enabled = false;
            this.txtEmailUser.Location = new System.Drawing.Point(21, 97);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(290, 20);
            this.txtEmailUser.TabIndex = 4;
            // 
            // AbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AbrirChamado";
            this.Text = "AbrirChamado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.TextBox txtCorpoMensagem;
        private System.Windows.Forms.TextBox txtTituloMsg;
        private System.Windows.Forms.TextBox txtEmailUser;
    }
}