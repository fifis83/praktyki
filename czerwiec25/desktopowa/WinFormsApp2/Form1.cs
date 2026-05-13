namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redSlider_Scroll(object sender, EventArgs e)
        {
            redValueLbl.Text = redSlider.Value.ToString();
            updateRectangle();
        }

        private void greenSlider_Scroll(object sender, EventArgs e)
        {
            greenValueLbl.Text = greenSlider.Value.ToString();
            updateRectangle();
        }

        private void blueSlider_Scroll(object sender, EventArgs e)
        {
            blueValueLbl.Text = blueSlider.Value.ToString();
            updateRectangle();
        }

        private void updateRectangle()
        {
            panel1.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueLblBackground.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
            valueLbl.Text = $"{redSlider.Value}, {greenSlider.Value}, {blueSlider.Value}";
        }
    }
}
