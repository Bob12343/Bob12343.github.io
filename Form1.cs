namespace thebatman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            panel2.Hide();
            btnSI.TabStop = false;
            btnNO.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnSI.Width);
            int y = r.Next(0, this.Height - btnSI.Height);
            btnSI.Location = new Point(x, y);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSI_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnSI.Location == btnNO.Location || btnSI.Location == label1.Location)
            {
                MoverBoton();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }
    }
}