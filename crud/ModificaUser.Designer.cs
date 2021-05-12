
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
            this.lblPermissao = new System.Windows.Forms.Label();
            this.cbPermissao = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbAdm = new System.Windows.Forms.ComboBox();
            this.lblAdm = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCadastroDespesas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDtDezembro = new System.Windows.Forms.Label();
            this.lblDtNovembro = new System.Windows.Forms.Label();
            this.lblDtOutubro = new System.Windows.Forms.Label();
            this.lblDtSetembro = new System.Windows.Forms.Label();
            this.lblDtFev = new System.Windows.Forms.Label();
            this.lblDtMarco = new System.Windows.Forms.Label();
            this.lblDtAbril = new System.Windows.Forms.Label();
            this.lblDtMaio = new System.Windows.Forms.Label();
            this.lblDtAgosto = new System.Windows.Forms.Label();
            this.lblDtJunho = new System.Windows.Forms.Label();
            this.lblDtJulho = new System.Windows.Forms.Label();
            this.lblDtJan = new System.Windows.Forms.Label();
            this.lblValorDezembro = new System.Windows.Forms.Label();
            this.lblValorNovembro = new System.Windows.Forms.Label();
            this.lblValorOutubro = new System.Windows.Forms.Label();
            this.lblValorSetembro = new System.Windows.Forms.Label();
            this.lblValorFev = new System.Windows.Forms.Label();
            this.lblValorMarco = new System.Windows.Forms.Label();
            this.lblValorAbril = new System.Windows.Forms.Label();
            this.lblValorMaio = new System.Windows.Forms.Label();
            this.lblValorAgosto = new System.Windows.Forms.Label();
            this.lblValorJunho = new System.Windows.Forms.Label();
            this.lblValorJulho = new System.Windows.Forms.Label();
            this.lblValorJan = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioUpdate = new System.Windows.Forms.TextBox();
            this.lblSalarioUpdate = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblCadastrarDespesas = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.txtEmail_User.Location = new System.Drawing.Point(309, 9);
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
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(509, 13);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(58, 13);
            this.lblPermissao.TabIndex = 4;
            this.lblPermissao.Text = "Permissão:";
            // 
            // cbPermissao
            // 
            this.cbPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermissao.FormattingEnabled = true;
            this.cbPermissao.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbPermissao.Location = new System.Drawing.Point(581, 9);
            this.cbPermissao.Name = "cbPermissao";
            this.cbPermissao.Size = new System.Drawing.Size(121, 21);
            this.cbPermissao.TabIndex = 5;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(709, 8);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(791, 8);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(709, 37);
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
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbFuncionario.Location = new System.Drawing.Point(339, 35);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(150, 21);
            this.cbFuncionario.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 39);
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
            this.cbCliente.Location = new System.Drawing.Point(76, 35);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(175, 21);
            this.cbCliente.TabIndex = 17;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(31, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbAdm
            // 
            this.cbAdm.FormattingEnabled = true;
            this.cbAdm.Items.AddRange(new object[] {
            "Comum",
            "Funcionario",
            "Administrador"});
            this.cbAdm.Location = new System.Drawing.Point(582, 35);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Size = new System.Drawing.Size(121, 21);
            this.cbAdm.TabIndex = 19;
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Location = new System.Drawing.Point(509, 39);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(73, 13);
            this.lblAdm.TabIndex = 18;
            this.lblAdm.Text = "Administrador:";
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
            // btnCadastroDespesas
            // 
            this.btnCadastroDespesas.Location = new System.Drawing.Point(574, 191);
            this.btnCadastroDespesas.Name = "btnCadastroDespesas";
            this.btnCadastroDespesas.Size = new System.Drawing.Size(114, 23);
            this.btnCadastroDespesas.TabIndex = 22;
            this.btnCadastroDespesas.Text = "Cadastrar Despesas";
            this.btnCadastroDespesas.UseVisualStyleBackColor = true;
            this.btnCadastroDespesas.Click += new System.EventHandler(this.btnCadastroDespesas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDtDezembro);
            this.groupBox1.Controls.Add(this.lblDtNovembro);
            this.groupBox1.Controls.Add(this.lblDtOutubro);
            this.groupBox1.Controls.Add(this.lblDtSetembro);
            this.groupBox1.Controls.Add(this.lblDtFev);
            this.groupBox1.Controls.Add(this.lblDtMarco);
            this.groupBox1.Controls.Add(this.lblDtAbril);
            this.groupBox1.Controls.Add(this.lblDtMaio);
            this.groupBox1.Controls.Add(this.lblDtAgosto);
            this.groupBox1.Controls.Add(this.lblDtJunho);
            this.groupBox1.Controls.Add(this.lblDtJulho);
            this.groupBox1.Controls.Add(this.lblDtJan);
            this.groupBox1.Controls.Add(this.lblValorDezembro);
            this.groupBox1.Controls.Add(this.lblValorNovembro);
            this.groupBox1.Controls.Add(this.lblValorOutubro);
            this.groupBox1.Controls.Add(this.lblValorSetembro);
            this.groupBox1.Controls.Add(this.lblValorFev);
            this.groupBox1.Controls.Add(this.lblValorMarco);
            this.groupBox1.Controls.Add(this.lblValorAbril);
            this.groupBox1.Controls.Add(this.lblValorMaio);
            this.groupBox1.Controls.Add(this.lblValorAgosto);
            this.groupBox1.Controls.Add(this.lblValorJunho);
            this.groupBox1.Controls.Add(this.lblValorJulho);
            this.groupBox1.Controls.Add(this.lblValorJan);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 347);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos Mensais";
            // 
            // lblDtDezembro
            // 
            this.lblDtDezembro.AutoSize = true;
            this.lblDtDezembro.Location = new System.Drawing.Point(274, 317);
            this.lblDtDezembro.Name = "lblDtDezembro";
            this.lblDtDezembro.Size = new System.Drawing.Size(10, 13);
            this.lblDtDezembro.TabIndex = 66;
            this.lblDtDezembro.Text = "-";
            // 
            // lblDtNovembro
            // 
            this.lblDtNovembro.AutoSize = true;
            this.lblDtNovembro.Location = new System.Drawing.Point(274, 290);
            this.lblDtNovembro.Name = "lblDtNovembro";
            this.lblDtNovembro.Size = new System.Drawing.Size(10, 13);
            this.lblDtNovembro.TabIndex = 65;
            this.lblDtNovembro.Text = "-";
            // 
            // lblDtOutubro
            // 
            this.lblDtOutubro.AutoSize = true;
            this.lblDtOutubro.Location = new System.Drawing.Point(274, 261);
            this.lblDtOutubro.Name = "lblDtOutubro";
            this.lblDtOutubro.Size = new System.Drawing.Size(10, 13);
            this.lblDtOutubro.TabIndex = 64;
            this.lblDtOutubro.Text = "-";
            // 
            // lblDtSetembro
            // 
            this.lblDtSetembro.AutoSize = true;
            this.lblDtSetembro.Location = new System.Drawing.Point(274, 234);
            this.lblDtSetembro.Name = "lblDtSetembro";
            this.lblDtSetembro.Size = new System.Drawing.Size(10, 13);
            this.lblDtSetembro.TabIndex = 63;
            this.lblDtSetembro.Text = "-";
            // 
            // lblDtFev
            // 
            this.lblDtFev.AutoSize = true;
            this.lblDtFev.Location = new System.Drawing.Point(274, 49);
            this.lblDtFev.Name = "lblDtFev";
            this.lblDtFev.Size = new System.Drawing.Size(10, 13);
            this.lblDtFev.TabIndex = 62;
            this.lblDtFev.Text = "-";
            // 
            // lblDtMarco
            // 
            this.lblDtMarco.AutoSize = true;
            this.lblDtMarco.Location = new System.Drawing.Point(274, 74);
            this.lblDtMarco.Name = "lblDtMarco";
            this.lblDtMarco.Size = new System.Drawing.Size(10, 13);
            this.lblDtMarco.TabIndex = 61;
            this.lblDtMarco.Text = "-";
            // 
            // lblDtAbril
            // 
            this.lblDtAbril.AutoSize = true;
            this.lblDtAbril.Location = new System.Drawing.Point(274, 101);
            this.lblDtAbril.Name = "lblDtAbril";
            this.lblDtAbril.Size = new System.Drawing.Size(10, 13);
            this.lblDtAbril.TabIndex = 60;
            this.lblDtAbril.Text = "-";
            // 
            // lblDtMaio
            // 
            this.lblDtMaio.AutoSize = true;
            this.lblDtMaio.Location = new System.Drawing.Point(274, 127);
            this.lblDtMaio.Name = "lblDtMaio";
            this.lblDtMaio.Size = new System.Drawing.Size(10, 13);
            this.lblDtMaio.TabIndex = 59;
            this.lblDtMaio.Text = "-";
            // 
            // lblDtAgosto
            // 
            this.lblDtAgosto.AutoSize = true;
            this.lblDtAgosto.Location = new System.Drawing.Point(274, 208);
            this.lblDtAgosto.Name = "lblDtAgosto";
            this.lblDtAgosto.Size = new System.Drawing.Size(10, 13);
            this.lblDtAgosto.TabIndex = 58;
            this.lblDtAgosto.Text = "-";
            // 
            // lblDtJunho
            // 
            this.lblDtJunho.AutoSize = true;
            this.lblDtJunho.Location = new System.Drawing.Point(274, 182);
            this.lblDtJunho.Name = "lblDtJunho";
            this.lblDtJunho.Size = new System.Drawing.Size(10, 13);
            this.lblDtJunho.TabIndex = 57;
            this.lblDtJunho.Text = "-";
            // 
            // lblDtJulho
            // 
            this.lblDtJulho.AutoSize = true;
            this.lblDtJulho.Location = new System.Drawing.Point(274, 153);
            this.lblDtJulho.Name = "lblDtJulho";
            this.lblDtJulho.Size = new System.Drawing.Size(10, 13);
            this.lblDtJulho.TabIndex = 56;
            this.lblDtJulho.Text = "-";
            // 
            // lblDtJan
            // 
            this.lblDtJan.AutoSize = true;
            this.lblDtJan.Location = new System.Drawing.Point(274, 27);
            this.lblDtJan.Name = "lblDtJan";
            this.lblDtJan.Size = new System.Drawing.Size(10, 13);
            this.lblDtJan.TabIndex = 55;
            this.lblDtJan.Text = "-";
            // 
            // lblValorDezembro
            // 
            this.lblValorDezembro.AutoSize = true;
            this.lblValorDezembro.Location = new System.Drawing.Point(136, 317);
            this.lblValorDezembro.Name = "lblValorDezembro";
            this.lblValorDezembro.Size = new System.Drawing.Size(13, 13);
            this.lblValorDezembro.TabIndex = 54;
            this.lblValorDezembro.Text = "0";
            // 
            // lblValorNovembro
            // 
            this.lblValorNovembro.AutoSize = true;
            this.lblValorNovembro.Location = new System.Drawing.Point(136, 290);
            this.lblValorNovembro.Name = "lblValorNovembro";
            this.lblValorNovembro.Size = new System.Drawing.Size(13, 13);
            this.lblValorNovembro.TabIndex = 53;
            this.lblValorNovembro.Text = "0";
            // 
            // lblValorOutubro
            // 
            this.lblValorOutubro.AutoSize = true;
            this.lblValorOutubro.Location = new System.Drawing.Point(136, 261);
            this.lblValorOutubro.Name = "lblValorOutubro";
            this.lblValorOutubro.Size = new System.Drawing.Size(13, 13);
            this.lblValorOutubro.TabIndex = 52;
            this.lblValorOutubro.Text = "0";
            // 
            // lblValorSetembro
            // 
            this.lblValorSetembro.AutoSize = true;
            this.lblValorSetembro.Location = new System.Drawing.Point(136, 234);
            this.lblValorSetembro.Name = "lblValorSetembro";
            this.lblValorSetembro.Size = new System.Drawing.Size(13, 13);
            this.lblValorSetembro.TabIndex = 51;
            this.lblValorSetembro.Text = "0";
            // 
            // lblValorFev
            // 
            this.lblValorFev.AutoSize = true;
            this.lblValorFev.Location = new System.Drawing.Point(136, 49);
            this.lblValorFev.Name = "lblValorFev";
            this.lblValorFev.Size = new System.Drawing.Size(13, 13);
            this.lblValorFev.TabIndex = 50;
            this.lblValorFev.Text = "0";
            // 
            // lblValorMarco
            // 
            this.lblValorMarco.AutoSize = true;
            this.lblValorMarco.Location = new System.Drawing.Point(136, 74);
            this.lblValorMarco.Name = "lblValorMarco";
            this.lblValorMarco.Size = new System.Drawing.Size(13, 13);
            this.lblValorMarco.TabIndex = 49;
            this.lblValorMarco.Text = "0";
            // 
            // lblValorAbril
            // 
            this.lblValorAbril.AutoSize = true;
            this.lblValorAbril.Location = new System.Drawing.Point(136, 101);
            this.lblValorAbril.Name = "lblValorAbril";
            this.lblValorAbril.Size = new System.Drawing.Size(13, 13);
            this.lblValorAbril.TabIndex = 48;
            this.lblValorAbril.Text = "0";
            // 
            // lblValorMaio
            // 
            this.lblValorMaio.AutoSize = true;
            this.lblValorMaio.Location = new System.Drawing.Point(136, 127);
            this.lblValorMaio.Name = "lblValorMaio";
            this.lblValorMaio.Size = new System.Drawing.Size(13, 13);
            this.lblValorMaio.TabIndex = 47;
            this.lblValorMaio.Text = "0";
            // 
            // lblValorAgosto
            // 
            this.lblValorAgosto.AutoSize = true;
            this.lblValorAgosto.Location = new System.Drawing.Point(136, 208);
            this.lblValorAgosto.Name = "lblValorAgosto";
            this.lblValorAgosto.Size = new System.Drawing.Size(13, 13);
            this.lblValorAgosto.TabIndex = 46;
            this.lblValorAgosto.Text = "0";
            // 
            // lblValorJunho
            // 
            this.lblValorJunho.AutoSize = true;
            this.lblValorJunho.Location = new System.Drawing.Point(136, 182);
            this.lblValorJunho.Name = "lblValorJunho";
            this.lblValorJunho.Size = new System.Drawing.Size(13, 13);
            this.lblValorJunho.TabIndex = 45;
            this.lblValorJunho.Text = "0";
            // 
            // lblValorJulho
            // 
            this.lblValorJulho.AutoSize = true;
            this.lblValorJulho.Location = new System.Drawing.Point(136, 153);
            this.lblValorJulho.Name = "lblValorJulho";
            this.lblValorJulho.Size = new System.Drawing.Size(13, 13);
            this.lblValorJulho.TabIndex = 44;
            this.lblValorJulho.Text = "0";
            // 
            // lblValorJan
            // 
            this.lblValorJan.AutoSize = true;
            this.lblValorJan.Location = new System.Drawing.Point(136, 27);
            this.lblValorJan.Name = "lblValorJan";
            this.lblValorJan.Size = new System.Drawing.Size(13, 13);
            this.lblValorJan.TabIndex = 30;
            this.lblValorJan.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(221, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Ultima Atualização:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(136, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Valor:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 16);
            this.label18.TabIndex = 41;
            this.label18.Text = "Dezembro:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 288);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Novembro:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 39;
            this.label16.Text = "Outubro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "Setembro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Agosto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Junho:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Julho:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Maio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Abril:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Março:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fevereiro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Janeiro:";
            // 
            // txtSalarioUpdate
            // 
            this.txtSalarioUpdate.Location = new System.Drawing.Point(76, 64);
            this.txtSalarioUpdate.Name = "txtSalarioUpdate";
            this.txtSalarioUpdate.Size = new System.Drawing.Size(105, 20);
            this.txtSalarioUpdate.TabIndex = 31;
            // 
            // lblSalarioUpdate
            // 
            this.lblSalarioUpdate.AutoSize = true;
            this.lblSalarioUpdate.Location = new System.Drawing.Point(31, 68);
            this.lblSalarioUpdate.Name = "lblSalarioUpdate";
            this.lblSalarioUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblSalarioUpdate.TabIndex = 30;
            this.lblSalarioUpdate.Text = "Salario:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Seu Salario: ";
            // 
            // lblSalario
            // 
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.Lime;
            this.lblSalario.Location = new System.Drawing.Point(85, 104);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(72, 13);
            this.lblSalario.TabIndex = 34;
            // 
            // lblCadastrarDespesas
            // 
            this.lblCadastrarDespesas.AutoSize = true;
            this.lblCadastrarDespesas.Location = new System.Drawing.Point(571, 217);
            this.lblCadastrarDespesas.Name = "lblCadastrarDespesas";
            this.lblCadastrarDespesas.Size = new System.Drawing.Size(0, 13);
            this.lblCadastrarDespesas.TabIndex = 35;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(791, 37);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 36;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ModificaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 493);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCadastrarDespesas);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtSalarioUpdate);
            this.Controls.Add(this.lblSalarioUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastroDespesas);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.lblAdm);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.cbPermissao);
            this.Controls.Add(this.lblPermissao);
            this.Controls.Add(this.txtEmail_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome_User);
            this.Controls.Add(this.label1);
            this.Name = "ModificaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaUser";
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome_User;
        private System.Windows.Forms.TextBox txtEmail_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPermissao;
        private System.Windows.Forms.ComboBox cbPermissao;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbAdm;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCadastroDespesas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorOutubro;
        private System.Windows.Forms.Label lblValorSetembro;
        private System.Windows.Forms.Label lblValorFev;
        private System.Windows.Forms.Label lblValorMarco;
        private System.Windows.Forms.Label lblValorAbril;
        private System.Windows.Forms.Label lblValorMaio;
        private System.Windows.Forms.Label lblValorAgosto;
        private System.Windows.Forms.Label lblValorJunho;
        private System.Windows.Forms.Label lblValorJulho;
        private System.Windows.Forms.Label lblValorJan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDtDezembro;
        private System.Windows.Forms.Label lblDtNovembro;
        private System.Windows.Forms.Label lblDtOutubro;
        private System.Windows.Forms.Label lblDtSetembro;
        private System.Windows.Forms.Label lblDtFev;
        private System.Windows.Forms.Label lblDtMarco;
        private System.Windows.Forms.Label lblDtAbril;
        private System.Windows.Forms.Label lblDtMaio;
        private System.Windows.Forms.Label lblDtAgosto;
        private System.Windows.Forms.Label lblDtJunho;
        private System.Windows.Forms.Label lblDtJulho;
        private System.Windows.Forms.Label lblDtJan;
        private System.Windows.Forms.Label lblValorDezembro;
        private System.Windows.Forms.Label lblValorNovembro;
        private System.Windows.Forms.TextBox txtSalarioUpdate;
        private System.Windows.Forms.Label lblSalarioUpdate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblCadastrarDespesas;
        private System.Windows.Forms.Button btnSair;
    }
}