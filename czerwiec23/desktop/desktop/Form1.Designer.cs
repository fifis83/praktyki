namespace desktop
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.postcardButton = new System.Windows.Forms.RadioButton();
            this.letterButton = new System.Windows.Forms.RadioButton();
            this.packageButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.checkPrice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.packageButton);
            this.groupBox1.Controls.Add(this.letterButton);
            this.groupBox1.Controls.Add(this.postcardButton);
            this.groupBox1.Location = new System.Drawing.Point(67, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj przesyłki";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::desktop.Properties.Resources.pocztowka;
            this.pictureBox.Location = new System.Drawing.Point(67, 202);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(103, 64);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // postcardButton
            // 
            this.postcardButton.AutoSize = true;
            this.postcardButton.Checked = true;
            this.postcardButton.Location = new System.Drawing.Point(31, 20);
            this.postcardButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.postcardButton.Name = "postcardButton";
            this.postcardButton.Size = new System.Drawing.Size(87, 17);
            this.postcardButton.TabIndex = 0;
            this.postcardButton.TabStop = true;
            this.postcardButton.Text = "Pocztówka";
            this.postcardButton.UseVisualStyleBackColor = true;
            // 
            // letterButton
            // 
            this.letterButton.AutoSize = true;
            this.letterButton.Location = new System.Drawing.Point(31, 43);
            this.letterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.letterButton.Name = "letterButton";
            this.letterButton.Size = new System.Drawing.Size(45, 17);
            this.letterButton.TabIndex = 1;
            this.letterButton.Text = "List";
            this.letterButton.UseVisualStyleBackColor = true;
            // 
            // packageButton
            // 
            this.packageButton.AutoSize = true;
            this.packageButton.Location = new System.Drawing.Point(31, 66);
            this.packageButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.packageButton.Name = "packageButton";
            this.packageButton.Size = new System.Drawing.Size(67, 17);
            this.packageButton.TabIndex = 2;
            this.packageButton.Text = "Paczka";
            this.packageButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceLabel.Location = new System.Drawing.Point(211, 213);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(98, 26);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Cena 1zł";
            // 
            // checkPrice
            // 
            this.checkPrice.Location = new System.Drawing.Point(67, 159);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(233, 23);
            this.checkPrice.TabIndex = 3;
            this.checkPrice.Text = "Sprawdź Cenę";
            this.checkPrice.UseVisualStyleBackColor = true;
            this.checkPrice.Click += new System.EventHandler(this.checkPrice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.streetTextBox);
            this.groupBox2.Location = new System.Drawing.Point(405, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 224);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane adresowe";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(15, 43);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(213, 20);
            this.streetTextBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(15, 103);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(213, 20);
            this.codeTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(15, 165);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(213, 20);
            this.cityTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ulica z numerem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kod pocztowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Miasto";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(66, 288);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(573, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Zatwierdź";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 335);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkPrice);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton packageButton;
        private System.Windows.Forms.RadioButton letterButton;
        private System.Windows.Forms.RadioButton postcardButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button checkPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}

