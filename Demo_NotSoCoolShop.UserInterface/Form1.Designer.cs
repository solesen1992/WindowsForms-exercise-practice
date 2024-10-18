namespace Demo_NotSoCoolShop.UserInterface
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
            btnInsert = new Button();
            button2 = new Button();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbProducts = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(96, 226);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(430, 226);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "GetAll";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(96, 88);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 2;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Cursor = Cursors.No;
            txtPrice.Location = new Point(96, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 60);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 141);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // lbProducts
            // 
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 25;
            lbProducts.Location = new Point(430, 88);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(180, 129);
            lbProducts.TabIndex = 6;
            lbProducts.SelectedIndexChanged += lbProducts_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 60);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 7;
            label3.Text = "Products";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lbProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(button2);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button button2;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private ListBox lbProducts;
        private Label label3;
    }
}
