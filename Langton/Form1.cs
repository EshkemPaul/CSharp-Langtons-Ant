using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;

namespace Langton
{
    public partial class Form1 : Form
    {
        int ant = 0, ants = 0, iterations = 0, threadNumber = 0, rule = 0;
        int winnerBlack = 0, winnerRed = 0, winnerDarkOrange = 0, winnerLawnGreen = 0, winnerDeepSkyBlue = 0;
        public static int xBlack = 0, yBlack = 0;
        public static int xRed = 0, yRed = 0;
        public static int xDarkOrange = 0, yDarkOrange = 0;
        public static int xLawnGreen = 0, yLawnGreen = 0;
        public static int xDeepSkyBlue = 0, yDeepSkyBlue = 0;
        public static int directionBlack = 0, directionRed = 0, directionDarkOrange = 0, directionLawnGreen = 0, directionDeepSkyBlue = 0;
        public static Bitmap bmp = new Bitmap(400, 400);
        Color color;
        bool clicked = false;
        ManualResetEvent pause = new ManualResetEvent(true);
        List<string> Ants = new List<string>();
        List<int> Ranking = new List<int>();
        List<Thread> Threads = new List<Thread>();
        SoundPlayer sound = new SoundPlayer(Properties.Resources.CompleteSound);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(400, 400);

            for (int y = 0; y < 400; y++)
            {
                for (int x = 0; x < 400; x++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }

            pictureBox1.Image = bmp;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        void Animation()
        {
            if (rule == 0)
            {
                for (int i = 0; i < iterations; i++)
                {
                    pause.WaitOne();

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            pictureBox1.Refresh();
                        }));
                    }
                    else
                    {
                        pictureBox1.Refresh();
                    }

                    switch (directionBlack)
                    {
                        case 1:
                            BlackDirections.MoveUp();
                            break;
                        case 2:
                            BlackDirections.MoveRight();
                            break;
                        case 3:
                            BlackDirections.MoveDown();
                            break;
                        case 4:
                            BlackDirections.MoveLeft();
                            break;
                    }

                    switch (directionRed)
                    {
                        case 1:
                            RedDirections.MoveUp();
                            break;
                        case 2:
                            RedDirections.MoveRight();
                            break;
                        case 3:
                            RedDirections.MoveDown();
                            break;
                        case 4:
                            RedDirections.MoveLeft();
                            break;
                    }

                    switch (directionDarkOrange)
                    {
                        case 1:
                            DarkOrangeDirections.MoveUp();
                            break;
                        case 2:
                            DarkOrangeDirections.MoveRight();
                            break;
                        case 3:
                            DarkOrangeDirections.MoveDown();
                            break;
                        case 4:
                            DarkOrangeDirections.MoveLeft();
                            break;
                    }

                    switch (directionLawnGreen)
                    {
                        case 1:
                            LawnGreenDirections.MoveUp();
                            break;
                        case 2:
                            LawnGreenDirections.MoveRight();
                            break;
                        case 3:
                            LawnGreenDirections.MoveDown();
                            break;
                        case 4:
                            LawnGreenDirections.MoveLeft();
                            break;
                    }

                    switch (directionDeepSkyBlue)
                    {
                        case 1:
                            DeepSkyBlueDirections.MoveUp();
                            break;
                        case 2:
                            DeepSkyBlueDirections.MoveRight();
                            break;
                        case 3:
                            DeepSkyBlueDirections.MoveDown();
                            break;
                        case 4:
                            DeepSkyBlueDirections.MoveLeft();
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < iterations; i++)
                {
                    pause.WaitOne();

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            pictureBox1.Refresh();
                        }));
                    }
                    else
                    {
                        pictureBox1.Refresh();
                    }

                    if(rule == 1)
                    {
                        switch (directionBlack)
                        {
                            case 1:
                                RuleRL.MoveUp();
                                break;
                            case 2:
                                RuleRL.MoveRight();
                                break;
                            case 3:
                                RuleRL.MoveDown();
                                break;
                            case 4:
                                RuleRL.MoveLeft();
                                break;
                        }

                    }
                    if(rule == 2)
                    {
                        switch (directionBlack)
                        {
                            case 1:
                                RuleRLR.MoveUp();
                                break;
                            case 2:
                                RuleRLR.MoveRight();
                                break;
                            case 3:
                                RuleRLR.MoveDown();
                                break;
                            case 4:
                                RuleRLR.MoveLeft();
                                break;
                        }
                    }
                    if (rule == 3)
                    {
                        switch (directionBlack)
                        {
                            case 1:
                                RuleLLRR.MoveUp();
                                break;
                            case 2:
                                RuleLLRR.MoveRight();
                                break;
                            case 3:
                                RuleLLRR.MoveDown();
                                break;
                            case 4:
                                RuleLLRR.MoveLeft();
                                break;
                        }
                    }
                    if (rule == 4)
                    {

                        switch (directionBlack)
                        {
                            case 1:
                                RuleLRRRRRLLR.MoveUp();
                                break;
                            case 2:
                                RuleLRRRRRLLR.MoveRight();
                                break;
                            case 3:
                                RuleLRRRRRLLR.MoveDown();
                                break;
                            case 4:
                                RuleLRRRRRLLR.MoveLeft();
                                break;
                        }
                    }
                    if (rule == 5)
                    {

                        switch (directionBlack)
                        {
                            case 1:
                                RuleLLRRRLRLRLLR.MoveUp();
                                break;
                            case 2:
                                RuleLLRRRLRLRLLR.MoveRight();
                                break;
                            case 3:
                                RuleLLRRRLRLRLLR.MoveDown();
                                break;
                            case 4:
                                RuleLLRRRLRLRLLR.MoveLeft();
                                break;
                        }
                    }
                    if (rule == 6)
                    {

                        switch (directionBlack)
                        {
                            case 1:
                                RuleRRLLLRLLLRRR.MoveUp();
                                break;
                            case 2:
                                RuleRRLLLRLLLRRR.MoveRight();
                                break;
                            case 3:
                                RuleRRLLLRLLLRRR.MoveDown();
                                break;
                            case 4:
                                RuleRRLLLRLLLRRR.MoveLeft();
                                break;
                        }
                    }
                }
            }
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    if(rule == 0)
                    {
                        buttonWinners.Enabled = true;
                    }
                    buttonStop.Enabled = false;
                    buttonClear.Enabled = true;
                    buttonSave.Enabled = true;
                    pictureBlack.Enabled = false;
                    pictureRed.Enabled = false;
                    pictureDarkOrange.Enabled = false;
                    pictureLawnGreen.Enabled = false;
                    pictureDeepSkyBlue.Enabled = false;
                }));
            }
            else
            {
                if (rule == 0)
                {
                    buttonWinners.Enabled = true;
                }
                buttonStop.Enabled = false;
                buttonClear.Enabled = true;
                buttonSave.Enabled = true;
                pictureBlack.Enabled = false;
                pictureRed.Enabled = false;
                pictureDarkOrange.Enabled = false;
                pictureLawnGreen.Enabled = false;
                pictureDeepSkyBlue.Enabled = false;
            }

            sound.Play();
            MessageBox.Show("Finished successfully.");
        }

        private void CloseThreads()
        {
            for (int i = 0; i < Threads.Count; i++)
            {
                Threads[i].Abort();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            pause.Set();
            pause.Close();
            CloseThreads();
            MessageBox.Show("Thank you for using my application :)");
            Application.ExitThread();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Input a number of iterations!");
                    return;
                }
                iterations = Convert.ToInt32(textBox1.Text);
                if (iterations <= 0)
                {
                    MessageBox.Show("Number of iterations should be higher than 0");
                    return;
                }

                SetColors();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if(!Char.IsDigit(character) && character != 8 && character != 46)
            {
                e.Handled = true;
            }
        }

        private void pictureBlack_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            color = Color.Black;
            ant = 0;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(rule == 0)
            {
                comboBox1.Enabled = true;
            }

            buttonRun.Enabled = true;
            buttonStop.Enabled = false;
            buttonSave.Enabled = false;
            buttonClear.Enabled = false;
            buttonWinners.Enabled = false;
            pictureBlack.Enabled = true;
            pictureRed.Enabled = true;
            pictureDarkOrange.Enabled = true;
            pictureLawnGreen.Enabled = true;
            pictureDeepSkyBlue.Enabled = true;
            textBox1.Enabled = true;
            comboBox2.Enabled = true;
            buttonStop.Text = "Stop";

            ClearBoard();

            xBlack = 0; yBlack = 0;
            xRed = 0; yRed = 0;
            xDarkOrange = 0; yDarkOrange = 0;
            xLawnGreen = 0; yLawnGreen = 0;
            xDeepSkyBlue = 0; yDeepSkyBlue = 0;
            directionBlack = 0; directionRed = 0; directionDarkOrange = 0; directionLawnGreen = 0; directionDeepSkyBlue = 0;
            winnerBlack = 0; winnerRed = 0; winnerDarkOrange = 0; winnerLawnGreen = 0; winnerDeepSkyBlue = 0;
            clicked = false;

            Ants.Clear();
            Ranking.Clear();
            CloseThreads();
            threadNumber++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pause.Set();
            ClearBoard();
            CloseThreads();
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            pause.Set();
            pause.Close();
            CloseThreads();
            MessageBox.Show("Thank you for using my application :)");
            Application.ExitThread();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Enabled = true;
                rule = 0;
                label5.Text = "Standard rule.";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = 0;
                rule = 1;
                label5.Text = "RL: Standard Langton's ant behaviour with\n       addition color rule.";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = 0;
                rule = 2;
                label5.Text = "RLR: Grows chaotically. It is not known whether\n          this ant ever produces a highway.";
            }
            if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = 0;
                rule = 3;
                label5.Text = "LLRR: Grows symmetrically.";
            }
            if (comboBox2.SelectedIndex == 4)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = 0;
                rule = 4;
                label5.Text = "LRRRRRLLR: Fills space in a square around itself.";
            }
            if (comboBox2.SelectedIndex == 5)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = 0;
                rule = 5;
                label5.Text = "LLRRRLRLRLLR: Creates a convoluted highway.";
            }
            if (comboBox2.SelectedIndex == 6)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = 0;
                rule = 6;
                label5.Text = "RRLLLRLLLRRR: Creates a filled triangle shape\n                               that grows and moves.";
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Input a number of iterations!");
                return;
            }
            iterations = Convert.ToInt32(textBox1.Text);
            if (iterations <= 0)
            {
                MessageBox.Show("Number of iterations should be higher than 0");
                return;
            }

            SetColors();
        }

        private void SetColors()
        {
            ants = Convert.ToInt32(comboBox1.Text);
            if (ants == 1)
            {
                Ants.Remove("BLUE");
                Ants.Remove("RED");
                Ants.Remove("ORANGE");
                Ants.Remove("GREEN");
            }
            if (ants == 2)
            {
                Ants.Remove("RED");
                Ants.Remove("ORANGE");
                Ants.Remove("GREEN");
            }
            if (ants == 3)
            {
                Ants.Remove("ORANGE");
                Ants.Remove("GREEN");
            }
            if (ants == 4)
            {
                Ants.Remove("GREEN");
            }

            if (ants != Ants.Count)
            {
                MessageBox.Show("You forgot to put all ants on the board!");
                return;
            }

            textBox1.Enabled = false;
            buttonRun.Enabled = false;
            buttonStop.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            switch (ants)
            {
                case 1:
                    if (rule != 3 && rule != 4 && rule != 5)
                    {
                        bmp.SetPixel(xBlack + 1, yBlack, Color.FromArgb(0, 0, 0));
                        xBlack += 1;
                        yBlack += 1;
                        directionBlack = 3;
                        break;
                    }
                    else
                    {
                        bmp.SetPixel(xBlack - 1, yBlack, Color.FromArgb(0, 0, 0));
                        xBlack -= 1;
                        yBlack += 1;
                        directionBlack = 3;
                        break;
                    }


                case 3:
                    if (bmp.GetPixel(xRed, yRed - 1) == Color.FromArgb(255, 255, 255))
                    {
                        bmp.SetPixel(xRed, yRed - 1, Color.FromArgb(255, 0, 0));
                        xRed -= 1;
                        yRed -= 1;
                        directionRed = 4;
                    }
                    else
                    {
                        bmp.SetPixel(xRed, yRed - 1, Color.FromArgb(255, 255, 255));
                        xRed += 1;
                        yRed -= 1;
                        directionRed = 2;
                    }
                    goto case 2;

                case 4:
                    if (bmp.GetPixel(xDarkOrange, yDarkOrange - 1) == Color.FromArgb(255, 255, 255))
                    {
                        bmp.SetPixel(xDarkOrange, yDarkOrange - 1, Color.FromArgb(255, 140, 0));
                        xDarkOrange -= 1;
                        yDarkOrange -= 1;
                        directionDarkOrange = 4;
                    }
                    else
                    {
                        bmp.SetPixel(xDarkOrange, yDarkOrange - 1, Color.FromArgb(255, 255, 255));
                        xDarkOrange += 1;
                        yDarkOrange -= 1;
                        directionDarkOrange = 2;
                    }
                    goto case 3;

                case 5:
                    if (bmp.GetPixel(xLawnGreen, yLawnGreen - 1) == Color.FromArgb(255, 255, 255))
                    {
                        bmp.SetPixel(xLawnGreen, yLawnGreen - 1, Color.FromArgb(124, 252, 0));
                        xLawnGreen -= 1;
                        yLawnGreen -= 1;
                        directionLawnGreen = 4;
                    }
                    else
                    {
                        bmp.SetPixel(xLawnGreen, yLawnGreen - 1, Color.FromArgb(255, 255, 255));
                        xLawnGreen += 1;
                        yLawnGreen -= 1;
                        directionLawnGreen = 2;
                    }
                    goto case 4;

                case 2:
                    if (bmp.GetPixel(xDeepSkyBlue, yDeepSkyBlue - 1) == Color.FromArgb(255, 255, 255))
                    {
                        bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue - 1, Color.FromArgb(0, 191, 255));
                        xDeepSkyBlue -= 1;
                        yDeepSkyBlue -= 1;
                        directionDeepSkyBlue = 4;
                    }
                    else
                    {
                        bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue - 1, Color.FromArgb(255, 255, 255));
                        xDeepSkyBlue += 1;
                        yDeepSkyBlue -= 1;
                        directionDeepSkyBlue = 2;
                    }
                    goto case 1;
            }

            pictureBox1.Enabled = false;
            Threads.Add(new Thread(new ThreadStart(Animation)));
            Threads[threadNumber].Start();
            pause.Set();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG(*.PNG)|*.png";

            if(save.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(save.FileName);
            }
        }

        private void buttonWinners_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                if (ants == 1)
                {
                    Ranking.Add(0);
                }
                if (ants == 2)
                {
                    Ranking.Add(0);
                    Ranking.Add(0);
                }
                if (ants == 3)
                {
                    Ranking.Add(0);
                    Ranking.Add(0);
                    Ranking.Add(0);
                }
                if (ants == 4)
                {
                    Ranking.Add(0);
                    Ranking.Add(0);
                    Ranking.Add(0);
                    Ranking.Add(0);
                }
                if (ants == 5)
                {
                    Ranking.Add(0);
                    Ranking.Add(0);
                    Ranking.Add(0);
                    Ranking.Add(0);
                    Ranking.Add(0);
                }

                for (int y = 0; y < 400; y++)
                {
                    for (int x = 0; x < 400; x++)
                    {
                        if (bmp.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                        {
                            winnerBlack++;
                            Ranking[0] = winnerBlack;
                        }
                        if (bmp.GetPixel(x, y) == Color.FromArgb(255, 0, 0))
                        {
                            winnerRed++;
                            Ranking[2] = winnerRed;
                        }
                        if (bmp.GetPixel(x, y) == Color.FromArgb(255, 140, 0))
                        {
                            winnerDarkOrange++;
                            Ranking[3] = winnerDarkOrange;
                        }
                        if (bmp.GetPixel(x, y) == Color.FromArgb(124, 252, 0))
                        {
                            winnerLawnGreen++;
                            Ranking[4] = winnerLawnGreen;
                        }
                        if (bmp.GetPixel(x, y) == Color.FromArgb(0, 191, 255))
                        {
                            winnerDeepSkyBlue++;
                            Ranking[1] = winnerDeepSkyBlue;
                        }
                    }
                }

                for (int i = 0; i < Ranking.Count; i++)
                {
                    for (int j = 0; j < Ranking.Count - 1; j++)
                    {
                        int tempRanking = 0;
                        string tempAnts = "";
                        if (Ranking[j] < Ranking[j + 1])
                        {
                            tempRanking = Ranking[j];
                            tempAnts = Ants[j];
                            Ranking[j] = Ranking[j + 1];
                            Ants[j] = Ants[j + 1];
                            Ranking[j + 1] = tempRanking;
                            Ants[j + 1] = tempAnts;
                        }
                    }
                }

                clicked = true;
            }

            switch(ants)
            {
                case 1:
                    MessageBox.Show("Scores:\n1. " + Ants[0] + " with a score " + Ranking[0] + ".");
                    break;
                case 2:
                    MessageBox.Show("Scores:\n1. " + Ants[0] + " with a score " + Ranking[0] + ".\n2. " + Ants[1] + " with a score " + Ranking[1] + ".");
                    break;
                case 3:
                    MessageBox.Show("Scores:\n1. " + Ants[0] + " with a score " + Ranking[0] + ".\n2. " + Ants[1] + " with a score " + Ranking[1] + ".\n3. " + Ants[2] + " with a score " + Ranking[2] + ".");
                    break;
                case 4:
                    MessageBox.Show("Scores:\n1. " + Ants[0] + " with a score " + Ranking[0] + ".\n2. " + Ants[1] + " with a score " + Ranking[1] + ".\n3. " + Ants[2] + " with a score " + Ranking[2] + ".\n4. " + Ants[3] + " with a score " + Ranking[3] + ".");
                    break;
                case 5:
                    MessageBox.Show("Scores:\n1. " + Ants[0] + " with a score " + Ranking[0] + ".\n2. " + Ants[1] + " with a score " + Ranking[1] + ".\n3. " + Ants[2] + " with a score " + Ranking[2] + ".\n4. " + Ants[3] + " with a score " + Ranking[3] + ".\n5. " + Ants[4] + " with a score " + Ranking[4] + ".");
                    break;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (buttonStop.Text == "Stop")
            {
                pause.Reset();
                buttonStop.Text = "Continue";
                buttonClear.Enabled = true;
                buttonSave.Enabled = true;
            }
            else
            {
                pause.Set();
                buttonStop.Text = "Stop";
                buttonClear.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Follow these steps please:\n1. Input number of iterations.\n2. Choose number of ants (1-5).\n3. Choose colors and click on board to place ants.\n4. Click 'Run' button to execute.\n5. Click 'Stop' button to stop executing.\n6. Click 'Continue' button to resume executing.\n7. Click 'Clear' button to clear everything and start over.\n8. Click 'Save image' button to save current state as PNG file.\n9. Click 'Winners' button to see which ant took more space (this feature is                    available only when execution is fully completed).");
        }

        private void pictureRed_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            color = Color.Red;
            ant = 1;
        }

        private void pictureDarkOrange_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            color = Color.DarkOrange;
            ant = 2;
        }

        private void pictureLawnGreen_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            color = Color.LawnGreen;
            ant = 3;
        }

        private void pictureDeepSkyBlue_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            color = Color.DeepSkyBlue;
            ant = 4;
        }

        private void ClearBoard()
        {
            for (int y = 0; y < 400; y++)
            {
                for (int x = 0; x < 400; x++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            pictureBox1.Image = bmp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ants = Convert.ToInt32(comboBox1.Text);

            switch (ants)
            {
                case 1:
                    pictureRed.Visible = false;
                    pictureDarkOrange.Visible = false;
                    pictureLawnGreen.Visible = false;
                    pictureDeepSkyBlue.Visible = false;
                    ClearBoard();
                    pictureBox1.Enabled = false;
                    break;
                case 2:
                    pictureRed.Visible = false;
                    pictureDarkOrange.Visible = false;
                    pictureLawnGreen.Visible = false;
                    pictureDeepSkyBlue.Visible = true;
                    ClearBoard();
                    pictureBox1.Enabled = false;
                    break;
                case 3:
                    pictureRed.Visible = true;
                    pictureDarkOrange.Visible = false;
                    pictureLawnGreen.Visible = false;
                    pictureDeepSkyBlue.Visible = true;
                    ClearBoard();
                    pictureBox1.Enabled = false;
                    break;
                case 4:
                    pictureRed.Visible = true;
                    pictureDarkOrange.Visible = true;
                    pictureLawnGreen.Visible = false;
                    pictureDeepSkyBlue.Visible = true;
                    ClearBoard();
                    pictureBox1.Enabled = false;
                    break;
                case 5:
                    pictureRed.Visible = true;
                    pictureDarkOrange.Visible = true;
                    pictureLawnGreen.Visible = true;
                    pictureDeepSkyBlue.Visible = true;
                    ClearBoard();
                    pictureBox1.Enabled = false;
                    break;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (ant)
            {
                case 0:
                    if (!Ants.Contains("BLACK"))
                    {
                        Ants.Add("BLACK");
                    }
                    Ants.Sort();
                    bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 255, 255));
                    xBlack = e.X;
                    yBlack = e.Y;
                    bmp.SetPixel(e.X, e.Y, color);
                    pictureBox1.Refresh();
                    break;
                case 1:
                    if (!Ants.Contains("RED"))
                    {
                        Ants.Add("RED");
                    }
                    Ants.Sort();
                    bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 255, 255));
                    xRed = e.X;
                    yRed = e.Y;
                    bmp.SetPixel(e.X, e.Y, color);
                    pictureBox1.Refresh();
                    pictureBox1.Refresh();
                    break;
                case 2:
                    if (!Ants.Contains("ORANGE"))
                    {
                        Ants.Add("ORANGE");
                    }
                    Ants.Sort();
                    bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 255, 255));
                    xDarkOrange = e.X;
                    yDarkOrange = e.Y;
                    bmp.SetPixel(e.X, e.Y, color);
                    pictureBox1.Refresh();
                    pictureBox1.Refresh();
                    break;
                case 3:
                    if (!Ants.Contains("GREEN"))
                    {
                        Ants.Add("GREEN");
                    }
                    Ants.Sort();
                    bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(255, 255, 255));
                    xLawnGreen = e.X;
                    yLawnGreen = e.Y;
                    bmp.SetPixel(e.X, e.Y, color);
                    pictureBox1.Refresh();
                    pictureBox1.Refresh();
                    break;
                case 4:
                    if (!Ants.Contains("BLUE"))
                    {
                        Ants.Add("BLUE");
                    }
                    Ants.Sort();
                    bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(255, 255, 255));
                    xDeepSkyBlue = e.X;
                    yDeepSkyBlue = e.Y;
                    bmp.SetPixel(e.X, e.Y, color);
                    pictureBox1.Refresh();
                    pictureBox1.Refresh();
                    break;
            }
        }
    }
}
