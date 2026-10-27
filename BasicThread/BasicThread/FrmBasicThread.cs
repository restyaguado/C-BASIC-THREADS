namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
            MyThreadClass.Output = Log;
        }

        private void Log(string text)
        {
            Invoke(() => lstOutput.Items.Add(text));
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            lstOutput.Items.Clear();
            lblStatus.Text = "-Before starting thread-";
            lstOutput.Items.Add("-Before starting thread-");

            Thread main = new Thread(() =>
            {
                ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
                Thread ThreadA = new Thread(delThread);
                Thread ThreadB = new Thread(delThread);
                ThreadA.Name = "Thread A Process";
                ThreadB.Name = "Thread B Process";

                ThreadA.Start();
                ThreadB.Start();

                ThreadA.Join();
                ThreadB.Join();

                Invoke(() =>
                {
                    lstOutput.Items.Add("-End of Thread-");
                    lblStatus.Text = "      -End of Thread-       ";
                    btnRun.Enabled = true;
                });
            });
            main.Start();
        }
    }
}
