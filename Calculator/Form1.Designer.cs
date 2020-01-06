// --------------------------------------------------------------
// Code generated from Windows Form Designer in Visual Studio
// --------------------------------------------------------------

namespace Calculator
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
            this.userInputText = new System.Windows.Forms.TextBox();
            this.calculationResultText = new System.Windows.Forms.Label();
            this.buttonsPannel = new System.Windows.Forms.TableLayoutPanel();
            this.CEbutton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multipyButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.buttonsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInputText
            // 
            this.userInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputText.Location = new System.Drawing.Point(41, 12);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(409, 22);
            this.userInputText.TabIndex = 0;
            // 
            // calculationResultText
            // 
            this.calculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationResultText.Location = new System.Drawing.Point(38, 48);
            this.calculationResultText.Name = "calculationResultText";
            this.calculationResultText.Size = new System.Drawing.Size(412, 23);
            this.calculationResultText.TabIndex = 1;
            this.calculationResultText.Text = "Please enter an equation and press enter or equals";
            // 
            // buttonsPannel
            // 
            this.buttonsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPannel.ColumnCount = 4;
            this.buttonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPannel.Controls.Add(this.equalButton, 3, 4);
            this.buttonsPannel.Controls.Add(this.decimalButton, 2, 4);
            this.buttonsPannel.Controls.Add(this.zeroButton, 1, 4);
            this.buttonsPannel.Controls.Add(this.addButton, 3, 3);
            this.buttonsPannel.Controls.Add(this.threeButton, 2, 3);
            this.buttonsPannel.Controls.Add(this.twoButton, 1, 3);
            this.buttonsPannel.Controls.Add(this.oneButton, 0, 3);
            this.buttonsPannel.Controls.Add(this.minusButton, 3, 2);
            this.buttonsPannel.Controls.Add(this.sixButton, 2, 2);
            this.buttonsPannel.Controls.Add(this.fiveButton, 1, 2);
            this.buttonsPannel.Controls.Add(this.fourButton, 0, 2);
            this.buttonsPannel.Controls.Add(this.multipyButton, 3, 1);
            this.buttonsPannel.Controls.Add(this.nineButton, 2, 1);
            this.buttonsPannel.Controls.Add(this.eightButton, 1, 1);
            this.buttonsPannel.Controls.Add(this.sevenButton, 0, 1);
            this.buttonsPannel.Controls.Add(this.divideButton, 3, 0);
            this.buttonsPannel.Controls.Add(this.delButton, 2, 0);
            this.buttonsPannel.Controls.Add(this.CEbutton, 0, 0);
            this.buttonsPannel.Location = new System.Drawing.Point(41, 88);
            this.buttonsPannel.Name = "buttonsPannel";
            this.buttonsPannel.RowCount = 5;
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.Size = new System.Drawing.Size(409, 432);
            this.buttonsPannel.TabIndex = 2;
            // 
            // CEbutton
            // 
            this.CEbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(96, 80);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // delButton
            // 
            this.delButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delButton.Location = new System.Drawing.Point(207, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(96, 80);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Del";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Location = new System.Drawing.Point(309, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(97, 80);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "%";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Location = new System.Drawing.Point(3, 89);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(96, 80);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Location = new System.Drawing.Point(105, 89);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(96, 80);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Location = new System.Drawing.Point(207, 89);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(96, 80);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // multipyButton
            // 
            this.multipyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipyButton.Location = new System.Drawing.Point(309, 89);
            this.multipyButton.Name = "multipyButton";
            this.multipyButton.Size = new System.Drawing.Size(97, 80);
            this.multipyButton.TabIndex = 7;
            this.multipyButton.Text = "X";
            this.multipyButton.UseVisualStyleBackColor = true;
            this.multipyButton.Click += new System.EventHandler(this.multipyButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Location = new System.Drawing.Point(3, 175);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(96, 80);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Location = new System.Drawing.Point(105, 175);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(96, 80);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Location = new System.Drawing.Point(207, 175);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(96, 80);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Location = new System.Drawing.Point(309, 175);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(97, 80);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Location = new System.Drawing.Point(3, 261);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(96, 80);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Location = new System.Drawing.Point(105, 261);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(96, 80);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Location = new System.Drawing.Point(207, 261);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(96, 80);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(309, 261);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 80);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Location = new System.Drawing.Point(105, 347);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(96, 82);
            this.zeroButton.TabIndex = 17;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Location = new System.Drawing.Point(207, 347);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(96, 82);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.Location = new System.Drawing.Point(309, 347);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(97, 82);
            this.equalButton.TabIndex = 19;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.equalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(482, 532);
            this.Controls.Add(this.buttonsPannel);
            this.Controls.Add(this.calculationResultText);
            this.Controls.Add(this.userInputText);
            this.MinimumSize = new System.Drawing.Size(480, 520);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.buttonsPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.Label calculationResultText;
        private System.Windows.Forms.TableLayoutPanel buttonsPannel;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button multipyButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button delButton;
    }
}

