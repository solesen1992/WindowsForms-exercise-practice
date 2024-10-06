namespace Exercise_DelegatesAndGui_UpdateList
{
    partial class DetailPage
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
            label1 = new Label();
            dropdownIds = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            BtnOk = new Button();
            tbFirst = new TextBox();
            tbLast = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Input id:";
            // 
            // dropdownIds
            // 
            dropdownIds.FormattingEnabled = true;
            dropdownIds.Location = new Point(153, 56);
            dropdownIds.Name = "dropdownIds";
            dropdownIds.Size = new Size(180, 33);
            dropdownIds.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 132);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 2;
            label2.Text = "Input firstname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 200);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 4;
            label3.Text = "Input lastname:";
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(225, 287);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(108, 36);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += this.BtnOk_Click;
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(56, 155);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(277, 31);
            tbFirst.TabIndex = 3;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(56, 223);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(277, 31);
            tbLast.TabIndex = 5;
            // 
            // DetailPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbFirst);
            Controls.Add(tbLast);
            Controls.Add(BtnOk);
            Controls.Add(dropdownIds);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailPage";
            Text = "DetailPage";
            FormClosed += OnClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox dropdownIds;
        private Button BtnOk;
        private bool tbLastStyleBackColor;
        private TextBox tbFirst;
        private TextBox tbLast;
    }
}
