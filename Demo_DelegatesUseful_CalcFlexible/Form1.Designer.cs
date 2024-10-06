namespace Demo_DelegatesUseful_CalcFlexible
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
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.comboBoxCalcMethod = new System.Windows.Forms.ComboBox();
            this.labelCalcResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(50, 42);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(81, 27);
            this.textBoxNumber1.TabIndex = 0;
            this.textBoxNumber1.Text = "1";
            this.textBoxNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(157, 42);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(81, 27);
            this.textBoxNumber2.TabIndex = 1;
            this.textBoxNumber2.Text = "1";
            this.textBoxNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxCalcMethod
            // 
            this.comboBoxCalcMethod.FormattingEnabled = true;
            this.comboBoxCalcMethod.Location = new System.Drawing.Point(50, 94);
            this.comboBoxCalcMethod.Name = "comboBoxCalcMethod";
            this.comboBoxCalcMethod.Size = new System.Drawing.Size(188, 28);
            this.comboBoxCalcMethod.TabIndex = 2;
            this.comboBoxCalcMethod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCalcMethod_SelectedIndexChanged);
            // 
            // labelCalcResult
            // 
            this.labelCalcResult.AutoSize = true;
            this.labelCalcResult.Location = new System.Drawing.Point(268, 96);
            this.labelCalcResult.Name = "labelCalcResult";
            this.labelCalcResult.Size = new System.Drawing.Size(15, 20);
            this.labelCalcResult.TabIndex = 3;
            this.labelCalcResult.Text = "..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 202);
            this.Controls.Add(this.labelCalcResult);
            this.Controls.Add(this.comboBoxCalcMethod);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Name = "Form1";
            this.Text = "Code using delegate";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private ComboBox comboBoxCalcMethod;
        private Label labelCalcResult;
    }
}
