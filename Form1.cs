namespace ThaiThanhNhat_buoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVienIT sinhVienIT = new SinhVienIT();
            sinhVienIT.diemJava = double.Parse(txtjava.Text);
            sinhVienIT.diemCss = double.Parse(txtcss.Text);
            MessageBox.Show(sinhVienIT.getDiemTB().ToString() + sinhVienIT.xeploai());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinhVienBiz sinhVienBiz = new SinhVienBiz();
            sinhVienBiz.banhang = double.Parse(txtbanhang.Text);
            sinhVienBiz.ketoan = double.Parse(txtmaketting.Text);
            sinhVienBiz.marketting = double.Parse(txtketoan.Text);
            MessageBox.Show(sinhVienBiz.getDiemTB().ToString() + sinhVienBiz.xeploai());
        }
    }
}
