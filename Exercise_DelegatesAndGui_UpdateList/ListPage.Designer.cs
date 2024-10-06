namespace Exercise_DelegatesAndGui_UpdateList
{
    partial class ListPage
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
            lblHeadline = new Label();
            lvPersons = new ListView();
            lblNote = new Label();
            SuspendLayout();
            // 
            // btnGotoNamePage
            // 
            btnGotoNamePage.Location = new Point(84, 61);
            btnGotoNamePage.Name = "btnGotoNamePage";
            btnGotoNamePage.Size = new Size(263, 58);
            btnGotoNamePage.TabIndex = 0;
            btnGotoNamePage.Text = "Add a person";
            btnGotoNamePage.UseVisualStyleBackColor = true;
            btnGotoNamePage.Click += BtnGotoNamePage_Click;
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.Location = new Point(84, 151);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(128, 25);
            lblHeadline.TabIndex = 1;
            lblHeadline.Text = "List of persons";
            // 
            // lvPersons
            // 
            lvPersons.Location = new Point(84, 198);
            lvPersons.Name = "lvPersons";
            lvPersons.Size = new Size(392, 192);
            lvPersons.TabIndex = 2;
            lvPersons.UseCompatibleStateImageBehavior = false;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(84, 393);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(24, 25);
            lblNote.TabIndex = 3;
            lblNote.Text = "...";
            // 
            // ListPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNote);
            Controls.Add(lvPersons);
            Controls.Add(lblHeadline);
            Controls.Add(btnGotoNamePage);
            Name = "ListPage";
            Text = "ListPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGotoNamePage;
        private Label lblHeadline;
        private ListView lvPersons;
        private Label lblNote;
    }
}