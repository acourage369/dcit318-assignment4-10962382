namespace AddressBookApplication
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
            button1 = new Button();
            label1 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            txtemail = new TextBox();
            txtnumber = new TextBox();
            label3 = new Label();
            addressBook = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(476, 228);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(335, 33);
            button1.TabIndex = 0;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 18);
            label1.TabIndex = 1;
            label1.Text = "Full Name:";
            // 
            // txtname
            // 
            txtname.Location = new Point(476, 79);
            txtname.Margin = new Padding(4, 4, 4, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(335, 27);
            txtname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 1;
            label2.Text = "Email Address:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(476, 129);
            txtemail.Margin = new Padding(4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(335, 27);
            txtemail.TabIndex = 2;
            // 
            // txtnumber
            // 
            txtnumber.Location = new Point(476, 174);
            txtnumber.Margin = new Padding(4);
            txtnumber.Name = "txtnumber";
            txtnumber.Size = new Size(335, 27);
            txtnumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 18);
            label3.TabIndex = 1;
            label3.Text = "Phone Number:";
            // 
            // addressBook
            // 
            addressBook.FormattingEnabled = true;
            addressBook.ItemHeight = 18;
            addressBook.Location = new Point(12, 79);
            addressBook.Name = "addressBook";
            addressBook.Size = new Size(305, 328);
            addressBook.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 18);
            label4.TabIndex = 1;
            label4.Text = "Address Book Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(838, 444);
            Controls.Add(addressBook);
            Controls.Add(txtnumber);
            Controls.Add(txtemail);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtname;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtnumber;
        private Label label3;
        private ListBox addressBook;
        private Label label4;
    }
}
