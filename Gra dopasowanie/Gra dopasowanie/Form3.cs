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
    public partial class Form3 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "23", "23", "41", "41", "5", "5", "14", "14",
            "9", "9", "39", "39", "57", "57", "85", "85" ,
            "1", "1", "62", "62", "76", "76","90","90",
        };
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel2.Controls)
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
        public Form3()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void instrukcjaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
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
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            label24.ForeColor = Color.Black;
            label25.ForeColor = Color.Black;
        }
        private void ukryjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = tableLayoutPanel2.BackColor;
            label2.ForeColor = tableLayoutPanel2.BackColor;
            label3.ForeColor = tableLayoutPanel2.BackColor;
            label4.ForeColor = tableLayoutPanel2.BackColor;
            label5.ForeColor = tableLayoutPanel2.BackColor;
            label6.ForeColor = tableLayoutPanel2.BackColor;
            label7.ForeColor = tableLayoutPanel2.BackColor;
            label8.ForeColor = tableLayoutPanel2.BackColor;
            label9.ForeColor = tableLayoutPanel2.BackColor;
            label10.ForeColor = tableLayoutPanel2.BackColor;
            label11.ForeColor = tableLayoutPanel2.BackColor;
            label12.ForeColor = tableLayoutPanel2.BackColor;
            label14.ForeColor = tableLayoutPanel2.BackColor;
            label15.ForeColor = tableLayoutPanel2.BackColor;
            label16.ForeColor = tableLayoutPanel2.BackColor;
            label17.ForeColor = tableLayoutPanel2.BackColor;
            label18.ForeColor = tableLayoutPanel2.BackColor;
            label19.ForeColor = tableLayoutPanel2.BackColor;
            label20.ForeColor = tableLayoutPanel2.BackColor;
            label21.ForeColor = tableLayoutPanel2.BackColor;
            label22.ForeColor = tableLayoutPanel2.BackColor;
            label23.ForeColor = tableLayoutPanel2.BackColor;
            label24.ForeColor = tableLayoutPanel2.BackColor;
            label25.ForeColor = tableLayoutPanel2.BackColor;
        }
        private void pomarańczowyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.DarkOrange;
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
            label14.ForeColor = Color.DarkOrange;
            label15.ForeColor = Color.DarkOrange;
            label16.ForeColor = Color.DarkOrange;
            label17.ForeColor = Color.DarkOrange;
            label18.ForeColor = Color.DarkOrange;
            label19.ForeColor = Color.DarkOrange;
            label20.ForeColor = Color.DarkOrange;
            label21.ForeColor = Color.DarkOrange;
            label22.ForeColor = Color.DarkOrange;
            label23.ForeColor = Color.DarkOrange;
            label24.ForeColor = Color.DarkOrange;
            label25.ForeColor = Color.DarkOrange;
        }
        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.Green;
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
            label14.ForeColor = Color.Green;
            label15.ForeColor = Color.Green;
            label16.ForeColor = Color.Green;
            label17.ForeColor = Color.Green;
            label18.ForeColor = Color.Green;
            label19.ForeColor = Color.Green;
            label20.ForeColor = Color.Green;
            label21.ForeColor = Color.Green;
            label22.ForeColor = Color.Green;
            label23.ForeColor = Color.Green;
            label24.ForeColor = Color.Green;
            label25.ForeColor = Color.Green;
        }

        private void żółtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.Yellow;
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
            label14.ForeColor = Color.Yellow;
            label15.ForeColor = Color.Yellow;
            label16.ForeColor = Color.Yellow;
            label17.ForeColor = Color.Yellow;
            label18.ForeColor = Color.Yellow;
            label19.ForeColor = Color.Yellow;
            label20.ForeColor = Color.Yellow;
            label21.ForeColor = Color.Yellow;
            label22.ForeColor = Color.Yellow;
            label23.ForeColor = Color.Yellow;
            label24.ForeColor = Color.Yellow;
            label25.ForeColor = Color.Yellow;
        }

        private void niebieskiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.Blue;
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
            label14.ForeColor = Color.Blue;
            label15.ForeColor = Color.Blue;
            label16.ForeColor = Color.Blue;
            label17.ForeColor = Color.Blue;
            label18.ForeColor = Color.Blue;
            label19.ForeColor = Color.Blue;
            label20.ForeColor = Color.Blue;
            label21.ForeColor = Color.Blue;
            label22.ForeColor = Color.Blue;
            label23.ForeColor = Color.Blue;
            label24.ForeColor = Color.Blue;
            label25.ForeColor = Color.Blue;
        }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.Red;
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
            label14.ForeColor = Color.Red;
            label15.ForeColor = Color.Red;
            label16.ForeColor = Color.Red;
            label17.ForeColor = Color.Red;
            label18.ForeColor = Color.Red;
            label19.ForeColor = Color.Red;
            label20.ForeColor = Color.Red;
            label21.ForeColor = Color.Red;
            label22.ForeColor = Color.Red;
            label23.ForeColor = Color.Red;
            label24.ForeColor = Color.Red;
            label25.ForeColor = Color.Red;
        }

        private void fioletowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackColor = Color.DarkViolet;
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
            label14.ForeColor = Color.DarkViolet;
            label15.ForeColor = Color.DarkViolet;
            label16.ForeColor = Color.DarkViolet;
            label17.ForeColor = Color.DarkViolet;
            label18.ForeColor = Color.DarkViolet;
            label19.ForeColor = Color.DarkViolet;
            label20.ForeColor = Color.DarkViolet;
            label21.ForeColor = Color.DarkViolet;
            label22.ForeColor = Color.DarkViolet;
            label23.ForeColor = Color.DarkViolet;
            label24.ForeColor = Color.DarkViolet;
            label25.ForeColor = Color.DarkViolet;
        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }
        Label firstClicked = null;
        Label secondClicked = null;
        private void label_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == true)
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
                timer2.Start();
            }
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Gratulacje " + textBox1.Text + " znalazłeś wszystkie pary! :D", "Wygrałeś!!!");
            Close();
        }
    }
}
