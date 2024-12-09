namespace ProgressBarRace
{
    public partial class Form1 : Form
    {
        private List<ProgressBar> progressBars = new List<ProgressBar>();
        private List<Label> labels = new List<Label>();
        private int finishOrder = 1;

        public Form1()
        {
            InitializeComponent();

            progressBars.Add(progressBar1);
            progressBars.Add(progressBar2);
            progressBars.Add(progressBar3);
            progressBars.Add(progressBar4);
            progressBars.Add(progressBar5);

            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < progressBars.Count; i++)
            {
                int index = i;
                ProgressBar progressBar = progressBars[index];
                Label label = labels[index];

                Task.Run(() =>
                {
                    while (progressBar.Value != 100)
                    {
                        int step = rnd.Next(1, 5);
                        progressBar.Invoke(new Action(() =>
                        {
                            if (progressBar.Value+step>100) {
                                progressBar.Value = 100;

                            }
                            else
                            {
                                progressBar.Value += step;
                            }
                        }));
                        Thread.Sleep(rnd.Next(100, 300));
                    }

                    label.Invoke(new Action(() =>
                    {
                        label.Text = finishOrder.ToString();
                        finishOrder++;
                    }));
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
