using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mastermind
{
    public partial class Form1 : Form
    {
        Color[] key = new Color[] { Color.Red , Color.Blue , Color.Green, Color.Yellow};
        Random rndm = new Random();
         int Row = 1;
        Color square1,square2,square3,square4;
       
        
        public Form1()
        {
            InitializeComponent();

            square1 = key[(rndm.Next(0, 4))];
            square2 = key[rndm.Next(0, 4)];
            square3 = key[rndm.Next(0, 4)];
            square4 = key[rndm.Next(0, 4)];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorSet(button1);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = ColorSet(button2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = ColorSet(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor=ColorSet(button4);
            
           
        }
        public static Color ColorSet(Button a)
        {
            if (a.BackColor == System.Drawing.Color.Red)
            {
                return System.Drawing.Color.Blue;
            }

            else if (a.BackColor == System.Drawing.Color.Blue)
            {
                return System.Drawing.Color.Green;
            }
            else if (a.BackColor == System.Drawing.Color.Green)
            {
                return System.Drawing.Color.Yellow;
            }
            else
            {
                return System.Drawing.Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = ColorSet(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = ColorSet(button6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = ColorSet(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = ColorSet(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = ColorSet(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = ColorSet(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = ColorSet(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = ColorSet(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = ColorSet(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = ColorSet(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = ColorSet(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = ColorSet(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = ColorSet(button18);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = ColorSet(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = ColorSet(button20);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (Row==1)
            {
               

                ColorChecker(button1,button2,button3,button4,richTextBox1);
                
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                richTextBox2.Visible = true;

               
                
        
                
            }
            if(Row==2)
            {
                ColorChecker(button5, button6, button7, button8, richTextBox2);
                richTextBox3.Visible = true;
             

                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;

            }
            if (Row == 3)
            {
                ColorChecker(button9, button10, button11, button12, richTextBox3);
                richTextBox4.Visible = true;

                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
              
            }
            if (Row == 4)
            {
                ColorChecker(button13, button14, button15, button16, richTextBox4);
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                button20.Visible = true;
            }

            if (Row==5)
            {
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                FinalChecker(button17, button18, button19, button20);
                BtnCheck.Enabled = false;

                
            }

            Row++;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FinalChecker(Button a, Button b, Button c, Button d)
        {
            button21.BackColor = square1;
            button22.BackColor = square2;
            button23.BackColor = square3;
            button24.BackColor = square4;

            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            if (square1==a.BackColor && square2== b.BackColor && square3==c.BackColor&& square4==d.BackColor)
            {
                MessageBox.Show("CONGRATULATIONS YOU SOLVED THE PUZZLE!");

            }
            else
            {
                MessageBox.Show("GAME OVER, betterluck next time.");
            }
        }
        private void ColorChecker(Button a, Button b, Button c, Button d,RichTextBox e )
        {
            int colormatch = 0;
            int positionmatch = 0;

            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;



            Color[] solution = new Color[] { square1, square2, square3, square4 };

            if (solution.Contains(a.BackColor))
            {
                colormatch++;
            }
            if (solution.Contains(b.BackColor))
            {
                colormatch++;
            }
            if (solution.Contains(c.BackColor))
            {
                colormatch++;
            }
            if (solution.Contains(d.BackColor))
            {

                colormatch++;
            }
            if(square1==a.BackColor)
            {
                positionmatch++;

            }

            if (square2 == b.BackColor)
            {
                positionmatch++;
            }

            if (square3 == c.BackColor)
            {
                positionmatch++;
            }
            if (square4 ==d.BackColor)
            {
                positionmatch++;
            }
                e.Text = "Number of color matches=" + colormatch + "\n" + "Number of Positon matches" + positionmatch;
                
                
            

        }

        public static void VictorySong()
        {
            Console.Beep(130, 200);
            Console.Beep(138, 200);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = ColorSet(button7);
        }
    }
}
