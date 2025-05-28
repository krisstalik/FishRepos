namespace Laba1_Nujin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void B_Resize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void B_Opacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
