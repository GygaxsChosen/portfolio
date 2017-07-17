using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class PaswordGenerator : Form
    {
        char[] LowLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h','i' ,'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] CapLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        int[] Nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        char[] Specials = new char[] {'!','@','#','$','%','^','&','*','(',')','-', '+','_','=','~','<','>','?','.',',',';',':','[',']','{','}'};
        Random rnd = new Random();

        public PaswordGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            int selector;
            int val= 4;
            string temp ="";
            int userinput = int.Parse(TxtInput.Text);
            txtbxOutput.Visible = true;
            if (ckbxSpecial.Checked == true)
                
            {
                val++;
            }
            if (ckbxCap.Checked == true)
            {
                userinput--;
                selector=rnd.Next(0,(CapLetters.Length-1));
                temp = temp + CapLetters[selector];
            }
            for (; userinput >=1; userinput--)
            {
                selector=rnd.Next(1, val);
                if (selector == 1)
                {
                    selector = rnd.Next(0, (LowLetters.Length - 1));
                    temp = temp + LowLetters[selector];

                }
                else if (selector == 2)
                {
                    selector = rnd.Next(0, (CapLetters.Length - 1));
                    temp = temp + CapLetters[selector];
                }
                else if (selector == 3)
                {
                    selector = rnd.Next(0, (Nums.Length - 1));
                    temp = temp + Nums[selector];
                }
                else if (selector == 4)
                {
                    selector = rnd.Next(0, (Specials.Length - 1));
                    temp = temp + Specials[selector];
                }

            }
            txtbxOutput.Text = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            LblResult.Visible = false;
            TxtInput.Text = "";
            button1.Enabled = true;
            txtbxOutput.Visible = false;
        }
        
    }
}
