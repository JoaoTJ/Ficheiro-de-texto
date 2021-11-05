
namespace Ficheiro_de_texto
{
    partial class Letexto
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
            this.btficheiro = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labpalavras = new System.Windows.Forms.Label();
            this.labcaract = new System.Windows.Forms.Label();
            this.labparag = new System.Windows.Forms.Label();
            this.butpalavra = new System.Windows.Forms.Button();
            this.butcaract = new System.Windows.Forms.Button();
            this.butparag = new System.Windows.Forms.Button();
            this.____ = new System.Windows.Forms.Label();
            this.butguardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btficheiro
            // 
            this.btficheiro.Location = new System.Drawing.Point(302, 12);
            this.btficheiro.Name = "btficheiro";
            this.btficheiro.Size = new System.Drawing.Size(109, 33);
            this.btficheiro.TabIndex = 0;
            this.btficheiro.Text = "Selecionar Ficheiro";
            this.btficheiro.UseVisualStyleBackColor = true;
            this.btficheiro.Click += new System.EventHandler(this.btficheiro_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(284, 332);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labpalavras
            // 
            this.labpalavras.AutoSize = true;
            this.labpalavras.Location = new System.Drawing.Point(352, 108);
            this.labpalavras.Name = "labpalavras";
            this.labpalavras.Size = new System.Drawing.Size(0, 13);
            this.labpalavras.TabIndex = 2;
            this.labpalavras.Click += new System.EventHandler(this.labpalavras_Click);
            // 
            // labcaract
            // 
            this.labcaract.AutoSize = true;
            this.labcaract.Location = new System.Drawing.Point(352, 169);
            this.labcaract.Name = "labcaract";
            this.labcaract.Size = new System.Drawing.Size(0, 13);
            this.labcaract.TabIndex = 3;
            // 
            // labparag
            // 
            this.labparag.AutoSize = true;
            this.labparag.Location = new System.Drawing.Point(352, 230);
            this.labparag.Name = "labparag";
            this.labparag.Size = new System.Drawing.Size(0, 13);
            this.labparag.TabIndex = 4;
            // 
            // butpalavra
            // 
            this.butpalavra.Location = new System.Drawing.Point(303, 81);
            this.butpalavra.Name = "butpalavra";
            this.butpalavra.Size = new System.Drawing.Size(109, 24);
            this.butpalavra.TabIndex = 5;
            this.butpalavra.Text = "Contar palavras";
            this.butpalavra.UseVisualStyleBackColor = true;
            this.butpalavra.Click += new System.EventHandler(this.butpalavra_Click);
            // 
            // butcaract
            // 
            this.butcaract.Location = new System.Drawing.Point(302, 142);
            this.butcaract.Name = "butcaract";
            this.butcaract.Size = new System.Drawing.Size(109, 24);
            this.butcaract.TabIndex = 6;
            this.butcaract.Text = "Contar caracteres";
            this.butcaract.UseVisualStyleBackColor = true;
            this.butcaract.Click += new System.EventHandler(this.butcaract_Click);
            // 
            // butparag
            // 
            this.butparag.Location = new System.Drawing.Point(302, 203);
            this.butparag.Name = "butparag";
            this.butparag.Size = new System.Drawing.Size(109, 24);
            this.butparag.TabIndex = 7;
            this.butparag.Text = "Contar paragrafos";
            this.butparag.UseVisualStyleBackColor = true;
            this.butparag.Click += new System.EventHandler(this.butparag_Click);
            // 
            // ____
            // 
            this.____.AutoSize = true;
            this.____.Location = new System.Drawing.Point(299, 48);
            this.____.Name = "____";
            this.____.Size = new System.Drawing.Size(115, 13);
            this.____.TabIndex = 8;
            this.____.Text = "__________________";
            // 
            // butguardar
            // 
            this.butguardar.Location = new System.Drawing.Point(302, 263);
            this.butguardar.Name = "butguardar";
            this.butguardar.Size = new System.Drawing.Size(110, 23);
            this.butguardar.TabIndex = 9;
            this.butguardar.Text = "Guardar";
            this.butguardar.UseVisualStyleBackColor = true;
            this.butguardar.Click += new System.EventHandler(this.butguardar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btfechar
            // 
            this.btfechar.Location = new System.Drawing.Point(303, 321);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(108, 23);
            this.btfechar.TabIndex = 10;
            this.btfechar.Text = "Fechar";
            this.btfechar.UseVisualStyleBackColor = true;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // Letexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 356);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.butguardar);
            this.Controls.Add(this.____);
            this.Controls.Add(this.butparag);
            this.Controls.Add(this.butcaract);
            this.Controls.Add(this.butpalavra);
            this.Controls.Add(this.labparag);
            this.Controls.Add(this.labcaract);
            this.Controls.Add(this.labpalavras);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btficheiro);
            this.Name = "Letexto";
            this.Text = "Ler texto";
            this.Load += new System.EventHandler(this.Letexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btficheiro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labpalavras;
        private System.Windows.Forms.Label labcaract;
        private System.Windows.Forms.Label labparag;
        private System.Windows.Forms.Button butpalavra;
        private System.Windows.Forms.Button butcaract;
        private System.Windows.Forms.Button butparag;
        private System.Windows.Forms.Label ____;
        private System.Windows.Forms.Button butguardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btfechar;
    }
}

