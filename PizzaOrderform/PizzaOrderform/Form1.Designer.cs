namespace PizzaOrderform
{
    partial class PizzaOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInstructions = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoLarge = new System.Windows.Forms.RadioButton();
            this.RdoMedium = new System.Windows.Forms.RadioButton();
            this.RdoSmall = new System.Windows.Forms.RadioButton();
            this.RchTxt1 = new System.Windows.Forms.RichTextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ChkBxCheese = new System.Windows.Forms.CheckBox();
            this.ChkbxPeperoni = new System.Windows.Forms.CheckBox();
            this.ChkBxBeef = new System.Windows.Forms.CheckBox();
            this.ChkBxGarlic = new System.Windows.Forms.CheckBox();
            this.ChckGreenPepper = new System.Windows.Forms.CheckBox();
            this.ChkBxPineApple = new System.Windows.Forms.CheckBox();
            this.ChkBxChicken = new System.Windows.Forms.CheckBox();
            this.ChkbxHam = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSuggestedTip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoCarryout = new System.Windows.Forms.RadioButton();
            this.RdoDelivery = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(36, 31);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(112, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select  a Size of Pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoLarge);
            this.groupBox1.Controls.Add(this.RdoMedium);
            this.groupBox1.Controls.Add(this.RdoSmall);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // RdoLarge
            // 
            this.RdoLarge.AutoSize = true;
            this.RdoLarge.Location = new System.Drawing.Point(18, 66);
            this.RdoLarge.Name = "RdoLarge";
            this.RdoLarge.Size = new System.Drawing.Size(52, 17);
            this.RdoLarge.TabIndex = 2;
            this.RdoLarge.TabStop = true;
            this.RdoLarge.Text = "Large";
            this.RdoLarge.UseVisualStyleBackColor = true;
            // 
            // RdoMedium
            // 
            this.RdoMedium.AutoSize = true;
            this.RdoMedium.Location = new System.Drawing.Point(18, 42);
            this.RdoMedium.Name = "RdoMedium";
            this.RdoMedium.Size = new System.Drawing.Size(62, 17);
            this.RdoMedium.TabIndex = 1;
            this.RdoMedium.TabStop = true;
            this.RdoMedium.Text = "Medium";
            this.RdoMedium.UseVisualStyleBackColor = true;
            // 
            // RdoSmall
            // 
            this.RdoSmall.AutoSize = true;
            this.RdoSmall.Location = new System.Drawing.Point(18, 19);
            this.RdoSmall.Name = "RdoSmall";
            this.RdoSmall.Size = new System.Drawing.Size(50, 17);
            this.RdoSmall.TabIndex = 0;
            this.RdoSmall.TabStop = true;
            this.RdoSmall.Text = "Small";
            this.RdoSmall.UseVisualStyleBackColor = true;
            // 
            // RchTxt1
            // 
            this.RchTxt1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RchTxt1.Location = new System.Drawing.Point(117, 308);
            this.RchTxt1.Name = "RchTxt1";
            this.RchTxt1.ReadOnly = true;
            this.RchTxt1.Size = new System.Drawing.Size(295, 96);
            this.RchTxt1.TabIndex = 3;
            this.RchTxt1.Text = "";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(400, 232);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(278, 232);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add to order";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ChkBxCheese
            // 
            this.ChkBxCheese.AutoSize = true;
            this.ChkBxCheese.Location = new System.Drawing.Point(288, 60);
            this.ChkBxCheese.Name = "ChkBxCheese";
            this.ChkBxCheese.Size = new System.Drawing.Size(89, 17);
            this.ChkBxCheese.TabIndex = 6;
            this.ChkBxCheese.Text = "Extra Cheese";
            this.ChkBxCheese.UseVisualStyleBackColor = true;
            // 
            // ChkbxPeperoni
            // 
            this.ChkbxPeperoni.AutoSize = true;
            this.ChkbxPeperoni.Location = new System.Drawing.Point(288, 84);
            this.ChkbxPeperoni.Name = "ChkbxPeperoni";
            this.ChkbxPeperoni.Size = new System.Drawing.Size(74, 17);
            this.ChkbxPeperoni.TabIndex = 7;
            this.ChkbxPeperoni.Text = "Pepperoni";
            this.ChkbxPeperoni.UseVisualStyleBackColor = true;
            // 
            // ChkBxBeef
            // 
            this.ChkBxBeef.AutoSize = true;
            this.ChkBxBeef.Location = new System.Drawing.Point(288, 109);
            this.ChkBxBeef.Name = "ChkBxBeef";
            this.ChkBxBeef.Size = new System.Drawing.Size(48, 17);
            this.ChkBxBeef.TabIndex = 8;
            this.ChkBxBeef.Text = "Beef";
            this.ChkBxBeef.UseVisualStyleBackColor = true;
            // 
            // ChkBxGarlic
            // 
            this.ChkBxGarlic.AutoSize = true;
            this.ChkBxGarlic.Location = new System.Drawing.Point(383, 60);
            this.ChkBxGarlic.Name = "ChkBxGarlic";
            this.ChkBxGarlic.Size = new System.Drawing.Size(53, 17);
            this.ChkBxGarlic.TabIndex = 9;
            this.ChkBxGarlic.Text = "Garlic";
            this.ChkBxGarlic.UseVisualStyleBackColor = true;
            // 
            // ChckGreenPepper
            // 
            this.ChckGreenPepper.AutoSize = true;
            this.ChckGreenPepper.Location = new System.Drawing.Point(383, 84);
            this.ChckGreenPepper.Name = "ChckGreenPepper";
            this.ChckGreenPepper.Size = new System.Drawing.Size(92, 17);
            this.ChckGreenPepper.TabIndex = 10;
            this.ChckGreenPepper.Text = "Green Pepper";
            this.ChckGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ChkBxPineApple
            // 
            this.ChkBxPineApple.AutoSize = true;
            this.ChkBxPineApple.Location = new System.Drawing.Point(383, 108);
            this.ChkBxPineApple.Name = "ChkBxPineApple";
            this.ChkBxPineApple.Size = new System.Drawing.Size(73, 17);
            this.ChkBxPineApple.TabIndex = 11;
            this.ChkBxPineApple.Text = "Pineapple";
            this.ChkBxPineApple.UseVisualStyleBackColor = true;
            // 
            // ChkBxChicken
            // 
            this.ChkBxChicken.AutoSize = true;
            this.ChkBxChicken.Location = new System.Drawing.Point(288, 132);
            this.ChkBxChicken.Name = "ChkBxChicken";
            this.ChkBxChicken.Size = new System.Drawing.Size(65, 17);
            this.ChkBxChicken.TabIndex = 12;
            this.ChkBxChicken.Text = "Chicken";
            this.ChkBxChicken.UseVisualStyleBackColor = true;
            // 
            // ChkbxHam
            // 
            this.ChkbxHam.AutoSize = true;
            this.ChkbxHam.Location = new System.Drawing.Point(383, 132);
            this.ChkbxHam.Name = "ChkbxHam";
            this.ChkbxHam.Size = new System.Drawing.Size(48, 17);
            this.ChkbxHam.TabIndex = 13;
            this.ChkbxHam.Text = "Ham";
            this.ChkbxHam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Topings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sub Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(285, 424);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Suggested Tip 15%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sales Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "5%";
            // 
            // lblSuggestedTip
            // 
            this.lblSuggestedTip.AutoSize = true;
            this.lblSuggestedTip.Location = new System.Drawing.Point(285, 499);
            this.lblSuggestedTip.Name = "lblSuggestedTip";
            this.lblSuggestedTip.Size = new System.Drawing.Size(13, 13);
            this.lblSuggestedTip.TabIndex = 20;
            this.lblSuggestedTip.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoCarryout);
            this.groupBox2.Controls.Add(this.RdoDelivery);
            this.groupBox2.Location = new System.Drawing.Point(13, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery or carryout?";
            // 
            // rdoCarryout
            // 
            this.rdoCarryout.AutoSize = true;
            this.rdoCarryout.Location = new System.Drawing.Point(7, 46);
            this.rdoCarryout.Name = "rdoCarryout";
            this.rdoCarryout.Size = new System.Drawing.Size(64, 17);
            this.rdoCarryout.TabIndex = 1;
            this.rdoCarryout.TabStop = true;
            this.rdoCarryout.Text = "Carryout";
            this.rdoCarryout.UseVisualStyleBackColor = true;
            // 
            // RdoDelivery
            // 
            this.RdoDelivery.AutoSize = true;
            this.RdoDelivery.Location = new System.Drawing.Point(7, 20);
            this.RdoDelivery.Name = "RdoDelivery";
            this.RdoDelivery.Size = new System.Drawing.Size(63, 17);
            this.RdoDelivery.TabIndex = 0;
            this.RdoDelivery.TabStop = true;
            this.RdoDelivery.Text = "Delivery";
            this.RdoDelivery.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(287, 472);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(13, 13);
            this.LblTotal.TabIndex = 23;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 602);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSuggestedTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkbxHam);
            this.Controls.Add(this.ChkBxChicken);
            this.Controls.Add(this.ChkBxPineApple);
            this.Controls.Add(this.ChckGreenPepper);
            this.Controls.Add(this.ChkBxGarlic);
            this.Controls.Add(this.ChkBxBeef);
            this.Controls.Add(this.ChkbxPeperoni);
            this.Controls.Add(this.ChkBxCheese);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.RchTxt1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInstructions);
            this.Name = "PizzaOrderForm";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoLarge;
        private System.Windows.Forms.RadioButton RdoMedium;
        private System.Windows.Forms.RadioButton RdoSmall;
        private System.Windows.Forms.RichTextBox RchTxt1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.CheckBox ChkBxCheese;
        private System.Windows.Forms.CheckBox ChkbxPeperoni;
        private System.Windows.Forms.CheckBox ChkBxBeef;
        private System.Windows.Forms.CheckBox ChkBxGarlic;
        private System.Windows.Forms.CheckBox ChckGreenPepper;
        private System.Windows.Forms.CheckBox ChkBxPineApple;
        private System.Windows.Forms.CheckBox ChkBxChicken;
        private System.Windows.Forms.CheckBox ChkbxHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSuggestedTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoCarryout;
        private System.Windows.Forms.RadioButton RdoDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTotal;
    }
}

