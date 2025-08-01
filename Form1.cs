using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enWinner { Player1,Player2,Draw,InProgress };

        enum enPlayerTurn { Player1,Player2};

        stStatusGame GameStatus;

        enPlayerTurn PlayerTurn = enPlayerTurn.Player1;
        struct stStatusGame
        {
            public byte NumberOfRound;
            public enWinner Winner;
            public bool IsGameOver;
        }

        private void DrawTheFrams(object sender, PaintEventArgs e)
        {
            Pen MyPen = new Pen(Color.White, 6);

            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(MyPen, 410, 205, 850, 205);
            e.Graphics.DrawLine(MyPen, 410, 320, 850, 320);

            e.Graphics.DrawLine(MyPen, 550,80, 550, 450);
            e.Graphics.DrawLine(MyPen, 700,80, 700, 450);

        }
       public bool CheckValue(PictureBox pb1,PictureBox pb2,PictureBox pb3)
        {
            if(pb1.Tag.ToString()!="?"&&pb1.Tag.ToString()==pb2.Tag.ToString()&&pb1.Tag.ToString()==pb3.Tag.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;

                if(pb1.Tag.ToString()=="X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.IsGameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.IsGameOver = true;
                    GameStatus.Winner = enWinner.Player2;
                    EndGame();
                    return true;
                }
            }
            GameStatus.IsGameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValue(pb1, pb2, pb3))
                return;

            if (CheckValue(pb4, pb5, pb6))
                return;
            if (CheckValue(pb7, pb8, pb9))
                return;


            if (CheckValue(pb1, pb4, pb7))
                return;
            if (CheckValue(pb2, pb5, pb8))
                return;

            if (CheckValue(pb3, pb6, pb9))
                return;


            if (CheckValue(pb1, pb5, pb9))
                return;
            if (CheckValue(pb3, pb5, pb7))
                return;
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    {
                        lblWinner.Text = "Player 1 ";
                        break;
                    }
                case enWinner.Player2:
                    {
                        lblWinner.Text = "Player 2";
                        break;
                    }
                default:
                    {
                        lblWinner.Text = "Draw";
                        break;
                    }
            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImage(PictureBox pb)
        {
            if (pb.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayerTurn.Player1:
                        pb.Image = Resources.X;
                        pb.Tag = "X";
                        PlayerTurn = enPlayerTurn.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.NumberOfRound++;
                        CheckWinner();
                        break;

                    case enPlayerTurn.Player2:
                        pb.Image = Resources.O;
                        pb.Tag = "O";
                        PlayerTurn = enPlayerTurn.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.NumberOfRound++;
                        CheckWinner();
                        break;
                }    
            }
            else
            {
                MessageBox.Show("Worng", "Worng Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if (GameStatus.NumberOfRound==9)
            {
                GameStatus.IsGameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
          
        }

        private void ResetPictureBox(PictureBox pb)
        {
            pb.Image = Resources.question_mark1;
            pb.Tag = "?";
            pb.BackColor = Color.Black;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {

            ResetPictureBox(pb1);
            ResetPictureBox(pb2);
            ResetPictureBox(pb3);
            ResetPictureBox(pb4);
            ResetPictureBox(pb5);
            ResetPictureBox(pb6);
            ResetPictureBox(pb7);
            ResetPictureBox(pb8);
            ResetPictureBox(pb9);
           
            lblTurn.Text = "Player1";
            lblWinner.Text = "In Progress";

            GameStatus.NumberOfRound = 0;
            GameStatus.IsGameOver = false;
            GameStatus.Winner = enWinner.InProgress;

            PlayerTurn = enPlayerTurn.Player1;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }
    }
}
