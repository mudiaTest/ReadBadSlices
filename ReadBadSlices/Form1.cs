using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string prvErrFile = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            List<string> list;
            int dummy;

            if (tbError.Text != "")
            {
                StreamReader errFile = File.OpenText(tbError.Text);
                while (true)
                {
                    line = errFile.ReadLine();
                    if (errFile.EndOfStream) break;
                    list = line.Split('_').ToList();
                    if (list.Count == 2 )
                    {
                        if (int.TryParse(list[0], out dummy) && int.TryParse(list[1], out dummy))
                        {
                            cblSlices.Items.Add(line);
                        }
                    }
                }
                errFile.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < cblSlices.SelectedItems.Count; i++)
            {
            };*/
            String line;
            StreamReader koordynatyFile = File.OpenText(tbKoordynaty.Text);
            int lpFive = 0;
            String stKoor1 = "";
            String stKoor2 = "";
            String stKoor3 = "";
            String stKoor4 = "";
            String stSlice = "";
            while (true)
            {
                line = koordynatyFile.ReadLine();
                if (koordynatyFile.EndOfStream) break;
                if (lpFive == 0)
                {
                    foreach (string poz in cblSlices.CheckedItems)
                    {
                        if (poz == line)
                        {
                            stSlice = poz;
                            Info("Wczytano: " + poz);
                            lpFive = 5;
                        }
                    }
                }
                else
                {
                    if (lpFive == 4)
                    {
                        stKoor1 = line;
                    }
                    else if (lpFive == 3)
                    {
                        stKoor2 = line;
                    }
                    else if (lpFive == 2)
                    {
                        stKoor3 = line;
                    }
                    else if (lpFive == 1)
                    {
                        stKoor4 = line;
                        Info("Koordynaty dla " + stSlice + ": " + stKoor1 + ", " + stKoor2 + ", " + stKoor3 + ", " + stKoor4);
                        UpdateCfg(stSlice, stKoor1, stKoor2, stKoor3, stKoor4);
                        DownloadSlice(stSlice);
                    }
                    lpFive--;
                }
            }
            
        }

        private void UpdateCfg(string astSlice, string astKoor1, string astKoor2, string astKoor3, string astKoor4)
        {
            String stCfgFilePath = tbFolder.Text + "\\download\\conf.txt";
            string[] arrLine = File.ReadAllLines(stCfgFilePath);
            arrLine[2] = astKoor2;
            arrLine[3] = astKoor1;
            arrLine[4] = astKoor4;
            arrLine[5] = astKoor3;
            File.WriteAllLines(stCfgFilePath, arrLine);
        }

        private void DownloadSlice(string astSlice)
        {
            foreach (string file in Directory.EnumerateFiles(tbFolder.Text + "\\download"))
            {
                if (Path.GetExtension(file) != ".txt")
                    File.Delete(file);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = (tbFolder.Text+"\\MapoTero.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "-autoStartClose";
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }
            File.Copy(tbFolder.Text + "\\download\\01_01.jpg", tbFolder.Text + "\\" + astSlice + ".jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(prvErrFile)) 
                dlg1.InitialDirectory = prvErrFile;
            if (dlg1.ShowDialog() == DialogResult.OK)
                tbError.Text = dlg1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(prvErrFile))
                dlg1.InitialDirectory = prvErrFile;
            if (dlg1.ShowDialog() == DialogResult.OK)
                tbKoordynaty.Text = dlg1.FileName;
        }

        private void Info(String stText)
        {
            rbInfo.AppendText(stText + "\n");
            rbInfo.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbFolder.Text = dlg.SelectedPath;
            }
        }
    }
}
