namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �e�X�gToolStripMenuItem_Click(object sender, EventArgs e)
        {

            {
                //Form2 dialog = new Form2();
                //DialogResult ret = dialog.ShowDialog(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void �m�F_Click(object sender, EventArgs e)
        {
            this.�w�b�h��.Enabled = false;
            this.�{�f�B��.Enabled = true;
            this.����.Focus();
            this.����.SelectAll();
        }

        private void �L�����Z��_Click(object sender, EventArgs e)
        {
            this.�w�b�h��.Enabled = true;
            this.�{�f�B��.Enabled = false;
            this.�Ј��R�[�h.Focus();
            this.�Ј��R�[�h.SelectAll();
            // �L�����Z���Ȃ̂œ��͂����t�B�[���h�̃N���A
            this.����.Clear();
            this.���^.Clear();
            this.���N����.Value = DateTime.Now;

        }
    }
}