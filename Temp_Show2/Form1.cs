namespace Temp_Show2
{
    public partial class Form1 : Form

    
    {
        public Connect_Test Connect_Test;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect_Test = new Connect_Test();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_Test.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}