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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            //query para selecionar os componentes e mostrar no dgv
            string vquery = @"
                SELECT  N_IDHORARIO as 'ID', 
                        T_DSCHORARIO as 'Horario'
                FROM tb_horarios
                ORDER BY T_DSCHORARIO
            ";
            //fazendo a conexao com o banco passando a query acima para preencher o data view
            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 170;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                //pegando o id do datagrid view
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                SELECT  * 
                FROM tb_horarios
                WHERE N_IDHORARIO="+vid;
                dt = Banco.dql(vquery);
                tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_dscHorario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_idHorario.Text == "")
            {
                vquery = "INSERT INTO tb_horarios(T_DSCHORARIO) VALUES('" + mtb_dscHorario.Text + "')";
            }
            else
            {
                vquery = "UPDATE tb_horarios SET T_DSCHORARIO='" + mtb_dscHorario.Text + "' WHERE N_IDHORARIO ="+tb_idHorario.Text;
            }
            Banco.dml(vquery);
            vquery = @"
                SELECT  N_IDHORARIO as 'ID', 
                        T_DSCHORARIO as 'Horario'
                FROM tb_horarios
                ORDER BY T_DSCHORARIO


            ";
            //fazendo a conexao com o banco passando a query acima para preencher o data view
            dgv_horarios.DataSource = Banco.dql(vquery);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusao", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO =" + tb_idHorario.Text;
                Banco.dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
