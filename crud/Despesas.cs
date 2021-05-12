using crud.Properties;
using System;
using System.Collections;
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
        public int idUser;
        ArrayList idGrid = new ArrayList();
        bool btnRmvIsTrue = false;
        bool btnRmvIsTrueInto = false;
        public Despesas()
        {
            InitializeComponent();
            InitializeGridDespesas();
            btnAdcLinha.Enabled = false;
            btnRmvLinha.Enabled = false;
            btnEnviar.Enabled = false;
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

        public void VerificaValorMes()
        {
            decimal totalMes = 0;
            foreach (DataGridViewRow row in gridDespesas.Rows)
            {
                totalMes += Convert.ToDecimal(row.Cells["VALOR"].Value);
            }
            lblTotalMes.Text = totalMes.ToString();
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
            this.gridDespesas.Columns["ID_USER"].Visible = false;
            this.gridDespesas.Columns["MES"].Visible = false;
            this.gridDespesas.Columns["DESCRICAO"].Width = 130;
            this.gridDespesas.Columns["VALOR"].Width = 130;

            this.Cursor = Cursors.Default;
        }

        public void InitializeGridDespesas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("ID_USER", typeof(int)));
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
                if (btnRmvIsTrue)
                {
                    ConexaoDb conexao = new ConexaoDb();
                    foreach (var id in idGrid)
                    {
                        conexao.ConexaoDbOpen();
                        sql = "DELETE FROM GASTOS WHERE ID = " + "'" + id + "'";
                        conexao.ExecutaQuery(sql);
                    }
                    btnRmvIsTrue = false;
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
                            sql = "INSERT INTO GASTOS(ID_USER, MES, DESCRICAO, VALOR) VALUES(" +
                                "'" + idUser                       +"', "+
                                "'" + cbDespesasMeses.SelectedItem + "', " +
                                "'" + row.Cells["DESCRICAO"].Value + "', " +
                                "'" + row.Cells["VALOR"].Value     + "'" +
                                ")";
                            conexao.ExecutaQuery(sql);
                        }
                        else {
                            MessageBox.Show("A campos vazio e por isso não sera possivel cadastrar");
                        }
                    }
                    InitializeGridDespesas();
                    cbDespesasMeses.SelectedItem = null;
                    btnAdcLinha.Enabled = false;
                    btnRmvLinha.Enabled = false;
                    btnEnviar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na hora de salvar");
            }
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbDespesasMeses.SelectedItem == null)
            {
                MessageBox.Show("Não é possivel pesquisar as despesas com o campo 'Mes' vazio!!!");
                btnAdcLinha.Enabled = false;
                btnRmvLinha.Enabled = false;
                btnEnviar.Enabled = false;
                return;
            }
            btnEnviar.Enabled = true;
            btnAdcLinha.Enabled = false;
            btnRmvLinha.Enabled = true;
            string sql;
            switch (cbDespesasMeses.SelectedItem)
            {
                case "Janeiro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Janeiro' AND ID_USER = "+ "'"+ idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Fevereiro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Fevereiro' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Março":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Março' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Abril":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Abril' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Maio":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Maio' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Junho":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Junho' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Julho":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Julho' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Agosto":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Agosto' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Setembro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Setembro' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Outubro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Outubro' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Novembro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Novembro' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
                case "Dezembro":
                    sql = "SELECT * FROM GASTOS WHERE MES = 'Dezembro' AND ID_USER = " + "'" + idUser + "'";
                    sqlPreencheDataGrid(sql);
                    break;
            }
            VerificaValorMes();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            InitializeGridDespesas();
            lblTotalMes.Text             = "";
            cbDespesasMeses.SelectedItem = null;
            btnAdcLinha.Enabled          = false;
            btnRmvLinha.Enabled          = false;
            btnEnviar.Enabled            = false;
        }

        private void cbDespesasMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdcLinha.Enabled = true;
            btnRmvLinha.Enabled = true;
            btnEnviar.Enabled = true;
        }

        private void btnRmvLinha_Click(object sender, EventArgs e)
        {
            if (gridDespesas.Rows.Count > 0)
            {
                gridDespesas.Rows.RemoveAt(gridDespesas.CurrentRow.Index);
            }
            if (gridDespesas.Rows.Count < 1)
            {
                btnRmvLinha.Enabled = false;
            }
            btnRmvIsTrue = true;
        }

        private void btnApagarDespesas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDespesasMeses.SelectedItem == null)
                {
                    MessageBox.Show("Não é possivel apagar os gastos do mes, sem informar o mês escolhido!");
                    return;
                }
                DialogResult dialog = MessageBox.Show($"Tem certeza que deseja excluir as despesas do mes: {cbDespesasMeses.SelectedItem}?", "Apagar Despesas", MessageBoxButtons.YesNo);
                ConexaoDb conexao = new ConexaoDb();
                string sql;
                if (dialog == DialogResult.Yes) 
                {
                    sql = "DELETE FROM GASTOS WHERE MES = " + "'" + cbDespesasMeses.SelectedItem + "'"+ "AND ID_USER = "+ "'"+ idUser+ "'";
                    conexao.ExecutaQuery(sql);
                    ModificaUser modificaUser = new ModificaUser();
                    modificaUser.GastosMensais(modificaUser.idGastosMensais);
                }
                else if(dialog == DialogResult.No)
                {
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na hora de apagar");
            }
        }

        private void gridDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = gridDespesas.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            idGrid.Add(id);
        }
    }
}
