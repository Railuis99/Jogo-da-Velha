using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_Raí
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn1.Text = "X";
                    btn1.Enabled = false;
                    
                    if((btn2.Text == "X" && btn3.Text == "X") || (btn5.Text == "X" && btn9.Text == "X") || (btn4.Text == "X" && btn7.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";
                        txtJogada.Text = "FIM";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn1.Text = "O";
                    btn1.Enabled = false;

                    if ((btn2.Text == "O" && btn3.Text == "O") || (btn5.Text == "O" && btn9.Text == "O") || (btn4.Text == "O" && btn7.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";
                        txtJogada.Text = "FIM";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn2.Text = "X";
                    btn2.Enabled = false;

                    if ((btn1.Text == "X" && btn3.Text == "X") || (btn5.Text == "X" && btn8.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";
                        txtJogada.Text = "FIM";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn2.Text = "O";
                    btn2.Enabled = false;

                    if ((btn1.Text == "O" && btn3.Text == "O") || (btn5.Text == "O" && btn8.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";
                        txtJogada.Text = "FIM";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn3.Text = "X";
                    btn3.Enabled = false;

                    if ((btn2.Text == "X" && btn1.Text == "X") || (btn5.Text == "X" && btn7.Text == "X") || (btn6.Text == "X" && btn9.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn3.Text = "O";
                    btn3.Enabled = false;

                    if ((btn2.Text == "O" && btn1.Text == "O") || (btn5.Text == "O" && btn7.Text == "O") || (btn6.Text == "O" && btn9.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn4.Text = "X";
                    btn4.Enabled = false;

                    if ((btn5.Text == "X" && btn6.Text == "X") || (btn1.Text == "X" && btn7.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn4.Text = "O";
                    btn4.Enabled = false;

                    if ((btn5.Text == "O" && btn6.Text == "O") || (btn1.Text == "O" && btn7.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn5.Text = "X";
                    btn5.Enabled = false;

                    if ((btn1.Text == "X" && btn9.Text == "X") || (btn2.Text == "X" && btn8.Text == "X") || (btn3.Text == "X" && btn7.Text == "X") || (btn4.Text == "X" && btn6.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn5.Text = "O";
                    btn5.Enabled = false;

                    if ((btn1.Text == "O" && btn9.Text == "O") || (btn2.Text == "O" && btn8.Text == "O") || (btn3.Text == "O" && btn7.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn6.Text = "X";
                    btn6.Enabled = false;

                    if ((btn3.Text == "X" && btn9.Text == "X") || (btn4.Text == "X" && btn5.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn6.Text = "O";
                    btn6.Enabled = false;

                    if ((btn3.Text == "O" && btn9.Text == "O") || (btn4.Text == "O" && btn5.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn7.Text = "X";
                    btn7.Enabled = false;

                    if ((btn1.Text == "X" && btn4.Text == "X") || (btn8.Text == "X" && btn9.Text == "X") || (btn3.Text == "X" && btn5.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn7.Text = "O";
                    btn7.Enabled = false;

                    if ((btn1.Text == "O" && btn4.Text == "O") || (btn8.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn8.Text = "X";
                    btn8.Enabled = false;

                    if ((btn7.Text == "X" && btn9.Text == "X") || (btn2.Text == "X" && btn5.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn8.Text = "O";
                    btn8.Enabled = false;

                    if ((btn7.Text == "O" && btn9.Text == "O") || (btn2.Text == "O" && btn5.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int vJogada;

            vJogada = Convert.ToInt16(txtJogada.Text);

            if (vJogada >= 0 && vJogada <= 9)
            {
                if (vJogada % 2 == 1)
                {
                    btn9.Text = "X";
                    btn9.Enabled = false;

                    if ((btn1.Text == "X" && btn5.Text == "X") || (btn8.Text == "X" && btn7.Text == "X") || (btn3.Text == "X" && btn2.Text == "X"))
                    {
                        txtRes.Text = "Jogador 1 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
                else
                {
                    btn9.Text = "O";
                    btn9.Enabled = false;

                    if ((btn1.Text == "O" && btn5.Text == "O") || (btn8.Text == "O" && btn7.Text == "O") || (btn3.Text == "O" && btn2.Text == "O"))
                    {
                        txtRes.Text = "Jogador 2 VENCEU";

                        btn1.Enabled = false;
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                    }
                }
            }

            if ((vJogada == 9) && (txtRes.Text == "... a jogar"))
            {
                txtRes.Text = "Empate";

            }

            vJogada = vJogada + 1;

            txtJogada.Text = vJogada.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            txtRes.Text = "... a jogar";
            txtJogada.Text = "1";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
    }
}
