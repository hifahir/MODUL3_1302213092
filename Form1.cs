namespace Modul3_1302213092
{
    public partial class Form1 : Form
    {
        int angka;
        int temp;
        int hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text= label2.Text + "=";
            hasil = temp + angka;
            label2.Text = label2.Text + hasil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "0";
            angka = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";
            angka = 1;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
            angka = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "3";
            angka = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
            angka = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
            angka = 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
            angka = 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
            angka = 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";
            angka = 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";
            angka = 9;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "+";
            temp = angka;
            angka = 0;
        }
    }
}