using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CustomMessageBox;

namespace RPCs
{
    public partial class RPC : Form
    {
        private static int logoOffset = 64; 
        private static int buttonOffset = 50;
        private static int panelOffsetX = 0;
        private static int panelOffsetY = 0;
        private static int offset = 7;
        private Boolean isOnlyGrid = true;
        private Boolean dragEnabled = false;
        private Boolean isEnabled = false;
        private string filePath;
        private int length;
        private int cur;
        private int resolutionFactor;
        private int choice;
        private int canvasSize = 0;
        private SolidBrush cleanser = new SolidBrush(Color.FloralWhite);
        private SolidBrush cleanserG = new SolidBrush(Color.LightGray);
        private Color penColor;
        private Color[,] colors;
        private Color red = Color.Black;
        private Color blue = Color.Black;
        private Color green = Color.Black;
        private Color[] history = { Color.Empty, Color.Empty, Color.Empty, Color.Empty, Color.Empty, Color.Empty, Color.Empty, Color.Empty, Color.Empty };
        private int xPrev = -1;
        private int yPrev = -1;


        public RPC()
        {
            penColor = Color.Black;
            canvasSize = 512;
            panelOffsetX = canvasSize / 2 - 100;
            panelOffsetY = canvasSize / 2 - 100;
            InitializeComponent();
            draw.Size = new Size(canvasSize, canvasSize);
            draw.Hide();
            redTrack.Hide();
            greenTrack.Hide();
            blueTrack.Hide();
            alphaTrack.Hide();
            Red.Hide();
            Green.Hide();
            Blue.Hide();
            Alpha.Hide();
            redBox.Hide();
            greenBox.Hide();
            blueBox.Hide();
            alphaBox.Hide();
            curColor.Hide();
            history0.Hide();
            history1.Hide();
            history2.Hide();
            history3.Hide();
            history4.Hide();
            history5.Hide();
            history6.Hide();
            history7.Hide();
            history8.Hide();
            RPC_Resize(this, new EventArgs());
        }

        private void RPC_Resize(object sender, EventArgs e)
        {
            int widthLogo = (this.Width / 2) - logoOffset - offset;
            int widthButton = (this.Width / 2) - buttonOffset - offset;
            int widthDraw = (this.Width / 2) - panelOffsetX - offset;
            int heightDraw = (this.Height / 2) - panelOffsetY - offset;
            Point newLoc1 = new Point(widthLogo, 0);
            Point newLoc2 = new Point(widthButton, 201);
            Point newLoc3 = new Point(widthButton, 251);
            Point newLoc4 = new Point(widthDraw, heightDraw);
            logo.Location = newLoc1;
            newButton.Location = newLoc2;
            loadButton.Location = newLoc3;
            draw.Location = newLoc4;
            this.BackColor = Color.FloralWhite;
        }

        private void Logo_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://metakat.neocities.org");
        }

        private void NewButton_MouseClick(object sender, MouseEventArgs e)
        {
            CustomBox dialog = new CustomBox(this, "Choose the resolution of your texture pack.", "4x4", "8x8", "16x16", "32x32");
            dialog.ShowDialog();
            logo.Hide();
            newButton.Hide();
            loadButton.Hide();
            draw.BorderStyle = BorderStyle.FixedSingle;
            draw.Show();
            redTrack.Show();
            blueTrack.Show();
            greenTrack.Show();
            alphaTrack.Show();
            Red.Show();
            Green.Show();
            Blue.Show();
            Alpha.Show();
            redBox.Show();
            greenBox.Show();
            blueBox.Show();
            alphaBox.Show();
            curColor.Show();
            history0.Show();
            history1.Show();
            history2.Show();
            history3.Show();
            history4.Show();
            history5.Show();
            history6.Show();
            history7.Show();
            history8.Show();
            if (choice == 1) { resolutionFactor = 4; }
            else if (choice == 2) { resolutionFactor = 8; }
            else if (choice == 3) { resolutionFactor = 16; }
            else if (choice == 4) { resolutionFactor = 32; }
            colors = new Color[resolutionFactor, resolutionFactor];
            for (int i = 0; i < resolutionFactor; i++)
            {
                for (int j = 0; j < resolutionFactor; j++)
                {
                    colors[i, j] = Color.Empty;
                }
            }
            isEnabled = true;
            gridUp(-1, -1);
            timer2.Enabled = true;
        }
        private void gridUp(int x, int y)
        {
            Pen pixelDrawer = new Pen(Color.Black);
            Graphics canvas = draw.CreateGraphics();
            int mult = (canvasSize / resolutionFactor);
            if (isOnlyGrid)
            {
                drawIt(canvas, pixelDrawer);
                int startCornerX;
                int startCornerY;
                int sizeX;
                int sizeY;
                for (int i = 0; i < resolutionFactor; i++)
                {
                    for (int j = 0; j < resolutionFactor; j++)
                    {
                        if (i == 0)
                        {
                            startCornerX = i * mult;
                            sizeY = canvasSize / resolutionFactor;
                        }
                        else
                        {
                            startCornerX = i * mult + 1;
                            sizeY = canvasSize / resolutionFactor - 1;
                        }
                        if (j == 0)
                        {
                            startCornerY = j * mult;
                            sizeX = canvasSize / resolutionFactor;
                        }
                        else
                        {
                            startCornerY = j * mult + 1;
                            sizeX = canvasSize / resolutionFactor - 1;
                        }
                        RectangleF r = new RectangleF(startCornerX, startCornerY, sizeY, sizeX);
                        SolidBrush squareDrawer = new SolidBrush(colors[i, j]);
                        if (colors[i, j] != Color.Empty)
                        {
                            if (colors[i, j].A != 255)
                            {
                                drawCheckers(canvas, startCornerX, startCornerY, sizeX, sizeY, r, i, j);
                                canvas.FillRectangle(squareDrawer, r);
                            }
                            else canvas.FillRectangle(squareDrawer, r);
                            squareDrawer.Dispose();
                        }
                        else
                        {
                            drawCheckers(canvas, startCornerX, startCornerY, sizeX, sizeY, r, i, j);
                        }
                    }
                }
                isOnlyGrid = false;
            }
            else
            {
                int startCornerX;
                int startCornerY;
                int sizeX;
                int sizeY;
                if (x == 0)
                {
                    startCornerX = x * mult;
                    sizeY = canvasSize / resolutionFactor;
                }
                else
                {
                    startCornerX = x * mult + 1;
                    sizeY = canvasSize / resolutionFactor - 1;
                }
                if (y == 0)
                {
                    startCornerY = y * mult;
                    sizeX = canvasSize / resolutionFactor;
                }
                else
                {
                    startCornerY = y * mult + 1;
                    sizeX = canvasSize / resolutionFactor - 1;
                }
                RectangleF r = new RectangleF(startCornerX, startCornerY, sizeY, sizeX);
                SolidBrush squareDrawer = new SolidBrush(colors[x, y]);
                if (colors[x, y] != Color.Empty)
                {
                    if ((colors[x, y].A != 255))
                    {
                        drawCheckers(canvas, startCornerX, startCornerY, sizeX, sizeY, r, x, y);
                        canvas.FillRectangle(squareDrawer, r);
                    }
                    else canvas.FillRectangle(squareDrawer, r);
                    squareDrawer.Dispose();
                }
                else
                {
                    drawCheckers(canvas, startCornerX, startCornerY, sizeX, sizeY, r, x, y);
                }
            }
            pixelDrawer.Dispose();
            canvas.Dispose();
        }
        private void drawCheckers(Graphics drawArea, int startCornerX, int startCornerY, int sizeX, int sizeY, RectangleF whole, int indexX, int indexY)
        {
            RectangleF checker;
            RectangleF checker2;
            if (indexX > 0 & indexY == 0)
            {
                checker = new RectangleF(startCornerX, startCornerY, sizeY / 2, sizeX / 2);
                checker2 = new RectangleF(startCornerX + sizeX / 2, startCornerY + sizeY / 2 + 1, sizeY - sizeY / 2 - 1, sizeX - sizeX / 2);
            }
            else if (indexY > 0 & indexX == 0)
            {
                checker = new RectangleF(startCornerX, startCornerY, sizeY / 2, sizeX / 2);
                checker2 = new RectangleF(startCornerX + sizeX / 2 + 1, startCornerY + sizeY / 2, sizeY - sizeY / 2, sizeX - sizeX / 2 - 1);
            }
            else
            {
                checker = new RectangleF(startCornerX, startCornerY, sizeY / 2, sizeX / 2);
                checker2 = new RectangleF(startCornerX + sizeX / 2, startCornerY + sizeY / 2, sizeY - sizeY / 2, sizeX - sizeX / 2);
            }
            drawArea.FillRectangle(cleanser, whole);
            drawArea.FillRectangle(cleanserG, checker);
            drawArea.FillRectangle(cleanserG, checker2);
        }
        private void drawIt(Graphics drawArea, Pen pen)
        {
            int increments = canvasSize / resolutionFactor;
            for (int i = 1; i < resolutionFactor; i++)
            {
                drawArea.DrawLine(pen, new Point(i * increments, 0), new Point(i * increments, canvasSize));
            }
            for (int i = 1; i < resolutionFactor; i++)
            {
                drawArea.DrawLine(pen, new Point(0, i * increments), new Point(canvasSize, i * increments));
            }
        }

        public void setChoice(int choice)
        {
            this.choice = choice;
        }

        private void LoadButton_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                filePath = f.FileName;
                length = filePath.Length;
                cur = 0;
                loadButton.Text = filePath;
                timer1.Enabled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loadButton.Text = filePath.Substring(cur, length - cur);
            if (cur == length) { cur = 0; }
            else cur++;
        }

        private void Draw_MouseDown(object sender, MouseEventArgs e)
        {
            dragEnabled = true;
            if (e.Button == MouseButtons.Left)
            {
                fixHistory();
                determineGrid(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Color preserve = penColor;
                penColor = Color.Empty;
                determineGrid(e.X, e.Y);
                penColor = preserve;
            }
        }

        private void fixHistory()
        {
            bool repeat = false;
            for (int i = 0; i < 9; i++)
            {
                if (history[i].Equals(penColor)) repeat = true;
            }
            if (repeat == false)
            {
                for (int i = 8; i > 0; i--)
                {
                    history[i] = history[i - 1];
                }

                history[0] = penColor;
                history0.BackColor = history[0];
                history1.BackColor = history[1];
                history2.BackColor = history[2];
                history3.BackColor = history[3];
                history4.BackColor = history[4];
                history5.BackColor = history[5];
                history6.BackColor = history[6];
                history7.BackColor = history[7];
                history8.BackColor = history[8];
            }
        }
        private void determineGrid(int x, int y)
        {
            if (x < 512 & y < 512 & x >= 0 & y >= 0)
            {
                int resolvedIndexX = (x / (canvasSize / resolutionFactor));
                int resolvedIndexY = (y / (canvasSize / resolutionFactor));
                if (!(resolvedIndexX == xPrev && resolvedIndexY == yPrev))
                {
                    colors[resolvedIndexX, resolvedIndexY] = penColor;
                    xPrev = resolvedIndexX;
                    yPrev = resolvedIndexY;
                    gridUp(resolvedIndexX, resolvedIndexY);
                }
            }
        }

        private void RPC_Paint(object sender, PaintEventArgs e)
        {
            if ((choice != 0 & isEnabled == true) )
            {
                isOnlyGrid = true;
                //gridUp(0, 0);
            }
        }

        private void Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragEnabled == true)
            {
                Draw_MouseDown(sender, e);
            }            
        }

        private void Draw_MouseUp(object sender, MouseEventArgs e)
        {
            dragEnabled = false;
        }

        private void RedTrack_ValueChanged(object sender, EventArgs e)
        {
            Color oldColor = penColor;
            Color newColor = Color.FromArgb(oldColor.A, redTrack.Value, oldColor.G, oldColor.B);
            redBox.Text = redTrack.Value.ToString();
            penColor = newColor;
        }

        private void GreenTrack_ValueChanged(object sender, EventArgs e)
        {
            Color oldColor = penColor;
            Color newColor = Color.FromArgb(oldColor.A, oldColor.R, greenTrack.Value, oldColor.B);
            greenBox.Text = greenTrack.Value.ToString();
            penColor = newColor;
        }

        private void BlueTrack_ValueChanged(object sender, EventArgs e)
        {
            Color oldColor = penColor;
            Color newColor = Color.FromArgb(oldColor.A, oldColor.R, oldColor.G, blueTrack.Value);
            blueBox.Text = blueTrack.Value.ToString();
            penColor = newColor;
        }

        private void AlphaTrack_ValueChanged(object sender, EventArgs e)
        {
            Color oldColor = penColor;
            Color newColor = Color.FromArgb(alphaTrack.Value, oldColor.R, oldColor.G, oldColor.B);
            alphaBox.Text = alphaTrack.Value.ToString();
            penColor = newColor;
        }

        private void RedBox_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (Int32.TryParse(redBox.Text, out x))
            {
                if (x >= 0 & x <= 255)
                {
                    Color oldColor = penColor;
                    Color newColor = Color.FromArgb(oldColor.A, x, oldColor.G, oldColor.B);
                    penColor = newColor;
                    redTrack.Value = x;
                    red = Color.FromArgb(x, 0, 0);
                }
            }
        }

        private void GreenBox_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (Int32.TryParse(greenBox.Text, out x))
            {
                if (x >= 0 & x <= 255)
                {
                    Color oldColor = penColor;
                    Color newColor = Color.FromArgb(oldColor.A, oldColor.R, x, oldColor.B);
                    penColor = newColor;
                    greenTrack.Value = x;
                    green = Color.FromArgb(0, x, 0);
                }
            }
        }

        private void BlueBox_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (Int32.TryParse(blueBox.Text, out x))
            {
                if (x >= 0 & x <= 255)
                {
                    Color oldColor = penColor;
                    Color newColor = Color.FromArgb(oldColor.A, oldColor.R, oldColor.G, x);
                    penColor = newColor;
                    blueTrack.Value = x;
                    blue = Color.FromArgb(0, 0, x);
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            curColor.BackColor = penColor;
            Red.ForeColor = red;
            redBox.BackColor = red;
            Green.ForeColor = green;
            greenBox.BackColor = green;
            Blue.ForeColor = blue;
            blueBox.BackColor = blue;
        }

        private void History0_Click(object sender, EventArgs e)
        {
            penColor = history0.BackColor;
            redTrack.Value = (int) penColor.R;
            redBox.Text = Convert.ToString((int) penColor.R);
            greenTrack.Value = (int) penColor.G;
            greenBox.Text = Convert.ToString((int) penColor.G);
            blueTrack.Value = (int) penColor.B;
            blueBox.Text = Convert.ToString((int) penColor.B);
            alphaTrack.Value = (int) penColor.A;
            alphaBox.Text = Convert.ToString((int) penColor.A);
        }

        private void History1_Click(object sender, EventArgs e)
        {
            penColor = history1.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History2_Click(object sender, EventArgs e)
        {
            penColor = history2.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History3_Click(object sender, EventArgs e)
        {
            penColor = history3.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History4_Click(object sender, EventArgs e)
        {
            penColor = history4.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History5_Click(object sender, EventArgs e)
        {
            penColor = history5.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History6_Click(object sender, EventArgs e)
        {
            penColor = history6.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History7_Click(object sender, EventArgs e)
        {
            penColor = history7.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }

        private void History8_Click(object sender, EventArgs e)
        {
            penColor = history8.BackColor;
            redTrack.Value = (int)penColor.R;
            redBox.Text = Convert.ToString((int)penColor.R);
            greenTrack.Value = (int)penColor.G;
            greenBox.Text = Convert.ToString((int)penColor.G);
            blueTrack.Value = (int)penColor.B;
            blueBox.Text = Convert.ToString((int)penColor.B);
            alphaTrack.Value = (int)penColor.A;
            alphaBox.Text = Convert.ToString((int)penColor.A);
        }
    }
}
