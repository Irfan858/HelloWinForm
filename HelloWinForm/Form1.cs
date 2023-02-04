namespace HelloWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sapa_Click(object sender, EventArgs e)
        {
            // Ambil Nama Dari TextBox
            String nama = tb_nama.Text;
            int umur = int.Parse(tb_umur.Text);

            // Message Box
            String title = "Hello Sapa";
            String message = "Halo " + nama + "\nUmur Anda "+umur+" Tahun";
            MessageBox.Show(message,title);
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_nama.Clear();
            tb_umur.Clear();
        }
    }
}