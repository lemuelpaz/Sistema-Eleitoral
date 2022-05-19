namespace Sistema_VE_.netframe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_gerar_eleicoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lista_resultados = new System.Windows.Forms.ListBox();
            this.count_votantes = new System.Windows.Forms.NumericUpDown();
            this.track_votos_brancos = new System.Windows.Forms.TrackBar();
            this.track_votos_nulos = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.count_votantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_brancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_nulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_gerar_eleicoes
            // 
            this.cmd_gerar_eleicoes.Location = new System.Drawing.Point(63, 362);
            this.cmd_gerar_eleicoes.Name = "cmd_gerar_eleicoes";
            this.cmd_gerar_eleicoes.Size = new System.Drawing.Size(495, 29);
            this.cmd_gerar_eleicoes.TabIndex = 0;
            this.cmd_gerar_eleicoes.Text = "Gerar Resultado";
            this.cmd_gerar_eleicoes.UseVisualStyleBackColor = true;
            this.cmd_gerar_eleicoes.Click += new System.EventHandler(this.cmd_gerar_eleicoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE VOTAÇÃO 2022";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de votantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Frequência de votos em branco";
            // 
            // lista_resultados
            // 
            this.lista_resultados.FormattingEnabled = true;
            this.lista_resultados.Location = new System.Drawing.Point(84, 42);
            this.lista_resultados.Name = "lista_resultados";
            this.lista_resultados.Size = new System.Drawing.Size(446, 121);
            this.lista_resultados.TabIndex = 4;
            // 
            // count_votantes
            // 
            this.count_votantes.Location = new System.Drawing.Point(410, 209);
            this.count_votantes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.count_votantes.Name = "count_votantes";
            this.count_votantes.Size = new System.Drawing.Size(120, 20);
            this.count_votantes.TabIndex = 5;
            this.count_votantes.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // track_votos_brancos
            // 
            this.track_votos_brancos.Location = new System.Drawing.Point(99, 203);
            this.track_votos_brancos.Maximum = 100;
            this.track_votos_brancos.Name = "track_votos_brancos";
            this.track_votos_brancos.Size = new System.Drawing.Size(104, 45);
            this.track_votos_brancos.TabIndex = 6;
            this.track_votos_brancos.TickFrequency = 10;
            // 
            // track_votos_nulos
            // 
            this.track_votos_nulos.Location = new System.Drawing.Point(99, 285);
            this.track_votos_nulos.Maximum = 100;
            this.track_votos_nulos.Name = "track_votos_nulos";
            this.track_votos_nulos.Size = new System.Drawing.Size(104, 45);
            this.track_votos_nulos.TabIndex = 8;
            this.track_votos_nulos.TickFrequency = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fraquência de votos nulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.track_votos_nulos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.track_votos_brancos);
            this.Controls.Add(this.count_votantes);
            this.Controls.Add(this.lista_resultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_gerar_eleicoes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count_votantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_brancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_nulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_gerar_eleicoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lista_resultados;
        private System.Windows.Forms.NumericUpDown count_votantes;
        private System.Windows.Forms.TrackBar track_votos_brancos;
        private System.Windows.Forms.TrackBar track_votos_nulos;
        private System.Windows.Forms.Label label4;
    }
}

