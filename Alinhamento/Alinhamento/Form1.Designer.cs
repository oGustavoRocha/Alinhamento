namespace Alinhamento
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
            this.components = new System.ComponentModel.Container();
            this.cima = new System.Windows.Forms.Button();
            this.baixo = new System.Windows.Forms.Button();
            this.direita = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cima
            // 
            this.cima.Location = new System.Drawing.Point(482, 219);
            this.cima.Name = "cima";
            this.cima.Size = new System.Drawing.Size(69, 30);
            this.cima.TabIndex = 0;
            this.cima.Text = "Cima";
            this.cima.UseVisualStyleBackColor = true;
            this.cima.Click += new System.EventHandler(this.cima_Click);
            // 
            // baixo
            // 
            this.baixo.Location = new System.Drawing.Point(482, 288);
            this.baixo.Name = "baixo";
            this.baixo.Size = new System.Drawing.Size(69, 30);
            this.baixo.TabIndex = 1;
            this.baixo.Text = "Baixo";
            this.baixo.UseVisualStyleBackColor = true;
            this.baixo.Click += new System.EventHandler(this.baixo_Click);
            // 
            // direita
            // 
            this.direita.Location = new System.Drawing.Point(558, 252);
            this.direita.Name = "direita";
            this.direita.Size = new System.Drawing.Size(69, 30);
            this.direita.TabIndex = 2;
            this.direita.Text = "Direita";
            this.direita.UseVisualStyleBackColor = true;
            this.direita.Click += new System.EventHandler(this.direita_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Esquerda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.esquerda_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Alinhamento.Properties.Resources.Penguins;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.No;
            this.button5.Location = new System.Drawing.Point(97, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 138);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(477, 255);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 428);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.direita);
            this.Controls.Add(this.baixo);
            this.Controls.Add(this.cima);
            this.Controls.Add(this.button5);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cima;
        private System.Windows.Forms.Button baixo;
        private System.Windows.Forms.Button direita;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button stop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

