namespace Demo_DelegatesUseful_CalcInflexible
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
            textBoxNumber1 = new TextBox();
            textBoxNumber2 = new TextBox();
            comboBoxCalcMethod = new ComboBox();
            labelCalcResult = new Label();
            SuspendLayout();
            // 
            // textBoxNumber1
            // 
            textBoxNumber1.Location = new Point(66, 72);
            textBoxNumber1.Margin = new Padding(4, 4, 4, 4);
            textBoxNumber1.Name = "textBoxNumber1";
            textBoxNumber1.Size = new Size(93, 31);
            textBoxNumber1.TabIndex = 0;
            textBoxNumber1.Text = "1";
            textBoxNumber1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxNumber2
            // 
            textBoxNumber2.Location = new Point(66, 132);
            textBoxNumber2.Margin = new Padding(4, 4, 4, 4);
            textBoxNumber2.Name = "textBoxNumber2";
            textBoxNumber2.Size = new Size(93, 31);
            textBoxNumber2.TabIndex = 1;
            textBoxNumber2.Text = "1";
            textBoxNumber2.TextAlign = HorizontalAlignment.Right;
            // 
            // comboBoxCalcMethod
            // 
            comboBoxCalcMethod.FormattingEnabled = true;
            comboBoxCalcMethod.Location = new Point(208, 100);
            comboBoxCalcMethod.Margin = new Padding(4, 4, 4, 4);
            comboBoxCalcMethod.Name = "comboBoxCalcMethod";
            comboBoxCalcMethod.Size = new Size(188, 33);
            comboBoxCalcMethod.TabIndex = 2;
            comboBoxCalcMethod.SelectedIndexChanged += ComboBoxCalcMethod_SelectedIndexChanged;
            // 
            // labelCalcResult
            // 
            labelCalcResult.AutoSize = true;
            labelCalcResult.Location = new Point(464, 110);
            labelCalcResult.Margin = new Padding(4, 0, 4, 0);
            labelCalcResult.Name = "labelCalcResult";
            labelCalcResult.Size = new Size(20, 25);
            labelCalcResult.TabIndex = 3;
            labelCalcResult.Text = "..";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 230);
            Controls.Add(labelCalcResult);
            Controls.Add(comboBoxCalcMethod);
            Controls.Add(textBoxNumber2);
            Controls.Add(textBoxNumber1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Code Inflexible";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private ComboBox comboBoxCalcMethod;
        private Label labelCalcResult;
    }
}
