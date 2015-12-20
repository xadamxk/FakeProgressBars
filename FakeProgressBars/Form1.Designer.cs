namespace FakeProgressBars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customCaptionCheckBox = new System.Windows.Forms.CheckBox();
            this.customCaptionTextBox = new System.Windows.Forms.TextBox();
            this.captionComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.percentSignLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.percentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.percentageRadioButton = new System.Windows.Forms.RadioButton();
            this.timerRadioButton = new System.Windows.Forms.RadioButton();
            this.timerTrackbar = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(12, 477);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(264, 35);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Progress Bar";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customCaptionCheckBox);
            this.groupBox1.Controls.Add(this.customCaptionTextBox);
            this.groupBox1.Controls.Add(this.captionComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caption";
            this.toolTip1.SetToolTip(this.groupBox1, "Caption: The title in the progress bar window.\r\n     Menu: Select common progress" +
        " bar titles.\r\n     Custom: Create own caption. \r\n          ex. (Excel - Loading " +
        ". . .)");
            // 
            // customCaptionCheckBox
            // 
            this.customCaptionCheckBox.AutoSize = true;
            this.customCaptionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCaptionCheckBox.Location = new System.Drawing.Point(10, 68);
            this.customCaptionCheckBox.Name = "customCaptionCheckBox";
            this.customCaptionCheckBox.Size = new System.Drawing.Size(89, 24);
            this.customCaptionCheckBox.TabIndex = 3;
            this.customCaptionCheckBox.Text = "Custom";
            this.customCaptionCheckBox.UseVisualStyleBackColor = true;
            this.customCaptionCheckBox.CheckedChanged += new System.EventHandler(this.customCaptionCheckBox_CheckedChanged);
            // 
            // customCaptionTextBox
            // 
            this.customCaptionTextBox.Location = new System.Drawing.Point(10, 98);
            this.customCaptionTextBox.Name = "customCaptionTextBox";
            this.customCaptionTextBox.Size = new System.Drawing.Size(248, 30);
            this.customCaptionTextBox.TabIndex = 2;
            // 
            // captionComboBox
            // 
            this.captionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.captionComboBox.FormattingEnabled = true;
            this.captionComboBox.Items.AddRange(new object[] {
            "Connecting . . .",
            "Extracting . . .",
            "Installing . . .",
            "Loading . . .",
            "Please Wait . . .",
            "Updating . . ."});
            this.captionComboBox.Location = new System.Drawing.Point(10, 29);
            this.captionComboBox.Name = "captionComboBox";
            this.captionComboBox.Size = new System.Drawing.Size(248, 33);
            this.captionComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.percentSignLabel);
            this.groupBox2.Controls.Add(this.percentageLabel);
            this.groupBox2.Controls.Add(this.percentNumericUpDown);
            this.groupBox2.Controls.Add(this.percentageRadioButton);
            this.groupBox2.Controls.Add(this.timerRadioButton);
            this.groupBox2.Controls.Add(this.timerTrackbar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress";
            this.toolTip1.SetToolTip(this.groupBox2, "Progress: Control the progress bar functions.\r\n     Timer: Starts halfway, then l" +
        "oads based on selected time.\r\n          \r\n     Percentage: Loads bar to selected" +
        " percent, then stops.");
            // 
            // percentSignLabel
            // 
            this.percentSignLabel.AutoSize = true;
            this.percentSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentSignLabel.Location = new System.Drawing.Point(221, 132);
            this.percentSignLabel.Name = "percentSignLabel";
            this.percentSignLabel.Size = new System.Drawing.Size(24, 20);
            this.percentSignLabel.TabIndex = 5;
            this.percentSignLabel.Text = "%";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.Location = new System.Drawing.Point(6, 132);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(77, 20);
            this.percentageLabel.TabIndex = 4;
            this.percentageLabel.Text = "Progress";
            // 
            // percentNumericUpDown
            // 
            this.percentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.percentNumericUpDown.Location = new System.Drawing.Point(101, 130);
            this.percentNumericUpDown.Name = "percentNumericUpDown";
            this.percentNumericUpDown.Size = new System.Drawing.Size(114, 26);
            this.percentNumericUpDown.TabIndex = 3;
            // 
            // percentageRadioButton
            // 
            this.percentageRadioButton.AutoSize = true;
            this.percentageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageRadioButton.Location = new System.Drawing.Point(10, 105);
            this.percentageRadioButton.Name = "percentageRadioButton";
            this.percentageRadioButton.Size = new System.Drawing.Size(115, 24);
            this.percentageRadioButton.TabIndex = 2;
            this.percentageRadioButton.TabStop = true;
            this.percentageRadioButton.Text = "Percentage";
            this.percentageRadioButton.UseVisualStyleBackColor = true;
            this.percentageRadioButton.CheckedChanged += new System.EventHandler(this.percentageRadioButton_CheckedChanged);
            // 
            // timerRadioButton
            // 
            this.timerRadioButton.AutoSize = true;
            this.timerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerRadioButton.Location = new System.Drawing.Point(10, 30);
            this.timerRadioButton.Name = "timerRadioButton";
            this.timerRadioButton.Size = new System.Drawing.Size(73, 24);
            this.timerRadioButton.TabIndex = 1;
            this.timerRadioButton.TabStop = true;
            this.timerRadioButton.Text = "Timer";
            this.timerRadioButton.UseVisualStyleBackColor = true;
            this.timerRadioButton.CheckedChanged += new System.EventHandler(this.timerRadioButton_CheckedChanged);
            // 
            // timerTrackbar
            // 
            this.timerTrackbar.Location = new System.Drawing.Point(10, 60);
            this.timerTrackbar.Maximum = 6;
            this.timerTrackbar.Minimum = 1;
            this.timerTrackbar.Name = "timerTrackbar";
            this.timerTrackbar.Size = new System.Drawing.Size(248, 56);
            this.timerTrackbar.TabIndex = 0;
            this.timerTrackbar.Value = 1;
            this.timerTrackbar.Scroll += new System.EventHandler(this.timerTrackbar_Scroll);
            this.timerTrackbar.ValueChanged += new System.EventHandler(this.timerTrackbar_ValueChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 29);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Fake Progress Bar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.iconPictureBox);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 93);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Icon";
            this.toolTip1.SetToolTip(this.groupBox3, "Icon: Spoofs progress bar icon.\r\n     Browse: Select any file, and it\'s icon will" +
        " be cloned.\r\n          Cloned icon will be used as the spoof icon.\r\n     Preview" +
        ": Selected icon will be displayed.");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(10, 31);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FBR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox customCaptionCheckBox;
        private System.Windows.Forms.TextBox customCaptionTextBox;
        private System.Windows.Forms.ComboBox captionComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar timerTrackbar;
        private System.Windows.Forms.Label percentSignLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.NumericUpDown percentNumericUpDown;
        private System.Windows.Forms.RadioButton percentageRadioButton;
        private System.Windows.Forms.RadioButton timerRadioButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox iconPictureBox;
    }
}

