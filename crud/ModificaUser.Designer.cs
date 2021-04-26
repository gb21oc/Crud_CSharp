
namespace crud
{
    partial class ModificaUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_User = new System.Windows.Forms.TextBox();
            this.txtEmail_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPermissao = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.txtMsgSuporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAdm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnEnviarMsg = new System.Windows.Forms.Button();
            this.btnCadastroDespesas = new System.Windows.Forms.Button();
            this.btnChamados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome_User
            // 
            this.txtNome_User.Location = new System.Drawing.Point(76, 9);
            this.txtNome_User.Name = "txtNome_User";
            this.txtNome_User.Size = new System.Drawing.Size(175, 20);
            this.txtNome_User.TabIndex = 1;
            // 
            // txtEmail_User
            // 
            this.txtEmail_User.Location = new System.Drawing.Point(313, 9);
            this.txtEmail_User.Name = "txtEmail_User";
            this.txtEmail_User.Size = new System.Drawing.Size(175, 20);
            this.txtEmail_User.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Permissão:";
            // 
            // cbPermissao
            // 
            this.cbPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermissao.FormattingEnabled = true;
            this.cbPermissao.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbPermissao.Location = new System.Drawing.Point(573, 9);
            this.cbPermissao.Name = "cbPermissao";
            this.cbPermissao.Size = new System.Drawing.Size(121, 21);
            this.cbPermissao.TabIndex = 5;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(745, 8);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(745, 40);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(745, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUser.Location = new System.Drawing.Point(368, 129);
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(482, 347);
            this.gridUser.TabIndex = 9;
            this.gridUser.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUser_CellContentDoubleClick);
            // 
            // txtMsgSuporte
            // 
            this.txtMsgSuporte.Location = new System.Drawing.Point(34, 129);
            this.txtMsgSuporte.Multiline = true;
            this.txtMsgSuporte.Name = "txtMsgSuporte";
            this.txtMsgSuporte.Size = new System.Drawing.Size(313, 320);
            this.txtMsgSuporte.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mensagem para suporte:";
            // 
            // txtNameMsg
            // 
            this.txtNameMsg.Location = new System.Drawing.Point(130, 44);
            this.txtNameMsg.Name = "txtNameMsg";
            this.txtNameMsg.Size = new System.Drawing.Size(328, 20);
            this.txtNameMsg.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome Mensagem:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbFuncionario.Location = new System.Drawing.Point(271, 71);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cbFuncionario.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Funcionario:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbCliente.Location = new System.Drawing.Point(76, 71);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cliente:";
            // 
            // cbAdm
            // 
            this.cbAdm.FormattingEnabled = true;
            this.cbAdm.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbAdm.Location = new System.Drawing.Point(471, 71);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Size = new System.Drawing.Size(121, 21);
            this.cbAdm.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Administrador:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(365, 104);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 13);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "Usuarios:";
            // 
            // btnEnviarMsg
            // 
            this.btnEnviarMsg.Location = new System.Drawing.Point(272, 458);
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarMsg.TabIndex = 21;
            this.btnEnviarMsg.Text = "Enviar";
            this.btnEnviarMsg.UseVisualStyleBackColor = true;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // btnCadastroDespesas
            // 
            this.btnCadastroDespesas.Location = new System.Drawing.Point(574, 191);
            this.btnCadastroDespesas.Name = "btnCadastroDespesas";
            this.btnCadastroDespesas.Size = new System.Drawing.Size(114, 23);
            this.btnCadastroDespesas.TabIndex = 22;
            this.btnCadastroDespesas.Text = "Cadastrar Despesas";
            this.btnCadastroDespesas.UseVisualStyleBackColor = true;
            // 
            // btnChamados
            // 
            this.btnChamados.Location = new System.Drawing.Point(745, 100);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(75, 23);
            this.btnChamados.TabIndex = 23;
            this.btnChamados.Text = "Chamados";
            this.btnChamados.UseVisualStyleBackColor = true;
            // 
            // ModificaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 493);
            this.Controls.Add(this.btnChamados);
            this.Controls.Add(this.btnCadastroDespesas);
            this.Controls.Add(this.btnEnviarMsg);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMsgSuporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.cbPermissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome_User);
            this.Controls.Add(this.label1);
            this.Name = "ModificaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaUser";
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome_User;
        private System.Windows.Forms.TextBox txtEmail_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPermissao;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.TextBox txtMsgSuporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAdm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnEnviarMsg;
        private System.Windows.Forms.Button btnCadastroDespesas;
        private System.Windows.Forms.Button btnChamados;
    }
}