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
            ((System.ComponentModel.ISupportInitialize)(this.lengthSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 31);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(160, 23);
            this.outputTextBox.TabIndex = 0;
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateBtn.Location = new System.Drawing.Point(53, 105);
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
            this.lengthSelect.Location = new System.Drawing.Point(103, 65);
            this.lengthSelect.Maximum = new decimal(new int[] {
            30,
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
            this.lengthLabel.Location = new System.Drawing.Point(41, 68);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
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
    }
}