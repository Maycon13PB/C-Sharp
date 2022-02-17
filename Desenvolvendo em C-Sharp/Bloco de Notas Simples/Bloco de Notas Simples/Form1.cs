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

namespace Bloco_de_Notas_Simples
{
    public partial class Form1 : Form
    {
        private OpenFileDialog abrirDialago;
        private SaveFileDialog salvarDialogo;
        private FontDialog fonteDialogo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fonteDialogo = new FontDialog();
        }

        private void CriarNovo()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    this.Text = "Sem título";
                    this.richTextBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Nâo tem nada para salvar!");

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void AbrirArquivo()
        {
            try
            {
                abrirDialago = new OpenFileDialog();

                if (abrirDialago.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(abrirDialago.FileName);
                    this.Text = abrirDialago.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                abrirDialago = null;
            }
        }
        private void SalvarArquivo()
        {
            try
            {
                salvarDialogo = new SaveFileDialog();

                salvarDialogo.Filter = "Arquivo de Texo (*.txt) | *.txt";

                if (salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarDialogo.FileName, this.richTextBox1.Text);
                    this.Text = salvarDialogo.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                abrirDialago = null;
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(fonteDialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fonteDialogo.Font;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
