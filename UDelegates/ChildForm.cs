using Timer = System.Windows.Forms.Timer;

namespace UDelegates
{
    public delegate void onReadyDelegate(string message);
    public partial class ChildForm : Form
    {
        private Timer timer;
        private int _Seconds = 0;
        private int _TimesSeconds = 0;
        private int _Span = 0;
        private onReadyDelegate _onReady;

        public event EventHandler <string> TimerSeconds;
        public ChildForm(int span, onReadyDelegate onReady)
        {
            InitializeComponent();
            _Span = span;
            _onReady = onReady;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            LblCounterSec.Text = $"{++_Seconds} sec";
            if (_Seconds == _Span) 
            { 
                ++_TimesSeconds;
                _onReady.Invoke($"{_TimesSeconds} x {_Span}" +
                    $" Seconds elapsed!");

                _Seconds -= _Span; 
            }
            TimerSeconds.Invoke(this,$"{_TimesSeconds}");
            //Refresh();
        }

        private void CmdCloseChildForm_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Close();
        }
    }
}
