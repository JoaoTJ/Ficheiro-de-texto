using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ficheiro_de_texto
{
    public partial class Letexto : Form
    {
        string arquivo;
        public Letexto()
        {
            InitializeComponent();
        }

        private void Letexto_Load(object sender, EventArgs e)
        {

        }

        private void btficheiro_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecionar Ficheiro:";
            openFileDialog1.Filter = "Ficheiros do tipo (*.txt)|*.txt";
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string text;
            OpenFileDialog arquivo = (OpenFileDialog)sender;
            text = File.ReadAllText(arquivo.FileName);
            textBox.Text = text;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labpalavras_Click(object sender, EventArgs e)
        {

        }

        private void butpalavra_Click(object sender, EventArgs e)
        {
            string texto = textBox.Text;

            char[] separator = {' '};
            texto = texto.Replace(Environment.NewLine, " ");

            int wordsCount = texto.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
            labpalavras.Text = wordsCount.ToString();
        }

        private void butcaract_Click(object sender, EventArgs e)
        {
            labcaract.Text = textBox.Text.Length.ToString();
        }

        private void butparag_Click(object sender, EventArgs e)
        {
            string num = textBox.Text;
            int count = 0;
            
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '.' || num[i] == '?' || num[i] == '!')
                {
                    count++;
                }
            }
            labparag.Text = "" + count;
        }

        private void butguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Ficheiros do tipo (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textBox.Text);
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
