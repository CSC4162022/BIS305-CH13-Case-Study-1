namespace GreenvilleRevenueGUI
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
            this.submitContestantNum = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.contestantNum = new System.Windows.Forms.TextBox();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.displayResultlbl = new System.Windows.Forms.Label();
            this.txtContestantTalentCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContestantAge = new System.Windows.Forms.TextBox();
            this.btnSubmitContestantData = new System.Windows.Forms.Button();
            this.lblDisplayContestantNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContestantName = new System.Windows.Forms.TextBox();
            this.btnGetResults = new System.Windows.Forms.Button();
            this.lblRemainingContestants = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitContestantNum
            // 
            this.submitContestantNum.Location = new System.Drawing.Point(5, 129);
            this.submitContestantNum.Name = "submitContestantNum";
            this.submitContestantNum.Size = new System.Drawing.Size(196, 23);
            this.submitContestantNum.TabIndex = 0;
            this.submitContestantNum.Text = "Submit Contestant Number";
            this.submitContestantNum.UseVisualStyleBackColor = true;
            this.submitContestantNum.Click += new System.EventHandler(this.submitContestantsNum_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(65, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contestantNum
            // 
            this.contestantNum.Location = new System.Drawing.Point(5, 94);
            this.contestantNum.Name = "contestantNum";
            this.contestantNum.Size = new System.Drawing.Size(196, 20);
            this.contestantNum.TabIndex = 2;
            // 
            // Resultlbl
            // 
            this.Resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Resultlbl.Location = new System.Drawing.Point(566, 133);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(471, 318);
            this.Resultlbl.TabIndex = 7;
            // 
            // displayResultlbl
            // 
            this.displayResultlbl.AutoSize = true;
            this.displayResultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.displayResultlbl.Location = new System.Drawing.Point(963, 107);
            this.displayResultlbl.Name = "displayResultlbl";
            this.displayResultlbl.Size = new System.Drawing.Size(52, 17);
            this.displayResultlbl.TabIndex = 8;
            this.displayResultlbl.Text = "Result:";
            // 
            // txtContestantTalentCode
            // 
            this.txtContestantTalentCode.Location = new System.Drawing.Point(233, 140);
            this.txtContestantTalentCode.Name = "txtContestantTalentCode";
            this.txtContestantTalentCode.Size = new System.Drawing.Size(146, 20);
            this.txtContestantTalentCode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(230, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter a talent code for the corresponding talent string";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(230, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Singing = S, Dancing = D, Musing = M, Other = O";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(230, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter the age of the contestant";
            // 
            // txtContestantAge
            // 
            this.txtContestantAge.Location = new System.Drawing.Point(233, 203);
            this.txtContestantAge.Name = "txtContestantAge";
            this.txtContestantAge.Size = new System.Drawing.Size(146, 20);
            this.txtContestantAge.TabIndex = 13;
            // 
            // btnSubmitContestantData
            // 
            this.btnSubmitContestantData.Location = new System.Drawing.Point(233, 303);
            this.btnSubmitContestantData.Name = "btnSubmitContestantData";
            this.btnSubmitContestantData.Size = new System.Drawing.Size(100, 23);
            this.btnSubmitContestantData.TabIndex = 14;
            this.btnSubmitContestantData.Text = "Submit contestant data";
            this.btnSubmitContestantData.UseVisualStyleBackColor = true;
            this.btnSubmitContestantData.Click += new System.EventHandler(this.btnSubmitContestantData_Click);
            // 
            // lblDisplayContestantNum
            // 
            this.lblDisplayContestantNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDisplayContestantNum.Location = new System.Drawing.Point(12, 29);
            this.lblDisplayContestantNum.Name = "lblDisplayContestantNum";
            this.lblDisplayContestantNum.Size = new System.Drawing.Size(353, 31);
            this.lblDisplayContestantNum.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(230, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter the name of the contestant";
            // 
            // txtContestantName
            // 
            this.txtContestantName.Location = new System.Drawing.Point(233, 247);
            this.txtContestantName.Name = "txtContestantName";
            this.txtContestantName.Size = new System.Drawing.Size(146, 20);
            this.txtContestantName.TabIndex = 17;
            // 
            // btnGetResults
            // 
            this.btnGetResults.Location = new System.Drawing.Point(233, 347);
            this.btnGetResults.Name = "btnGetResults";
            this.btnGetResults.Size = new System.Drawing.Size(100, 23);
            this.btnGetResults.TabIndex = 18;
            this.btnGetResults.Text = "Get Results";
            this.btnGetResults.UseVisualStyleBackColor = true;
            this.btnGetResults.Click += new System.EventHandler(this.btnGetResults_Click);
            // 
            // lblRemainingContestants
            // 
            this.lblRemainingContestants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRemainingContestants.Location = new System.Drawing.Point(231, 29);
            this.lblRemainingContestants.Name = "lblRemainingContestants";
            this.lblRemainingContestants.Size = new System.Drawing.Size(353, 31);
            this.lblRemainingContestants.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(2, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "1) Enter # contestants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(231, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "2) Enter contestant information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRemainingContestants);
            this.Controls.Add(this.btnGetResults);
            this.Controls.Add(this.txtContestantName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDisplayContestantNum);
            this.Controls.Add(this.btnSubmitContestantData);
            this.Controls.Add(this.txtContestantAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContestantTalentCode);
            this.Controls.Add(this.displayResultlbl);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.contestantNum);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitContestantNum);
            this.Name = "Form1";
            this.Text = "Greenville Talent Contest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitContestantNum;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox contestantNum;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Label displayResultlbl;
        private System.Windows.Forms.TextBox txtContestantTalentCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContestantAge;
        private System.Windows.Forms.Button btnSubmitContestantData;
        private System.Windows.Forms.Label lblDisplayContestantNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContestantName;
        private System.Windows.Forms.Button btnGetResults;
        private System.Windows.Forms.Label lblRemainingContestants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}

