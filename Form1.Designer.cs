namespace RandomStringApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            outputTextBox = new TextBox();
            generateBtn = new Button();
            lengthSelect = new NumericUpDown();
            lengthLabel = new Label();
            alphaLower_checkBox = new CheckBox();
            alphaUpper_checkBox = new CheckBox();
            symbols_checkBox = new CheckBox();
            space_checkBox = new CheckBox();
            numeric_checkBox = new CheckBox();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)lengthSelect).BeginInit();
            SuspendLayout();
            // 
            // outputTextBox
            // 
            outputTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            outputTextBox.Location = new Point(12, 31);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(160, 22);
            outputTextBox.TabIndex = 0;
            // 
            // generateBtn
            // 
            generateBtn.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            generateBtn.Location = new Point(55, 220);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(75, 23);
            generateBtn.TabIndex = 1;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // lengthSelect
            // 
            lengthSelect.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lengthSelect.Location = new Point(103, 68);
            lengthSelect.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            lengthSelect.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            lengthSelect.Name = "lengthSelect";
            lengthSelect.Size = new Size(43, 25);
            lengthSelect.TabIndex = 2;
            lengthSelect.TextAlign = HorizontalAlignment.Center;
            lengthSelect.Value = new decimal(new int[] { 8, 0, 0, 0 });
            lengthSelect.ValueChanged += lengthSelect_ValueChanged;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lengthLabel.Location = new Point(41, 70);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(56, 17);
            lengthLabel.TabIndex = 3;
            lengthLabel.Text = "Length";
            // 
            // alphaLower_checkBox
            // 
            alphaLower_checkBox.AutoSize = true;
            alphaLower_checkBox.Checked = true;
            alphaLower_checkBox.CheckState = CheckState.Checked;
            alphaLower_checkBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            alphaLower_checkBox.Location = new Point(30, 110);
            alphaLower_checkBox.Name = "alphaLower_checkBox";
            alphaLower_checkBox.Size = new Size(47, 18);
            alphaLower_checkBox.TabIndex = 4;
            alphaLower_checkBox.Text = "a-z";
            alphaLower_checkBox.UseVisualStyleBackColor = true;
            alphaLower_checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // alphaUpper_checkBox
            // 
            alphaUpper_checkBox.AutoSize = true;
            alphaUpper_checkBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            alphaUpper_checkBox.Location = new Point(30, 140);
            alphaUpper_checkBox.Name = "alphaUpper_checkBox";
            alphaUpper_checkBox.Size = new Size(47, 18);
            alphaUpper_checkBox.TabIndex = 5;
            alphaUpper_checkBox.Text = "A-Z";
            alphaUpper_checkBox.UseVisualStyleBackColor = true;
            alphaUpper_checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // symbols_checkBox
            // 
            symbols_checkBox.AutoSize = true;
            symbols_checkBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            symbols_checkBox.Location = new Point(30, 170);
            symbols_checkBox.Name = "symbols_checkBox";
            symbols_checkBox.Size = new Size(47, 18);
            symbols_checkBox.TabIndex = 6;
            symbols_checkBox.Text = "!@#";
            symbols_checkBox.UseVisualStyleBackColor = true;
            symbols_checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // space_checkBox
            // 
            space_checkBox.AutoSize = true;
            space_checkBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            space_checkBox.Location = new Point(103, 110);
            space_checkBox.Name = "space_checkBox";
            space_checkBox.Size = new Size(61, 18);
            space_checkBox.TabIndex = 7;
            space_checkBox.Text = "space";
            space_checkBox.UseVisualStyleBackColor = true;
            space_checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // numeric_checkBox
            // 
            numeric_checkBox.AutoSize = true;
            numeric_checkBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numeric_checkBox.Location = new Point(103, 140);
            numeric_checkBox.Name = "numeric_checkBox";
            numeric_checkBox.Size = new Size(47, 18);
            numeric_checkBox.TabIndex = 8;
            numeric_checkBox.Text = "0-9";
            numeric_checkBox.UseVisualStyleBackColor = true;
            numeric_checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Firebrick;
            errorLabel.Location = new Point(16, 195);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(156, 15);
            errorLabel.TabIndex = 9;
            errorLabel.Text = "Error: more options required";
            errorLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 261);
            Controls.Add(errorLabel);
            Controls.Add(numeric_checkBox);
            Controls.Add(space_checkBox);
            Controls.Add(symbols_checkBox);
            Controls.Add(alphaUpper_checkBox);
            Controls.Add(alphaLower_checkBox);
            Controls.Add(lengthLabel);
            Controls.Add(lengthSelect);
            Controls.Add(generateBtn);
            Controls.Add(outputTextBox);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)lengthSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputTextBox;
        private Button generateBtn;
        private NumericUpDown lengthSelect;
        private Label lengthLabel;
        private CheckBox alphaLower_checkBox;
        private CheckBox alphaUpper_checkBox;
        private CheckBox symbols_checkBox;
        private CheckBox space_checkBox;
        private CheckBox numeric_checkBox;
        private Label errorLabel;
    }
}