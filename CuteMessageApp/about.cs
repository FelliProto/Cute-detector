using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;

namespace CuteMessageApp
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        public static class TextFileFetcher
        {
            private static readonly HttpClient _httpClient = new HttpClient();

            public static async Task<string> FetchTextFileContentAsync(string url)
            {
                try
                {
                    HttpResponseMessage response = await _httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching text file: {ex.Message}");
                    return string.Empty;
                }
            }
        }

        private bool isFetching = false;
        //private readonly int cooldownSeconds = 5; ill implement this fully soon enough (dont ddos my server please)

        private async void label2_Click(object sender, EventArgs e)
        {
            if (isFetching)
                return;

            string url = "https://fproto.com/text.txt";

            try
            {
                label2.Text = "Loading...";
                string textContent = await TextFileFetcher.FetchTextFileContentAsync(url);

                if (!string.IsNullOrEmpty(textContent))
                {
                    string[] lines = textContent.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (lines.Length > 0)
                    {
                        Random random = new Random();
                        int randomIndex = random.Next(0, lines.Length);

                        label2.Text = lines[randomIndex];
                    }
                    else
                    {
                        label2.Text = "Text file is empty- server error?? please report to felliproto";
                    }
                }
                else
                {
                    label2.Text = "Failed to fetch data possible server outtage contact felliproto";
                }
            }
            catch (Exception ex)
            {
                label2.Text = $"Error fetching or displaying text: {ex.Message}";
            }
            finally
            {
                isFetching = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //i dont know if ill actually add anything here lol
        }

        private void label3_Click(object sender, EventArgs e) //last updated thingy will be made dynimaclly eventually
        {
            //label3.Text = $"Last updated: ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://felliproto.com";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = websiteUrl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"didn work cause: {ex.Message}");
            }
        }
    }
}
