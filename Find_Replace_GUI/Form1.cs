using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Find_Replace_GUI
{
        public partial class Form1 : Form
        {
                public Form1()
                {
                        InitializeComponent();
                }
                private void Form1_Load(object sender, EventArgs e)
                {
                        UsefulVariables.Directory = System.IO.Directory.GetCurrentDirectory();
                }
                private void ButtonReplace_Click(object sender, EventArgs e)
                {
                        UsefulVariables.DeepReplace = checkBoxSearchSubDirs.Checked;
                        UsefulVariables.FindThis = textBoxFind.Text;
                        UsefulVariables.ReplaceWithThis = textBoxReplace.Text;
                        ReplaceText();
                        if(UsefulVariables.ReplaceCount == 1)
                        {
                                MessageBox.Show(UsefulVariables.ReplaceCount + " filename with " + UsefulVariables.FindThis + " has had that text replaced with " + UsefulVariables.ReplaceWithThis);//For people with OCD around grammar
                        }
                        else
                        {
                                MessageBox.Show(UsefulVariables.ReplaceCount + " filenames with " + UsefulVariables.FindThis + " have had that text replaced with " + UsefulVariables.ReplaceWithThis);
                        }
                        
                }
                private void ReplaceText()
                {
                        string directoryPath = UsefulVariables.Directory;
                        string[] files;
                        if (UsefulVariables.DeepReplace)
                        {
                                files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
                        }
                        else
                        {
                                files = Directory.GetFiles(directoryPath, "*", SearchOption.TopDirectoryOnly);
                        }
                        // Use a regular expression for case-insensitive matching
                        Regex regex = new Regex(Regex.Escape(UsefulVariables.FindThis), RegexOptions.IgnoreCase);
                        UsefulVariables.ReplaceCount = 0;
                        foreach (string filePath in files)
                        {
                                string fileName = Path.GetFileName(filePath);
                                if (regex.IsMatch(fileName))
                                {
                                        string newFileName = regex.Replace(fileName, UsefulVariables.ReplaceWithThis);
                                        string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName);

                                        try
                                        {
                                                if (!File.Exists(newFilePath))
                                                {
                                                        File.Move(filePath, newFilePath);
                                                        UsefulVariables.ReplaceCount++;
                                                }
                                        }
                                        catch
                                        {
                                                // Silent failure, continue to next file if any errors occur
                                        }
                                }
                        }
                }
                private void ButtonSetDirectory_Click(object sender, EventArgs e)
                {
                        using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                        {
                                DialogResult result = folderBrowser.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                                {
                                        UsefulVariables.Directory = folderBrowser.SelectedPath;
                                }
                                else
                                {
                                        UsefulVariables.Directory = Directory.GetCurrentDirectory();
                                }
                        }
                }
                private void ButtonGitHub_Click(object sender, EventArgs e)
                {
                        Process.Start(new ProcessStartInfo
                        {
                                FileName = "https://github.com/frashure11",
                                UseShellExecute = true
                        });
                }
        }
        public class UsefulVariables
        {
                public static string Directory { get; set; }
                public static string FindThis { get; set; }
                public static string ReplaceWithThis { get; set; }
                public static bool DeepReplace { get; set; }
                public static int ReplaceCount { get; set; }
        }
}
