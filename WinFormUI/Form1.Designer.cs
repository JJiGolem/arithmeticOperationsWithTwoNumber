
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateBtn = new System.Windows.Forms.Button();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.operationsGroup = new System.Windows.Forms.GroupBox();
            this.divRadioBtn = new System.Windows.Forms.RadioButton();
            this.multRadioBtn = new System.Windows.Forms.RadioButton();
            this.subRadioBtn = new System.Windows.Forms.RadioButton();
            this.sumRadioBtn = new System.Windows.Forms.RadioButton();
            this.operationsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 177);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(344, 37);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(12, 38);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.PlaceholderText = "0";
            this.firstNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNumberTextBox.TabIndex = 1;
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(12, 20);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(77, 15);
            this.firstNumberLabel.TabIndex = 2;
            this.firstNumberLabel.Text = "First number:";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(256, 20);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(94, 15);
            this.secondNumberLabel.TabIndex = 4;
            this.secondNumberLabel.Text = "Second number:";
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(256, 38);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.PlaceholderText = "0";
            this.secondNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.secondNumberTextBox.TabIndex = 3;
            // 
            // operationsGroup
            // 
            this.operationsGroup.Controls.Add(this.divRadioBtn);
            this.operationsGroup.Controls.Add(this.multRadioBtn);
            this.operationsGroup.Controls.Add(this.subRadioBtn);
            this.operationsGroup.Controls.Add(this.sumRadioBtn);
            this.operationsGroup.Location = new System.Drawing.Point(128, 68);
            this.operationsGroup.Name = "operationsGroup";
            this.operationsGroup.Size = new System.Drawing.Size(113, 82);
            this.operationsGroup.TabIndex = 5;
            this.operationsGroup.TabStop = false;
            this.operationsGroup.Text = "Operations";
            // 
            // divRadioBtn
            // 
            this.divRadioBtn.AutoSize = true;
            this.divRadioBtn.Location = new System.Drawing.Point(78, 47);
            this.divRadioBtn.Name = "divRadioBtn";
            this.divRadioBtn.Size = new System.Drawing.Size(30, 19);
            this.divRadioBtn.TabIndex = 0;
            this.divRadioBtn.TabStop = true;
            this.divRadioBtn.Text = "/";
            this.divRadioBtn.UseVisualStyleBackColor = true;
            this.divRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // multRadioBtn
            // 
            this.multRadioBtn.AutoSize = true;
            this.multRadioBtn.Location = new System.Drawing.Point(78, 22);
            this.multRadioBtn.Name = "multRadioBtn";
            this.multRadioBtn.Size = new System.Drawing.Size(31, 19);
            this.multRadioBtn.TabIndex = 0;
            this.multRadioBtn.TabStop = true;
            this.multRadioBtn.Text = "x";
            this.multRadioBtn.UseVisualStyleBackColor = true;
            this.multRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // subRadioBtn
            // 
            this.subRadioBtn.AutoSize = true;
            this.subRadioBtn.Location = new System.Drawing.Point(6, 47);
            this.subRadioBtn.Name = "subRadioBtn";
            this.subRadioBtn.Size = new System.Drawing.Size(30, 19);
            this.subRadioBtn.TabIndex = 0;
            this.subRadioBtn.TabStop = true;
            this.subRadioBtn.Text = "-";
            this.subRadioBtn.UseVisualStyleBackColor = true;
            this.subRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sumRadioBtn
            // 
            this.sumRadioBtn.AutoSize = true;
            this.sumRadioBtn.Location = new System.Drawing.Point(6, 22);
            this.sumRadioBtn.Name = "sumRadioBtn";
            this.sumRadioBtn.Size = new System.Drawing.Size(33, 19);
            this.sumRadioBtn.TabIndex = 0;
            this.sumRadioBtn.TabStop = true;
            this.sumRadioBtn.Text = "+";
            this.sumRadioBtn.UseVisualStyleBackColor = true;
            this.sumRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 226);
            this.Controls.Add(this.operationsGroup);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberLabel);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arithmetic Operations With Two Numbers";
            this.operationsGroup.ResumeLayout(false);
            this.operationsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.GroupBox operationsGroup;
        private System.Windows.Forms.RadioButton sumRadioBtn;
        private System.Windows.Forms.RadioButton subRadioBtn;
        private System.Windows.Forms.RadioButton multRadioBtn;
        private System.Windows.Forms.RadioButton divRadioBtn;
    }
}

