/*
 * Criado por SharpDevelop.
 * Usuário: couti
 * Data: 30/11/2020
 * Hora: 18:24
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace JogoDePerguntas
{
	partial class FormPerguntas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnGravar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(435, 166);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(200, 280);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "RichTextBox1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSair);
			this.panel1.Controls.Add(this.btnGravar);
			this.panel1.Controls.Add(this.btnNovo);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.btnAlterar);
			this.panel1.Controls.Add(this.btnConsultar);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(623, 42);
			this.panel1.TabIndex = 1;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.LightBlue;
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.Black;
			this.btnSair.Location = new System.Drawing.Point(521, 5);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(99, 34);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnGravar
			// 
			this.btnGravar.BackColor = System.Drawing.Color.LightBlue;
			this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGravar.ForeColor = System.Drawing.Color.Black;
			this.btnGravar.Location = new System.Drawing.Point(108, 5);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(99, 34);
			this.btnGravar.TabIndex = 1;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = false;
			this.btnGravar.Click += new System.EventHandler(this.BtnGravarClick);
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.LightBlue;
			this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ForeColor = System.Drawing.Color.Black;
			this.btnNovo.Location = new System.Drawing.Point(3, 5);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(99, 34);
			this.btnNovo.TabIndex = 0;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(423, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 31);
			this.textBox1.TabIndex = 4;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.LightBlue;
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.Color.Black;
			this.btnAlterar.Location = new System.Drawing.Point(213, 5);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(99, 34);
			this.btnAlterar.TabIndex = 2;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.LightBlue;
			this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.Color.Black;
			this.btnConsultar.Location = new System.Drawing.Point(318, 5);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(99, 34);
			this.btnConsultar.TabIndex = 3;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Registro:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Pergunta:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(12, 126);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(623, 29);
			this.textBox2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Alternativa A:";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(12, 192);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(417, 29);
			this.textBox3.TabIndex = 6;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(12, 258);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(417, 29);
			this.textBox4.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Alternativa B:";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(12, 324);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(417, 29);
			this.textBox5.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 298);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Alternativa C:";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(12, 390);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(417, 29);
			this.textBox6.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 364);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Alternativa D:";
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(12, 456);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(40, 29);
			this.textBox7.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 430);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Correta:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(102, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "0";
			// 
			// FormPerguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 494);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FormPerguntas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Perguntas e Respostas";
			this.Load += new System.EventHandler(this.FormPerguntasLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
