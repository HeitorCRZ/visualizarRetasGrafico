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

        public void desenharPlanoPequeno(PaintEventArgs e)
        {
            desenharLinha(e, 130, 550, 760, 550, 1);
            desenharLinha(e, 445, 320, 445, 670, 1);
            desenharSetasPlanoPequeno(e);
            desenharTracejadoPlanoPequeno(e);
        }
        public void desenharSetasPlanoPequeno(PaintEventArgs e)
        {
            desenharLinha(e, 765, 550, 755, 545, 1);
            desenharLinha(e, 765, 550, 755, 555, 1);

            desenharLinha(e, 445, 315, 440, 325, 1);
            desenharLinha(e, 445, 315, 450, 325, 1);
        }

        public void desenharTracejadoPlanoPequeno(PaintEventArgs e)
        {
            for (int i = 0; i < 126; i++)
            {
                int x = 5 * i;
                desenharLinha(e, 130 + x, 549, 130 + x, 551, 1);
            }
            for (int i = 0; i < 70; i++)
            {
                int x = 5 * i;
                desenharLinha(e, 444, 325 + x, 446, 325 + x, 1);
            }
        }

        public void desenharFront(PaintEventArgs e)
        {
            iniciarCor(0,0,0);
            desenharLinha(e, 0, 250, 930, 250, 1); // Linha Horizontal Superior
            desenharLinha(e, 930, 320, 1400, 320, 1); // Linha Horizontal Inferior
            desenharLinha(e, 930, 0, 930, 800, 1); // Linha Vertical
            desenharPlanoPequeno(e);
        }
        public void desenharRetas(PaintEventArgs e)
        {
           
            for (int i = 0; i < listaRetas.Items.Count; i++)
            {
                string itemSelecionado = listaRetas.Items[i].ToString();
                string[] partes = itemSelecionado.Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

                int intervalo = int.Parse(partes[1].Trim());
                int inclinacao = int.Parse(partes[3].Trim());
                int intercepto = int.Parse(partes[5].Trim());
                int numeroCor = int.Parse(partes[7].Trim());

                acharCorReta(numeroCor);
                int pontoXinicial = calcularEixoX(inclinacao, intercepto, -120);
                int pontoXfinal = calcularEixoX(inclinacao, intercepto, 230);

                if (pontoXinicial < -315)
                    pontoXinicial = -315;
                if (pontoXfinal > 315)
                    pontoXfinal = 315;

                if (inclinacao == 0)
                    desenharLinha(e, 130, 550 - intercepto, 760, 550 - intercepto, 2);
                else
                    desenharLinha(e, 445 + pontoXinicial, 550 + 120, 445 + pontoXfinal, 320, 2);

                desenharPontoXYreta(e, inclinacao, intercepto, intervalo);
               

            }
        }
        public void desenharPontoXYreta(PaintEventArgs e, int inclinacao, int intercepto, int intervalo)
        {
            int y = calcularEixoY(inclinacao, intercepto, intervalo);
            iniciarCor(255, 0, 0);
            desenharLinha(e, 444 + intervalo, 550 - y, 446 + intervalo, 550 - y, 8);
            desenharLinha(e, 445, 551 - intercepto, 445, 549 - intercepto, 8);
            
        }
        public int calcularEixoX(int m, int b, int y)
        {
            if (m == 0)
                return 0;
            float valorX = (-b + y) / m;
            int xArredondado = (int)Math.Round(valorX);

            return xArredondado;
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

            if (!int.TryParse(inclinacaoBox.Text, out int inclinacao) ||
                !int.TryParse(interceptoBox.Text, out int intercepto) ||
                !int.TryParse(intervaloBox.Text, out int intervalo))
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
                desenharRetas(e);
                clickBtn = 0;
            }
            else if(clickBtn == 2)
            {
                desenharRetas(e);
                clickBtn = 0;
            }
            else if (clickBtn == 3)
            {
                clickBtn = 0;
            }
            else if (clickBtn == 4)
            {
                clickBtn = 0;
                desenharRetas(e);
            }


        }

        private void criarRetaBtn_Click(object sender, EventArgs e)
        {
            bool validado = validarDados();
            if (validado)
            {
                int inclinacao = int.Parse(inclinacaoBox.Text);
                int intercepto = int.Parse(interceptoBox.Text);
                int intervalo = int.Parse(intervaloBox.Text);

                int y = calcularEixoY(inclinacao, intercepto, intervalo);
                if (intervalo <= 315 && intervalo >= -315 && y <= 230 && y >= -120)
                {
                    int numeroCor = acharCorReta(0);
                    listaRetas.Items.Add("Reta(" + numeroReta + ") ---> x = " + intervalo + "; m = " + inclinacao + "; b = " + intercepto + "; Numero da cor = " + numeroCor);
                    numeroReta++;
                    clickBtn = 1;
                    messageStatus("Reta Criada", true);
                    Refresh();
                }
                else
                    messageStatus("Valor fora da escala do Plano. X(" + intervalo + ") e Y(" + y + ").", false);

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
                    clickBtn = 2;
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
            foreach (var item in listaRetas.Items)
            {
                string itemSelecionado = item.ToString();
                string[] partes = itemSelecionado.Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

                int intervalo = int.Parse(partes[1].Trim());
                int inclinacao = int.Parse(partes[3].Trim());
                int intercepto = int.Parse(partes[5].Trim());
                int y = calcularEixoY(inclinacao, intercepto, intervalo);
                if (inclinacao == 0)
                    dados += "f(" + intervalo + ") = " + inclinacao + "." + intervalo + "+" + intercepto + " ----> IM(f) = [" + y + "]\n";
                else if(intercepto>y)
                    dados += "f(" + intervalo + ") = " + inclinacao + "." + intervalo + "+" + intercepto + " ----> IM(f) = [" + y + "," + intercepto + "]\n";
                else
                    dados += "f(" + intervalo + ") = " + inclinacao + "." + intervalo + "+" + intercepto + " ----> IM(f) = [" + intercepto + "," + y + "]\n";



            }
            return dados;
        }
        private void salvarImagemBtn_Click(object sender, EventArgs e)
        {
            clickBtn = 3;
            criarArquivo();
        }

        private void resetarPlanoBtn_Click(object sender, EventArgs e)
        {
            clickBtn = 4;
            listaRetas.Items.Clear();
            messageStatus("Plano Cartesiano Limpo", true);
            Refresh();
        }
    }
}
