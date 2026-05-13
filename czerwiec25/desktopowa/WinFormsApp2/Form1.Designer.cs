namespace WinFormsApp2
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            redValueLbl = new Label();
            greenValueLbl = new Label();
            blueValueLbl = new Label();
            redSlider = new TrackBar();
            greenSlider = new TrackBar();
            blueSlider = new TrackBar();
            button1 = new Button();
            valueLbl = new Label();
            valueLblBackground = new Panel();
            ((System.ComponentModel.ISupportInitialize)redSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueSlider).BeginInit();
            valueLblBackground.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(43, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 62);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 119);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 1;
            label1.Text = "Dobierz kolor suwakami i zapisz przyciskiem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 179);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 2;
            label2.Text = "R";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 240);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 3;
            label3.Text = "G";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 297);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 4;
            label4.Text = "B";
            // 
            // redValueLbl
            // 
            redValueLbl.AutoSize = true;
            redValueLbl.Location = new Point(739, 179);
            redValueLbl.Name = "redValueLbl";
            redValueLbl.Size = new Size(25, 15);
            redValueLbl.TabIndex = 5;
            redValueLbl.Text = "255";
            // 
            // greenValueLbl
            // 
            greenValueLbl.AutoSize = true;
            greenValueLbl.Location = new Point(739, 240);
            greenValueLbl.Name = "greenValueLbl";
            greenValueLbl.Size = new Size(25, 15);
            greenValueLbl.TabIndex = 6;
            greenValueLbl.Text = "255";
            // 
            // blueValueLbl
            // 
            blueValueLbl.AutoSize = true;
            blueValueLbl.Location = new Point(739, 297);
            blueValueLbl.Name = "blueValueLbl";
            blueValueLbl.Size = new Size(25, 15);
            blueValueLbl.TabIndex = 7;
            blueValueLbl.Text = "255";
            // 
            // redSlider
            // 
            redSlider.Location = new Point(60, 175);
            redSlider.Maximum = 255;
            redSlider.Name = "redSlider";
            redSlider.Size = new Size(673, 45);
            redSlider.TabIndex = 8;
            redSlider.TickStyle = TickStyle.None;
            redSlider.Value = 255;
            redSlider.Scroll += redSlider_Scroll;
            redSlider.ValueChanged += trackBar1_ValueChanged;
            // 
            // greenSlider
            // 
            greenSlider.Location = new Point(61, 240);
            greenSlider.Maximum = 255;
            greenSlider.Name = "greenSlider";
            greenSlider.Size = new Size(673, 45);
            greenSlider.TabIndex = 9;
            greenSlider.TickStyle = TickStyle.None;
            greenSlider.Value = 255;
            greenSlider.Scroll += greenSlider_Scroll;
            // 
            // blueSlider
            // 
            blueSlider.Location = new Point(61, 297);
            blueSlider.Maximum = 255;
            blueSlider.Name = "blueSlider";
            blueSlider.Size = new Size(673, 45);
            blueSlider.TabIndex = 10;
            blueSlider.TickStyle = TickStyle.None;
            blueSlider.Value = 255;
            blueSlider.Scroll += blueSlider_Scroll;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(290, 322);
            button1.Name = "button1";
            button1.Size = new Size(206, 49);
            button1.TabIndex = 11;
            button1.Text = "Pobierz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // valueLbl
            // 
            valueLbl.AutoSize = true;
            valueLbl.Font = new Font("Segoe UI", 12F);
            valueLbl.Location = new Point(58, 22);
            valueLbl.Name = "valueLbl";
            valueLbl.Size = new Size(105, 21);
            valueLbl.TabIndex = 12;
            valueLbl.Text = "255, 255, 255";
            // 
            // valueLblBackground
            // 
            valueLblBackground.BackColor = Color.White;
            valueLblBackground.Controls.Add(valueLbl);
            valueLblBackground.Location = new Point(281, 377);
            valueLblBackground.Name = "valueLblBackground";
            valueLblBackground.Size = new Size(224, 62);
            valueLblBackground.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(valueLblBackground);
            Controls.Add(button1);
            Controls.Add(blueSlider);
            Controls.Add(greenSlider);
            Controls.Add(redSlider);
            Controls.Add(blueValueLbl);
            Controls.Add(greenValueLbl);
            Controls.Add(redValueLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Wzornik kolorów RGB";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)redSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueSlider).EndInit();
            valueLblBackground.ResumeLayout(false);
            valueLblBackground.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label redValueLbl;
        private Label greenValueLbl;
        private Label blueValueLbl;
        private TrackBar redSlider;
        private TrackBar greenSlider;
        private TrackBar blueSlider;
        private Button button1;
        private Label valueLbl;
        private Panel valueLblBackground;
    }
}
