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
    public partial class F_selecionarTurma : Form
    {
        F_novoAluno formNovoAluno;
        public F_selecionarTurma(F_novoAluno f)
        {
            
            InitializeComponent();
            formNovoAluno = f;
        }

        private void F_selecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurmas = string.Format(@"
                SELECT  tbt.N_IDTURMA as 'ID',
                        tbt.T_DSCTURMA as 'Turma',
                        tbh.T_DSCHORARIO as 'Horario',
                        tbp.T_NOMEPROFESSOR as 'Professor',
                        (SELECT COUNT(N_IDALUNO)
                         FROM tb_alunos as tba
                         WHERE tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A'
                        )as 'QTDE ALUNOS'
                        
                FROM tb_turmas as tbt
                INNER JOIN  tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                INNER JOIN tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ");
            dgv_turmas.DataSource= Banco.dql(queryTurmas);
        }
    }
}
