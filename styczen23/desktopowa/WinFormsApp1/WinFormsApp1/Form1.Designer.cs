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
            groupBox1 = new GroupBox();
            occupationComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            surnameInput = new TextBox();
            nameInput = new TextBox();
            groupBox2 = new GroupBox();
            genPassBtn = new Button();
            charsNrInput = new TextBox();
            specialCharsChekbox = new CheckBox();
            numbersCheckbox = new CheckBox();
            upperLowerCaseCheckbox = new CheckBox();
            label4 = new Label();
            confirmBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(occupationComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(surnameInput);
            groupBox1.Controls.Add(nameInput);
            groupBox1.Location = new Point(22, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // occupationComboBox
            // 
            occupationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            occupationComboBox.FormattingEnabled = true;
            occupationComboBox.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            occupationComboBox.Location = new Point(151, 106);
            occupationComboBox.Name = "occupationComboBox";
            occupationComboBox.Size = new Size(165, 23);
            occupationComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 109);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Imię";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(151, 63);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(165, 23);
            surnameInput.TabIndex = 1;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(151, 22);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(165, 23);
            nameInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(genPassBtn);
            groupBox2.Controls.Add(charsNrInput);
            groupBox2.Controls.Add(specialCharsChekbox);
            groupBox2.Controls.Add(numbersCheckbox);
            groupBox2.Controls.Add(upperLowerCaseCheckbox);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(435, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 171);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // genPassBtn
            // 
            genPassBtn.BackColor = Color.SteelBlue;
            genPassBtn.ForeColor = Color.White;
            genPassBtn.Location = new Point(96, 142);
            genPassBtn.Name = "genPassBtn";
            genPassBtn.Size = new Size(117, 23);
            genPassBtn.TabIndex = 3;
            genPassBtn.Text = "Generuj hasło";
            genPassBtn.UseVisualStyleBackColor = false;
            genPassBtn.Click += genPassBtn_Click;
            // 
            // charsNrInput
            // 
            charsNrInput.Location = new Point(136, 25);
            charsNrInput.Name = "charsNrInput";
            charsNrInput.Size = new Size(165, 23);
            charsNrInput.TabIndex = 6;
            // 
            // specialCharsChekbox
            // 
            specialCharsChekbox.AutoSize = true;
            specialCharsChekbox.Location = new Point(20, 112);
            specialCharsChekbox.Name = "specialCharsChekbox";
            specialCharsChekbox.Size = new Size(107, 19);
            specialCharsChekbox.TabIndex = 9;
            specialCharsChekbox.Text = "Znaki specjalne";
            specialCharsChekbox.UseVisualStyleBackColor = true;
            // 
            // numbersCheckbox
            // 
            numbersCheckbox.AutoSize = true;
            numbersCheckbox.Location = new Point(20, 87);
            numbersCheckbox.Name = "numbersCheckbox";
            numbersCheckbox.Size = new Size(54, 19);
            numbersCheckbox.TabIndex = 8;
            numbersCheckbox.Text = "Cyfry";
            numbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // upperLowerCaseCheckbox
            // 
            upperLowerCaseCheckbox.AutoSize = true;
            upperLowerCaseCheckbox.Location = new Point(20, 62);
            upperLowerCaseCheckbox.Name = "upperLowerCaseCheckbox";
            upperLowerCaseCheckbox.Size = new Size(126, 19);
            upperLowerCaseCheckbox.TabIndex = 7;
            upperLowerCaseCheckbox.Text = "Małe i wielkie litery";
            upperLowerCaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 25);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Ile znaków?";
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.SteelBlue;
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(292, 240);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(193, 23);
            confirmBtn.TabIndex = 2;
            confirmBtn.Text = "Zatwierdź";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 292);
            Controls.Add(confirmBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button confirmBtn;
        private ComboBox occupationComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox surnameInput;
        private TextBox nameInput;
        private Button genPassBtn;
        private TextBox charsNrInput;
        private CheckBox specialCharsChekbox;
        private CheckBox numbersCheckbox;
        private CheckBox upperLowerCaseCheckbox;
        private Label label4;
    }
}
