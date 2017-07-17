namespace Password_Generator
{
    partial class PaswordGenerator
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
            this.LblInstructions = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.ckbxCap = new System.Windows.Forms.CheckBox();
            this.ckbxSpecial = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblInstructions
            // 
            this.LblInstructions.AutoSize = true;
            this.LblInstructions.Location = new System.Drawing.Point(138, 58);
            this.LblInstructions.Name = "LblInstructions";
            this.LblInstructions.Size = new System.Drawing.Size(185, 13);
            this.LblInstructions.TabIndex = 0;
            this.LblInstructions.Text = "Enter number of Password Characters";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(179, 74);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(100, 20);
            this.TxtInput.TabIndex = 1;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(212, 317);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 13);
            this.LblResult.TabIndex = 2;
            this.LblResult.Visible = false;
            // 
            // ckbxCap
            // 
            this.ckbxCap.AutoSize = true;
            this.ckbxCap.Location = new System.Drawing.Point(186, 112);
            this.ckbxCap.Name = "ckbxCap";
            this.ckbxCap.Size = new System.Drawing.Size(93, 17);
            this.ckbxCap.TabIndex = 3;
            this.ckbxCap.Text = "Force Capitals";
            this.ckbxCap.UseVisualStyleBackColor = true;
            // 
            // ckbxSpecial
            // 
            this.ckbxSpecial.AutoSize = true;
            this.ckbxSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbxSpecial.Location = new System.Drawing.Point(186, 135);
            this.ckbxSpecial.Name = "ckbxSpecial";
            this.ckbxSpecial.Size = new System.Drawing.Size(140, 17);
            this.ckbxSpecial.TabIndex = 4;
            this.ckbxSpecial.Text = "Allow Special Characters";
            this.ckbxSpecial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ckbxSpecial.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbxOutput
            // 
            this.txtbxOutput.Location = new System.Drawing.Point(35, 285);
            this.txtbxOutput.Name = "txtbxOutput";
            this.txtbxOutput.Size = new System.Drawing.Size(405, 20);
            this.txtbxOutput.TabIndex = 7;
            this.txtbxOutput.Visible = false;
            // 
            // PaswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 581);
            this.Controls.Add(this.txtbxOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckbxSpecial);
            this.Controls.Add(this.ckbxCap);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblInstructions);
            this.Name = "PaswordGenerator";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInstructions;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.CheckBox ckbxCap;
        private System.Windows.Forms.CheckBox ckbxSpecial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbxOutput;
    }
}

