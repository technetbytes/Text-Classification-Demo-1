namespace MLDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnPositive = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.lstTweets = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTweet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSentiment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTestTweet = new System.Windows.Forms.Button();
            this.txtTestTweet = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNegativeTweets = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblPositiveTweets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNegative = new System.Windows.Forms.ListBox();
            this.btnAddTrainTweet = new System.Windows.Forms.Button();
            this.txtTrainTweet = new System.Windows.Forms.TextBox();
            this.lstPositive = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblClassificationType = new System.Windows.Forms.Label();
            this.lblClassify = new System.Windows.Forms.Label();
            this.btnSubmitEmailData = new System.Windows.Forms.Button();
            this.txtEmailData = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnNegative);
            this.tabPage1.Controls.Add(this.btnPositive);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tweets Sentiment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(92, 11);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(75, 23);
            this.btnNegative.TabIndex = 7;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnPositive
            // 
            this.btnPositive.Location = new System.Drawing.Point(11, 11);
            this.btnPositive.Name = "btnPositive";
            this.btnPositive.Size = new System.Drawing.Size(75, 23);
            this.btnPositive.TabIndex = 6;
            this.btnPositive.Text = "Positive";
            this.btnPositive.UseVisualStyleBackColor = true;
            this.btnPositive.Click += new System.EventHandler(this.btnPositive_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessages);
            this.groupBox2.Controls.Add(this.lstTweets);
            this.groupBox2.Controls.Add(this.btnSentiment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddTestTweet);
            this.groupBox2.Controls.Add(this.txtTestTweet);
            this.groupBox2.Location = new System.Drawing.Point(8, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 285);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test sets";
            // 
            // txtMessages
            // 
            this.txtMessages.BackColor = System.Drawing.Color.Black;
            this.txtMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMessages.Location = new System.Drawing.Point(6, 210);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(735, 74);
            this.txtMessages.TabIndex = 16;
            // 
            // lstTweets
            // 
            this.lstTweets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTweets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTweet,
            this.colStatus});
            this.lstTweets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTweets.FullRowSelect = true;
            this.lstTweets.GridLines = true;
            this.lstTweets.Location = new System.Drawing.Point(6, 73);
            this.lstTweets.MultiSelect = false;
            this.lstTweets.Name = "lstTweets";
            this.lstTweets.Size = new System.Drawing.Size(735, 137);
            this.lstTweets.TabIndex = 15;
            this.lstTweets.UseCompatibleStateImageBehavior = false;
            this.lstTweets.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 40;
            // 
            // colTweet
            // 
            this.colTweet.Text = "Tweets";
            this.colTweet.Width = 592;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 100;
            // 
            // btnSentiment
            // 
            this.btnSentiment.Location = new System.Drawing.Point(648, 30);
            this.btnSentiment.Name = "btnSentiment";
            this.btnSentiment.Size = new System.Drawing.Size(93, 23);
            this.btnSentiment.TabIndex = 7;
            this.btnSentiment.Text = "Sentiment";
            this.btnSentiment.UseVisualStyleBackColor = true;
            this.btnSentiment.Click += new System.EventHandler(this.btnSentiment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Test Tweets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tweet";
            // 
            // btnAddTestTweet
            // 
            this.btnAddTestTweet.Location = new System.Drawing.Point(378, 31);
            this.btnAddTestTweet.Name = "btnAddTestTweet";
            this.btnAddTestTweet.Size = new System.Drawing.Size(87, 23);
            this.btnAddTestTweet.TabIndex = 1;
            this.btnAddTestTweet.Text = "Add";
            this.btnAddTestTweet.UseVisualStyleBackColor = true;
            this.btnAddTestTweet.Click += new System.EventHandler(this.btnAddTestTweet_Click);
            // 
            // txtTestTweet
            // 
            this.txtTestTweet.Location = new System.Drawing.Point(8, 32);
            this.txtTestTweet.Name = "txtTestTweet";
            this.txtTestTweet.Size = new System.Drawing.Size(364, 21);
            this.txtTestTweet.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNegativeTweets);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.lblPositiveTweets);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstNegative);
            this.groupBox1.Controls.Add(this.btnAddTrainTweet);
            this.groupBox1.Controls.Add(this.txtTrainTweet);
            this.groupBox1.Controls.Add(this.lstPositive);
            this.groupBox1.Location = new System.Drawing.Point(8, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 296);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train sets";
            // 
            // lblNegativeTweets
            // 
            this.lblNegativeTweets.AutoSize = true;
            this.lblNegativeTweets.Location = new System.Drawing.Point(6, 174);
            this.lblNegativeTweets.Name = "lblNegativeTweets";
            this.lblNegativeTweets.Size = new System.Drawing.Size(94, 13);
            this.lblNegativeTweets.TabIndex = 7;
            this.lblNegativeTweets.Text = "Negative Tweet";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.cmbType.Location = new System.Drawing.Point(378, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(87, 21);
            this.cmbType.TabIndex = 3;
            // 
            // lblPositiveTweets
            // 
            this.lblPositiveTweets.AutoSize = true;
            this.lblPositiveTweets.Location = new System.Drawing.Point(5, 59);
            this.lblPositiveTweets.Name = "lblPositiveTweets";
            this.lblPositiveTweets.Size = new System.Drawing.Size(88, 13);
            this.lblPositiveTweets.TabIndex = 6;
            this.lblPositiveTweets.Text = "Positive Tweet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tweet";
            // 
            // lstNegative
            // 
            this.lstNegative.FormattingEnabled = true;
            this.lstNegative.Location = new System.Drawing.Point(6, 193);
            this.lstNegative.Name = "lstNegative";
            this.lstNegative.Size = new System.Drawing.Size(735, 95);
            this.lstNegative.TabIndex = 1;
            // 
            // btnAddTrainTweet
            // 
            this.btnAddTrainTweet.Location = new System.Drawing.Point(470, 31);
            this.btnAddTrainTweet.Name = "btnAddTrainTweet";
            this.btnAddTrainTweet.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrainTweet.TabIndex = 1;
            this.btnAddTrainTweet.Text = "Add";
            this.btnAddTrainTweet.UseVisualStyleBackColor = true;
            this.btnAddTrainTweet.Click += new System.EventHandler(this.btnAddTrainTweet_Click);
            // 
            // txtTrainTweet
            // 
            this.txtTrainTweet.Location = new System.Drawing.Point(8, 32);
            this.txtTrainTweet.Name = "txtTrainTweet";
            this.txtTrainTweet.Size = new System.Drawing.Size(364, 21);
            this.txtTrainTweet.TabIndex = 0;
            // 
            // lstPositive
            // 
            this.lstPositive.FormattingEnabled = true;
            this.lstPositive.Location = new System.Drawing.Point(6, 76);
            this.lstPositive.Name = "lstPositive";
            this.lstPositive.Size = new System.Drawing.Size(735, 95);
            this.lstPositive.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblClassificationType);
            this.tabPage2.Controls.Add(this.lblClassify);
            this.tabPage2.Controls.Add(this.btnSubmitEmailData);
            this.tabPage2.Controls.Add(this.txtEmailData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email Classification [Ham/Spam]";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblClassificationType
            // 
            this.lblClassificationType.AutoSize = true;
            this.lblClassificationType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificationType.ForeColor = System.Drawing.Color.Red;
            this.lblClassificationType.Location = new System.Drawing.Point(142, 602);
            this.lblClassificationType.Name = "lblClassificationType";
            this.lblClassificationType.Size = new System.Drawing.Size(54, 18);
            this.lblClassificationType.TabIndex = 3;
            this.lblClassificationType.Text = "None";
            // 
            // lblClassify
            // 
            this.lblClassify.AutoSize = true;
            this.lblClassify.Location = new System.Drawing.Point(8, 604);
            this.lblClassify.Name = "lblClassify";
            this.lblClassify.Size = new System.Drawing.Size(127, 13);
            this.lblClassify.TabIndex = 2;
            this.lblClassify.Text = "Classification Type :-";
            // 
            // btnSubmitEmailData
            // 
            this.btnSubmitEmailData.Location = new System.Drawing.Point(656, 599);
            this.btnSubmitEmailData.Name = "btnSubmitEmailData";
            this.btnSubmitEmailData.Size = new System.Drawing.Size(99, 23);
            this.btnSubmitEmailData.TabIndex = 1;
            this.btnSubmitEmailData.Text = "Submit Data";
            this.btnSubmitEmailData.UseVisualStyleBackColor = true;
            this.btnSubmitEmailData.Click += new System.EventHandler(this.btnSubmitEmailData_Click);
            // 
            // txtEmailData
            // 
            this.txtEmailData.AcceptsReturn = true;
            this.txtEmailData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmailData.Location = new System.Drawing.Point(7, 7);
            this.txtEmailData.Multiline = true;
            this.txtEmailData.Name = "txtEmailData";
            this.txtEmailData.Size = new System.Drawing.Size(748, 586);
            this.txtEmailData.TabIndex = 0;
            this.txtEmailData.Text = "sex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 656);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Science Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTrainTweet;
        private System.Windows.Forms.TextBox txtTrainTweet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNegativeTweets;
        private System.Windows.Forms.Label lblPositiveTweets;
        private System.Windows.Forms.ListBox lstNegative;
        private System.Windows.Forms.ListBox lstPositive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTestTweet;
        private System.Windows.Forms.TextBox txtTestTweet;
        private System.Windows.Forms.ListView lstTweets;
        private System.Windows.Forms.ColumnHeader colTweet;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Button btnSentiment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnPositive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Label lblClassificationType;
        private System.Windows.Forms.Label lblClassify;
        private System.Windows.Forms.Button btnSubmitEmailData;
        private System.Windows.Forms.TextBox txtEmailData;
    }
}

