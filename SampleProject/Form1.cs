using System.Windows.Forms;
using Tupy.Jobs;
using Tupy.Logger;
using Tupy.Logger.Providers;

namespace SampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PrepareLog();

            rdbError.Checked = true;
        }

        private void PrepareLog()
        {
            var provtextf = new TextFileProvider()
            {
                FolderPath = @"c:\temp"
            };
            LoggerOrchestrator.ProviderManager.Add(provtextf);


            var srcinfinite = new EventSource()
            {
                Name = "InfiniteRetentionPeriod",
                MinimumRetention = 0
            };

            var src5minutes = new EventSource()
            {
                Name = "FiveMinutes",
                MinimumRetention = 5,
                RetentionPeriodoType = FrequencyOptions.Minute
            };

            var src1hour = new EventSource()
            {
                Name = "OneHour",
                MinimumRetention = 5,
                RetentionPeriodoType = FrequencyOptions.Minute
            };

            LoggerOrchestrator.AddEventSource(srcinfinite);
            LoggerOrchestrator.AddEventSource(src5minutes);
            LoggerOrchestrator.AddEventSource(src1hour);

            LoggerOrchestrator.Start();
        }

        private void AutoLogWrite()
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoggerOrchestrator.Stop();
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            var src = "";
            EventEntryTypes type = EventEntryTypes.Error;

            if (rdbError.Checked)
            {
                src = "InfiniteRetentionPeriod";
                type = EventEntryTypes.Error;
            }
            else if (rdbWarning.Checked)
            {
                src = "FiveMinutes";
                type = EventEntryTypes.Warning;
            }
            else if (rdbInformation.Checked)
            {
                src = "OneHour";
                type = EventEntryTypes.Information;
            }

            Logger.WriteEntry(src, txtMessage.Text, type);
        }
    }
}
