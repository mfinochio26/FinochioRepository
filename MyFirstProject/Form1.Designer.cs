
namespace MyFirstProject
{
    partial class introduction
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introduction));
            this.messageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionColor = new System.Windows.Forms.Label();
            this.answerColor = new System.Windows.Forms.Label();
            this.answerColorButton = new System.Windows.Forms.Button();
            this.ageQuestion = new System.Windows.Forms.Label();
            this.ageAnswer = new System.Windows.Forms.Label();
            this.ageAnswerButton = new System.Windows.Forms.Button();
            this.goodBye = new System.Windows.Forms.Button();
            this.familyButton = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.familyButton)).BeginInit();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(227, 37);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(147, 29);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "NAME BUTTON";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-227, -115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press the button to learn my Name!";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TO LEARN MY NAME, PRESS BUTTON!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionColor
            // 
            this.questionColor.AutoSize = true;
            this.questionColor.Location = new System.Drawing.Point(46, 99);
            this.questionColor.Name = "questionColor";
            this.questionColor.Size = new System.Drawing.Size(217, 20);
            this.questionColor.TabIndex = 3;
            this.questionColor.Text = "WHAT IS MY FAVORITE COLOR?";
            // 
            // answerColor
            // 
            this.answerColor.BackColor = System.Drawing.SystemColors.Window;
            this.answerColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerColor.Location = new System.Drawing.Point(46, 134);
            this.answerColor.Name = "answerColor";
            this.answerColor.Size = new System.Drawing.Size(217, 39);
            this.answerColor.TabIndex = 4;
            this.answerColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerColorButton
            // 
            this.answerColorButton.Location = new System.Drawing.Point(102, 195);
            this.answerColorButton.Name = "answerColorButton";
            this.answerColorButton.Size = new System.Drawing.Size(94, 29);
            this.answerColorButton.TabIndex = 5;
            this.answerColorButton.Text = "ANSWER";
            this.answerColorButton.UseVisualStyleBackColor = true;
            this.answerColorButton.Click += new System.EventHandler(this.answerColorButton_Click);
            // 
            // ageQuestion
            // 
            this.ageQuestion.AutoSize = true;
            this.ageQuestion.Location = new System.Drawing.Point(393, 99);
            this.ageQuestion.Name = "ageQuestion";
            this.ageQuestion.Size = new System.Drawing.Size(120, 20);
            this.ageQuestion.TabIndex = 6;
            this.ageQuestion.Text = "HOW OLD AM I?";
            // 
            // ageAnswer
            // 
            this.ageAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.ageAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ageAnswer.Location = new System.Drawing.Point(340, 134);
            this.ageAnswer.Name = "ageAnswer";
            this.ageAnswer.Size = new System.Drawing.Size(219, 39);
            this.ageAnswer.TabIndex = 7;
            this.ageAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageAnswerButton
            // 
            this.ageAnswerButton.Location = new System.Drawing.Point(405, 195);
            this.ageAnswerButton.Name = "ageAnswerButton";
            this.ageAnswerButton.Size = new System.Drawing.Size(94, 29);
            this.ageAnswerButton.TabIndex = 8;
            this.ageAnswerButton.Text = "ANSWER";
            this.ageAnswerButton.UseVisualStyleBackColor = true;
            this.ageAnswerButton.Click += new System.EventHandler(this.ageAnswerButton_Click);
            // 
            // goodBye
            // 
            this.goodBye.Location = new System.Drawing.Point(479, 381);
            this.goodBye.Name = "goodBye";
            this.goodBye.Size = new System.Drawing.Size(125, 29);
            this.goodBye.TabIndex = 9;
            this.goodBye.Text = "PRESS BUTTON";
            this.goodBye.UseVisualStyleBackColor = true;
            this.goodBye.Click += new System.EventHandler(this.goodBye_Click);
            // 
            // familyButton
            // 
            this.familyButton.Image = ((System.Drawing.Image)(resources.GetObject("familyButton.Image")));
            this.familyButton.Location = new System.Drawing.Point(204, 243);
            this.familyButton.Name = "familyButton";
            this.familyButton.Size = new System.Drawing.Size(185, 121);
            this.familyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.familyButton.TabIndex = 10;
            this.familyButton.TabStop = false;
            this.familyButton.Click += new System.EventHandler(this.familyButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(227, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "CLICK THE PICTURE!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.familyButton);
            this.Controls.Add(this.goodBye);
            this.Controls.Add(this.ageAnswerButton);
            this.Controls.Add(this.ageAnswer);
            this.Controls.Add(this.ageQuestion);
            this.Controls.Add(this.answerColorButton);
            this.Controls.Add(this.answerColor);
            this.Controls.Add(this.questionColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageButton);
            this.Name = "introduction";
            this.Text = "MyFirstProject";
            ((System.ComponentModel.ISupportInitialize)(this.familyButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questionColor;
        private System.Windows.Forms.Label answerColor;
        private System.Windows.Forms.Button answerColorButton;
        private System.Windows.Forms.Label ageQuestion;
        private System.Windows.Forms.Label ageAnswer;
        private System.Windows.Forms.Button ageAnswerButton;
        private System.Windows.Forms.Button goodBye;
        private System.Windows.Forms.PictureBox familyButton;
        private System.Windows.Forms.Label label3;
    }
}

