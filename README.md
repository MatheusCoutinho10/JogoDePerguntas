# Jogo de Perguntas
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/LICENSE) 

# Sobre o projeto

Jogo de Perguntas é uma aplicação construída como trabalho da matéria Programação de Algoritmos, do 1º semestre do Curso Técnico de Desenvolvimento de Sistemas, curso da [ETEC de Embu](https://www.etecdeembu.com.br/ "Site da ETEC de Embu").

A aplicação consiste nas mesmas regras de um Quiz, um jogo ou desporto mental no qual o jogador tentam responder corretamente a questões alternativas(de múltipla escolha) que lhes são colocadas.

Agora falando sobre a aplicação, ela inicia com a tela em branco e com um menu com três opções: Quiz, Cadastro e Sair. A opção Sair, encerra o aplicativo; A opção Quiz inicia o jogo, com 10 questões de múltipla escolha e com apenas uma resposta correta cada uma. Após o jogador escolher a resporta clicando no botão dela, se estiver correta o botão fica com o Background verde, se incorreta fica vermelho, e em ambos os casos desativa todos os botões, exceto o que avança para a próxima questão. Quando chegamos na decima questão esse botão de avançar para a próxima questão some, e após responder a décima ele apresenta o resultado de quantas questões o jogador acertou; Já o botão Cadastro, leva a gente para outro formulário, onde temos os campos para a pergunta e para as resposta e para qual é a correta. Acima temos cinco botôes: Novo, Gravar, Alterar, Consultar e Sair, além de um campo de texto para o consultar. O botão Sair fecha o formulário de cadastro; o Consultar pega o número escrito no campo de texto, que equivale a pergunta, e preenche os campos abaixo com os dados da pergunta; o Alterar salva as alterações que foram feitas na pergunta escolhida; o Novo limpa os campos e mostra o número de questões salvas no arquivo; e o Gravar permite gravar uma nova questão inserida pelo usuário.

## Layout
### Início
![Layout 1](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas01.JPG)

### Quiz (Ínicio, Resposta errada, Resposta correta e finalizando o jogo)
![Layout 2](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas02.JPG) ![Layout 3](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas03.JPG) ![Layout 4](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas04.JPG) ![Layout 5](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas05.JPG) ![Layout 6](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas06.JPG)

### Cadastro
![Layout 7](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas07.JPG)

#### Gravando nova questão
![Layout 8](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas08.JPG) ![Layout 9](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas09.JPG) ![Layout 10](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas10.JPG)

#### Consultando questão
![Layout 11](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas11.JPG) ![Layout 12](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas12.JPG)

#### Alterando a questão consultada
![Layout 13](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas13.JPG) ![Layout 14](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas14.JPG)

#### Limpando a tela e mostrando a quantidade de perguntas cadastradas (botão Novo)
![Layout 16](https://github.com/MatheusCoutinho10/JogoDePerguntas/blob/master/Assets/JogoDePerguntas16.JPG)

# Tecnologias utilizadas
## Back end
- C#
  - Lógicas de Programação
  - Conversões de Tipos de Dados
  - Variável Randomica
  - Arrays
  - Métodos de Abertura e Fechamento de Formulários
  - Métodos de Leitura e Salvamento de Arquivo
  - Metódos IF/Else para verificação
  - Métodos Try/Catch
  - Messagens de Aviso
  - Ativação e Desativação dos Componentes da Tela
  - Ativação e Desativação de Visibilidade dos Componentes de Tela
## Front end
- Windows Forms Designer
  - Label
  - Button
  - RichTextBox
  - Panel
  - MenuStrip
## Implantação em produção
- Back end: SharpDevelop
- Front end: SharpDevelop

# Como executar o projeto

- Pré-requisitos: Microsoft Visual C++

```bash
# clonar repositório
git clone https://github.com/MatheusCoutinho10/JogoDePerguntas

# entrar na pasta do executável
cd JogoDePerguntas\JogoDePerguntas\obj\Debug

# executar o projeto
JogoDePerguntas spring-boot:run
```

# Autor

Matheus Henrique Martins Coutinho

https://www.linkedin.com/in/matheushmcoutinho/

# Agradecimentos

[ETEC de Embu](https://www.etecdeembu.com.br/ "Site da ETEC de Embu")
