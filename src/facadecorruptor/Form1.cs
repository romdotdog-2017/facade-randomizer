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

namespace facadecorruptor
{
    public partial class Form1 : Form
    {

        public Random rnd = new Random();
        string root = "";
        string sources = "";
        public Form1()
        {
            InitializeComponent();
            backup.ProgressChanged += new ProgressChangedEventHandler(backup_ProgressChanged);
            backup.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backup_RunWorkerCompleted);
            corruptWorker.ProgressChanged += new ProgressChangedEventHandler(corruptWorker_ProgressChanged);
            corruptWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(corruptWorker_RunWorkerCompleted);
            uncorruptWorker.ProgressChanged += new ProgressChangedEventHandler(uncorruptWorker_ProgressChanged);
            uncorruptWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(uncorruptWorker_RunWorkerCompleted);
        }

        private void backup_DoWork(object sender, DoWorkEventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(sources, "backup"));
            backup.ReportProgress(25);
            CopyDirectory(Path.Combine(sources, "animation"), Path.Combine(sources, @"backup\animation"));
            backup.ReportProgress(50);
            CopyDirectory(Path.Combine(sources, "textures"), Path.Combine(sources, @"backup\textures"));
            backup.ReportProgress(75);
            CopyDirectory(Path.Combine(sources, "Sounds"), Path.Combine(sources, @"backup\Sounds"));
            backup.ReportProgress(100);
        }

        private void backup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            backupBar.Value = e.ProgressPercentage;
        }

        private void corruptWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            corruptBar.Value = corruptBar.Value + e.ProgressPercentage;
        }

        private void corruptWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Facade Corruptions", "Done!");
        }

        private void uncorruptWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            uncorruptBar.Value = e.ProgressPercentage;
        }

        private void uncorruptWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Facade Corruptions", "Done with reset!");
        }

        private void backup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            corrupt.Enabled = true;
            reverse.Enabled = true;
        }

        private Stack<T> Shuffle<T>(Stack<T> stack)
        {
            return new Stack<T>(stack.OrderBy(x => rnd.Next()));
        }

        private void CopyDirectory(string source_dir, string destination_dir)
        {
            if (!Directory.Exists(destination_dir)) Directory.CreateDirectory(destination_dir);

            foreach (string dir in Directory.GetDirectories(source_dir, "*", SearchOption.AllDirectories))
            {
                var dirpath = Path.Combine(destination_dir, dir.Substring(source_dir.Length + 1));
                if (!Directory.Exists(dirpath)) Directory.CreateDirectory(dirpath);
            }

            foreach (string file_name in Directory.GetFiles(source_dir, "*", SearchOption.AllDirectories))
            {
                File.Copy(file_name, Path.Combine(destination_dir, file_name.Substring(source_dir.Length + 1)), true);
            }
        }

        private void directory_Click(object sender, EventArgs e)
        {
            facadeDirectory.ShowDialog();
            root = facadeDirectory.SelectedPath;
            sources = Path.Combine(root, @"util\sources\facade");
            directoryBox.Text = root;

            
            if (!Directory.Exists(Path.Combine(sources, "backup")))
            {
                backupButton.Enabled = true;
            } else
            {
                reverse.Enabled = true;
                corrupt.Enabled = true;
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            backup.RunWorkerAsync();
        }

        private void SeedEntry_TextChanged(object sender, EventArgs e)
        {
            var hash = SeedEntry.Text.GetHashCode();
            SeedBox.Text = hash.ToString();
            rnd = new Random(hash);
        }

        private void corrupt_Click(object sender, EventArgs e)
        {
            corruptWorker.RunWorkerAsync();
        }

        private void corruptWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Regex wine = new Regex(@"(beer|cola|drink|wine|liquor|martini|juice|pint)");
            Regex keyboard = new Regex(@"yellowfont");
            string texturesDirectory = Path.Combine(sources, @"textures");
            string backupTexturesDirectory = Path.Combine(sources, @"backup\textures");
            string tripVoiceDirectory = Path.Combine(sources, @"Sounds\trip");
            string graceVoiceDirectory = Path.Combine(sources, @"Sounds\grace");
            string globalSoundsDirectory = Path.Combine(sources, @"Sounds\global");
            string backupTripVoiceDirectory = Path.Combine(sources, @"backup\Sounds\trip");
            string backupGraceVoiceDirectory = Path.Combine(sources, @"backup\Sounds\grace");
            string backupGlobalSoundsDirectory = Path.Combine(sources, @"backup\Sounds\global");
            string tripAnimationDirectory = Path.Combine(sources, @"animation\trip");
            string graceAnimationDirectory = Path.Combine(sources, @"animation\grace");
            string backupTripAnimationDirectory = Path.Combine(sources, @"backup\animation\trip");
            string backupGraceAnimationDirectory = Path.Combine(sources, @"backup\animation\grace");
            corruptWorker.ReportProgress(1);
            //Do Trip's Voice
            if (tripVoice.Checked)
            {
                var tripVoiceReplace = new List<string>();

                if (tripTrip.Checked) //use backup directories because if it's corrupted already then it wont be accurate results
                {
                    tripVoiceReplace.AddRange(Directory.GetFiles(backupTripVoiceDirectory, "*.wav", SearchOption.AllDirectories));
                }
                if (tripGrace.Checked)
                {
                    tripVoiceReplace.AddRange(Directory.GetFiles(backupGraceVoiceDirectory, "*.wav", SearchOption.AllDirectories));
                }
                if (tripGlobal.Checked)
                {
                    tripVoiceReplace.AddRange(Directory.GetFiles(backupGlobalSoundsDirectory, "*.wav", SearchOption.AllDirectories));
                }

                var tripVoiceCorrupt = new Stack<string>();
                foreach (string file in tripVoiceReplace.ToArray())
                {
                    tripVoiceCorrupt.Push(file);
                }
                tripVoiceCorrupt = Shuffle(tripVoiceCorrupt);
                foreach (string file in Directory.GetFiles(tripVoiceDirectory, "*.wav", SearchOption.AllDirectories))
                {
                    if (tripVoiceCorrupt.Count < 1)
                    {
                        foreach (string refill in tripVoiceReplace.ToArray())
                        {
                            tripVoiceCorrupt.Push(refill);
                        }
                    }
                    File.Copy(tripVoiceCorrupt.Pop(), file, true);
                }
            }
            corruptWorker.ReportProgress(1);
            if (graceVoice.Checked)
            {
                //Do Grace's Voice

                var graceVoiceReplace = new List<string>();

                if (graceTrip.Checked) //use backup directories because if it's corrupted already then it wont be accurate results
                {
                    graceVoiceReplace.AddRange(Directory.GetFiles(backupTripVoiceDirectory, "*.wav", SearchOption.AllDirectories));
                }
                if (graceGrace.Checked)
                {
                    graceVoiceReplace.AddRange(Directory.GetFiles(backupGraceVoiceDirectory, "*.wav", SearchOption.AllDirectories));
                }
                if (graceGlobal.Checked)
                {
                    graceVoiceReplace.AddRange(Directory.GetFiles(backupGlobalSoundsDirectory, "*.wav", SearchOption.AllDirectories));
                }

                var graceVoiceCorrupt = new Stack<string>();
                foreach (string file in graceVoiceReplace.ToArray())
                {
                    graceVoiceCorrupt.Push(file);
                }
                graceVoiceCorrupt = Shuffle(graceVoiceCorrupt);
                foreach (string file in Directory.GetFiles(graceVoiceDirectory, "*.wav", SearchOption.AllDirectories))
                {
                    if (graceVoiceCorrupt.Count < 1)
                    {
                        foreach (string refill in graceVoiceReplace.ToArray())
                        {
                            graceVoiceCorrupt.Push(refill);
                        }
                    } 
                    File.Copy(graceVoiceCorrupt.Pop(), file, true);
                }
            }
            corruptWorker.ReportProgress(1);
            //Do Global Sounds
            if (globalSounds.Checked)
            {
                var globalSoundsReplace = new List<string>();

                if (globalTrip.Checked) //use backup directories because if it's corrupted already then it wont be accurate results
                {
                    globalSoundsReplace.AddRange(Directory.GetFiles(backupTripVoiceDirectory, "*.wav", SearchOption.AllDirectories));
                }
                if (globalGrace.Checked)
                {
                    globalSoundsReplace.AddRange(Directory.GetFiles(backupGraceVoiceDirectory, "*.wav", SearchOption.AllDirectories));
                }
                if (globalGlobal.Checked)
                {
                    globalSoundsReplace.AddRange(Directory.GetFiles(backupGlobalSoundsDirectory, "*.wav", SearchOption.AllDirectories));
                }

                var globalSoundsCorrupt = new Stack<string>();
                foreach (string file in globalSoundsReplace.ToArray())
                {
                    globalSoundsCorrupt.Push(file);
                }
                globalSoundsCorrupt = Shuffle(globalSoundsCorrupt);
                foreach (string file in Directory.GetFiles(globalSoundsDirectory, "*.wav", SearchOption.AllDirectories))
                {
                    if (globalSoundsCorrupt.Count < 1)
                    {
                        foreach (string refill in globalSoundsReplace.ToArray())
                        {
                            globalSoundsCorrupt.Push(refill);
                        }
                    }
                    File.Copy(globalSoundsCorrupt.Pop(), file, true);
                }
            }
            corruptWorker.ReportProgress(1);
            if (tripsAnimations.Checked)
            {
                //Do Trips Animations
                var tripAnimationCorrupt = new Stack<string>();
                var tripAnimationReplace = Directory.GetFiles(backupTripAnimationDirectory, "*.abinary", SearchOption.AllDirectories);
                foreach (string file in tripAnimationReplace)
                {
                    tripAnimationCorrupt.Push(file);
                }
                tripAnimationCorrupt = Shuffle(tripAnimationCorrupt);
                foreach (string file in Directory.GetFiles(tripAnimationDirectory, "*.abinary", SearchOption.AllDirectories))
                {
                    File.Copy(tripAnimationCorrupt.Pop(), file, true);
                }
            }
            corruptWorker.ReportProgress(1);
            if (gracesAnimations.Checked)
            {
                //Do Graces Animations
                var graceAnimationCorrupt = new Stack<string>();
                var graceAnimationReplace = Directory.GetFiles(backupGraceAnimationDirectory, "*.abinary", SearchOption.AllDirectories);
                foreach (string file in graceAnimationReplace)
                {
                    graceAnimationCorrupt.Push(file);
                }
                graceAnimationCorrupt = Shuffle(graceAnimationCorrupt);
                foreach (string file in Directory.GetFiles(graceAnimationDirectory, "*.abinary", SearchOption.AllDirectories))
                {
                    File.Copy(graceAnimationCorrupt.Pop(), file, true);
                }
            }
            corruptWorker.ReportProgress(1);
            if (textures.Checked)
            {
                var texturesReplace = new List<string>();
                if (textureWine.Checked)
                {
                    texturesReplace.AddRange(Directory.GetFiles(backupTexturesDirectory, "*.bmp", SearchOption.AllDirectories)
                     .Where(path => wine.IsMatch(path))
                     .ToArray());
                } else if (textureAll.Checked)
                {
                    texturesReplace.AddRange(Directory.GetFiles(backupTexturesDirectory, "*.bmp", SearchOption.AllDirectories));
                } else if (textureNoKeyboard.Checked)
                {
                    texturesReplace.AddRange(Directory.GetFiles(backupTexturesDirectory, "*.bmp", SearchOption.AllDirectories)
                     .Where(path => !keyboard.IsMatch(path))
                     .ToArray());
                }
                var texturesCorrupt = new Stack<string>();
                foreach (string file in texturesReplace)
                {
                    texturesCorrupt.Push(file);
                }
                texturesCorrupt = Shuffle(texturesCorrupt);
                if (textureIncludeKeyboard.Checked)
                {
                    foreach (string file in Directory.GetFiles(texturesDirectory, "*.bmp", SearchOption.AllDirectories))
                    {
                        File.Copy(texturesCorrupt.Pop(), file, true);
                    }
                } else if (textureExcludeKeyboard.Checked)
                {
                    
                    foreach (string file in Directory.GetFiles(texturesDirectory, "*.bmp")
                     .Where(path => !keyboard.IsMatch(path))
                     .ToArray())
                    {
                        File.Copy(texturesCorrupt.Pop(), file, true);
                    }
                }
            }
        }

        private void uncorruptWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            uncorruptWorker.ReportProgress(25);
            CopyDirectory(Path.Combine(sources, @"backup\animation"), Path.Combine(sources, "animation"));
            uncorruptWorker.ReportProgress(50);
            CopyDirectory(Path.Combine(sources, @"backup\textures"), Path.Combine(sources, "textures"));
            uncorruptWorker.ReportProgress(75);
            CopyDirectory(Path.Combine(sources, @"backup\Sounds"), Path.Combine(sources, "Sounds"));
            uncorruptWorker.ReportProgress(100);
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            uncorruptWorker.RunWorkerAsync();
        }
    }
}
