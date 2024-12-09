namespace ProjectBar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ProgressBar> progressBars = new List<ProgressBar>();

        private void button1_Click(object sender, EventArgs e)
        {
            var progressbar = new ProgressBar();
            progressbar.Width = 500;
            progressbar.Location = new Point(50, (progressBars.Count) * 50);
            Controls.Add(progressbar);
            progressBars.Add(progressbar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var progressbar in progressBars)
                Task.Run(() =>
                {
                    while (progressbar.Value != 100)
                    {
                        int step = rnd.Next(1, 5);
                        progressbar.Invoke(new Action(() =>
                        {
                            if (progressbar.Value + step > 100)
                            {
                                progressbar.Value = 100;

                            }
                            else
                            {
                                progressbar.Value += step;
                            }
                        }));
                        Thread.Sleep(rnd.Next(100, 300));
                    }
                });
        }
    }
}
