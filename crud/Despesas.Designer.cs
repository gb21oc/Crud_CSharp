
namespace crud
{
    partial class Despesas
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbDespesasMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDespesas = new System.Windows.Forms.DataGridView();
            this.btnAdcLinha = new System.Windows.Forms.Button();
            this.btnRmvLinha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMes = new System.Windows.Forms.Label();
            this.btnApagarDespesas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApagarDespesas);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(196, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 29);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(196, 48);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(76, 29);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(278, 13);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(76, 29);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Salvar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbDespesasMeses
            // 
            this.cbDespesasMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDespesasMeses.FormattingEnabled = true;
            this.cbDespesasMeses.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbDespesasMeses.Location = new System.Drawing.Point(53, 29);
            this.cbDespesasMeses.Name = "cbDespesasMeses";
            this.cbDespesasMeses.Size = new System.Drawing.Size(136, 21);
            this.cbDespesasMeses.TabIndex = 1;
            this.cbDespesasMeses.SelectedIndexChanged += new System.EventHandler(this.cbDespesasMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes:";
            // 
            // gridDespesas
            // 
            this.gridDespesas.AllowUserToAddRows = false;
            this.gridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDespesas.Location = new System.Drawing.Point(12, 137);
            this.gridDespesas.Name = "gridDespesas";
            this.gridDespesas.Size = new System.Drawing.Size(333, 397);
            this.gridDespesas.TabIndex = 1;
            this.gridDespesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDespesas_CellClick);
            // 
            // btnAdcLinha
            // 
            this.btnAdcLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcLinha.Location = new System.Drawing.Point(289, 106);
            this.btnAdcLinha.Name = "btnAdcLinha";
            this.btnAdcLinha.Size = new System.Drawing.Size(25, 27);
            this.btnAdcLinha.TabIndex = 2;
            this.btnAdcLinha.Text = "+";
            this.btnAdcLinha.UseVisualStyleBackColor = true;
            this.btnAdcLinha.Click += new System.EventHandler(this.btnAdcLinha_Click);
            // 
            // btnRmvLinha
            // 
            this.btnRmvLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvLinha.Location = new System.Drawing.Point(320, 106);
            this.btnRmvLinha.Name = "btnRmvLinha";
            this.btnRmvLinha.Size = new System.Drawing.Size(25, 27);
            this.btnRmvLinha.TabIndex = 3;
            this.btnRmvLinha.Text = "-";
            this.btnRmvLinha.UseVisualStyleBackColor = true;
            this.btnRmvLinha.Click += new System.EventHandler(this.btnRmvLinha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total do mes:";
            // 
            // lblTotalMes
            // 
            this.lblTotalMes.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalMes.Location = new System.Drawing.Point(84, 113);
            this.lblTotalMes.Name = "lblTotalMes";
            this.lblTotalMes.Size = new System.Drawing.Size(100, 13);
            this.lblTotalMes.TabIndex = 5;
            // 
            // btnApagarDespesas
            // 
            this.btnApagarDespesas.Location = new System.Drawing.Point(278, 48);
            this.btnApagarDespesas.Name = "btnApagarDespesas";
            this.btnApagarDespesas.Size = new System.Drawing.Size(76, 29);
            this.btnApagarDespesas.TabIndex = 5;
            this.btnApagarDespesas.Text = "Apagar";
            this.btnApagarDespesas.UseVisualStyleBackColor = true;
            this.btnApagarDespesas.Click += new System.EventHandler(this.btnApagarDespesas_Click);
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 546);
            this.Controls.Add(this.lblTotalMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRmvLinha);
            this.Controls.Add(this.btnAdcLinha);
            this.Controls.Add(this.gridDespesas);
            this.Controls.Add(this.cbDespesasMeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Despesas";
            this.Text = "Despesas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDespesasMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDespesas;
        private System.Windows.Forms.Button btnAdcLinha;
        private System.Windows.Forms.Button btnRmvLinha;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMes;
        private System.Windows.Forms.Button btnApagarDespesas;
    }
}