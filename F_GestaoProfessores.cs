using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados
{
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            //query para selecionar os componentes e mostrar no dgv
            string vquery = @"
                SELECT  N_IDPROFESSOR as 'ID', 
                        T_NOMEPROFESSOR as 'Professor',
                        T_TELEFONE as 'Telefone'
                FROM tb_professores
                ORDER BY T_NOMEPROFESSOR
            ";
            //fazendo a conexao com o banco passando a query acima para preencher o data view
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 60;
            dgv_professores.Columns[1].Width = 170;
            dgv_professores.Columns[1].Width = 180;
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                //pegando o id do datagrid view
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                SELECT  * 
                FROM tb_professores
                WHERE N_IDPROFESSOR=" + vid;
                dt = Banco.dql(vquery);
                tb_idProfessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_professores.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtb_dsctelefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_idProfessor.Clear();
            tb_professores.Clear();
            mtb_dsctelefone.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_idProfessor.Text == "")
            {
                vquery = "INSERT INTO tb_professores(T_TELEFONE, T_NOMEPROFESSOR) VALUES('" + mtb_dsctelefone.Text + "', '"+tb_professores.Text+"')";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_TELEFONE='" + mtb_dsctelefone.Text + "',T_NOMEPROFESSOR='"+tb_professores.Text+"'  WHERE N_IDPROFESSOR =" + tb_idProfessor.Text;
            }
            Banco.dml(vquery);
            vquery = @"
                SELECT  N_IDPROFESSOR as 'ID', 
                        T_NOMEPROFESSOR as 'Nome',
                        T_TELEFONE as 'Telefone'
                FROM tb_professores
                ORDER BY T_NOMEPROFESSOR


            ";
            //fazendo a conexao com o banco passando a query acima para preencher o data view
            dgv_professores.DataSource = Banco.dql(vquery);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusao", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_IDPROFESSOR =" + tb_idProfessor.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }
    }
}
