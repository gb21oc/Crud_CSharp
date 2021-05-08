using crud.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Despesas : Form
    {
        public Despesas()
        {
            InitializeComponent();
            InitializeGridDespesas();
        }

        public void sqlPreencheDataGrid(string sql)
        {
            ConexaoDb conexao = new ConexaoDb();
            DataTable tb = conexao.DataTable_ConsultarDados(sql);
            gridDespesas.DataSource = tb;

            int n = 1;
            while (n < gridDespesas.Columns.Count)
            {
                gridDespesas.Columns[n].ReadOnly = true;
                n++;
            }
        }
        public void PreencherDataGrid(DataTable dt)
        {
            this.Cursor = Cursors.WaitCursor;
            gridDespesas.DataSource = null;
            gridDespesas.DataSource = dt;
            gridDespesas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int n = 1;
            while (n < gridDespesas.Columns.Count)
            {
                gridDespesas.Columns[n].SortMode = DataGridViewColumnSortMode.NotSortable;
                n++;
            }

            this.gridDespesas.Columns["ID"].Visible = false;
            this.gridDespesas.Columns["MES"].Visible = false;
            this.gridDespesas.Columns["DESCRICAO"].Width = 130;
            this.gridDespesas.Columns["VALOR"].Width = 130;

            this.Cursor = Cursors.Default;
        }

        public void InitializeGridDespesas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("MES", typeof(string)));
            dt.Columns.Add(new DataColumn("DESCRICAO", typeof(string)));
            dt.Columns.Add(new DataColumn("VALOR", typeof(float)));
            PreencherDataGrid(dt);
        }

        private void btnAdcLinha_Click(object sender, EventArgs e)
        {
            //gridDespesas.Rows.Add("Nome da Coluna", "Texto que aparece em cima");
            int countRow = (gridDespesas.RowCount == 0) ? 0 : gridDespesas.RowCount;
            DataTable despesasRow = (DataTable)gridDespesas.DataSource;
            DataRow despesasRowNew = despesasRow.NewRow();
            despesasRowNew[0] = DBNull.Value;
            despesasRowNew[1] = DBNull.Value;
            despesasRowNew[2] = "";
            despesasRowNew[3] = 0;
            despesasRow.Rows.InsertAt(despesasRowNew, countRow + 1);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //lblTotalMes.Text = txtGanhosRecebidos.Text;
                btnAdcLinha.Enabled = true;
                btnRmvLinha.Enabled = true;
                string sql;
                if (cbDespesasMeses.SelectedItem == null)
                {
                    MessageBox.Show("Filtro mes não pode ficar vazio");
                }
                else
                {
                    ConexaoDb conexao = new ConexaoDb();
                    foreach (DataGridViewRow row in gridDespesas.Rows)
                    {
                        if (row.Cells["VALOR"].Value == "0")
                        {
                            MessageBox.Show("Filtro mes não pode ficar vazio");
                            return;
                        }
                        if (row.Cells["DESCRICAO"].Value != "" || row.Cells["VALOR"].Value != "")
                        {
                            sql = "INSERT INTO GASTOS(MES, DESCRICAO, VALOR) VALUES(" +
                                "'" + cbDespesasMeses.SelectedItem + "', " +
                                "'" + row.Cells["DESCRICAO"].Value + "', " +
                                "'" + row.Cells["VALOR"].Value + "'" +
                                ")";
                            conexao.ExecutaQuery(sql);

                        }
                        else {
                            MessageBox.Show("A campos vazio e por isso não sera possivel cadastrar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //if (txtGanhosRecebidos.Text == "" || txtGanhosRecebidos.Text == "0")
            //{
            //    lblTotalMes.Text = "0";
            //}
            if (cbDespesasMeses.SelectedItem == null)
            {
                MessageBox.Show("Não é possivel pesquisar as despesas com o campo 'Mes' vazio!!!");
                btnAdcLinha.Enabled = false;
                btnRmvLinha.Enabled = false;
                btnEnviar.Enabled = false;
                return;
            }
            btnEnviar.Enabled = false;
            btnAdcLinha.Enabled = false;
            btnRmvLinha.Enabled = false;
            string sql;
            switch (cbDespesasMeses.SelectedItem)
            {
                case "Janeiro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Janeiro'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Fevereiro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Fevereiro'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Março":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Março'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Abril":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Abril'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Maio":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Maio'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Junho":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Junho'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Julho":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Julho'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Agosto":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Agosto'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Setembro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Setembro'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Outubro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Outubro'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Novembro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Novembro'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Dezembro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Dezembro'";
                    sqlPreencheDataGrid(sql);
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            InitializeGridDespesas();
            cbDespesasMeses.SelectedItem = null;
            btnAdcLinha.Enabled = false;
            btnRmvLinha.Enabled = false;
        }
    }
}
