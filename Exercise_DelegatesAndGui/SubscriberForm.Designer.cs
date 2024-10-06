namespace Exercise_DelegatesAndGui
{
    partial class SubscriberForm
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
            btnGotoNamePage = new Button();
            label1 = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnGotoNamePage
            // 
            btnGotoNamePage.Location = new Point(113, 101);
            btnGotoNamePage.Name = "btnGotoNamePage";
            btnGotoNamePage.Size = new Size(236, 34);
            btnGotoNamePage.TabIndex = 0;
            btnGotoNamePage.Text = "Goto name page";
            btnGotoNamePage.UseVisualStyleBackColor = true;
            btnGotoNamePage.Click += BtnGotoNamePage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 170);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 1;
            label1.Text = "Name input:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(113, 213);
            lblName.Name = "lblName";
            lblName.Size = new Size(20, 25);
            lblName.TabIndex = 2;
            lblName.Text = "..";
            // 
            // SubscriberForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(btnGotoNamePage);
            Name = "SubscriberForm";
            Text = "SubscriberForm";
            Load += SubscriberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGotoNamePage;
        private Label label1;
        private Label lblName;
    }
}