using LAB08_CONSUMO.AlunoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB08_CONSUMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherLista();
        }

        private void PreencherLista()
        {
            AlunoService.AlunoServiceClient client = new AlunoService.AlunoServiceClient();

            dataGridView1.DataSource = client.GetAlunos(true);
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            AlunoServiceClient client = new AlunoServiceClient();

            Aluno aluno = new Aluno();
            aluno.CPF = textBoxCPF.Text;
            aluno.Nome = textBoxNome.Text;

            client.AddStudent(aluno);

            dataGridView1.DataSource = client.GetAlunos(true);
        }
    }
}
