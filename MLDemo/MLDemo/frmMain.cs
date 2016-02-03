using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDemo
{
    public partial class Form1 : Form
    {
        string posFileName = string.Empty;
        string negFileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
        }

        private void btnPositive_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                posFileName = f.FileName;
                lstPositive.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;                    
                    while ((line = r.ReadLine()) != null)
                    {
                        lstPositive.Items.Add(line);
                    }
                }
                lblPositiveTweets.Text = string.Format("Positive Tweet ({0})", lstPositive.Items.Count);
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                negFileName = f.FileName;
                lstNegative.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lstNegative.Items.Add(line);
                    }
                }
                lblNegativeTweets.Text = string.Format("Negative Tweet ({0})", lstNegative.Items.Count);
            }
        }

        private void btnAddTrainTweet_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTrainTweet.Text))
            {
                // Zero for Positive Tweet
                if (cmbType.SelectedIndex == 0)
                {
                    lstPositive.Items.Add(txtTrainTweet.Text);
                }
                else// one for negative Tweet
                {
                    lstNegative.Items.Add(txtTrainTweet.Text);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            posFileName = string.Empty;
            negFileName = string.Empty;
            lstNegative.Items.Clear();
            lstPositive.Items.Clear();
            txtTrainTweet.Text = string.Empty;
            txtTestTweet.Text = string.Empty;
            lstTweets.Items.Clear();
            lblPositiveTweets.Text = "Positive Tweet";
            lblNegativeTweets.Text = "Negative Tweet";
        }

        private void btnAddTestTweet_Click(object sender, EventArgs e)
        {
            if (lstTweets.Items.Count > 0)
            {
                ListViewItem temp = lstTweets.Items[lstTweets.Items.Count - 1];
                if (!String.IsNullOrEmpty(txtTestTweet.Text))
                {
                    string val = string.Empty;
                    if (temp != null)
                        val = temp.Text;

                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(txtTestTweet.Text);
                    item.SubItems.Add("None");
                    item.Text = (Convert.ToInt32(val) + 1).ToString();
                    lstTweets.Items.Add(item);
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(txtTestTweet.Text))
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(txtTestTweet.Text);
                    item.SubItems.Add("None");
                    item.Text = "1";
                    lstTweets.Items.Add(item);
                }
            }
        }

        private void btnSentiment_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < lstPositive.Items.Count; i++)
            {
                data.Add(new KeyValuePair<string, string>(lstPositive.Items[i].ToString(),"Positive"));
            }

            for (int i = 0; i < lstNegative.Items.Count; i++)
            {
                data.Add(new KeyValuePair<string, string>(lstNegative.Items[i].ToString(), "Negative"));
            }

            WebClient2.AddTraining(data);
            txtMessages.Text = "Data add for training ..." + Environment.NewLine;
            WebClient2.GetFeature();
            txtMessages.Text += "Create internal dictionary ..." + Environment.NewLine;
            WebClient2.GetBuildtrainset();
            txtMessages.Text += "Build sentiment classifier ..." + Environment.NewLine;

            List<KeyValuePair<string, string>> testData = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < lstTweets.Items.Count; i++)
			{
                ListViewItem item = lstTweets.Items[i];
                testData.Add(new KeyValuePair<string, string>(item.Text, item.SubItems[1].Text));
			}           

            string[] sentiments = WebClient2.AddTestSet(testData);
            txtMessages.Text += "Following sentiments received ..." + Environment.NewLine;
            txtMessages.Text += string.Join(Environment.NewLine, sentiments);

            foreach (var sent in sentiments)
            {
                string[] vals = sent.Split(new char[] { ':' });
                if (vals.Length == 2)
                {
                    vals[0] = Regex.Replace(vals[0], @"\t|\n|\r| |\""", "");
                    vals[1] = Regex.Replace(vals[1], @"\t|\n|\r| |\""", "");
                    for (int i = 0; i < lstTweets.Items.Count; i++)
                    {
                        if (lstTweets.Items[i].Text == vals[0])
                        {
                            lstTweets.Items[i].SubItems[2].Text = vals[1];
                            break;
                        }
                    }
                }
            }
        }

        private void btnSubmitEmailData_Click(object sender, EventArgs e)
        {
            lblClassificationType.Text = WebClient2.ClassifyEmail(txtEmailData.Text);
        }
    }
}
