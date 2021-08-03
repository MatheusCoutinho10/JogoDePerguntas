using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDePerguntas
{
	public partial class FormQuiz : Form
	{
		public FormQuiz()
		{
			InitializeComponent();
		}
		//Criando o método aleatório
		Random rnd = new Random();
		int linhaAtual;
		string resposta;
		int contAcertos = 0;
		int contErros = 0;
		int respostas = 0;
		int questao = 3;
		
		void FormQuizLoad(object sender, EventArgs e)
		{
			try //Tentar
			{
				richTextBox1.LoadFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Arquivando o arquivo
			}
			catch(Exception exc) //Caso de erro
			{
				richTextBox1.Text="\n"; //Aplicando a quebra de linha na primeira linha
				richTextBox1.SaveFile("arquivo.txt",RichTextBoxStreamType.PlainText); //Salvando um arquivo
			}
			
			int nLinha = rnd.Next(1,richTextBox1.Lines.Length-1); //Pegando a linha aleatória
			linhaAtual = nLinha; //Passando os dados para variável global
			string dado = richTextBox1.Lines[nLinha]; //Recebendo os dados da linha escolhida
			richTextBox1.Visible = false; //Deixando o RichTextBox invisível
			
			if(nLinha>0 && nLinha<richTextBox1.Lines.Length-1) //Se o número da linha for maior que 0 e menor que a quantidade do arquivo-1 linha em branco
			{
				string linha = richTextBox1.Lines[nLinha]; //Recebendo os dados da linha
				string[] dados = linha.Split('|'); //Aplicando os cortes nos caracteres "|"
				
				//Mostrando os dados nos label's
				label1.Text = dados[0];
				label2.Text = dados[1];
				label3.Text = dados[2];
				label4.Text = dados[3];
				label5.Text = dados[4];
				resposta = dados[5]; //Guardando o dado na variável global
			}
			
			
			string linhaCompleta = richTextBox1.Lines[linhaAtual]; //Pegando a linha novamente
			string linhaNova = label1.Text+"|"+label2.Text+"|"+label3.Text+"|"+label4.Text+"|"+label5.Text+"|"+resposta+"|D"; //Trocando o último dado para "D"
			richTextBox1.Text = richTextBox1.Text.Replace(linhaCompleta,linhaNova); //Trocando os dados antigos pelos novos
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Configurando os botões das alternativas
			string linha = richTextBox1.Lines[linhaAtual]; //Coletando os dados da linha
			string[] dados = linha.Split('|'); //Cortando no caractere "|"
			string resposta = dados[5]; //Guardando a resposta na variável global
			
			
			if(resposta[0] == (sender as Button).Text[0]) //Se a resposta for igual ao botão clicado
			{
				(sender as Button).BackColor = Color.Green; //Cor de fundo do botão fica verde
				(sender as Button).Enabled = false; //Desativa o clique do botão
				panel1.Enabled = false; //Desativa o painel com os todos os botões
				contAcertos++; //Acrescenta mais 1 a variável global "contAcertos"
			}
			else //Se não
			{
				(sender as Button).BackColor = Color.Red; //Cor do fundo do botão fica vermelho
				(sender as Button).Enabled = false; //Desativa o clique do botão
				panel1.Enabled = false; //Desativa o painel com todos os botões
				contErros++; //Acrescenta mais 1 a variável global "contErros"
			}
			
			int respostas = contErros + contAcertos; //variável respostas = a soma das variáveis contErros + contAcertos
		
			if(contErros + contAcertos == 10) //Se contErros + contAcertos == 10
		{
			MessageBox.Show("Você acertou " + contAcertos + " questões!","Aviso"); //Mensagem mostrando a quantidade de acertos
		}
		}
			
		void BtnProxQuesClick(object sender, EventArgs e)
		{
			//Botão próxima pergunta
			btnProxQues.Text = "Questão " + questao + " >>"; //Texto do botão
			string status = "D"; //Atribuindo um valor D para string usada na comparação
            while (status == "D")
            {
            	//loop
                 linhaAtual = rnd.Next(1,richTextBox1.Lines.Length-1); //Pegando uma linha aleatória
                 string linha = richTextBox1.Lines[linhaAtual]; //Coletando os dados da linha
                 string[]dados = linha.Split('|'); //Cortando os dados no caractere "|"
                 status = dados[6]; //Coletando os dados da variável de comparação da linha
            }
            
            panel1.Enabled = true; //Ativando o clique do painel com os botões
            Button[] botoes = {button1, button2, button3, button4}; //Criando um grupo com os botões
            
            foreach (Button botao in botoes) //Manipulando os botões
			{
				botao.BackColor = Color.LightGray; //Colocando todos na cor padão
				botao.Enabled = true; //Ativando o clique de todos
			}
            
            string linhaCompleta = richTextBox1.Lines[linhaAtual]; //Coletando dados da linha atual
            string[]dado = linhaCompleta.Split('|'); //Aplicando o corte nos caracteres "|"
            
            //Aplicando os dados nos label'a
            label1.Text = dado[0];
			label2.Text = dado[1];
			label3.Text = dado[2];
			label4.Text = dado[3];
			label5.Text = dado[4];
			resposta = dado[5]; //Guardando o dado na variável global
			
			if(questao == 11) //Se questão for igual a 11
			{
				btnProxQues.Visible = false; //Desativando a visibilidade do botão
			}
			questao++; //Adicionando mais 1 para variável global "questão"
			
            string linhaNova = label1.Text+"|"+label2.Text+"|"+label3.Text+"|"+label4.Text+"|"+label5.Text+"|"+resposta+"|D"; //Trocando o último dado da linha
			richTextBox1.Text = richTextBox1.Text.Replace(linhaCompleta,linhaNova); //Aplicando a atualização do último dado
		}
	}
}