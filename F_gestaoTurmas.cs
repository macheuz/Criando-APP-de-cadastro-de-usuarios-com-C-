using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados
{
    public partial class F_gestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; //0= modo padrao, 1 = edicao, 2 = inserção
        string vqueryDGV = "";
        public F_gestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_gestaoTurmas_Load(object sender, EventArgs e)
        {
            
        }

        private void F_gestaoTurmas_Load_1(object sender, EventArgs e)
        {
            vqueryDGV = @"
            SELECT  tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horario'
            FROM tb_turmas as tbt
            INNER JOIN tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ";
            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 130;
            dgv_turmas.Columns[2].Width = 85;

            //Popular comboBox professores
            string vQueryProfessores = @"
                SELECT  N_IDPROFESSOR,
                        T_NOMEPROFESSOR
                FROM tb_professores
                ORDER BY N_IDPROFESSOR";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vQueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //Popular combobox status

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular combobox de horario
            string vQueryHorarios = @"
                SELECT  *
                FROM tb_horarios
                ORDER BY T_DSCHORARIO";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vQueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIOS";
            cb_horario.ValueMember = "N_IDHORARIO";

        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                 SELECT T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                FROM tb_turmas
                WHERE N_IDTURMA = " + idSelecionado;

                DataTable dt = Banco.dql(vqueryCampos);
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();

                
                tb_vagas.Text = calcvagas();
            }

        }
        private string calcvagas()
        {
            //Calculo de vagas
            string queryVagas = string.Format(@"
                SELECT count(N_IDALUNO) as 'contVagas'
                FROM tb_alunos
                WHERE T_STATUS = 'A'
                and N_IDTURMA = {0}", idSelecionado);
            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_dscTurma.Focus();
            modo = 2;
        }

        private void btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            if ( modo !=0) {
                string queryTurma = "";
                string msg = "";
                if (modo ==1)
                {
                    msg = "Dados Alterados";
                    queryTurma = string.Format(@"UPDATE tb_turmas SET T_DSCTURMA='{0}',N_IDPROFESSOR ={1}, N_IDHORARIO = {2}, N_MAXALUNOS = {3}, T_STATUS = '{4}' WHERE N_IDTURMA = {5}", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);
                }
                else
                {
                    msg = "Turma Inserida";
                    queryTurma = string.Format(@"INSERT INTO tb_turmas (T_DSCTURMA,N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS) VALUES ('{0}',{1},{2},{3},'{4}')", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                }
                int linha = dgv_turmas.SelectedRows[0].Index;
                 
                Banco.dml(queryTurma);
                if(modo == 1)
                {
                    dgv_turmas[1, linha].Value = tb_dscTurma.Text;
                    dgv_turmas[2, linha].Value = cb_horario.Text;
                    tb_vagas.Text = calcvagas(); 
                }
                else if (modo == 2)
                {
                    dgv_turmas.DataSource = Banco.dql(vqueryDGV);
                }
                
                MessageBox.Show(msg);
            }
        }

        private void btn_excluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = string.Format(@"DELETE FROM tb_turmas WHERE N_IDTURMA = {0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void tb_dscTurma_TextChanged(object sender, EventArgs e)
        {
            if(modo == 0)
            {
            modo = 1;
            }
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void n_maxAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void btn_imprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            string dados = "";
            //criando elemento paragrafo com as configuracoes padroes de fonte
            Paragraph Paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            Paragrafo1.Alignment = Element.ALIGN_CENTER;
            Paragrafo1.Add("CFB Cursos \n");
            Paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            Paragrafo1.Add("Curso de C#");
            string texto1 = "youtube.com";
            Paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            Paragrafo1.Add(texto1 + "\n");

            Paragraph Paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            Paragrafo2.Alignment = Element.ALIGN_LEFT;
            string texto2 = "Esse é o texto do segundo paragrafo";
            Paragrafo2.Add(texto2 + "\n");

            //criando tabela 

            PdfPTable tabela = new PdfPTable(3); //3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            PdfPCell celula = new PdfPCell(new Phrase("Tabela de Preços"));
            celula.Colspan = 3; //linha 1 mesclada
            celula.Rotation = 90;
            tabela.AddCell(celula);

            tabela.AddCell("Codigo");
            tabela.AddCell("Produto");
            tabela.AddCell("Preço");

            tabela.AddCell("01");
            tabela.AddCell("Mouse");
            tabela.AddCell("25");

            tabela.AddCell("02");
            tabela.AddCell("Teclado");
            tabela.AddCell("65");


            celula.Phrase.Add("Tabela de preços");
            celula.Rotation = 0;
            celula.Colspan = 3;
            celula.FixedHeight = 35;
            celula.HorizontalAlignment = Element.ALIGN_CENTER;
            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.AddCell(celula);


            doc.Open();
            doc.Add(Paragrafo1);
            doc.Add(Paragrafo2);
            doc.Add(tabela);
            doc.Close();

        }
    }
}
