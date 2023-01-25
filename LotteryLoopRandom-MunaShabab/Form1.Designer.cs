namespace LotteryLoopRandom_MunaShabab
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.thirdNumTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.generatedNumDesLabel = new System.Windows.Forms.Label();
            this.genFirstNumLabel = new System.Windows.Forms.Label();
            this.genSecondNumLabel = new System.Windows.Forms.Label();
            this.genThirdNumLabel = new System.Windows.Forms.Label();
            this.attemptNumDesLabel = new System.Windows.Forms.Label();
            this.attemptNumLabel = new System.Windows.Forms.Label();
            this.payDesLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.historyDesLabel = new System.Windows.Forms.Label();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(36, 18);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(142, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter The Winning Number :\r\n";
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(195, 15);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(19, 20);
            this.firstNumTextBox.TabIndex = 1;
            this.firstNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(220, 15);
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(19, 20);
            this.secondNumTextBox.TabIndex = 2;
            this.secondNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thirdNumTextBox
            // 
            this.thirdNumTextBox.Location = new System.Drawing.Point(245, 15);
            this.thirdNumTextBox.Name = "thirdNumTextBox";
            this.thirdNumTextBox.Size = new System.Drawing.Size(19, 20);
            this.thirdNumTextBox.TabIndex = 3;
            this.thirdNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(22, 53);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(300, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Generate Random Number / Try To Match Winning Number";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // generatedNumDesLabel
            // 
            this.generatedNumDesLabel.AutoSize = true;
            this.generatedNumDesLabel.Location = new System.Drawing.Point(36, 94);
            this.generatedNumDesLabel.Name = "generatedNumDesLabel";
            this.generatedNumDesLabel.Size = new System.Drawing.Size(161, 13);
            this.generatedNumDesLabel.TabIndex = 5;
            this.generatedNumDesLabel.Text = "My Generated Randon Number :";
            // 
            // genFirstNumLabel
            // 
            this.genFirstNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genFirstNumLabel.Location = new System.Drawing.Point(206, 84);
            this.genFirstNumLabel.Name = "genFirstNumLabel";
            this.genFirstNumLabel.Size = new System.Drawing.Size(21, 23);
            this.genFirstNumLabel.TabIndex = 6;
            this.genFirstNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genSecondNumLabel
            // 
            this.genSecondNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genSecondNumLabel.Location = new System.Drawing.Point(233, 84);
            this.genSecondNumLabel.Name = "genSecondNumLabel";
            this.genSecondNumLabel.Size = new System.Drawing.Size(22, 23);
            this.genSecondNumLabel.TabIndex = 7;
            this.genSecondNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genThirdNumLabel
            // 
            this.genThirdNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genThirdNumLabel.Location = new System.Drawing.Point(261, 84);
            this.genThirdNumLabel.Name = "genThirdNumLabel";
            this.genThirdNumLabel.Size = new System.Drawing.Size(23, 23);
            this.genThirdNumLabel.TabIndex = 8;
            this.genThirdNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attemptNumDesLabel
            // 
            this.attemptNumDesLabel.AutoSize = true;
            this.attemptNumDesLabel.Location = new System.Drawing.Point(36, 131);
            this.attemptNumDesLabel.Name = "attemptNumDesLabel";
            this.attemptNumDesLabel.Size = new System.Drawing.Size(191, 13);
            this.attemptNumDesLabel.TabIndex = 9;
            this.attemptNumDesLabel.Text = "Number of Match Attempt @ 1$ Each :\r\n";
            // 
            // attemptNumLabel
            // 
            this.attemptNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attemptNumLabel.Location = new System.Drawing.Point(233, 118);
            this.attemptNumLabel.Name = "attemptNumLabel";
            this.attemptNumLabel.Size = new System.Drawing.Size(59, 26);
            this.attemptNumLabel.TabIndex = 10;
            this.attemptNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payDesLabel
            // 
            this.payDesLabel.AutoSize = true;
            this.payDesLabel.Location = new System.Drawing.Point(36, 165);
            this.payDesLabel.Name = "payDesLabel";
            this.payDesLabel.Size = new System.Drawing.Size(123, 13);
            this.payDesLabel.TabIndex = 11;
            this.payDesLabel.Text = "Matching Number Pays :";
            // 
            // payLabel
            // 
            this.payLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.payLabel.Location = new System.Drawing.Point(233, 155);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(59, 23);
            this.payLabel.TabIndex = 12;
            this.payLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyDesLabel
            // 
            this.historyDesLabel.AutoSize = true;
            this.historyDesLabel.Location = new System.Drawing.Point(54, 203);
            this.historyDesLabel.Name = "historyDesLabel";
            this.historyDesLabel.Size = new System.Drawing.Size(136, 13);
            this.historyDesLabel.TabIndex = 13;
            this.historyDesLabel.Text = "History Of Match Attempts :";
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(57, 229);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(235, 160);
            this.historyListBox.TabIndex = 14;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(152, 416);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 451);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.historyDesLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.payDesLabel);
            this.Controls.Add(this.attemptNumLabel);
            this.Controls.Add(this.attemptNumDesLabel);
            this.Controls.Add(this.genThirdNumLabel);
            this.Controls.Add(this.genSecondNumLabel);
            this.Controls.Add(this.genFirstNumLabel);
            this.Controls.Add(this.generatedNumDesLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.thirdNumTextBox);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Lottery-Odds Are...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.TextBox thirdNumTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label generatedNumDesLabel;
        private System.Windows.Forms.Label genFirstNumLabel;
        private System.Windows.Forms.Label genSecondNumLabel;
        private System.Windows.Forms.Label genThirdNumLabel;
        private System.Windows.Forms.Label attemptNumDesLabel;
        private System.Windows.Forms.Label attemptNumLabel;
        private System.Windows.Forms.Label payDesLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label historyDesLabel;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button clearButton;
    }
}

