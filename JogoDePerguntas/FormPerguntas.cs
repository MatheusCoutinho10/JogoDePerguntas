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
			btnAlterar.Enabled = false; //Deixando o botão "Gravar" clicável
			textBox1.MaxLength = 3;
			textBox7.MaxLength = 1;
		}
		
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			//Botão "Novo"
			Novo(); //Utilizando o método "Novo"
			btnAlterar.Enabled = false; //Deixando o botão "Gravar" clicável
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
			btnAlterar.Enabled = false; //Deixando o botão "Alterar" não clicável
		}
		
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			//Botão "Consultar"
			if(textBox1.Text != "" && textBox1.Text != "0" && textBox1.Text != null){
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
					btnAlterar.Enabled = true; //Deixando o botão "Gravar" clicável
				}
				else //Se não
				{
					Novo(); //Método "Novo"
					MessageBox.Show("Questionário não encontrado!","Aviso"); //Mensagem de erro
				}
				btnGravar.Enabled = false; //Deixando o botão "Gravar" não clicável
			}else{
				Novo(); //Método "Novo"
				MessageBox.Show("O campo da consulta não pode estar vazio!","Aviso"); //Mensagem de erro
				btnGravar.Enabled = false; //Deixando o botão "Gravar" não clicável
				btnAlterar.Enabled = false; //Deixando o botão "Alterar" não clicável
				textBox1.Clear();
			}
		}
		
		
		void BtnGravarClick(object sender, EventArgs e)
		{
			if(textBox2.Text == "" || textBox2.Text == "0" || textBox2.Text == null){
				MessageBox.Show("O campo da pergunta não pode estar vazio!","Aviso"); //Mensagem de erro
			}else if(textBox3.Text == "" || textBox3.Text == "0" || textBox3.Text == null){
				MessageBox.Show("O campo da alternativa A não pode estar vazio!","Aviso"); //Mensagem de erro
			}else if(textBox4.Text == "" || textBox4.Text == "0" || textBox4.Text == null){
				MessageBox.Show("O campo da alternativa B não pode estar vazio!","Aviso"); //Mensagem de erro
			}else if(textBox5.Text == "" || textBox5.Text == "0" || textBox5.Text == null){
				MessageBox.Show("O campo da alternativa C não pode estar vazio!","Aviso"); //Mensagem de erro
			}else if(textBox6.Text == "" || textBox6.Text == "0" || textBox6.Text == null){
				MessageBox.Show("O campo da alternativa D não pode estar vazio!","Aviso"); //Mensagem de erro
			}else if(textBox7.Text == "" || textBox7.Text == "0" || textBox7.Text == null){
				MessageBox.Show("O campo da resposta não pode estar vazio!","Aviso"); //Mensagem de erro
			}else if(textBox7.Text == "A" || textBox7.Text == "a" || textBox7.Text == "B" || textBox7.Text == "b" || textBox7.Text == "C" || textBox7.Text == "c" || textBox7.Text == "D" || textBox7.Text == "d"){
				//Botão "Gravar"
				string linha = textBox2.Text+"|"+textBox3.Text+"|"+textBox4.Text+"|"+textBox5.Text+"|"+textBox6.Text+"|"+textBox7.Text+"|A"; //Armazenando os dados dos textBox na String
				richTextBox1.Text += linha + "\n"; //Adicionando a linha ao RichTextBox
				richTextBox1.SaveFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Salvando o arquivo
				MessageBox.Show("Questionário gravado com sucesso","Aviso"); //Mensagem de sucesso
				Novo(); //Método "Novo"
			}else{
				MessageBox.Show("Alternativa de resposta inexistente!","Aviso"); //Mensagem de erro
			}
		}
		
		void BtnAlterarClick(object sender, EventArgs e)
		{
			//BotãoAlterar
			try //Tentar acessar os dados
			{
				if(textBox2.Text == "" || textBox2.Text == "0" || textBox2.Text == null){
					MessageBox.Show("O campo da pergunta não pode estar vazio!","Aviso"); //Mensagem de erro
				}else if(textBox3.Text == "" || textBox3.Text == "0" || textBox3.Text == null){
					MessageBox.Show("O campo da alternativa A não pode estar vazio!","Aviso"); //Mensagem de erro
				}else if(textBox4.Text == "" || textBox4.Text == "0" || textBox4.Text == null){
					MessageBox.Show("O campo da alternativa B não pode estar vazio!","Aviso"); //Mensagem de erro
				}else if(textBox5.Text == "" || textBox5.Text == "0" || textBox5.Text == null){
					MessageBox.Show("O campo da alternativa C não pode estar vazio!","Aviso"); //Mensagem de erro
				}else if(textBox6.Text == "" || textBox6.Text == "0" || textBox6.Text == null){
					MessageBox.Show("O campo da alternativa D não pode estar vazio!","Aviso"); //Mensagem de erro
				}else if(textBox7.Text == "" || textBox7.Text == "0" || textBox7.Text == null){
					MessageBox.Show("O campo da resposta não pode estar vazio!","Aviso"); //Mensagem de erro
				}else if(textBox7.Text == "A" || textBox7.Text == "a" || textBox7.Text == "B" || textBox7.Text == "b" || textBox7.Text == "C" || textBox7.Text == "c" || textBox7.Text == "D" || textBox7.Text == "d"){
					int nLinha = int.Parse(label8.Text); //Recebendo o número da linha que o usuário escolheu
					string linhaAntiga = richTextBox1.Lines[nLinha]; //Armazenando os dados a linha na String
					string linhaNova = textBox2.Text+"|"+textBox3.Text+"|"+textBox4.Text+"|"+textBox5.Text+"|"+textBox6.Text+"|"+textBox7.Text+"|A"; //Armazenando os dados do TextBox na String
					richTextBox1.Text = richTextBox1.Text.Replace(linhaAntiga,linhaNova); //Trocando os dados antigos pelos novos
					richTextBox1.SaveFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Salvando o arquivo
					MessageBox.Show("Questionário alterado com sucesso!","Aviso"); //Mebsagem de sucesso
					Novo();
				}else{
					MessageBox.Show("Alternativa de resposta inexistente!","Aviso"); //Mensagem de erro
				}
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
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
		}
	}
}
