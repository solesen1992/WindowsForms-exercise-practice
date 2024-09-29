namespace Exercise_Exceptions
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
            textBoxProduct = new TextBox();
            btnSave = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // textBoxProduct
            // 
            textBoxProduct.Location = new Point(71, 71);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(150, 31);
            textBoxProduct.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(71, 136);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(71, 207);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(326, 25);
            lblResult.TabIndex = 2;
            lblResult.Text = "Message will appear after you click save";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnSave);
            Controls.Add(textBoxProduct);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProduct;
        private Button btnSave;
        private Label lblResult;
    }
}
