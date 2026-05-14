namespace desktopowa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blueEyesButton = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.hazelEyesButton = new System.Windows.Forms.RadioButton();
            this.greenEyesButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fingerprintPictureBox = new System.Windows.Forms.PictureBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprintPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko:";
            // 
            // blueEyesButton
            // 
            this.blueEyesButton.AutoSize = true;
            this.blueEyesButton.BackColor = System.Drawing.Color.CadetBlue;
            this.blueEyesButton.Location = new System.Drawing.Point(15, 19);
            this.blueEyesButton.Name = "blueEyesButton";
            this.blueEyesButton.Size = new System.Drawing.Size(72, 17);
            this.blueEyesButton.TabIndex = 3;
            this.blueEyesButton.TabStop = true;
            this.blueEyesButton.Text = "niebieskie";
            this.blueEyesButton.UseVisualStyleBackColor = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.hazelEyesButton);
            this.groupBox.Controls.Add(this.greenEyesButton);
            this.groupBox.Controls.Add(this.blueEyesButton);
            this.groupBox.Location = new System.Drawing.Point(59, 251);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(298, 132);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "kolor oczu";
            // 
            // hazelEyesButton
            // 
            this.hazelEyesButton.AutoSize = true;
            this.hazelEyesButton.Location = new System.Drawing.Point(15, 89);
            this.hazelEyesButton.Name = "hazelEyesButton";
            this.hazelEyesButton.Size = new System.Drawing.Size(53, 17);
            this.hazelEyesButton.TabIndex = 5;
            this.hazelEyesButton.TabStop = true;
            this.hazelEyesButton.Text = "piwne";
            this.hazelEyesButton.UseVisualStyleBackColor = true;
            // 
            // greenEyesButton
            // 
            this.greenEyesButton.AutoSize = true;
            this.greenEyesButton.Location = new System.Drawing.Point(15, 55);
            this.greenEyesButton.Name = "greenEyesButton";
            this.greenEyesButton.Size = new System.Drawing.Size(58, 17);
            this.greenEyesButton.TabIndex = 4;
            this.greenEyesButton.TabStop = true;
            this.greenEyesButton.Text = "zielone";
            this.greenEyesButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Azure;
            this.submitButton.Location = new System.Drawing.Point(536, 393);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "OK";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.Color.Azure;
            this.numberTextBox.Location = new System.Drawing.Point(124, 50);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(233, 20);
            this.numberTextBox.TabIndex = 6;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            this.numberTextBox.Leave += new System.EventHandler(this.numeberTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Azure;
            this.nameTextBox.Location = new System.Drawing.Point(124, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(233, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.lastNameTextBox.Location = new System.Drawing.Point(124, 159);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // fingerprintPictureBox
            // 
            this.fingerprintPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fingerprintPictureBox.Image")));
            this.fingerprintPictureBox.Location = new System.Drawing.Point(602, 73);
            this.fingerprintPictureBox.Name = "fingerprintPictureBox";
            this.fingerprintPictureBox.Size = new System.Drawing.Size(150, 180);
            this.fingerprintPictureBox.TabIndex = 9;
            this.fingerprintPictureBox.TabStop = false;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Image = global::desktopowa.Properties.Resources._000_zdjecie;
            this.photoPictureBox.Location = new System.Drawing.Point(413, 73);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(150, 180);
            this.photoPictureBox.TabIndex = 10;
            this.photoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.fingerprintPictureBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wprowadzenie danych do paszportu. Wykonał:  Dawid";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprintPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton hazelEyesButton;
        private System.Windows.Forms.RadioButton greenEyesButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.PictureBox fingerprintPictureBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton blueEyesButton;
    }
}

