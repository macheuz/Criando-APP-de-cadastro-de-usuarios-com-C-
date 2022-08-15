﻿using System;
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
    public partial class F_gestaoTurmas : Form
    {
        string idSelecionado;
        public F_gestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_gestaoTurmas_Load(object sender, EventArgs e)
        {
            
        }

        private void F_gestaoTurmas_Load_1(object sender, EventArgs e)
        {
            string vqueryDGV = @"
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
            }

        }
    }
}
