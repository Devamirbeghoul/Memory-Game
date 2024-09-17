using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class fmMemoryGame : Form
    {
        List<int> Numbers = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string FirstChoice;
        string SecondChoice;
        int Tries;
        List<PictureBox> PictureBoxes = new List<PictureBox>();
        PictureBox PicA;
        PictureBox PicB;
        int TotalTime = 30;
        int CountDownTime;
        bool GameOver = false;
        public fmMemoryGame()
        {
            InitializeComponent();
            CustomWindow(Color.FromArgb(185, 52, 95), Color.FromArgb(51, 51, 51), Color.FromArgb(185, 52, 95), Handle);
            LoadPictures();
        }

        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        const int DWWMA_BORDER_COLOR = 34;
        const int DWMWA_TEXT_COLOR = 36;
        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);

        }
        

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            CountDownTime--;
            lbTime.Text = CountDownTime.ToString();
            if (CountDownTime < 1)
            {
                MakeGameOver("Times Up", "You Lose");
                foreach (PictureBox x in PictureBoxes)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".jpg");
                    }
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        void LoadPictures()
        {
            int LeftPos = 248;
            int TopPos = 203;
            int Rows = 0;
            for (int i = 0; i < 12; i++)
            {
                PictureBox NewPic = new PictureBox();
                NewPic.Height = 67;
                NewPic.Width = 87;
                NewPic.Cursor = Cursors.Hand;
                NewPic.BorderStyle = BorderStyle.FixedSingle;
                NewPic.BackColor = Color.Transparent;
                NewPic.SizeMode = PictureBoxSizeMode.StretchImage;
                NewPic.Click += NewPic_Click;
                NewPic.MouseLeave += NewPic_MouseLeave;
                PictureBoxes.Add(NewPic);
                if (Rows < 3)
                {
                    Rows++;
                    NewPic.Left = LeftPos;
                    NewPic.Top = TopPos;
                    this.Controls.Add(NewPic);
                    LeftPos = LeftPos + 143;
                }
                if (Rows == 3)
                {
                    LeftPos = 248;
                    TopPos += 110;
                    Rows = 0;
                }
            }
            RestartGame();
        }

        private void NewPic_MouseLeave(object sender, EventArgs e)
        {
            if (GameOver)
            {
                return;
            }

            if (FirstChoice != null && SecondChoice != null)
            {
                CheckPictures(PicA, PicB);
            }

            
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (GameOver)
            {
                return;
            }
            if (FirstChoice == null)
            {
                PicA = sender as PictureBox;
                if (PicA.Tag != null && PicA.Image == null)
                {
                    PicA.Image = Image.FromFile("pics/" + (string)PicA.Tag + ".jpg");
                    FirstChoice = (string)PicA.Tag;
                }

                return;
            }
            if (SecondChoice == null)
            {
                PicB = sender as PictureBox;
                if (PicB.Tag != null && PicB.Image == null)
                {
                    PicB.Image = Image.FromFile("pics/" + (string)PicB.Tag + ".jpg");
                    SecondChoice = (string)PicB.Tag;
                }

                return;
            }
            
        }

        void RestartGame()
        {
            
            var randomList = Numbers.OrderBy(x => Guid.NewGuid()).ToList();
            Numbers = randomList;
            for (int i = 0; i < PictureBoxes.Count; i++)
            {
                PictureBoxes[i].Enabled = false; 
                PictureBoxes[i].Image = null;
                PictureBoxes[i].Tag = Numbers[i].ToString();
            }
            GameTimer.Stop();
            Tries = 0;
            lbMoves.Text = Tries.ToString();
            lbTime.Text =  TotalTime.ToString();
            GameOver = false;
            CountDownTime = TotalTime;
            btnStart.Enabled = true;
        }

        void CheckPictures(PictureBox A , PictureBox B)
        {
            if (FirstChoice == SecondChoice)
            {
                A.Tag = null;
                B.Tag = null;
            }

            Tries++;
            lbMoves.Text = Tries.ToString();

            FirstChoice = null;
            SecondChoice = null;

            if (PictureBoxes.All(o => o.Tag == null))
            {
                MakeGameOver("Great Work", "You Win");
                return;
            }

            foreach (PictureBox pics in PictureBoxes.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }
            
            
        }

        void MakeGameOver(string Message , string Title)
        {
            GameTimer.Stop();
            GameOver = true;
            MessageBox.Show(Message, Title , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (PictureBox x in PictureBoxes)
            {
                x.Enabled = true;
            }

            GameTimer.Start();
            btnStart.Enabled = false;
        }
    }
}
