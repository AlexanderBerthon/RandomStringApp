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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.lengthSelect = new System.Windows.Forms.NumericUpDown();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.alphaLower_checkBox = new System.Windows.Forms.CheckBox();
            this.alphaUpper_checkBox = new System.Windows.Forms.CheckBox();
            this.symbols_checkBox = new System.Windows.Forms.CheckBox();
            this.space_checkBox = new System.Windows.Forms.CheckBox();
            this.numeric_checkBox = new System.Windows.Forms.CheckBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTextBox.Location = new System.Drawing.Point(12, 31);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(160, 22);
            this.outputTextBox.TabIndex = 0;
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateBtn.Location = new System.Drawing.Point(55, 220);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // lengthSelect
            // 
            this.lengthSelect.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthSelect.Location = new System.Drawing.Point(103, 68);
            this.lengthSelect.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lengthSelect.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lengthSelect.Name = "lengthSelect";
            this.lengthSelect.Size = new System.Drawing.Size(43, 25);
            this.lengthSelect.TabIndex = 2;
            this.lengthSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthSelect.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lengthSelect.ValueChanged += new System.EventHandler(this.lengthSelect_ValueChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.Location = new System.Drawing.Point(41, 70);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Length";
            // 
            // alphaLower_checkBox
            // 
            this.alphaLower_checkBox.AutoSize = true;
            this.alphaLower_checkBox.Checked = true;
            this.alphaLower_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaLower_checkBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alphaLower_checkBox.Location = new System.Drawing.Point(30, 110);
            this.alphaLower_checkBox.Name = "alphaLower_checkBox";
            this.alphaLower_checkBox.Size = new System.Drawing.Size(47, 18);
            this.alphaLower_checkBox.TabIndex = 4;
            this.alphaLower_checkBox.Text = "a-z";
            this.alphaLower_checkBox.UseVisualStyleBackColor = true;
            // 
            // alphaUpper_checkBox
            // 
            this.alphaUpper_checkBox.AutoSize = true;
            this.alphaUpper_checkBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alphaUpper_checkBox.Location = new System.Drawing.Point(30, 140);
            this.alphaUpper_checkBox.Name = "alphaUpper_checkBox";
            this.alphaUpper_checkBox.Size = new System.Drawing.Size(47, 18);
            this.alphaUpper_checkBox.TabIndex = 5;
            this.alphaUpper_checkBox.Text = "A-Z";
            this.alphaUpper_checkBox.UseVisualStyleBackColor = true;
            // 
            // symbols_checkBox
            // 
            this.symbols_checkBox.AutoSize = true;
            this.symbols_checkBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symbols_checkBox.Location = new System.Drawing.Point(30, 170);
            this.symbols_checkBox.Name = "symbols_checkBox";
            this.symbols_checkBox.Size = new System.Drawing.Size(47, 18);
            this.symbols_checkBox.TabIndex = 6;
            this.symbols_checkBox.Text = "!@#";
            this.symbols_checkBox.UseVisualStyleBackColor = true;
            // 
            // space_checkBox
            // 
            this.space_checkBox.AutoSize = true;
            this.space_checkBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.space_checkBox.Location = new System.Drawing.Point(103, 110);
            this.space_checkBox.Name = "space_checkBox";
            this.space_checkBox.Size = new System.Drawing.Size(61, 18);
            this.space_checkBox.TabIndex = 7;
            this.space_checkBox.Text = "space";
            this.space_checkBox.UseVisualStyleBackColor = true;
            // 
            // numeric_checkBox
            // 
            this.numeric_checkBox.AutoSize = true;
            this.numeric_checkBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numeric_checkBox.Location = new System.Drawing.Point(103, 140);
            this.numeric_checkBox.Name = "numeric_checkBox";
            this.numeric_checkBox.Size = new System.Drawing.Size(47, 18);
            this.numeric_checkBox.TabIndex = 8;
            this.numeric_checkBox.Text = "0-9";
            this.numeric_checkBox.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLabel.Location = new System.Drawing.Point(16, 195);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(156, 15);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Error: more options required";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.numeric_checkBox);
            this.Controls.Add(this.space_checkBox);
            this.Controls.Add(this.symbols_checkBox);
            this.Controls.Add(this.alphaUpper_checkBox);
            this.Controls.Add(this.alphaLower_checkBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthSelect);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lengthSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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