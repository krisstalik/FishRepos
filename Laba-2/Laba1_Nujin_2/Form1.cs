namespace Laba1_Nujin_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0),
                new Point(0, this.Height),
                new Point(this.Width, 0) });
            Region myRegion = new Region(myPath);
                this.Region = myRegion;
        }
    }
}
