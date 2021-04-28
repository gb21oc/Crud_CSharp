
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDespesasMeses = new System.Windows.Forms.ComboBox();
            this.gridDespesas = new System.Windows.Forms.DataGridView();
            this.btnAdcLinha = new System.Windows.Forms.Button();
            this.btnRmvLinha = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.cbDespesasMeses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes:";
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
            this.cbDespesasMeses.Location = new System.Drawing.Point(58, 17);
            this.cbDespesasMeses.Name = "cbDespesasMeses";
            this.cbDespesasMeses.Size = new System.Drawing.Size(136, 21);
            this.cbDespesasMeses.TabIndex = 1;
            this.cbDespesasMeses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDespesasMeses_MouseClick);
            // 
            // gridDespesas
            // 
            this.gridDespesas.AllowUserToAddRows = false;
            this.gridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDespesas.Location = new System.Drawing.Point(12, 108);
            this.gridDespesas.Name = "gridDespesas";
            this.gridDespesas.Size = new System.Drawing.Size(333, 266);
            this.gridDespesas.TabIndex = 1;
            // 
            // btnAdcLinha
            // 
            this.btnAdcLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcLinha.Location = new System.Drawing.Point(289, 79);
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
            this.btnRmvLinha.Location = new System.Drawing.Point(320, 79);
            this.btnRmvLinha.Name = "btnRmvLinha";
            this.btnRmvLinha.Size = new System.Drawing.Size(25, 27);
            this.btnRmvLinha.TabIndex = 3;
            this.btnRmvLinha.Text = "-";
            this.btnRmvLinha.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(220, 12);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(76, 29);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 386);
            this.Controls.Add(this.btnRmvLinha);
            this.Controls.Add(this.btnAdcLinha);
            this.Controls.Add(this.gridDespesas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Despesas";
            this.Text = "Despesas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDespesasMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDespesas;
        private System.Windows.Forms.Button btnAdcLinha;
        private System.Windows.Forms.Button btnRmvLinha;
        private System.Windows.Forms.Button btnEnviar;
    }
}