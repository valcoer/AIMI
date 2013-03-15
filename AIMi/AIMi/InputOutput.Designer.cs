namespace AIMind
{
    partial class InOut
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
            this.lblOutputLabel = new System.Windows.Forms.Label();
            this.inputWindow = new System.Windows.Forms.TextBox();
            this.YesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.btnListVocabulary = new System.Windows.Forms.Button();
            this.parse = new System.Windows.Forms.Button();
            this.lv_words = new System.Windows.Forms.ListView();
            this.lv_nouns = new System.Windows.Forms.ListView();
            this.lv_verbs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(306, 20);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutputLabel.Size = new System.Drawing.Size(131, 13);
            this.lblOutputLabel.TabIndex = 1;
            this.lblOutputLabel.Text = "my responses appear here";
            // 
            // inputWindow
            // 
            this.inputWindow.Location = new System.Drawing.Point(13, 13);
            this.inputWindow.Name = "inputWindow";
            this.inputWindow.Size = new System.Drawing.Size(259, 20);
            this.inputWindow.TabIndex = 2;
            this.inputWindow.Text = "type here";
            this.inputWindow.Enter += new System.EventHandler(this.inputWindow_EnterPressed);
            this.inputWindow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputWindow_KeyPress);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(12, 129);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Visible = false;
            this.YesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(111, 129);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 4;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // btnListVocabulary
            // 
            this.btnListVocabulary.Location = new System.Drawing.Point(111, 52);
            this.btnListVocabulary.Name = "btnListVocabulary";
            this.btnListVocabulary.Size = new System.Drawing.Size(98, 23);
            this.btnListVocabulary.TabIndex = 5;
            this.btnListVocabulary.Text = "List Vocabulary";
            this.btnListVocabulary.UseVisualStyleBackColor = true;
            this.btnListVocabulary.Click += new System.EventHandler(this.btnListVocabulary_Click);
            // 
            // parse
            // 
            this.parse.Location = new System.Drawing.Point(13, 52);
            this.parse.Name = "parse";
            this.parse.Size = new System.Drawing.Size(92, 23);
            this.parse.TabIndex = 6;
            this.parse.Text = "Parse sentence";
            this.parse.UseVisualStyleBackColor = true;
            this.parse.Click += new System.EventHandler(this.parse_Click);
            // 
            // lv_words
            // 
            this.lv_words.Location = new System.Drawing.Point(328, 52);
            this.lv_words.Name = "lv_words";
            this.lv_words.Size = new System.Drawing.Size(91, 198);
            this.lv_words.TabIndex = 7;
            this.lv_words.UseCompatibleStateImageBehavior = false;
            // 
            // lv_nouns
            // 
            this.lv_nouns.Location = new System.Drawing.Point(425, 52);
            this.lv_nouns.Name = "lv_nouns";
            this.lv_nouns.Size = new System.Drawing.Size(91, 198);
            this.lv_nouns.TabIndex = 8;
            this.lv_nouns.UseCompatibleStateImageBehavior = false;
            // 
            // lv_verbs
            // 
            this.lv_verbs.Location = new System.Drawing.Point(522, 52);
            this.lv_verbs.Name = "lv_verbs";
            this.lv_verbs.Size = new System.Drawing.Size(91, 198);
            this.lv_verbs.TabIndex = 9;
            this.lv_verbs.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nouns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Verbs";
            // 
            // InOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_verbs);
            this.Controls.Add(this.lv_nouns);
            this.Controls.Add(this.lv_words);
            this.Controls.Add(this.parse);
            this.Controls.Add(this.btnListVocabulary);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.inputWindow);
            this.Controls.Add(this.lblOutputLabel);
            this.Name = "InOut";
            this.Text = "AIMind";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InOut_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutputLabel;
        private System.Windows.Forms.TextBox inputWindow;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button btnListVocabulary;
        private System.Windows.Forms.Button parse;
        private System.Windows.Forms.ListView lv_words;
        private System.Windows.Forms.ListView lv_nouns;
        private System.Windows.Forms.ListView lv_verbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

