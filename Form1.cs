namespace cs_form_mtn_002_vs2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void テストToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 確認_Click(object sender, EventArgs e)
        {
            this.ヘッド部.Enabled = false;
            this.ボディ部.Enabled = true;
            this.氏名.Focus();
            this.氏名.SelectAll();
        }

        private void キャンセル_Click(object sender, EventArgs e)
        {
            this.ヘッド部.Enabled = true;
            this.ボディ部.Enabled = false;
            this.社員コード.Focus();
            this.社員コード.SelectAll();
            // キャンセルなので入力したフィールドのクリア
            this.氏名.Clear();
            this.給与.Clear();
            this.生年月日.Value = DateTime.Now;

        }
    }
}
