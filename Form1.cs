namespace WinFormTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.mostrarTabla();
        }

        private void mostrarTabla()
        {
            int n = Convert.ToInt32( this.textBoxNum.Text );
            string tabla = " ";
            for (int i = 1; i<=10; i++)
            {
                tabla = tabla + n + "*" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxResultado.AppendText(tabla);
        }
    }
}
