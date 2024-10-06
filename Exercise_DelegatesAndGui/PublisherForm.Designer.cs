
namespace Exercise_DelegatesAndGui
{
    partial class PublisherForm
    {
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
        private void InitializeComponent()
        {
            label1 = new Label();
            tbFirstname = new TextBox();
            tbLastname = new TextBox();
            label2 = new Label();
            BtnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Input firstname:";
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(51, 85);
            tbFirstname.Margin = new Padding(4, 4, 4, 4);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(285, 31);
            tbFirstname.TabIndex = 1;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(51, 174);
            tbLastname.Margin = new Padding(4, 4, 4, 4);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(285, 31);
            tbLastname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Input lastname:";
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(220, 249);
            BtnOk.Margin = new Padding(4, 4, 4, 4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(118, 36);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // PublisherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(531, 392);
            Controls.Add(BtnOk);
            Controls.Add(tbLastname);
            Controls.Add(label2);
            Controls.Add(tbFirstname);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PublisherForm";
            Text = "PublisherForm";
            FormClosed += OnClose;
            Load += PublisherForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFirstname;
        private TextBox tbLastname;
        private Button BtnOk;
    }
}
