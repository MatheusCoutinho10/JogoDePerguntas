using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDePerguntas
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void QuizToolStripMenuItemClick(object sender, EventArgs e)
		{
			//Acessando o formulário do Quiz
			FormQuiz frm2 = new FormQuiz();
			frm2.Show();
		}
		
		void CadastroToolStripMenuItemClick(object sender, EventArgs e)
		{
			//Acessando o formulário do Banco de Dados das Perguntas e Respostas
			FormPerguntas frm3 = new FormPerguntas();
			frm3.Show();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void AjudaToolStripMenuItemClick(object sender, EventArgs e)
		{
			//Botão sair
			Application.Exit(); //Sair da aplicação
		}
	}
}