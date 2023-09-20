namespace WindowsFormsApp_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenLabel = new System.Windows.Forms.Label();
            this.number1Button = new System.Windows.Forms.Button();
            this.number2Button = new System.Windows.Forms.Button();
            this.number3Button = new System.Windows.Forms.Button();
            this.number6Button = new System.Windows.Forms.Button();
            this.number5Button = new System.Windows.Forms.Button();
            this.number4Button = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.number0Button = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.number9Button = new System.Windows.Forms.Button();
            this.number8Button = new System.Windows.Forms.Button();
            this.number7Button = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.Color.Honeydew;
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenLabel.Location = new System.Drawing.Point(12, 9);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(318, 77);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "0";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number1Button
            // 
            this.number1Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1Button.Location = new System.Drawing.Point(12, 107);
            this.number1Button.Name = "number1Button";
            this.number1Button.Size = new System.Drawing.Size(75, 75);
            this.number1Button.TabIndex = 1;
            this.number1Button.Text = "1";
            this.number1Button.UseVisualStyleBackColor = false;
            this.number1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // number2Button
            // 
            this.number2Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Button.Location = new System.Drawing.Point(93, 107);
            this.number2Button.Name = "number2Button";
            this.number2Button.Size = new System.Drawing.Size(75, 75);
            this.number2Button.TabIndex = 2;
            this.number2Button.Text = "2";
            this.number2Button.UseVisualStyleBackColor = false;
            this.number2Button.Click += new System.EventHandler(this.number2Button_Click);
            // 
            // number3Button
            // 
            this.number3Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3Button.Location = new System.Drawing.Point(174, 107);
            this.number3Button.Name = "number3Button";
            this.number3Button.Size = new System.Drawing.Size(75, 75);
            this.number3Button.TabIndex = 3;
            this.number3Button.Text = "3";
            this.number3Button.UseVisualStyleBackColor = false;
            this.number3Button.Click += new System.EventHandler(this.number3Button_Click);
            // 
            // number6Button
            // 
            this.number6Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6Button.Location = new System.Drawing.Point(174, 188);
            this.number6Button.Name = "number6Button";
            this.number6Button.Size = new System.Drawing.Size(75, 75);
            this.number6Button.TabIndex = 6;
            this.number6Button.Text = "6";
            this.number6Button.UseVisualStyleBackColor = false;
            this.number6Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // number5Button
            // 
            this.number5Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5Button.Location = new System.Drawing.Point(93, 188);
            this.number5Button.Name = "number5Button";
            this.number5Button.Size = new System.Drawing.Size(75, 75);
            this.number5Button.TabIndex = 5;
            this.number5Button.Text = "5";
            this.number5Button.UseVisualStyleBackColor = false;
            this.number5Button.Click += new System.EventHandler(this.button5_Click);
            // 
            // number4Button
            // 
            this.number4Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4Button.Location = new System.Drawing.Point(12, 188);
            this.number4Button.Name = "number4Button";
            this.number4Button.Size = new System.Drawing.Size(75, 75);
            this.number4Button.TabIndex = 4;
            this.number4Button.Text = "4";
            this.number4Button.UseVisualStyleBackColor = false;
            this.number4Button.Click += new System.EventHandler(this.button6_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(174, 350);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 75);
            this.equalsButton.TabIndex = 12;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // number0Button
            // 
            this.number0Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0Button.Location = new System.Drawing.Point(93, 350);
            this.number0Button.Name = "number0Button";
            this.number0Button.Size = new System.Drawing.Size(75, 75);
            this.number0Button.TabIndex = 11;
            this.number0Button.Text = "0";
            this.number0Button.UseVisualStyleBackColor = false;
            this.number0Button.Click += new System.EventHandler(this.number0Button_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.MistyRose;
            this.clearButton.Location = new System.Drawing.Point(12, 350);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 75);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // number9Button
            // 
            this.number9Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9Button.Location = new System.Drawing.Point(174, 269);
            this.number9Button.Name = "number9Button";
            this.number9Button.Size = new System.Drawing.Size(75, 75);
            this.number9Button.TabIndex = 9;
            this.number9Button.Text = "9";
            this.number9Button.UseVisualStyleBackColor = false;
            this.number9Button.Click += new System.EventHandler(this.number9Button_Click);
            // 
            // number8Button
            // 
            this.number8Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8Button.Location = new System.Drawing.Point(93, 269);
            this.number8Button.Name = "number8Button";
            this.number8Button.Size = new System.Drawing.Size(75, 75);
            this.number8Button.TabIndex = 8;
            this.number8Button.Text = "8";
            this.number8Button.UseVisualStyleBackColor = false;
            this.number8Button.Click += new System.EventHandler(this.number8Button_Click);
            // 
            // number7Button
            // 
            this.number7Button.BackColor = System.Drawing.Color.CadetBlue;
            this.number7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7Button.Location = new System.Drawing.Point(12, 269);
            this.number7Button.Name = "number7Button";
            this.number7Button.Size = new System.Drawing.Size(75, 75);
            this.number7Button.TabIndex = 7;
            this.number7Button.Text = "7";
            this.number7Button.UseVisualStyleBackColor = false;
            this.number7Button.Click += new System.EventHandler(this.number7Button_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(255, 350);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 75);
            this.divisionButton.TabIndex = 16;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(255, 269);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 75);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(255, 188);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 75);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(255, 107);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 75);
            this.plusButton.TabIndex = 13;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.number0Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.number9Button);
            this.Controls.Add(this.number8Button);
            this.Controls.Add(this.number7Button);
            this.Controls.Add(this.number6Button);
            this.Controls.Add(this.number5Button);
            this.Controls.Add(this.number4Button);
            this.Controls.Add(this.number3Button);
            this.Controls.Add(this.number2Button);
            this.Controls.Add(this.number1Button);
            this.Controls.Add(this.screenLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Button number1Button;
        private System.Windows.Forms.Button number2Button;
        private System.Windows.Forms.Button number3Button;
        private System.Windows.Forms.Button number6Button;
        private System.Windows.Forms.Button number5Button;
        private System.Windows.Forms.Button number4Button;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button number0Button;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button number9Button;
        private System.Windows.Forms.Button number8Button;
        private System.Windows.Forms.Button number7Button;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
    }
}

