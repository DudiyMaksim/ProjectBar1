namespace horse_racing
{
    public partial class Form1 : Form
    {
        private List<ProgressBar> progressBars = new List<ProgressBar>();
        
        
        public Form1()
        {
            InitializeComponent();
            progressBars.Add(progressBar1);
            progressBars.Add(progressBar2);
            progressBars.Add(progressBar3);
            progressBars.Add(progressBar4);
            progressBars.Add(progressBar5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var progressbar in progressBars)
                Task.Run(() =>
                {
                    while (progressbar.Value != 100)
                    {
                        int step = rnd.Next(0, 5);
                        if (progressbar.Value + step > 100)
                        {
                            progressbar.Value = 100;
                        }
                        else
                        {
                            progressbar.Value += step;
                            Thread.Sleep(rnd.Next(0, 1000));
                        }
                    }
                });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
