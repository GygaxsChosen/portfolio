using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderform
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
           
            
        }

        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {double total = double.Parse(lblSubTotal.Text);

           
            

            if (RdoSmall.Checked == true)             
            {
                total += 10.00;
                RchTxt1.Text = RchTxt1.Text+"\n 1x Small Pizza with";
            }

            else if (RdoMedium.Checked == true)
            {
                total += 15.00;
                RchTxt1.Text = RchTxt1.Text+"\n 1x Medium Pizza with";
            }
            else if (RdoLarge.Checked == true)
            {
                total += 20.00;
                RchTxt1.Text = RchTxt1.Text+ "\n 1x Large Pizza with";
            }

            if (ChkBxBeef.Checked == true)
            {
                total += 2.00;
                RchTxt1.Text = RchTxt1.Text + " Beef ";
            }
            if (ChkBxCheese.Checked == true)
            {
                total += .5;
                RchTxt1.Text = RchTxt1.Text + " X-tra Cheese ";
            }
            if (ChkBxChicken.Checked == true)
            {
                total += 1.00;
                RchTxt1.Text = RchTxt1.Text + " Chicken ";

            }
            if (ChkBxGarlic.Checked == true)
            {
                total += .30;
                RchTxt1.Text = RchTxt1.Text + " Garlic ";
            }
            if (ChkbxHam.Checked == true) 
            {
                total += 1.50;
                RchTxt1.Text = RchTxt1.Text + " Ham ";
            }
            if (ChkbxPeperoni.Checked == true)
            {
                total += .50;
                RchTxt1.Text = RchTxt1.Text + " Peperoni ";
            }
            if (ChckGreenPepper.Checked == true)
            {
                total += .30;
                RchTxt1.Text = RchTxt1.Text + " GreenPepper ";
            }
            if (ChkBxPineApple.Checked==true)
            {

                total += .25;
                RchTxt1.Text = RchTxt1.Text + " PineApple ";
            }
            if (RdoDelivery.Checked == true)
            {
                total = (total * 1.10);
            }
            lblSubTotal.Visible = true;

            lblSubTotal.Text =  total.ToString();
            LblTotal.Text = (total * 1.05).ToString();

            lblSuggestedTip.Text = (double.Parse(LblTotal.Text) * .15).ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RchTxt1.Text = "";
            ChkBxPineApple.Checked = false;
            ChkbxPeperoni.Checked = false;
            ChkbxHam.Checked = false;
            ChkBxGarlic.Checked = false;
            ChkBxChicken.Checked = false;
            ChkBxCheese.Checked = false;
            ChkBxBeef.Checked = false;
           
            lblSuggestedTip.Visible = false;
            lblSubTotal.Text = 0.ToString();
        }
    }
}
