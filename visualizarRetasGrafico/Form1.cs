using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace visualizarRetasGrafico
{
    public partial class Form1 : Form
    {
        int numeroReta = 1;
        int clickBtn = 0;
        Color cor;

        int pontoYGraficoRetaX = 550;
        int pontoInicialGraficoRetaX = 130;
        int pontoFinalGraficoRetaX = 760;

        int pontoXGraficoRetaY = 445;
        int pontoInicialGraficoRetaY = 320;
        int pontoFinalGraficoRetaY = 670;
        public void iniciarCor(int r, int g, int b)
        {
            cor = Color.FromArgb(255, r, g, b);
        }
        public Pen criarCaneta(Color cor, int i)
        {
            Pen caneta = new Pen(cor, i);
            return caneta;
        }
        public void desenharLinha(PaintEventArgs e, int x1, int y1, int x2, int y2, int espessura)
        {
            Pen caneta = criarCaneta(cor,espessura);
            e.Graphics.DrawLine(caneta, x1, y1, x2, y2);
        }

        public void desenharGrafico(PaintEventArgs e)
        {
            desenharLinha(e, pontoInicialGraficoRetaX, pontoYGraficoRetaX, pontoFinalGraficoRetaX, pontoYGraficoRetaX, 1);
            desenharLinha(e, pontoXGraficoRetaY, pontoInicialGraficoRetaY, pontoXGraficoRetaY, pontoFinalGraficoRetaY, 1);
            desenharSetasPlanoPequeno(e);
            desenharTracejadoPlanoPequeno(e);
        }
        public void desenharSetasPlanoPequeno(PaintEventArgs e)
        {
            desenharLinha(e, pontoFinalGraficoRetaX + 5, pontoYGraficoRetaX, pontoFinalGraficoRetaX - 5, pontoYGraficoRetaX - 5, 1);
            desenharLinha(e, pontoFinalGraficoRetaX + 5, pontoYGraficoRetaX, pontoFinalGraficoRetaX - 5, pontoYGraficoRetaX + 5, 1);

            desenharLinha(e, pontoXGraficoRetaY, pontoInicialGraficoRetaY - 5, pontoXGraficoRetaY - 5, pontoInicialGraficoRetaY + 5, 1);
            desenharLinha(e, pontoXGraficoRetaY, pontoInicialGraficoRetaY - 5, pontoXGraficoRetaY + 5, pontoInicialGraficoRetaY + 5, 1);
        }

        public void desenharTracejadoPlanoPequeno(PaintEventArgs e)
        {
            for (int i = 0; i < 126; i++)
            {
                int x = 5 * i;
                desenharLinha(e, pontoInicialGraficoRetaX + x, pontoYGraficoRetaX - 1, pontoInicialGraficoRetaX + x, pontoYGraficoRetaX + 1, 1);
            }
            for (int i = 0; i < 70; i++)
            {
                int x = 5 * i;
                desenharLinha(e, pontoXGraficoRetaY - 1, pontoInicialGraficoRetaY + x, pontoXGraficoRetaY + 1, pontoInicialGraficoRetaY + x, 1);
            }
        }

        public void desenharFront(PaintEventArgs e)
        {
            iniciarCor(0,0,0);
            desenharLinha(e, 0, 250, 930, 250, 1); // Linha Horizontal Superior
            desenharLinha(e, 930, 320, 1400, 320, 1); // Linha Horizontal Inferior
            desenharLinha(e, 930, 0, 930, 800, 1); // Linha Vertical
            desenharGrafico(e);
        }
        public void desenharRetasGrafico(PaintEventArgs e)
        {
           
            for (int i = 0; i < listaRetas.Items.Count; i++)
            {
                string itemSelecionado = listaRetas.Items[i].ToString();
                string[] partes = itemSelecionado.Split(new char[] { '=', ';' });

                int x1 = int.Parse(partes[1]);
                int y1 = int.Parse(partes[3]);
                int x2 = int.Parse(partes[5]);
                int y2 = int.Parse(partes[7]);
                int inclinacao = int.Parse(partes[9]);
                int intercepto = int.Parse(partes[11]);
                int numeroCor = int.Parse(partes[13]);
           

                acharCorReta(numeroCor);
                desenharLinha(e, pontoXGraficoRetaY + x1, pontoYGraficoRetaX - y1, pontoXGraficoRetaY + x2, pontoYGraficoRetaX - y2,2);
            }
        }
       

        public int calcularEixoY(int m, int b, int x)
        {
            int y = m * x + b;
            return y;
        }


        public int acharCorReta(int numeroCor)
        {
          
            if (numeroCor == 0)
            {
                if (azulBtn.Checked) numeroCor = 1;
                else if (cinzaBtn.Checked) numeroCor = 2;
                else if (verdeBtn.Checked) numeroCor = 3;
                else if (pretoBtn.Checked) numeroCor = 4;
                else if (laranjaBtn.Checked) numeroCor = 5;
                else if (rosaBtn.Checked) numeroCor = 6;
                else if (amareloBtn.Checked) numeroCor = 7;
                else if (roxoBtn.Checked) numeroCor = 8;
                else if (marromBtn.Checked) numeroCor = 9;
                else return 0;
            }

         
            switch (numeroCor)
            {
                case 1: iniciarCor(0, 0, 255); return 1; // Azul
                case 2: iniciarCor(169, 169, 169); return 2; // Cinza
                case 3: iniciarCor(0, 255, 0); return 3; // Verde
                case 4: iniciarCor(0, 0, 0); return 4; // Preto
                case 5: iniciarCor(255, 165, 0); return 5; // Laranja
                case 6: iniciarCor(255, 220, 230); return 6; // Rosa
                case 7: iniciarCor(255, 255, 0); return 7; // Amarelo
                case 8: iniciarCor(128, 0, 128); return 8; // Roxo
                case 9: iniciarCor(139, 69, 19); return 9; // Marrom
                default: return 0; 
            }
        }


        public bool validarDados()
        {
            int corEncontrada = acharCorReta(0);

            if (corEncontrada == 0)
            {
                messageStatus("Cor não encontrada", false);
                return false;
            }

            string[] linhas = intervalosBox.Lines;

            if (linhas.Length < 2 ||
                !int.TryParse(inclinacaoBox.Text, out int inclinacao) ||
                !int.TryParse(interceptoBox.Text, out int intercepto) ||
                !int.TryParse(linhas[0], out int intervalo1) ||
                !int.TryParse(linhas[1], out int intervalo2))
            {
                messageStatus("Valores inválidos. Certifique-se de que todos os campos contêm números inteiros.", false);
                return false;
            }
            return true;
        }


        public void messageStatus(string txt, bool status)
        {
            if (status)
            {
                messageLabel.Text = txt;
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.Text = txt;
                messageLabel.ForeColor = Color.Red;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            desenharFront(e);
            if(clickBtn == 1)
            {
                desenharRetasGrafico(e);
                clickBtn = 0;          
            }
        }

        private void criarRetaBtn_Click(object sender, EventArgs e)
        {
            bool validado = validarDados();
            if (validado)
            {
                int inclinacao = int.Parse(inclinacaoBox.Text);
                int intercepto = int.Parse(interceptoBox.Text);
                string[] linhas = intervalosBox.Lines;
                int intervalo1 = int.Parse(linhas[0]);
                int intervalo2 = int.Parse(linhas[1]);

                int y1 = calcularEixoY(inclinacao, intercepto, intervalo1);
                int y2 = calcularEixoY(inclinacao, intercepto, intervalo2);
                if ( (intervalo1 <= 315 && intervalo1 >= -315 && y1 <= 230 && y1 >= -120) ||
                     (intervalo1 <= 315 && intervalo1 >= -315 && y1 <= 230 && y1 >= -120) )
                {
                    int numeroCor = acharCorReta(0);
                    listaRetas.Items.Add("Reta(" + numeroReta + ")->x1=" + intervalo1 + ";y1= " + y1 + ";x2=" + intervalo2 + ";y2=" + y2 + ";m=" + inclinacao + ";b=" + intercepto + ";Numero da cor = " + numeroCor);
                    numeroReta++;
                    clickBtn = 1;
                    messageStatus("Reta Criada", true);
                    Refresh();
                }
                else
                    messageStatus("Valor fora da escala do Plano. X1(" + intervalo1 + ") e Y1(" + y1 + ") / X2(" + intervalo2 + ") e Y2(" + y2 + ") .", false);

            }
            
        }

        private void deletarRetaBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(deletarBox.Text, out int indice))
                messageStatus("Selecione o número de uma reta para deletar", false);
            else
            {
                string prefixo = $"Reta({indice})";
                int index = -1;

                for (int i = 0; i < listaRetas.Items.Count; i++)
                {
                    if (listaRetas.Items[i].ToString().StartsWith(prefixo))
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    listaRetas.Items.RemoveAt(index);
                    clickBtn = 1;
                    messageStatus("Reta Deletada", false);
                    Refresh();
                }
                else
                    messageStatus("Reta não encontrada na lista", false);
                
            }
        }

        public void criarArquivo()
        {
            string caminho = "imagemRetas.txt";
            string conteudo = pegarDadosArquivo();
            if (conteudo != null)
            {
                File.WriteAllText(caminho, conteudo);
                messageStatus("Arquivo gerado com sucesso", true);
            }
            else
                messageStatus("Erro ao gerar arquivo", false);

        }
        public string pegarDadosArquivo()
        {
            string dados = "";
            for (int i = 0; i < listaRetas.Items.Count; i++){

                string itemSelecionado = listaRetas.Items[i].ToString();
                string[] partes = itemSelecionado.Split(new char[] { '=', ';' });

                int y1 = int.Parse(partes[3]);
                int y2 = int.Parse(partes[7]);
               
               
                if (y1 > y2)
                    dados += "IM(f) = [" + y2 +","+ y1 +"]\n";
                else if (y2 > y1)
                    dados += "IM(f) = [" + y1 + "," + y2 + "]\n";
                else
                    dados += "IM(f) = [" + y1 + "]\n";
            }
            return dados;
        }
        private void salvarImagemBtn_Click(object sender, EventArgs e)
        {
            criarArquivo();
        }

        private void resetarPlanoBtn_Click(object sender, EventArgs e)
        {
            listaRetas.Items.Clear();
            messageStatus("Plano Cartesiano Limpo", true);
            Refresh();
        }
    }
}
