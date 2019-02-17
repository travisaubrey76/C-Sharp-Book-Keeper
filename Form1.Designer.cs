namespace Compe561_Project1
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.bookSelectComboBox = new System.Windows.Forms.ComboBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.author_TextBox = new System.Windows.Forms.TextBox();
            this.isbn_TextBox = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.bookPriceTextBox = new System.Windows.Forms.TextBox();
            this.bookPriceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityUserInputTextBox = new System.Windows.Forms.TextBox();
            this.addTitleButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookSelectComboBox
            // 
            this.bookSelectComboBox.FormattingEnabled = true;
            this.bookSelectComboBox.Location = new System.Drawing.Point(100, 75);
            this.bookSelectComboBox.Name = "bookSelectComboBox";
            this.bookSelectComboBox.Size = new System.Drawing.Size(600, 21);
            this.bookSelectComboBox.TabIndex = 0;
            this.bookSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.bookSelectComboBox_SelectedIndexChanged);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(100, 121);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(44, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author: ";
            // 
            // author_TextBox
            // 
            this.author_TextBox.Location = new System.Drawing.Point(150, 118);
            this.author_TextBox.Name = "author_TextBox";
            this.author_TextBox.ReadOnly = true;
            this.author_TextBox.ShortcutsEnabled = false;
            this.author_TextBox.Size = new System.Drawing.Size(200, 20);
            this.author_TextBox.TabIndex = 2;
            // 
            // isbn_TextBox
            // 
            this.isbn_TextBox.Location = new System.Drawing.Point(501, 121);
            this.isbn_TextBox.Name = "isbn_TextBox";
            this.isbn_TextBox.ReadOnly = true;
            this.isbn_TextBox.Size = new System.Drawing.Size(200, 20);
            this.isbn_TextBox.TabIndex = 3;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(460, 125);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(38, 13);
            this.isbnLabel.TabIndex = 4;
            this.isbnLabel.Text = "ISBN: ";
            // 
            // bookPriceTextBox
            // 
            this.bookPriceTextBox.Location = new System.Drawing.Point(323, 176);
            this.bookPriceTextBox.Name = "bookPriceTextBox";
            this.bookPriceTextBox.ReadOnly = true;
            this.bookPriceTextBox.Size = new System.Drawing.Size(150, 20);
            this.bookPriceTextBox.TabIndex = 5;
            // 
            // bookPriceLabel
            // 
            this.bookPriceLabel.AutoSize = true;
            this.bookPriceLabel.Location = new System.Drawing.Point(282, 179);
            this.bookPriceLabel.Name = "bookPriceLabel";
            this.bookPriceLabel.Size = new System.Drawing.Size(37, 13);
            this.bookPriceLabel.TabIndex = 6;
            this.bookPriceLabel.Text = "Price: ";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(376, 225);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(48, 13);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quanitity";
            // 
            // quantityUserInputTextBox
            // 
            this.quantityUserInputTextBox.Location = new System.Drawing.Point(350, 240);
            this.quantityUserInputTextBox.Name = "quantityUserInputTextBox";
            this.quantityUserInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityUserInputTextBox.TabIndex = 8;
            // 
            // addTitleButton
            // 
            this.addTitleButton.Location = new System.Drawing.Point(325, 275);
            this.addTitleButton.Name = "addTitleButton";
            this.addTitleButton.Size = new System.Drawing.Size(150, 25);
            this.addTitleButton.TabIndex = 9;
            this.addTitleButton.Text = "Add Title";
            this.addTitleButton.UseVisualStyleBackColor = true;
            this.addTitleButton.Click += new System.EventHandler(this.addTitleButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 179);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridViewLabel
            // 
            this.dataGridViewLabel.AutoSize = true;
            this.dataGridViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLabel.Location = new System.Drawing.Point(293, 330);
            this.dataGridViewLabel.Name = "dataGridViewLabel";
            this.dataGridViewLabel.Size = new System.Drawing.Size(205, 31);
            this.dataGridViewLabel.TabIndex = 11;
            this.dataGridViewLabel.Text = "Order Summary";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(79, 572);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 12;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(134, 569);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(133, 20);
            this.subtotalTextBox.TabIndex = 13;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(301, 572);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 14;
            this.taxLabel.Text = "Tax:";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(335, 569);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(140, 20);
            this.taxTextBox.TabIndex = 15;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(527, 572);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(567, 569);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(134, 20);
            this.totalTextBox.TabIndex = 17;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Location = new System.Drawing.Point(200, 613);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(150, 25);
            this.confirmOrderButton.TabIndex = 18;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            this.confirmOrderButton.Click += new System.EventHandler(this.confirmOrderButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(463, 613);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(150, 25);
            this.cancelOrderButton.TabIndex = 19;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.dataGridViewLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addTitleButton);
            this.Controls.Add(this.quantityUserInputTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.bookPriceLabel);
            this.Controls.Add(this.bookPriceTextBox);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.isbn_TextBox);
            this.Controls.Add(this.author_TextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.bookSelectComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The BookStore of Aubrey";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookSelectComboBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox author_TextBox;
        private System.Windows.Forms.TextBox isbn_TextBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox bookPriceTextBox;
        private System.Windows.Forms.Label bookPriceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityUserInputTextBox;
        private System.Windows.Forms.Button addTitleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dataGridViewLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Button cancelOrderButton;
    }
}

