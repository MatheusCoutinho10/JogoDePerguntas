using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDePerguntas
{
	public partial class FormPerguntas : Form
	{
		public FormPerguntas()
		{
			InitializeComponent();
		}
		
		void FormPerguntasLoad(object sender, EventArgs e)
		{
			try //Tentar carregar arquivo
			{
				richTextBox1.LoadFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Carregando o arquivo
			}
			catch(Exception exc) //Caso de erro, criar um arquivo
			{
				richTextBox1.Text="\n"; //Aplicando quebra na primeira linha
				richTextBox1.SaveFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Salvando o arquivo
			}
			Novo(); //Utilizando o método "Novo"
		}
		
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			//Botão "Novo"
			Novo(); //Utilizando o método "Novo"
		}
		
		
		void Novo()
		{
			//Método Novo
			//Limpando as caixas de texto
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			label8.Text = (richTextBox1.Lines.Length-2).ToString(); //Mostrando a quantidade de registros
			btnGravar.Enabled = true; //Deixando o botão "Gravar" clicável
		}
		
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			//Botão "Consultar"
			int nLinha = int.Parse(textBox1.Text); //Recebendo o número da linha que o usuário digitar
			
			if(nLinha>0 && nLinha<richTextBox1.Lines.Length-1) //Se o número da linha for maior que 0 e menor que a quantidade do RichTextBox -a linha em branco
			{
				label8.Text = nLinha.ToString(); //Recebendo o número da linha
				string linha = richTextBox1.Lines[nLinha]; //Recebendo os dados da linha
				string[] dados = linha.Split('|'); //Cortando a linha nos "|"
				
				//Recebendo os dados nos textBox
				textBox2.Text = dados[0];
				textBox3.Text = dados[1];
				textBox4.Text = dados[2];
				textBox5.Text = dados[3];
				textBox6.Text = dados[4];
				textBox7.Text = dados[5];
			}
			else //Se não
			{
				Novo(); //Método "Novo"
				MessageBox.Show("Questionário não encontrado!","Aviso"); //Mensagem de erro
			}
			textBox1.Clear(); //Limpando o textBox
			btnGravar.Enabled = false; //Deixando o botão "Gravar" não clicável
		}
		
		
		void BtnGravarClick(object sender, EventArgs e)
		{
			//Botão "Gravar"
			string linha = textBox2.Text+"|"+textBox3.Text+"|"+textBox4.Text+"|"+textBox5.Text+"|"+textBox6.Text+"|"+textBox7.Text+"|A"; //Armazenando os dados dos textBox na String
			richTextBox1.Text += linha + "\n"; //Adicionando a linha ao RichTextBox
			richTextBox1.SaveFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Salvando o arquivo
			MessageBox.Show("Questionário gravado com sucesso","Aviso"); //Mensagem de sucesso
			Novo(); //Método "Novo"
		}
		
		void BtnAlterarClick(object sender, EventArgs e)
		{
			//BotãoAlterar
			try //Tentar acessar os dados
			{
				int nLinha = int.Parse(label8.Text); //Recebendo o número da linha que o usuário escolheu
				string linhaAntiga = richTextBox1.Lines[nLinha]; //Armazenando os dados a linha na String
				string linhaNova = textBox2.Text+"|"+textBox3.Text+"|"+textBox4.Text+"|"+textBox5.Text+"|"+textBox6.Text+"|"+textBox7.Text+"|A"; //Armazenando os dados do TextBox na String
				richTextBox1.Text = richTextBox1.Text.Replace(linhaAntiga,linhaNova); //Trocando os dados antigos pelos novos
				richTextBox1.SaveFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Salvando o arquivo
				MessageBox.Show("Questionário alterado com sucesso!","Aviso"); //Mebsagem de sucesso
				btnGravar.Enabled = false; //Deixando o botão "Gravar" não clicável
			}
			catch(Exception exc) //Caso de erro
			{
				MessageBox.Show("Não foi possível realizar a operação","Aviso");//Messagem caso de erro
			}
		}
		
		void BtnSairClick(object sender, EventArgs e)
		{
			//Botão sair
			Application.Exit(); //Sair da aplicação
		}
	}
}
