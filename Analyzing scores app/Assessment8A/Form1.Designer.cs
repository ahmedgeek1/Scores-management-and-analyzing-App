namespace Assessment8A
{
    partial class FormScoresAnalysis
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveFileAnalysis = new System.Windows.Forms.Button();
            this.btnOpenAndAnalyzeFile = new System.Windows.Forms.Button();
            this.lblThelowestTestScorePrompt = new System.Windows.Forms.Label();
            this.lblHighestTestScorePompt = new System.Windows.Forms.Label();
            this.lblAverageTestScorePrompt = new System.Windows.Forms.Label();
            this.lblTotalNumberOfScoresPrompt = new System.Windows.Forms.Label();
            this.lblAverageTestScoreOutput = new System.Windows.Forms.Label();
            this.lblTotalNumberOfScoreOutput = new System.Windows.Forms.Label();
            this.lblLowestTestScoreOutput = new System.Windows.Forms.Label();
            this.lblHighestTestScoreOutput = new System.Windows.Forms.Label();
            this.openFileDialogScores = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogScores = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(484, 467);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 57);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(219, 467);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 57);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveFileAnalysis
            // 
            this.btnSaveFileAnalysis.BackColor = System.Drawing.Color.Firebrick;
            this.btnSaveFileAnalysis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFileAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnSaveFileAnalysis.Location = new System.Drawing.Point(312, 385);
            this.btnSaveFileAnalysis.Name = "btnSaveFileAnalysis";
            this.btnSaveFileAnalysis.Size = new System.Drawing.Size(211, 57);
            this.btnSaveFileAnalysis.TabIndex = 2;
            this.btnSaveFileAnalysis.Text = "Save Analysis";
            this.btnSaveFileAnalysis.UseVisualStyleBackColor = false;
            this.btnSaveFileAnalysis.Click += new System.EventHandler(this.btnSaveFileAnalysis_Click);
            // 
            // btnOpenAndAnalyzeFile
            // 
            this.btnOpenAndAnalyzeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenAndAnalyzeFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAndAnalyzeFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenAndAnalyzeFile.Location = new System.Drawing.Point(56, 182);
            this.btnOpenAndAnalyzeFile.Name = "btnOpenAndAnalyzeFile";
            this.btnOpenAndAnalyzeFile.Size = new System.Drawing.Size(215, 55);
            this.btnOpenAndAnalyzeFile.TabIndex = 3;
            this.btnOpenAndAnalyzeFile.Text = "Open And Analyze a file";
            this.btnOpenAndAnalyzeFile.UseVisualStyleBackColor = false;
            this.btnOpenAndAnalyzeFile.Click += new System.EventHandler(this.btnOpenAndAnalyseFile_Click);
            // 
            // lblThelowestTestScorePrompt
            // 
            this.lblThelowestTestScorePrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThelowestTestScorePrompt.Location = new System.Drawing.Point(407, 279);
            this.lblThelowestTestScorePrompt.Name = "lblThelowestTestScorePrompt";
            this.lblThelowestTestScorePrompt.Size = new System.Drawing.Size(190, 59);
            this.lblThelowestTestScorePrompt.TabIndex = 4;
            this.lblThelowestTestScorePrompt.Text = "The Lowest Test Score";
            this.lblThelowestTestScorePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestTestScorePompt
            // 
            this.lblHighestTestScorePompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestTestScorePompt.Location = new System.Drawing.Point(407, 212);
            this.lblHighestTestScorePompt.Name = "lblHighestTestScorePompt";
            this.lblHighestTestScorePompt.Size = new System.Drawing.Size(193, 59);
            this.lblHighestTestScorePompt.TabIndex = 5;
            this.lblHighestTestScorePompt.Text = "The Highest Test Score";
            this.lblHighestTestScorePompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighestTestScorePompt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAverageTestScorePrompt
            // 
            this.lblAverageTestScorePrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageTestScorePrompt.Location = new System.Drawing.Point(407, 146);
            this.lblAverageTestScorePrompt.Name = "lblAverageTestScorePrompt";
            this.lblAverageTestScorePrompt.Size = new System.Drawing.Size(177, 59);
            this.lblAverageTestScorePrompt.TabIndex = 6;
            this.lblAverageTestScorePrompt.Text = "Average Test Score";
            this.lblAverageTestScorePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalNumberOfScoresPrompt
            // 
            this.lblTotalNumberOfScoresPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberOfScoresPrompt.Location = new System.Drawing.Point(407, 83);
            this.lblTotalNumberOfScoresPrompt.Name = "lblTotalNumberOfScoresPrompt";
            this.lblTotalNumberOfScoresPrompt.Size = new System.Drawing.Size(198, 59);
            this.lblTotalNumberOfScoresPrompt.TabIndex = 7;
            this.lblTotalNumberOfScoresPrompt.Text = "Total Number Of Scores";
            this.lblTotalNumberOfScoresPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageTestScoreOutput
            // 
            this.lblAverageTestScoreOutput.BackColor = System.Drawing.Color.White;
            this.lblAverageTestScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageTestScoreOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAverageTestScoreOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageTestScoreOutput.Location = new System.Drawing.Point(630, 167);
            this.lblAverageTestScoreOutput.Name = "lblAverageTestScoreOutput";
            this.lblAverageTestScoreOutput.Size = new System.Drawing.Size(174, 28);
            this.lblAverageTestScoreOutput.TabIndex = 11;
            this.lblAverageTestScoreOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalNumberOfScoreOutput
            // 
            this.lblTotalNumberOfScoreOutput.BackColor = System.Drawing.Color.White;
            this.lblTotalNumberOfScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNumberOfScoreOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalNumberOfScoreOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberOfScoreOutput.Location = new System.Drawing.Point(630, 104);
            this.lblTotalNumberOfScoreOutput.Name = "lblTotalNumberOfScoreOutput";
            this.lblTotalNumberOfScoreOutput.Size = new System.Drawing.Size(174, 32);
            this.lblTotalNumberOfScoreOutput.TabIndex = 12;
            this.lblTotalNumberOfScoreOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestTestScoreOutput
            // 
            this.lblLowestTestScoreOutput.BackColor = System.Drawing.Color.White;
            this.lblLowestTestScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowestTestScoreOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLowestTestScoreOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestTestScoreOutput.Location = new System.Drawing.Point(630, 300);
            this.lblLowestTestScoreOutput.Name = "lblLowestTestScoreOutput";
            this.lblLowestTestScoreOutput.Size = new System.Drawing.Size(174, 28);
            this.lblLowestTestScoreOutput.TabIndex = 13;
            this.lblLowestTestScoreOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestTestScoreOutput
            // 
            this.lblHighestTestScoreOutput.BackColor = System.Drawing.Color.White;
            this.lblHighestTestScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHighestTestScoreOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHighestTestScoreOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestTestScoreOutput.Location = new System.Drawing.Point(630, 233);
            this.lblHighestTestScoreOutput.Name = "lblHighestTestScoreOutput";
            this.lblHighestTestScoreOutput.Size = new System.Drawing.Size(174, 27);
            this.lblHighestTestScoreOutput.TabIndex = 14;
            this.lblHighestTestScoreOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialogScores
            // 
            this.openFileDialogScores.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(708, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(184, 18);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(475, 24);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Welcome To Our File Scores Analysis Application";
            // 
            // FormScoresAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(864, 554);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHighestTestScoreOutput);
            this.Controls.Add(this.lblLowestTestScoreOutput);
            this.Controls.Add(this.lblTotalNumberOfScoreOutput);
            this.Controls.Add(this.lblAverageTestScoreOutput);
            this.Controls.Add(this.lblTotalNumberOfScoresPrompt);
            this.Controls.Add(this.lblAverageTestScorePrompt);
            this.Controls.Add(this.lblHighestTestScorePompt);
            this.Controls.Add(this.lblThelowestTestScorePrompt);
            this.Controls.Add(this.btnOpenAndAnalyzeFile);
            this.Controls.Add(this.btnSaveFileAnalysis);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "FormScoresAnalysis";
            this.Text = "Scores Analysis";
            this.Load += new System.EventHandler(this.FormScoresAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveFileAnalysis;
        private System.Windows.Forms.Button btnOpenAndAnalyzeFile;
        private System.Windows.Forms.Label lblThelowestTestScorePrompt;
        private System.Windows.Forms.Label lblHighestTestScorePompt;
        private System.Windows.Forms.Label lblAverageTestScorePrompt;
        private System.Windows.Forms.Label lblTotalNumberOfScoresPrompt;
        private System.Windows.Forms.Label lblAverageTestScoreOutput;
        private System.Windows.Forms.Label lblTotalNumberOfScoreOutput;
        private System.Windows.Forms.Label lblLowestTestScoreOutput;
        private System.Windows.Forms.Label lblHighestTestScoreOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialogScores;
        private System.Windows.Forms.SaveFileDialog saveFileDialogScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
    }
}

