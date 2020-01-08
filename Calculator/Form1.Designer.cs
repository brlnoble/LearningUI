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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userInputText = new System.Windows.Forms.TextBox();
            this.calculationResultText = new System.Windows.Forms.Label();
            this.buttonsPannel = new System.Windows.Forms.TableLayoutPanel();
            this.equalButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.buttonsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInputText
            // 
            this.userInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputText.Location = new System.Drawing.Point(41, 12);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(389, 22);
            this.userInputText.TabIndex = 0;
            // 
            // calculationResultText
            // 
            this.calculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationResultText.Location = new System.Drawing.Point(38, 48);
            this.calculationResultText.Name = "calculationResultText";
            this.calculationResultText.Size = new System.Drawing.Size(392, 80);
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
            this.buttonsPannel.Controls.Add(this.multiplyButton, 3, 1);
            this.buttonsPannel.Controls.Add(this.nineButton, 2, 1);
            this.buttonsPannel.Controls.Add(this.eightButton, 1, 1);
            this.buttonsPannel.Controls.Add(this.sevenButton, 0, 1);
            this.buttonsPannel.Controls.Add(this.divideButton, 3, 0);
            this.buttonsPannel.Controls.Add(this.delButton, 2, 0);
            this.buttonsPannel.Controls.Add(this.CEbutton, 0, 0);
            this.buttonsPannel.Location = new System.Drawing.Point(41, 131);
            this.buttonsPannel.Name = "buttonsPannel";
            this.buttonsPannel.RowCount = 5;
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPannel.Size = new System.Drawing.Size(389, 330);
            this.buttonsPannel.TabIndex = 2;
            // 
            // CEbutton
            // 
            this.CEbutton.BackColor = System.Drawing.Color.Transparent;
            this.CEbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CEbutton.BackgroundImage")));
            this.CEbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CEbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.FlatAppearance.BorderSize = 0;
            this.CEbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(91, 60);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = false;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Transparent;
            this.delButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delButton.BackgroundImage")));
            this.delButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.delButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delButton.FlatAppearance.BorderSize = 0;
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delButton.Location = new System.Drawing.Point(197, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(91, 60);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Del";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.Transparent;
            this.equalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("equalButton.BackgroundImage")));
            this.equalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equalButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equalButton.Location = new System.Drawing.Point(294, 267);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(92, 60);
            this.equalButton.TabIndex = 19;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.Transparent;
            this.decimalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("decimalButton.BackgroundImage")));
            this.decimalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decimalButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimalButton.Location = new System.Drawing.Point(197, 267);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(91, 60);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(294, 201);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 60);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Transparent;
            this.minusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusButton.BackgroundImage")));
            this.minusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusButton.Location = new System.Drawing.Point(294, 135);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(92, 60);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Transparent;
            this.multiplyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiplyButton.BackgroundImage")));
            this.multiplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiplyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.FlatAppearance.BorderSize = 0;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplyButton.Location = new System.Drawing.Point(294, 69);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(92, 60);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "X";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multipyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.Transparent;
            this.divideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divideButton.BackgroundImage")));
            this.divideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.divideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.FlatAppearance.BorderSize = 0;
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divideButton.Location = new System.Drawing.Point(294, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(92, 60);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "%";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Transparent;
            this.zeroButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zeroButton.BackgroundImage")));
            this.zeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zeroButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.FlatAppearance.BorderSize = 0;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroButton.Location = new System.Drawing.Point(100, 267);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(91, 60);
            this.zeroButton.TabIndex = 17;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Transparent;
            this.oneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oneButton.BackgroundImage")));
            this.oneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.FlatAppearance.BorderSize = 0;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneButton.Location = new System.Drawing.Point(3, 201);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(91, 60);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.Transparent;
            this.twoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twoButton.BackgroundImage")));
            this.twoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.FlatAppearance.BorderSize = 0;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoButton.Location = new System.Drawing.Point(100, 201);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(91, 60);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.Transparent;
            this.threeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("threeButton.BackgroundImage")));
            this.threeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.threeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.FlatAppearance.BorderSize = 0;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeButton.Location = new System.Drawing.Point(197, 201);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(91, 60);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.Transparent;
            this.fourButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fourButton.BackgroundImage")));
            this.fourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fourButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.FlatAppearance.BorderSize = 0;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourButton.Location = new System.Drawing.Point(3, 135);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(91, 60);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.Transparent;
            this.fiveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fiveButton.BackgroundImage")));
            this.fiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fiveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.FlatAppearance.BorderSize = 0;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveButton.Location = new System.Drawing.Point(100, 135);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(91, 60);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.Transparent;
            this.sixButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sixButton.BackgroundImage")));
            this.sixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sixButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.FlatAppearance.BorderSize = 0;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixButton.Location = new System.Drawing.Point(197, 135);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(91, 60);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.Transparent;
            this.sevenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sevenButton.BackgroundImage")));
            this.sevenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sevenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.FlatAppearance.BorderSize = 0;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sevenButton.Location = new System.Drawing.Point(3, 69);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(91, 60);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eightButton.BackgroundImage")));
            this.eightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eightButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.FlatAppearance.BorderSize = 0;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightButton.Location = new System.Drawing.Point(100, 69);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(91, 60);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.Transparent;
            this.nineButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nineButton.BackgroundImage")));
            this.nineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nineButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.FlatAppearance.BorderSize = 0;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineButton.Location = new System.Drawing.Point(197, 69);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(91, 60);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.equalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(462, 473);
            this.Controls.Add(this.buttonsPannel);
            this.Controls.Add(this.calculationResultText);
            this.Controls.Add(this.userInputText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 520);
            this.MinimumSize = new System.Drawing.Size(480, 520);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button delButton;
    }
}


