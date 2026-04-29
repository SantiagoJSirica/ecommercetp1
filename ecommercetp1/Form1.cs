namespace ecommercetp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosMI_Click(object sender, EventArgs e)
        {

            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is UsuariosForm)
                {
                    hijo.Activate();
                    return;
                }
            }

            UsuariosForm form = new UsuariosForm();
            form.MdiParent = this;
            form.Show();

        }
    }
}
