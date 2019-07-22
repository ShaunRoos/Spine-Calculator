namespace WindowsFormsApplication4
{
    partial class Spine_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spine_Calculator));
            this.paperComboBox = new System.Windows.Forms.ComboBox();
            this.coatingBox = new System.Windows.Forms.ComboBox();
            this.bindingComboBox = new System.Windows.Forms.ComboBox();
            this.glueTextBox = new System.Windows.Forms.TextBox();
            this.gsmBox = new System.Windows.Forms.ComboBox();
            this.calliperTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pageNumberTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paperComboBox
            // 
            this.paperComboBox.FormattingEnabled = true;
            this.paperComboBox.Items.AddRange(new object[] {
            "Bond White",
            "Coated Paper"});
            this.paperComboBox.Location = new System.Drawing.Point(168, 110);
            this.paperComboBox.Name = "paperComboBox";
            this.paperComboBox.Size = new System.Drawing.Size(121, 21);
            this.paperComboBox.TabIndex = 1;
            this.paperComboBox.Text = "Bond White";
            this.paperComboBox.SelectedIndexChanged += new System.EventHandler(this.paperComboBox_SelectedIndexChanged);
            // 
            // coatingBox
            // 
            this.coatingBox.FormattingEnabled = true;
            this.coatingBox.Items.AddRange(new object[] {
            "Uncoated",
            "Gloss",
            "Matt"});
            this.coatingBox.Location = new System.Drawing.Point(168, 154);
            this.coatingBox.Name = "coatingBox";
            this.coatingBox.Size = new System.Drawing.Size(121, 21);
            this.coatingBox.TabIndex = 2;
            this.coatingBox.Text = "Uncoated";
            this.coatingBox.SelectedIndexChanged += new System.EventHandler(this.coatingBox_SelectedIndexChanged);
            // 
            // bindingComboBox
            // 
            this.bindingComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.bindingComboBox.FormattingEnabled = true;
            this.bindingComboBox.Items.AddRange(new object[] {
            "Saddle Stich",
            "Perfect Bind",
            "Sew Soft Cover",
            "Sew Case Bound 1200",
            "Sew Case Bound 1800",
            "Sew Case Bound 2300"});
            this.bindingComboBox.Location = new System.Drawing.Point(168, 69);
            this.bindingComboBox.Name = "bindingComboBox";
            this.bindingComboBox.Size = new System.Drawing.Size(121, 21);
            this.bindingComboBox.TabIndex = 3;
            this.bindingComboBox.Text = "Perfect Bind";
            this.bindingComboBox.SelectedIndexChanged += new System.EventHandler(this.bindingComboBox_SelectedIndexChanged);
            this.bindingComboBox.TextChanged += new System.EventHandler(this.bindingComboBox_TextChanged);
            // 
            // glueTextBox
            // 
            this.glueTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.glueTextBox.Location = new System.Drawing.Point(315, 69);
            this.glueTextBox.Name = "glueTextBox";
            this.glueTextBox.Size = new System.Drawing.Size(45, 20);
            this.glueTextBox.TabIndex = 4;
            this.glueTextBox.Text = "1";
            this.glueTextBox.TextChanged += new System.EventHandler(this.glueTextBox_TextChanged);
            // 
            // gsmBox
            // 
            this.gsmBox.FormattingEnabled = true;
            this.gsmBox.Items.AddRange(new object[] {
            "060",
            "070",
            "080",
            "085",
            "090",
            "095",
            "100",
            "105",
            "113",
            "115",
            "120",
            "128",
            "135",
            "140",
            "148",
            "150",
            "157",
            "170",
            "180",
            "200",
            "210",
            "250",
            "300",
            "350"});
            this.gsmBox.Location = new System.Drawing.Point(168, 197);
            this.gsmBox.Name = "gsmBox";
            this.gsmBox.Size = new System.Drawing.Size(121, 21);
            this.gsmBox.TabIndex = 5;
            this.gsmBox.Text = "0";
            this.gsmBox.SelectedIndexChanged += new System.EventHandler(this.gsmComboBox_SelectedIndexChanged);
            this.gsmBox.TextChanged += new System.EventHandler(this.gsmComboBox_TextChanged);
            // 
            // calliperTextBox
            // 
            this.calliperTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.calliperTextBox.Location = new System.Drawing.Point(315, 197);
            this.calliperTextBox.Name = "calliperTextBox";
            this.calliperTextBox.Size = new System.Drawing.Size(45, 20);
            this.calliperTextBox.TabIndex = 6;
            this.calliperTextBox.TextChanged += new System.EventHandler(this.calliperTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(179, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate Shingling";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pageNumberTextBox
            // 
            this.pageNumberTextBox.Location = new System.Drawing.Point(168, 240);
            this.pageNumberTextBox.Name = "pageNumberTextBox";
            this.pageNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.pageNumberTextBox.TabIndex = 8;
            this.pageNumberTextBox.Text = "1";
            this.pageNumberTextBox.TextChanged += new System.EventHandler(this.pageNumberTextBox_TextChanged);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(445, 465);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(111, 31);
            this.answerLabel.TabIndex = 9;
            this.answerLabel.Text = "Answer";
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(179, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Calculate Spine";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(57, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 125);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Spine_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(857, 577);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.pageNumberTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calliperTextBox);
            this.Controls.Add(this.gsmBox);
            this.Controls.Add(this.glueTextBox);
            this.Controls.Add(this.bindingComboBox);
            this.Controls.Add(this.coatingBox);
            this.Controls.Add(this.paperComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spine_Calculator";
            this.Text = "Shingelator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paperComboBox;
        private System.Windows.Forms.ComboBox coatingBox;
        private System.Windows.Forms.ComboBox bindingComboBox;
        private System.Windows.Forms.TextBox glueTextBox;
        private System.Windows.Forms.ComboBox gsmBox;
        private System.Windows.Forms.TextBox calliperTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pageNumberTextBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

