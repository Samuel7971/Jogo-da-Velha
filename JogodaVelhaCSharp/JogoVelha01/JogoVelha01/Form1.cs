using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha01
{
    public partial class Form1 : Form
    {
        //Variáveis:
        int pontoX = 0, pontoO = 0, empate = 0;

        string ganhador = string.Empty;

        public Form1()
        {
            InitializeComponent();

            DesabilitarBotoes();
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            AtivarBotoes();
        }

        public void btn_01_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalSuperior();
            GanhadorVerticalEsquerda();
            GanhadorTransversalEsquerdaDireita();
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalSuperior();
            GanhadorVerticalCentro();
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalSuperior();
            GanhadorVerticaoDireita();
            GanhadorTransversalDireitaEsquerda();
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalMeio();
            GanhadorVerticalEsquerda();
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalMeio();
            GanhadorVerticalCentro();
            GanhadorTransversalDireitaEsquerda();
            GanhadorTransversalEsquerdaDireita();
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalMeio();
            GanhadorVerticaoDireita();
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalBaixo();
            GanhadorVerticalEsquerda();
            GanhadorTransversalDireitaEsquerda();
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);

            GanhadorHorizontalBaixo();
            GanhadorVerticalCentro();
        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            Verificar(sender, e);
            //VerificarProximoJogador(sender, e);
            GanhadorHorizontalBaixo();
            GanhadorVerticaoDireita();
            GanhadorTransversalEsquerdaDireita();
        }

        private bool VerificandoAreaVaga()
        {
            if (string.IsNullOrEmpty(btn_01.Text) ||
                string.IsNullOrEmpty(btn_02.Text) ||
                string.IsNullOrEmpty(btn_03.Text) ||
                string.IsNullOrEmpty(btn_04.Text) ||
                string.IsNullOrEmpty(btn_05.Text) ||
                string.IsNullOrEmpty(btn_06.Text) ||
                string.IsNullOrEmpty(btn_07.Text) ||
                string.IsNullOrEmpty(btn_08.Text) ||
                string.IsNullOrEmpty(btn_09.Text))
                return true;

            return false;
        }

        private void VerificarProximoJogador(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (radioButtonJogadorX.Checked == true)
            {
                button.Text = "X";
                button.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
        }

        private void InformarGanhador()
        {
            if (radioButtonJogadorO.Checked == true)
            {
                MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                button_Iniciar.Enabled = false;
                ganhador = "X";
                DesabilitarBotoes();
                btn_NovoJogo.Enabled = true;
                btn_NovoJogo.Focus();
                btn_Zerar.Enabled = true;
            }

            else if (radioButtonJogadorX.Checked == true)
            {
                MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                button_Iniciar.Enabled = false;
                ganhador = "O";
                DesabilitarBotoes();
                btn_NovoJogo.Enabled = true;
                btn_NovoJogo.Focus();
                btn_Zerar.Enabled = true;
            }
            else
                ganhador = string.Empty;
        }

        private bool VerificarEmpate()
        {
            if (btn_01.Text == btn_02.Text && btn_02.Text == btn_03.Text ||
                btn_04.Text == btn_05.Text && btn_05.Text == btn_06.Text ||
                btn_07.Text == btn_08.Text && btn_08.Text == btn_09.Text ||
                btn_01.Text == btn_04.Text && btn_04.Text == btn_07.Text ||
                btn_02.Text == btn_05.Text && btn_05.Text == btn_08.Text ||
                btn_03.Text == btn_06.Text && btn_06.Text == btn_09.Text ||
                btn_03.Text == btn_05.Text && btn_05.Text == btn_07.Text ||
                btn_01.Text == btn_05.Text && btn_05.Text == btn_09.Text)
            {
                return false;
            }

            return true;
        }

        // Verificando ganhador na reta vertical superior
        public void GanhadorHorizontalSuperior()
        {
            if (btn_01.Text == btn_02.Text && btn_02.Text == btn_03.Text)
                InformarGanhador();
        }

        // Verificando ganhador na reta vertical - meio(---)
        public void GanhadorHorizontalMeio()
        {
            if (btn_04.Text == btn_05.Text && btn_05.Text == btn_06.Text)
                InformarGanhador();
        }

        // Verificando ganhador na reta horizontal de baixo(___)
        public void GanhadorHorizontalBaixo()
        {
            if (btn_07.Text == btn_08.Text && btn_08.Text == btn_09.Text)
                InformarGanhador();
        }

        // Verificando ganhador na vertical da esquerada(|  )
        public void GanhadorVerticalEsquerda()
        {
            if (btn_01.Text == btn_04.Text && btn_04.Text == btn_07.Text)
                InformarGanhador();
        }

        // Verificando ganhador na vertical do meio( | )
        public void GanhadorVerticalCentro()
        {
            if (btn_02.Text == btn_05.Text && btn_05.Text == btn_08.Text)
                InformarGanhador();
        }

        // Verificando ganhador na vartical direita(  |)
        public void GanhadorVerticaoDireita()
        {
            if (btn_03.Text == btn_06.Text && btn_06.Text == btn_09.Text)
                InformarGanhador();
        }

        // Verificando ganhador em  transversal da direita para esquerda( / )
        public void GanhadorTransversalDireitaEsquerda()
        {
            if (btn_03.Text == btn_05.Text && btn_05.Text == btn_07.Text)
                InformarGanhador();
        }

        // Verificando ganhador em transversal da esquerda para a direita( \ )
        public void GanhadorTransversalEsquerdaDireita()
        {
            if (btn_01.Text == btn_05.Text && btn_05.Text == btn_09.Text)
                InformarGanhador();
        }

        private void btn_NovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void NovoJogo()
        {
            if (ganhador == "X")
                radioButtonJogadorX.Checked = true;
            else
                radioButtonJogadorO.Checked = true;

            LimparTextBotoes();
            AtivarBotoes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Zerar_Click(object sender, EventArgs e)
        {
            //Teste botão Zerar
            LimparTextBotoes();
            textBoxPontoX.Text = string.Empty;
            textBoxPontoO.Text = string.Empty;
            textBoxEmpate.Text = string.Empty;
            pontoO = 0;
            pontoX = 0;
            empate = 0;
            button_Iniciar.Enabled = true;
            button_Iniciar.Focus();

            radioButtonJogadorX.Enabled = true;
            radioButtonJogadorO.Enabled = true;
            radioButtonJogadorO.Checked = false;
            radioButtonJogadorX.Checked = false;
        }

        private void LimparTextBotoes()
        {
            btn_01.Text = string.Empty;
            btn_02.Text = string.Empty;
            btn_03.Text = string.Empty;
            btn_04.Text = string.Empty;
            btn_05.Text = string.Empty;
            btn_06.Text = string.Empty;
            btn_07.Text = string.Empty;
            btn_08.Text = string.Empty;
            btn_09.Text = string.Empty;
        }

        private void AtivarBotoes()
        {
            btn_01.Enabled = true;
            btn_02.Enabled = true;
            btn_03.Enabled = true;
            btn_04.Enabled = true;
            btn_05.Enabled = true;
            btn_06.Enabled = true;
            btn_07.Enabled = true;
            btn_08.Enabled = true;
            btn_09.Enabled = true;
            radioButtonJogadorX.Enabled = true;
            radioButtonJogadorO.Enabled = true;
            btn_NovoJogo.Enabled = true;
            btn_Zerar.Enabled = true;
        }

        private void DesabilitarBotoes()
        {
            btn_01.Enabled = false;
            btn_02.Enabled = false;
            btn_03.Enabled = false;
            btn_04.Enabled = false;
            btn_05.Enabled = false;
            btn_06.Enabled = false;
            btn_07.Enabled = false;
            btn_08.Enabled = false;
            btn_09.Enabled = false;
            radioButtonJogadorX.Enabled = false;
            radioButtonJogadorO.Enabled = false;
            btn_NovoJogo.Enabled = false;
            btn_Zerar.Enabled = false;
        }

        private bool Verificar(object sender, EventArgs e)
        {
            VerificarProximoJogador(sender, e);
            if (!VerificandoAreaVaga())
            {
                var retornno = VerificarEmpate();
                if (retornno)
                {
                    if (MessageBox.Show("EMPATE!!!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        empate += 1;
                        textBoxEmpate.Text = empate.ToString();
                        button_Iniciar.Enabled = false;
                        btn_NovoJogo.Focus();
                    }
                }
            }
            return true;
        }

    }
}
