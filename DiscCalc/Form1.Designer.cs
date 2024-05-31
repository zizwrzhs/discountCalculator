namespace DiscCalc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.origPriceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.fpriceLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.savedLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.fprice = new System.Windows.Forms.Label();
            this.saved = new System.Windows.Forms.Label();
            this.reqFields = new System.Windows.Forms.Label();
            this.origPrice = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(400, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "Discount Calculator";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Label_Click);
            // 
            // origPriceLabel
            // 
            this.origPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.origPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.origPriceLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origPriceLabel.ForeColor = System.Drawing.Color.White;
            this.origPriceLabel.Location = new System.Drawing.Point(142, 74);
            this.origPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.origPriceLabel.Name = "origPriceLabel";
            this.origPriceLabel.Size = new System.Drawing.Size(118, 16);
            this.origPriceLabel.TabIndex = 1;
            this.origPriceLabel.Text = "Original Price* (€):";
            this.origPriceLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discountLabel.BackColor = System.Drawing.Color.Transparent;
            this.discountLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.ForeColor = System.Drawing.Color.White;
            this.discountLabel.Location = new System.Drawing.Point(153, 141);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(95, 16);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.Text = "Discount* (%):";
            this.discountLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // fpriceLabel
            // 
            this.fpriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpriceLabel.AutoSize = true;
            this.fpriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.fpriceLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpriceLabel.ForeColor = System.Drawing.Color.White;
            this.fpriceLabel.Location = new System.Drawing.Point(238, 306);
            this.fpriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fpriceLabel.Name = "fpriceLabel";
            this.fpriceLabel.Size = new System.Drawing.Size(76, 16);
            this.fpriceLabel.TabIndex = 8;
            this.fpriceLabel.Text = "Final Price:";
            this.fpriceLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // calcButton
            // 
            this.calcButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calcButton.BackColor = System.Drawing.Color.LightGreen;
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.calcButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.calcButton.Location = new System.Drawing.Point(216, 225);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(120, 50);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // savedLabel
            // 
            this.savedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savedLabel.AutoSize = true;
            this.savedLabel.BackColor = System.Drawing.Color.Transparent;
            this.savedLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.savedLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedLabel.ForeColor = System.Drawing.Color.White;
            this.savedLabel.Location = new System.Drawing.Point(83, 306);
            this.savedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(81, 16);
            this.savedLabel.TabIndex = 7;
            this.savedLabel.Text = "You Saved:";
            this.savedLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.BackColor = System.Drawing.Color.LightBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clearButton.Location = new System.Drawing.Point(63, 225);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 50);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fprice
            // 
            this.fprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fprice.BackColor = System.Drawing.Color.Transparent;
            this.fprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fprice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fprice.ForeColor = System.Drawing.Color.White;
            this.fprice.Location = new System.Drawing.Point(216, 353);
            this.fprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fprice.Name = "fprice";
            this.fprice.Size = new System.Drawing.Size(120, 50);
            this.fprice.TabIndex = 10;
            this.fprice.Text = "-";
            this.fprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fprice.Click += new System.EventHandler(this.Label_Click);
            // 
            // saved
            // 
            this.saved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saved.BackColor = System.Drawing.Color.Transparent;
            this.saved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saved.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved.ForeColor = System.Drawing.Color.White;
            this.saved.Location = new System.Drawing.Point(63, 353);
            this.saved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saved.Name = "saved";
            this.saved.Size = new System.Drawing.Size(120, 50);
            this.saved.TabIndex = 9;
            this.saved.Text = "-";
            this.saved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saved.Click += new System.EventHandler(this.Label_Click);
            // 
            // reqFields
            // 
            this.reqFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reqFields.BackColor = System.Drawing.Color.Transparent;
            this.reqFields.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqFields.ForeColor = System.Drawing.Color.DarkGray;
            this.reqFields.Location = new System.Drawing.Point(4, 475);
            this.reqFields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reqFields.Name = "reqFields";
            this.reqFields.Size = new System.Drawing.Size(102, 16);
            this.reqFields.TabIndex = 11;
            this.reqFields.Text = "* required fields";
            this.reqFields.Click += new System.EventHandler(this.Label_Click);
            // 
            // origPrice
            // 
            this.origPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.origPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.origPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.origPrice.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origPrice.Location = new System.Drawing.Point(140, 93);
            this.origPrice.MaxLength = 12;
            this.origPrice.Name = "origPrice";
            this.origPrice.Size = new System.Drawing.Size(120, 28);
            this.origPrice.TabIndex = 13;
            this.origPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.origPrice.TextChanged += new System.EventHandler(this.origPrice_TextChanged);
            this.origPrice.Enter += new System.EventHandler(this.origPrice_Enter);
            this.origPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.origPrice_KeyPress);
            this.origPrice.Leave += new System.EventHandler(this.origPrice_Leave);
            // 
            // discount
            // 
            this.discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.discount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.discount.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(140, 160);
            this.discount.MaxLength = 12;
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(120, 28);
            this.discount.TabIndex = 13;
            this.discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discount.TextChanged += new System.EventHandler(this.discount_TextChanged);
            this.discount.Enter += new System.EventHandler(this.discount_Enter);
            this.discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discount_KeyPress);
            this.discount.Leave += new System.EventHandler(this.discount_Leave);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImage = global::DiscCalc.Properties.Resources.Untitled_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.origPrice);
            this.Controls.Add(this.saved);
            this.Controls.Add(this.fprice);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.fpriceLabel);
            this.Controls.Add(this.reqFields);
            this.Controls.Add(this.origPriceLabel);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label origPriceLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label fpriceLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label fprice;
        private System.Windows.Forms.Label saved;
        private System.Windows.Forms.Label reqFields;
        private System.Windows.Forms.TextBox origPrice;
        private System.Windows.Forms.TextBox discount;
    }
}

