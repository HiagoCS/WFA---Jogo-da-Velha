using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA___Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        public char rodada;
        public char[,] jogo = new char[3,3];
        public int pontoX = 0;
        public int pontoO = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            start(gbJogo.Controls);
            rodada = 'X';
            vez.Text = Convert.ToString(rodada);
            vez.ForeColor = Color.MediumBlue;
            startBtn.Enabled = false;
            restartBtn.Enabled = true;
        }
        private void restartBtn_Click(object sender, EventArgs e)
        {
            clean(gbJogo.Controls);
            vez.Text = null;
            vez.ForeColor = Color.MediumBlue;
            rodada = 'X';
            jogo[0, 0] = '0';
            jogo[0, 1] = '0';
            jogo[0, 2] = '0';
            jogo[1, 0] = '0';
            jogo[1, 1] = '0';
            jogo[1, 2] = '0';
            jogo[2, 0] = '0';
            jogo[2, 1] = '0';
            jogo[2, 2] = '0';
            startBtn.Enabled = true;
            restartBtn.Enabled = false;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                a1.Enabled = false;
                a1.Text = "X";
                a1.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[0, 0] = 'X';
                if (jogo[1,1] == 'X' && jogo[2, 2] == 'X' && jogo[0, 0] == 'X')
                {
                    a1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 1] == 'X' && jogo[0, 2] == 'X' && jogo[0, 0] == 'X')
                {
                    a1.BackColor = Color.Green;
                    a2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[1, 0] == 'X' && jogo[2, 0] == 'X' && jogo[0, 0] == 'X')
                {
                    a1.BackColor = Color.Green;
                    b1.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }

            }
            else if(rodada == 'O')
            {
                a1.Text = "O";
                a1.Enabled = false;
                a1.ForeColor = Color.Red;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[0, 0] = 'O';
                if (jogo[1, 1] == 'O' && jogo[2, 2] == 'O' && jogo[0, 0] == 'O')
                {
                    a1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 1] == 'O' && jogo[0, 2] == 'O' && jogo[0, 0] == 'O')
                {
                    a1.BackColor = Color.Green;
                    a2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[1, 0] == 'O' && jogo[2, 0] == 'O' && jogo[0, 0] == 'O')
                {
                    a1.BackColor = Color.Green;
                    b1.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                b1.Text = "X";
                b1.Enabled = false;
                b1.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[1, 0] = 'X';
                if (jogo[1, 0] == 'X' && jogo[0, 0] == 'X' && jogo[2, 0] == 'X')
                {
                    a1.BackColor = Color.Green;
                    b1.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[1, 0] == 'X' && jogo[1, 1] == 'X' && jogo[1, 2] == 'X')
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                b1.Text = "O";
                b1.Enabled = false;
                b1.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[1, 0] = 'O';
                if (jogo[1, 0] == 'O' && jogo[0, 0] == 'O' && jogo[2, 0] == 'O')
                {
                    a1.BackColor = Color.Green;
                    b1.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[1, 0] == 'O' && jogo[1, 1] == 'O' && jogo[1, 2] == 'O')
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                c1.Text = "X";
                c1.Enabled = false;
                c1.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[2, 0] = 'X';
                if (jogo[2, 0] == 'X' && jogo[1, 0] == 'X' && jogo[0, 0] == 'X')
                {
                    a1.BackColor = Color.Green;
                    b1.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[2, 0] == 'X' && jogo[2, 1] == 'X' && jogo[2, 2] == 'X')
                {
                    c1.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if(jogo[2, 0] == 'X' && jogo[1, 1] == 'X' && jogo[0, 2] == 'X')
                {
                    c1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                c1.Text = "O";
                c1.Enabled = false;
                c1.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[2, 0] = 'O';
                if (jogo[2, 0] == 'O' && jogo[1, 0] == 'O' && jogo[0, 0] == 'O')
                {
                    a1.BackColor = Color.Green;
                    b1.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[2, 0] == 'O' && jogo[2, 1] == 'O' && jogo[2, 2] == 'O')
                {
                    c1.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                }
                else if (jogo[2, 0] == 'O' && jogo[1, 1] == 'O' && jogo[0, 2] == 'O')
                {
                    c1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                a2.Text = "X";
                a2.Enabled = false;
                a2.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[0, 1] = 'X';
                if (jogo[0, 1] == 'X' && jogo[0, 0] == 'X' && jogo[0, 2] == 'X')
                {
                    a1.BackColor = Color.Green;
                    a2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if(jogo[0, 1] == 'X' && jogo[1, 1] == 'X' && jogo[2, 1] == 'X')
                {
                    a2.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                a2.Text = "O";
                a2.Enabled = false;
                a2.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[0, 1] = 'O';
                if (jogo[0, 1] == 'O' && jogo[0, 0] == 'O' && jogo[0, 2] == 'O')
                {
                    a1.BackColor = Color.Green;
                    a2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 1] == 'O' && jogo[1, 1] == 'O' && jogo[2, 1] == 'O')
                {
                    a2.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                b2.Text = "X";
                b2.Enabled = false;
                b2.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[1, 1] = 'X';
                if (jogo[0, 0] == 'X' && jogo[2, 2] == 'X' && jogo[1, 1] == 'X')
                {
                    a1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 1] == 'X' && jogo[2, 1] == 'X' && jogo[1, 1] == 'X')
                {
                    a2.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[1, 0] == 'X' && jogo[1, 1] == 'X' && jogo[1, 2] == 'X')
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 2] == 'X' && jogo[2, 0] == 'X' && jogo[1, 1] == 'X')
                {
                    a3.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                b2.Text = "O";
                b2.Enabled = false;
                b2.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[1, 1] = 'O';
                if (jogo[0, 0] == 'O' && jogo[2, 2] == 'O' && jogo[1, 1] == 'O')
                {
                    a1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 1] == 'O' && jogo[2, 1] == 'O' && jogo[1, 1] == 'O')
                {
                    a2.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[1, 0] == 'O' && jogo[1, 1] == 'O' && jogo[1, 2] == 'O')
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 2] == 'O' && jogo[2, 0] == 'O' && jogo[1, 1] == 'O')
                {
                    a3.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                c2.Text = "X";
                c2.Enabled = false;
                c2.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[2, 1] = 'X';
                if (jogo[2, 1] == 'X' && jogo[2, 0] == 'X' && jogo[2, 2] == 'X')
                {
                    c1.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 1] == 'X' && jogo[2, 1] == 'X' && jogo[1, 1] == 'X')
                {
                    a2.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }

            }
            else if (rodada == 'O')
            {
                c2.Text = "O";
                c2.Enabled = false;
                c2.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[2, 1] = 'O';
                if (jogo[2, 1] == 'O' && jogo[2, 0] == 'O' && jogo[2, 2] == 'O')
                {
                    c1.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 1] == 'O' && jogo[2, 1] == 'O' && jogo[1, 1] == 'O')
                {
                    a2.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                a3.Text = "X";
                a3.Enabled = false;
                a3.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[0, 2] = 'X';
                if (jogo[0, 1] == 'X' && jogo[0, 2] == 'X' && jogo[0, 0] == 'X')
                {
                    a1.BackColor = Color.Green;
                    a2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 2] == 'X' && jogo[2, 0] == 'X' && jogo[1, 1] == 'X')
                {
                    a3.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 2] == 'X' && jogo[2, 2] == 'X' && jogo[1, 2] == 'X')
                {
                    a3.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                a3.Text = "O";
                a3.Enabled = false;
                a3.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[0, 2] = 'O';
                if (jogo[0, 1] == 'O' && jogo[0, 2] == 'O' && jogo[0, 0] == 'O')
                {
                    a1.BackColor = Color.Green;
                    a2.BackColor = Color.Green;
                    a3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 2] == 'O' && jogo[2, 0] == 'O' && jogo[1, 1] == 'O')
                {
                    a3.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c1.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 2] == 'O' && jogo[2, 2] == 'O' && jogo[1, 2] == 'O')
                {
                    a3.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                b3.Text = "X";
                b3.Enabled = false;
                b3.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[1, 2] = 'X';
                if(jogo[0, 2] == 'X' && jogo[2, 2] == 'X' && jogo[1, 2] == 'X')
                {
                    a3.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[1, 0] == 'X' && jogo[1, 1] == 'X' && jogo[1, 2] == 'X')
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                b3.Text = "O";
                b3.Enabled = false;
                b3.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[1, 2] = 'O';
                if (jogo[0, 2] == 'O' && jogo[2, 2] == 'O' && jogo[1, 2] == 'O')
                {
                    a3.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[1, 0] == 'O' && jogo[1, 1] == 'O' && jogo[1, 2] == 'O')
                {
                    b1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0, 0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (rodada == 'X')
            {
                c3.Text = "X";
                c3.Enabled = false;
                c3.ForeColor = Color.MediumBlue;
                rodada = 'O';
                vez.Text = Convert.ToString(rodada);
                jogo[2, 2] = 'X';
                if (jogo[0, 0] == 'X' && jogo[1, 1] == 'X' && jogo[2, 2] == 'X')
                {
                    a1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[2, 1] == 'X' && jogo[2, 0] == 'X' && jogo[2, 2] == 'X')
                {
                    c1.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
                else if (jogo[0, 2] == 'X' && jogo[2, 2] == 'X' && jogo[1, 2] == 'X')
                {
                    a3.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoX++;
                    pontosX.Text = Convert.ToString(pontoX);
                }
            }
            else if (rodada == 'O')
            {
                c3.Text = "O";
                c3.Enabled = false;
                c3.ForeColor = Color.MediumBlue;
                rodada = 'X';
                vez.Text = Convert.ToString(rodada);
                jogo[2, 2] = 'O';
                if (jogo[0, 0] == 'O' && jogo[1, 1] == 'O' && jogo[2, 2] == 'O')
                {
                    a1.BackColor = Color.Green;
                    b2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[2, 1] == 'O' && jogo[2, 0] == 'O' && jogo[2, 2] == 'O')
                {
                    c1.BackColor = Color.Green;
                    c2.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
                else if (jogo[0, 2] == 'O' && jogo[2, 2] == 'O' && jogo[1, 2] == 'O')
                {
                    a3.BackColor = Color.Green;
                    b3.BackColor = Color.Green;
                    c3.BackColor = Color.Green;
                    disnable(gbJogo.Controls);
                    pontoO++;
                    pontosO.Text = Convert.ToString(pontoO);
                }
            }
            else if (jogo[0,0] != '0' && jogo[0, 1] != '0' && jogo[0, 2] != '0' && jogo[1, 0] != '0' && jogo[1, 1] != '0' && jogo[1, 2] != '0' && jogo[2, 0] != '0' && jogo[2, 1] != '0' && jogo[2, 2] != '0')
            {
                deuVelha.Text = "Deu velha!!!";
            }
        }
        private void disnable(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).Enabled = false;
                }
            }
        }
        private void clean(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).Text = null;
                    ((Button)(ctrl)).Enabled = false;
                    ((Button)(ctrl)).BackColor = restartBtn.BackColor;
                }
            }
        }
        private void start(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).Enabled = true;
                }
            }
        }
    }
}
