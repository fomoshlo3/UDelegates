namespace UDelegates
{
    public partial class MainForm : Form
    {
        private ChildForm? _childForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void WriteToLblCountTimesSec(string message)
        {
            LblCountTimesSec.Text = message;
        }

        private void WriteToLblSeconds(object sender, string message)
        {
            LblSeconds.Text = message; 
        }
        
        private void CmdOpenChildForm_Click(object sender, EventArgs e)
        {
            _childForm = new ChildForm(Convert.ToInt32(TbSpan.Text),WriteToLblCountTimesSec);
            _childForm.TimerSeconds += WriteToLblSeconds;
            _childForm.Show();
        }
    }
}