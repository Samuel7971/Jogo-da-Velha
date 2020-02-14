using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha01
{
    public partial class Form1 : Form
    {
        //Variáveis:
        int pontoX = 0, pontoO = 0;

        string ganhador = "";

        public Form1()
        {
            InitializeComponent();

            Limpar();
        }

        private void Limpar()
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
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            radioButtonJogadorX.Enabled = true;
            radioButtonJogadorO.Enabled = true;
            btn_01.Enabled = true;
            btn_02.Enabled = true;
            btn_03.Enabled = true;
            btn_04.Enabled = true;
            btn_05.Enabled = true;
            btn_06.Enabled = true;
            btn_07.Enabled = true;
            btn_08.Enabled = true;
            btn_09.Enabled = true;
           
        }

        private void radioButtonJogadorX_CheckedChanged(object sender, EventArgs e)
        {
               
        }

        private void radioButtonJogadorO_CheckedChanged(object sender, EventArgs e)
        {
                        
        }

        public void btn_01_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_01.Text = "X";
                btn_01.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_01.Text = "O";
                btn_01.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador();   // chamando função para verificar ganhador vertical superior
            Ganhador3();  // chamando função para verificar ganhador(|  )
            Ganhador7();  // chamando função para verificar ganhador( \ )
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_02.Text = "X";
                btn_02.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_02.Text = "O";
                btn_02.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador();   // chamando função para verificar ganhador vertical superior
            Ganhador4();  // chamando função para verificar ganhador( | )
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_03.Text = "X";
                btn_03.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_03.Text = "O";
                btn_03.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador();   // chamando função para verificar ganhador vertical superior
            Ganhador5();  // chamando função para verificar ganhador(  |)
            Ganhador6();  // chamando função para verificar ganhador( / )
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_04.Text = "X";
                btn_04.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_04.Text = "O";
                btn_04.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador1();  // chamando função para verificar ganhador(---)
            Ganhador3();  // chamando função para verificar ganhador(|  )
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_05.Text = "X";
                btn_05.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_05.Text = "O";
                btn_05.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador1();  // chamando função para verificar ganhador(---)
            Ganhador4();  // chamando função para verificar ganhador( | )
            Ganhador6();  // chamando função para verificar ganhador( / )
            Ganhador7();  // chamando função para verificar ganhador( \ )
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_06.Text = "X";
                btn_06.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_06.Text = "O";
                btn_06.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador1();  // chamando função para verificar ganhador(---)
            Ganhador5();  // chamando função para verificar ganhador(  |)
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_07.Text = "X";
                btn_07.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_07.Text = "O";
                btn_07.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador2();  // chamando função para verificar ganhador(___)
            Ganhador3();  // chamando função para verificar ganhador(|  )
            Ganhador6();  // chamando função para verificar ganhador( / )
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_08.Text = "X";
                btn_08.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_08.Text = "O";
                btn_08.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador2();  // chamando função para verificar ganhador(___)
            Ganhador4();  // chamando função para verificar ganhador( | )
        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            if (radioButtonJogadorX.Checked == true)
            {
                this.btn_09.Text = "X";
                btn_09.Enabled = false;
                radioButtonJogadorO.Checked = true;
            }
            else
            {
                this.btn_09.Text = "O";
                btn_09.Enabled = false;
                radioButtonJogadorX.Checked = true;
            }
            Ganhador2();  // chamando função para verificar ganhador(___)
            Ganhador5();  // chamando função para verificar ganhador(  |)
            Ganhador7();  // chamando função para verificar ganhador( \ )
        }

        // Verificando ganhador na reta vertical superior
        public void Ganhador()
        {
            if (btn_01.Text == btn_02.Text && btn_02.Text == btn_03.Text)
            {
                if(radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");        
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador na reta vertical - meio(---)
        public void Ganhador1()
        {
            if (btn_04.Text == btn_05.Text && btn_05.Text == btn_06.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador na reta horizontal de baixo(___)
        public void Ganhador2()
        {
            if (btn_07.Text == btn_08.Text && btn_08.Text == btn_09.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador na vertical da esquerada(|  )
        public void Ganhador3()
        {
            if (btn_01.Text == btn_04.Text && btn_04.Text == btn_07.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador na vertical do meio( | )
        public void Ganhador4()
        {
            if (btn_02.Text == btn_05.Text && btn_05.Text == btn_08.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador na vartical direita(  |)
        public void Ganhador5()
        {
            if (btn_03.Text == btn_06.Text && btn_06.Text == btn_09.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador em  transversal da direita para esquerda( / )
        public void Ganhador6()
        {
            if (btn_03.Text == btn_05.Text && btn_05.Text == btn_07.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        // Verificando ganhador em transversal da esquerda para a direita( \ )
        public void Ganhador7()
        {
            if (btn_01.Text == btn_05.Text && btn_05.Text == btn_09.Text)
            {
                if (radioButtonJogadorO.Checked == true)
                {
                    MessageBox.Show("O jogador" + " X " + "é o vencedor!!!");
                    textBoxPontoX.Text = Convert.ToString(pontoX += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "X";
                    Limpar();
                }

                else
                {
                    MessageBox.Show("O jogador" + " O " + "é o vencedor!!!");
                    textBoxPontoO.Text = Convert.ToString(pontoO += 1);
                    button_Iniciar.Enabled = false;
                    btn_NovoJogo.Focus();
                    ganhador = "O";
                    Limpar();
                }    
            }
        }

        private void btn_NovoJogo_Click(object sender, EventArgs e)
        {
            if (ganhador == "X")
            {
                radioButtonJogadorX.Checked = true;
            }
            else
            {
                radioButtonJogadorO.Checked = true;
            }

            btn_01.Text = "";
            btn_02.Text = "";
            btn_03.Text = "";
            btn_04.Text = "";
            btn_05.Text = "";
            btn_06.Text = "";
            btn_07.Text = "";
            btn_08.Text = "";
            btn_09.Text = "";
      
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
            btn_01.Text = "";
            btn_02.Text = "";
            btn_03.Text = "";
            btn_04.Text = "";
            btn_05.Text = "";
            btn_06.Text = "";
            btn_07.Text = "";
            btn_08.Text = "";
            btn_09.Text = "";
            textBoxPontoX.Text = "";
            textBoxPontoO.Text = "";
            pontoO = 0;
            pontoX = 0;
            button_Iniciar.Enabled = true;
            button_Iniciar.Focus();
            
            radioButtonJogadorX.Enabled = true;
            radioButtonJogadorO.Enabled = true;
            radioButtonJogadorO.Checked = false;
            radioButtonJogadorX.Checked = false;


        }

    }
}
