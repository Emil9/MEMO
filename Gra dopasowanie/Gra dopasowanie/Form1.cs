using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_dopasowanie
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "Y", "Y",
            "l", "l", "v", "v", "s", "s", "t", "t"
        };
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
            public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
        }
        private void ukryjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = tableLayoutPanel1.BackColor;
            label2.ForeColor = tableLayoutPanel1.BackColor;
            label3.ForeColor = tableLayoutPanel1.BackColor;
            label4.ForeColor = tableLayoutPanel1.BackColor;
            label5.ForeColor = tableLayoutPanel1.BackColor;
            label6.ForeColor = tableLayoutPanel1.BackColor;
            label7.ForeColor = tableLayoutPanel1.BackColor;
            label8.ForeColor = tableLayoutPanel1.BackColor;
            label9.ForeColor = tableLayoutPanel1.BackColor;
            label10.ForeColor = tableLayoutPanel1.BackColor;
            label11.ForeColor = tableLayoutPanel1.BackColor;
            label12.ForeColor = tableLayoutPanel1.BackColor;
            label13.ForeColor = tableLayoutPanel1.BackColor;
            label14.ForeColor = tableLayoutPanel1.BackColor;
            label15.ForeColor = tableLayoutPanel1.BackColor;
            label16.ForeColor = tableLayoutPanel1.BackColor;
        }
        private void pomarańczowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.DarkOrange;
            label1.ForeColor = Color.DarkOrange;
            label2.ForeColor = Color.DarkOrange;
            label3.ForeColor = Color.DarkOrange;
            label4.ForeColor = Color.DarkOrange;
            label5.ForeColor = Color.DarkOrange;
            label6.ForeColor = Color.DarkOrange;
            label7.ForeColor = Color.DarkOrange;
            label8.ForeColor = Color.DarkOrange;
            label9.ForeColor = Color.DarkOrange;
            label10.ForeColor = Color.DarkOrange;
            label11.ForeColor = Color.DarkOrange;
            label12.ForeColor = Color.DarkOrange;
            label13.ForeColor = Color.DarkOrange;
            label14.ForeColor = Color.DarkOrange;
            label15.ForeColor = Color.DarkOrange;
            label16.ForeColor = Color.DarkOrange;
        }
        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.Green;
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Green;
            label5.ForeColor = Color.Green;
            label6.ForeColor = Color.Green;
            label7.ForeColor = Color.Green;
            label8.ForeColor = Color.Green;
            label9.ForeColor = Color.Green;
            label10.ForeColor = Color.Green;
            label11.ForeColor = Color.Green;
            label12.ForeColor = Color.Green;
            label13.ForeColor = Color.Green;
            label14.ForeColor = Color.Green;
            label15.ForeColor = Color.Green;
            label16.ForeColor = Color.Green;
        }

        private void żółtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label3.ForeColor = Color.Yellow;
            label4.ForeColor = Color.Yellow;
            label5.ForeColor = Color.Yellow;
            label6.ForeColor = Color.Yellow;
            label7.ForeColor = Color.Yellow;
            label8.ForeColor = Color.Yellow;
            label9.ForeColor = Color.Yellow;
            label10.ForeColor = Color.Yellow;
            label11.ForeColor = Color.Yellow;
            label12.ForeColor = Color.Yellow;
            label13.ForeColor = Color.Yellow;
            label14.ForeColor = Color.Yellow;
            label15.ForeColor = Color.Yellow;
            label16.ForeColor = Color.Yellow;
        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.Blue;
            label1.ForeColor = Color.Blue;
            label2.ForeColor = Color.Blue;
            label3.ForeColor = Color.Blue;
            label4.ForeColor = Color.Blue;
            label5.ForeColor = Color.Blue;
            label6.ForeColor = Color.Blue;
            label7.ForeColor = Color.Blue;
            label8.ForeColor = Color.Blue;
            label9.ForeColor = Color.Blue;
            label10.ForeColor = Color.Blue;
            label11.ForeColor = Color.Blue;
            label12.ForeColor = Color.Blue;
            label13.ForeColor = Color.Blue;
            label14.ForeColor = Color.Blue;
            label15.ForeColor = Color.Blue;
            label16.ForeColor = Color.Blue;
        }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.Red;
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label8.ForeColor = Color.Red;
            label9.ForeColor = Color.Red;
            label10.ForeColor = Color.Red;
            label11.ForeColor = Color.Red;
            label12.ForeColor = Color.Red;
            label13.ForeColor = Color.Red;
            label14.ForeColor = Color.Red;
            label15.ForeColor = Color.Red;
            label16.ForeColor = Color.Red;
        }

        private void fioletowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.DarkViolet;
            label1.ForeColor = Color.DarkViolet;
            label2.ForeColor = Color.DarkViolet;
            label3.ForeColor = Color.DarkViolet;
            label4.ForeColor = Color.DarkViolet;
            label5.ForeColor = Color.DarkViolet;
            label6.ForeColor = Color.DarkViolet;
            label7.ForeColor = Color.DarkViolet;
            label8.ForeColor = Color.DarkViolet;
            label9.ForeColor = Color.DarkViolet;
            label10.ForeColor = Color.DarkViolet;
            label11.ForeColor = Color.DarkViolet;
            label12.ForeColor = Color.DarkViolet;
            label13.ForeColor = Color.DarkViolet;
            label14.ForeColor = Color.DarkViolet;
            label15.ForeColor = Color.DarkViolet;
            label16.ForeColor = Color.DarkViolet;
        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        Label firstClicked = null;
        Label secondClicked = null;
        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    if (clickedLabel == firstClicked)
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                CheckForWinner();
                if (firstClicked.Text == secondClicked.Text)
            {
                    firstClicked.ForeColor = Color.DimGray;
                    secondClicked.ForeColor = Color.DimGray;
                    firstClicked = null;
                    secondClicked = null;
                    return;
            }
                timer1.Start();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Gratulacje, przechodzisz na kolejny poziom! :D","Powodzenia!!!");
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
