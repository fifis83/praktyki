namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            inputText = new RichTextBox();
            encryptBtn = new Button();
            label3 = new Label();
            button1 = new Button();
            encyptedText = new Label();
            keyValueText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(36, 22);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Podaj wartość klucza";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(42, 139);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Podaj tekst";
            // 
            // inputText
            // 
            inputText.Location = new Point(42, 167);
            inputText.Name = "inputText";
            inputText.Size = new Size(249, 208);
            inputText.TabIndex = 2;
            inputText.Text = "";
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(348, 192);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(75, 23);
            encryptBtn.TabIndex = 4;
            encryptBtn.Text = "Zaszyfruj";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(592, 22);
            label3.Name = "label3";
            label3.Size = new Size(171, 25);
            label3.TabIndex = 5;
            label3.Text = "Tekst zaszyfrowany";
            // 
            // button1
            // 
            button1.Location = new Point(569, 390);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 6;
            button1.Text = "Zapisz szyfr do pliku";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // encyptedText
            // 
            encyptedText.BorderStyle = BorderStyle.Fixed3D;
            encyptedText.FlatStyle = FlatStyle.Popup;
            encyptedText.ForeColor = Color.AliceBlue;
            encyptedText.Location = new Point(563, 72);
            encyptedText.Name = "encyptedText";
            encyptedText.Size = new Size(200, 219);
            encyptedText.TabIndex = 7;
            // 
            // keyValueText
            // 
            keyValueText.Location = new Point(108, 70);
            keyValueText.Name = "keyValueText";
            keyValueText.Size = new Size(100, 23);
            keyValueText.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(keyValueText);
            Controls.Add(encyptedText);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(encryptBtn);
            Controls.Add(inputText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Szyfrowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox inputText;
        private Button encryptBtn;
        private Label label3;
        private Button button1;
        private Label encyptedText;
        private TextBox keyValueText;
    }
}
