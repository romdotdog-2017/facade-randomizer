namespace facadecorruptor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directory = new System.Windows.Forms.Button();
            this.corrupt = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.tripVoice = new System.Windows.Forms.CheckBox();
            this.textures = new System.Windows.Forms.CheckBox();
            this.backup = new System.ComponentModel.BackgroundWorker();
            this.backupBar = new System.Windows.Forms.ProgressBar();
            this.facadeDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.backupButton = new System.Windows.Forms.Button();
            this.corruptBar = new System.Windows.Forms.ProgressBar();
            this.uncorruptBar = new System.Windows.Forms.ProgressBar();
            this.tripsAnimations = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tripGlobal = new System.Windows.Forms.CheckBox();
            this.tripGrace = new System.Windows.Forms.CheckBox();
            this.tripTrip = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.graceGlobal = new System.Windows.Forms.CheckBox();
            this.graceGrace = new System.Windows.Forms.CheckBox();
            this.graceTrip = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.globalGlobal = new System.Windows.Forms.CheckBox();
            this.globalGrace = new System.Windows.Forms.CheckBox();
            this.globalTrip = new System.Windows.Forms.CheckBox();
            this.graceVoice = new System.Windows.Forms.CheckBox();
            this.globalSounds = new System.Windows.Forms.CheckBox();
            this.gracesAnimations = new System.Windows.Forms.CheckBox();
            this.SeedEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SeedBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.corruptWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textureIncludeKeyboard = new System.Windows.Forms.RadioButton();
            this.textureExcludeKeyboard = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textureWine = new System.Windows.Forms.RadioButton();
            this.textureAll = new System.Windows.Forms.RadioButton();
            this.textureNoKeyboard = new System.Windows.Forms.RadioButton();
            this.uncorruptWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(13, 13);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(105, 23);
            this.directory.TabIndex = 0;
            this.directory.Text = "Game Directory";
            this.directory.UseVisualStyleBackColor = true;
            this.directory.Click += new System.EventHandler(this.directory_Click);
            // 
            // corrupt
            // 
            this.corrupt.Enabled = false;
            this.corrupt.Location = new System.Drawing.Point(13, 43);
            this.corrupt.Name = "corrupt";
            this.corrupt.Size = new System.Drawing.Size(75, 23);
            this.corrupt.TabIndex = 1;
            this.corrupt.Text = "Corrupt";
            this.corrupt.UseVisualStyleBackColor = true;
            this.corrupt.Click += new System.EventHandler(this.corrupt_Click);
            // 
            // reverse
            // 
            this.reverse.Enabled = false;
            this.reverse.Location = new System.Drawing.Point(12, 73);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(76, 23);
            this.reverse.TabIndex = 2;
            this.reverse.Text = "Uncorrupt";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(124, 15);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.ReadOnly = true;
            this.directoryBox.Size = new System.Drawing.Size(240, 20);
            this.directoryBox.TabIndex = 3;
            // 
            // tripVoice
            // 
            this.tripVoice.AutoSize = true;
            this.tripVoice.Location = new System.Drawing.Point(13, 131);
            this.tripVoice.Name = "tripVoice";
            this.tripVoice.Size = new System.Drawing.Size(80, 17);
            this.tripVoice.TabIndex = 4;
            this.tripVoice.Text = "Trip\'s voice";
            this.tripVoice.UseVisualStyleBackColor = true;
            // 
            // textures
            // 
            this.textures.AutoSize = true;
            this.textures.Location = new System.Drawing.Point(322, 131);
            this.textures.Name = "textures";
            this.textures.Size = new System.Drawing.Size(67, 17);
            this.textures.TabIndex = 5;
            this.textures.Text = "Textures";
            this.textures.UseVisualStyleBackColor = true;
            // 
            // backup
            // 
            this.backup.WorkerReportsProgress = true;
            this.backup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backup_DoWork);
            // 
            // backupBar
            // 
            this.backupBar.Location = new System.Drawing.Point(124, 102);
            this.backupBar.Name = "backupBar";
            this.backupBar.Size = new System.Drawing.Size(240, 23);
            this.backupBar.TabIndex = 6;
            // 
            // backupButton
            // 
            this.backupButton.Enabled = false;
            this.backupButton.Location = new System.Drawing.Point(12, 102);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(106, 23);
            this.backupButton.TabIndex = 7;
            this.backupButton.Text = "Backup Files";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // corruptBar
            // 
            this.corruptBar.Location = new System.Drawing.Point(95, 43);
            this.corruptBar.Maximum = 6;
            this.corruptBar.Name = "corruptBar";
            this.corruptBar.Size = new System.Drawing.Size(269, 23);
            this.corruptBar.TabIndex = 8;
            // 
            // uncorruptBar
            // 
            this.uncorruptBar.Location = new System.Drawing.Point(95, 73);
            this.uncorruptBar.Name = "uncorruptBar";
            this.uncorruptBar.Size = new System.Drawing.Size(269, 23);
            this.uncorruptBar.TabIndex = 9;
            // 
            // tripsAnimations
            // 
            this.tripsAnimations.AutoSize = true;
            this.tripsAnimations.Location = new System.Drawing.Point(395, 131);
            this.tripsAnimations.Name = "tripsAnimations";
            this.tripsAnimations.Size = new System.Drawing.Size(104, 17);
            this.tripsAnimations.TabIndex = 10;
            this.tripsAnimations.Text = "Trip\'s animations";
            this.tripsAnimations.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tripGlobal);
            this.groupBox1.Controls.Add(this.tripGrace);
            this.groupBox1.Controls.Add(this.tripTrip);
            this.groupBox1.Location = new System.Drawing.Point(13, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip\'s voice will be..";
            // 
            // tripGlobal
            // 
            this.tripGlobal.AutoSize = true;
            this.tripGlobal.Location = new System.Drawing.Point(7, 66);
            this.tripGlobal.Name = "tripGlobal";
            this.tripGlobal.Size = new System.Drawing.Size(122, 17);
            this.tripGlobal.TabIndex = 2;
            this.tripGlobal.Text = "Environment sounds";
            this.tripGlobal.UseVisualStyleBackColor = true;
            // 
            // tripGrace
            // 
            this.tripGrace.AutoSize = true;
            this.tripGrace.Location = new System.Drawing.Point(7, 43);
            this.tripGrace.Name = "tripGrace";
            this.tripGrace.Size = new System.Drawing.Size(91, 17);
            this.tripGrace.TabIndex = 1;
            this.tripGrace.Text = "Grace\'s voice";
            this.tripGrace.UseVisualStyleBackColor = true;
            // 
            // tripTrip
            // 
            this.tripTrip.AutoSize = true;
            this.tripTrip.Location = new System.Drawing.Point(7, 20);
            this.tripTrip.Name = "tripTrip";
            this.tripTrip.Size = new System.Drawing.Size(80, 17);
            this.tripTrip.TabIndex = 0;
            this.tripTrip.Text = "Trip\'s voice";
            this.tripTrip.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.graceGlobal);
            this.groupBox2.Controls.Add(this.graceGrace);
            this.groupBox2.Controls.Add(this.graceTrip);
            this.groupBox2.Location = new System.Drawing.Point(219, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grace\'s voice will be..";
            // 
            // graceGlobal
            // 
            this.graceGlobal.AutoSize = true;
            this.graceGlobal.Location = new System.Drawing.Point(6, 65);
            this.graceGlobal.Name = "graceGlobal";
            this.graceGlobal.Size = new System.Drawing.Size(122, 17);
            this.graceGlobal.TabIndex = 5;
            this.graceGlobal.Text = "Environment sounds";
            this.graceGlobal.UseVisualStyleBackColor = true;
            // 
            // graceGrace
            // 
            this.graceGrace.AutoSize = true;
            this.graceGrace.Location = new System.Drawing.Point(6, 42);
            this.graceGrace.Name = "graceGrace";
            this.graceGrace.Size = new System.Drawing.Size(91, 17);
            this.graceGrace.TabIndex = 4;
            this.graceGrace.Text = "Grace\'s voice";
            this.graceGrace.UseVisualStyleBackColor = true;
            // 
            // graceTrip
            // 
            this.graceTrip.AutoSize = true;
            this.graceTrip.Location = new System.Drawing.Point(6, 19);
            this.graceTrip.Name = "graceTrip";
            this.graceTrip.Size = new System.Drawing.Size(80, 17);
            this.graceTrip.TabIndex = 3;
            this.graceTrip.Text = "Trip\'s voice";
            this.graceTrip.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.globalGlobal);
            this.groupBox3.Controls.Add(this.globalGrace);
            this.groupBox3.Controls.Add(this.globalTrip);
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 90);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Environment Sounds will be..";
            // 
            // globalGlobal
            // 
            this.globalGlobal.AutoSize = true;
            this.globalGlobal.Location = new System.Drawing.Point(6, 65);
            this.globalGlobal.Name = "globalGlobal";
            this.globalGlobal.Size = new System.Drawing.Size(122, 17);
            this.globalGlobal.TabIndex = 5;
            this.globalGlobal.Text = "Environment sounds";
            this.globalGlobal.UseVisualStyleBackColor = true;
            // 
            // globalGrace
            // 
            this.globalGrace.AutoSize = true;
            this.globalGrace.Location = new System.Drawing.Point(6, 42);
            this.globalGrace.Name = "globalGrace";
            this.globalGrace.Size = new System.Drawing.Size(91, 17);
            this.globalGrace.TabIndex = 4;
            this.globalGrace.Text = "Grace\'s voice";
            this.globalGrace.UseVisualStyleBackColor = true;
            // 
            // globalTrip
            // 
            this.globalTrip.AutoSize = true;
            this.globalTrip.Location = new System.Drawing.Point(6, 19);
            this.globalTrip.Name = "globalTrip";
            this.globalTrip.Size = new System.Drawing.Size(80, 17);
            this.globalTrip.TabIndex = 3;
            this.globalTrip.Text = "Trip\'s voice";
            this.globalTrip.UseVisualStyleBackColor = true;
            // 
            // graceVoice
            // 
            this.graceVoice.AutoSize = true;
            this.graceVoice.Location = new System.Drawing.Point(99, 131);
            this.graceVoice.Name = "graceVoice";
            this.graceVoice.Size = new System.Drawing.Size(91, 17);
            this.graceVoice.TabIndex = 15;
            this.graceVoice.Text = "Grace\'s voice";
            this.graceVoice.UseVisualStyleBackColor = true;
            // 
            // globalSounds
            // 
            this.globalSounds.AutoSize = true;
            this.globalSounds.Location = new System.Drawing.Point(194, 131);
            this.globalSounds.Name = "globalSounds";
            this.globalSounds.Size = new System.Drawing.Size(122, 17);
            this.globalSounds.TabIndex = 16;
            this.globalSounds.Text = "Environment sounds";
            this.globalSounds.UseVisualStyleBackColor = true;
            // 
            // gracesAnimations
            // 
            this.gracesAnimations.AutoSize = true;
            this.gracesAnimations.Location = new System.Drawing.Point(505, 131);
            this.gracesAnimations.Name = "gracesAnimations";
            this.gracesAnimations.Size = new System.Drawing.Size(115, 17);
            this.gracesAnimations.TabIndex = 17;
            this.gracesAnimations.Text = "Grace\'s animations";
            this.gracesAnimations.UseVisualStyleBackColor = true;
            // 
            // SeedEntry
            // 
            this.SeedEntry.Location = new System.Drawing.Point(409, 15);
            this.SeedEntry.Name = "SeedEntry";
            this.SeedEntry.Size = new System.Drawing.Size(198, 20);
            this.SeedEntry.TabIndex = 19;
            this.SeedEntry.Text = "(please change for different corruptions)";
            this.SeedEntry.TextChanged += new System.EventHandler(this.SeedEntry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seed:";
            // 
            // SeedBox
            // 
            this.SeedBox.Location = new System.Drawing.Point(445, 42);
            this.SeedBox.Name = "SeedBox";
            this.SeedBox.ReadOnly = true;
            this.SeedBox.Size = new System.Drawing.Size(162, 20);
            this.SeedBox.TabIndex = 21;
            this.SeedBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Actual Seed:";
            // 
            // corruptWorker
            // 
            this.corruptWorker.WorkerReportsProgress = true;
            this.corruptWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.corruptWorker_DoWork);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textureExcludeKeyboard);
            this.groupBox5.Controls.Add(this.textureIncludeKeyboard);
            this.groupBox5.Location = new System.Drawing.Point(425, 154);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 72);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Keyboard";
            // 
            // textureIncludeKeyboard
            // 
            this.textureIncludeKeyboard.AutoSize = true;
            this.textureIncludeKeyboard.Location = new System.Drawing.Point(7, 20);
            this.textureIncludeKeyboard.Name = "textureIncludeKeyboard";
            this.textureIncludeKeyboard.Size = new System.Drawing.Size(152, 17);
            this.textureIncludeKeyboard.TabIndex = 0;
            this.textureIncludeKeyboard.TabStop = true;
            this.textureIncludeKeyboard.Text = "Replace keyboard textures";
            this.textureIncludeKeyboard.UseVisualStyleBackColor = true;
            // 
            // textureExcludeKeyboard
            // 
            this.textureExcludeKeyboard.AutoSize = true;
            this.textureExcludeKeyboard.Checked = true;
            this.textureExcludeKeyboard.Location = new System.Drawing.Point(7, 43);
            this.textureExcludeKeyboard.Name = "textureExcludeKeyboard";
            this.textureExcludeKeyboard.Size = new System.Drawing.Size(175, 17);
            this.textureExcludeKeyboard.TabIndex = 1;
            this.textureExcludeKeyboard.TabStop = true;
            this.textureExcludeKeyboard.Text = "Don\'t replace keyboard textures";
            this.textureExcludeKeyboard.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textureNoKeyboard);
            this.groupBox6.Controls.Add(this.textureAll);
            this.groupBox6.Controls.Add(this.textureWine);
            this.groupBox6.Location = new System.Drawing.Point(219, 250);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 90);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Textures";
            // 
            // textureWine
            // 
            this.textureWine.AutoSize = true;
            this.textureWine.Location = new System.Drawing.Point(7, 41);
            this.textureWine.Name = "textureWine";
            this.textureWine.Size = new System.Drawing.Size(155, 17);
            this.textureWine.TabIndex = 0;
            this.textureWine.TabStop = true;
            this.textureWine.Text = "Use only wineglass textures";
            this.textureWine.UseVisualStyleBackColor = true;
            // 
            // textureAll
            // 
            this.textureAll.AutoSize = true;
            this.textureAll.Location = new System.Drawing.Point(7, 19);
            this.textureAll.Name = "textureAll";
            this.textureAll.Size = new System.Drawing.Size(108, 17);
            this.textureAll.TabIndex = 2;
            this.textureAll.TabStop = true;
            this.textureAll.Text = "Use every texture";
            this.textureAll.UseVisualStyleBackColor = true;
            // 
            // textureNoKeyboard
            // 
            this.textureNoKeyboard.AutoSize = true;
            this.textureNoKeyboard.Checked = true;
            this.textureNoKeyboard.Location = new System.Drawing.Point(7, 63);
            this.textureNoKeyboard.Name = "textureNoKeyboard";
            this.textureNoKeyboard.Size = new System.Drawing.Size(190, 17);
            this.textureNoKeyboard.TabIndex = 3;
            this.textureNoKeyboard.TabStop = true;
            this.textureNoKeyboard.Text = "Use every texture except keyboard";
            this.textureNoKeyboard.UseVisualStyleBackColor = true;
            // 
            // uncorruptWorker
            // 
            this.uncorruptWorker.WorkerReportsProgress = true;
            this.uncorruptWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.uncorruptWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 353);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeedEntry);
            this.Controls.Add(this.gracesAnimations);
            this.Controls.Add(this.globalSounds);
            this.Controls.Add(this.graceVoice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tripsAnimations);
            this.Controls.Add(this.uncorruptBar);
            this.Controls.Add(this.corruptBar);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.backupBar);
            this.Controls.Add(this.textures);
            this.Controls.Add(this.tripVoice);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.corrupt);
            this.Controls.Add(this.directory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Facade Corruptor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.Button corrupt;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.CheckBox tripVoice;
        private System.Windows.Forms.CheckBox textures;
        private System.ComponentModel.BackgroundWorker backup;
        private System.Windows.Forms.ProgressBar backupBar;
        private System.Windows.Forms.FolderBrowserDialog facadeDirectory;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.ProgressBar corruptBar;
        private System.Windows.Forms.ProgressBar uncorruptBar;
        private System.Windows.Forms.CheckBox tripsAnimations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox tripGlobal;
        private System.Windows.Forms.CheckBox tripGrace;
        private System.Windows.Forms.CheckBox tripTrip;
        private System.Windows.Forms.CheckBox graceGlobal;
        private System.Windows.Forms.CheckBox graceGrace;
        private System.Windows.Forms.CheckBox graceTrip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox globalGlobal;
        private System.Windows.Forms.CheckBox globalGrace;
        private System.Windows.Forms.CheckBox globalTrip;
        private System.Windows.Forms.CheckBox graceVoice;
        private System.Windows.Forms.CheckBox globalSounds;
        private System.Windows.Forms.CheckBox gracesAnimations;
        private System.Windows.Forms.TextBox SeedEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeedBox;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker corruptWorker;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton textureExcludeKeyboard;
        private System.Windows.Forms.RadioButton textureIncludeKeyboard;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton textureAll;
        private System.Windows.Forms.RadioButton textureWine;
        private System.Windows.Forms.RadioButton textureNoKeyboard;
        private System.ComponentModel.BackgroundWorker uncorruptWorker;
    }
}

