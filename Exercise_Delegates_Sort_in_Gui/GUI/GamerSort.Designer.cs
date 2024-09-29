

namespace Exercise_Delegates_Sort_in_Gui
{
    partial class GamerSort
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
            btnByName = new Button();
            btnByHighScore = new Button();
            lbGamers = new ListBox();
            lblGamers = new Label();
            SuspendLayout();
            // 
            // btnByName
            // 
            btnByName.Location = new Point(498, 91);
            btnByName.Name = "btnByName";
            btnByName.Size = new Size(186, 34);
            btnByName.TabIndex = 0;
            btnByName.Text = "Sort by name";
            btnByName.UseVisualStyleBackColor = true;
            btnByName.Click += this.BtnByName_Click;
            // 
            // btnByHighScore
            // 
            btnByHighScore.Location = new Point(501, 154);
            btnByHighScore.Name = "btnByHighScore";
            btnByHighScore.Size = new Size(183, 34);
            btnByHighScore.TabIndex = 1;
            btnByHighScore.Text = "Sort by high score";
            btnByHighScore.UseVisualStyleBackColor = true;
            btnByHighScore.Click += this.BtnByHighScore_Click;
            // 
            // lbGamers
            // 
            lbGamers.FormattingEnabled = true;
            lbGamers.ItemHeight = 25;
            lbGamers.Location = new Point(93, 91);
            lbGamers.Name = "lbGamers";
            lbGamers.Size = new Size(370, 304);
            lbGamers.TabIndex = 2;
            // 
            // lblGamers
            // 
            lblGamers.AutoSize = true;
            lblGamers.Location = new Point(93, 53);
            lblGamers.Name = "lblGamers";
            lblGamers.Size = new Size(82, 25);
            lblGamers.TabIndex = 3;
            lblGamers.Text = "GAMERS";
            // 
            // GamerSort
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGamers);
            Controls.Add(lbGamers);
            Controls.Add(btnByHighScore);
            Controls.Add(btnByName);
            Name = "GamerSort";
            Text = "Form1";
            Load += GamerSort_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnByName;
        private Button btnByHighScore;
        private ListBox lbGamers;
        private Label lblGamers;
    }
}
