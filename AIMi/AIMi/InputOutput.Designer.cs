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
            this.nounButton = new System.Windows.Forms.Button();
            this.verbButton = new System.Windows.Forms.Button();
            this.btnListVocabulary = new System.Windows.Forms.Button();
            this.parse = new System.Windows.Forms.Button();
            this.lv_words = new System.Windows.Forms.ListView();
            this.lv_nouns = new System.Windows.Forms.ListView();
            this.lv_verbs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.greetingButton = new System.Windows.Forms.Button();
            this.hiddenOutput = new System.Windows.Forms.GroupBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.hiddenOutput.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(9, 15);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutputLabel.Size = new System.Drawing.Size(131, 13);
            this.lblOutputLabel.TabIndex = 1;
            this.lblOutputLabel.Text = "my responses appear here";
            // 
            // inputWindow
            // 
            this.inputWindow.Location = new System.Drawing.Point(7, 19);
            this.inputWindow.Name = "inputWindow";
            this.inputWindow.Size = new System.Drawing.Size(259, 20);
            this.inputWindow.TabIndex = 2;
            this.inputWindow.Text = "type here";
            this.inputWindow.Enter += new System.EventHandler(this.inputWindow_EnterPressed);
            this.inputWindow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputWindow_KeyPress);
            // 
            // nounButton
            // 
            this.nounButton.Location = new System.Drawing.Point(4, 83);
            this.nounButton.Name = "nounButton";
            this.nounButton.Size = new System.Drawing.Size(75, 23);
            this.nounButton.TabIndex = 3;
            this.nounButton.Text = "Noun";
            this.nounButton.UseVisualStyleBackColor = true;
            this.nounButton.Visible = false;
            this.nounButton.Click += new System.EventHandler(this.NounButton_Click);
            // 
            // verbButton
            // 
            this.verbButton.Location = new System.Drawing.Point(103, 83);
            this.verbButton.Name = "verbButton";
            this.verbButton.Size = new System.Drawing.Size(75, 23);
            this.verbButton.TabIndex = 4;
            this.verbButton.Text = "Verb";
            this.verbButton.UseVisualStyleBackColor = true;
            this.verbButton.Visible = false;
            this.verbButton.Click += new System.EventHandler(this.verbButton_Click);
            // 
            // btnListVocabulary
            // 
            this.btnListVocabulary.Location = new System.Drawing.Point(102, 23);
            this.btnListVocabulary.Name = "btnListVocabulary";
            this.btnListVocabulary.Size = new System.Drawing.Size(98, 23);
            this.btnListVocabulary.TabIndex = 5;
            this.btnListVocabulary.Text = "List Vocabulary";
            this.btnListVocabulary.UseVisualStyleBackColor = true;
            this.btnListVocabulary.Click += new System.EventHandler(this.btnListVocabulary_Click);
            // 
            // parse
            // 
            this.parse.Location = new System.Drawing.Point(4, 23);
            this.parse.Name = "parse";
            this.parse.Size = new System.Drawing.Size(92, 23);
            this.parse.TabIndex = 6;
            this.parse.Text = "Parse sentence";
            this.parse.UseVisualStyleBackColor = true;
            this.parse.Click += new System.EventHandler(this.parse_Click);
            // 
            // lv_words
            // 
            this.lv_words.Location = new System.Drawing.Point(32, 31);
            this.lv_words.Name = "lv_words";
            this.lv_words.Size = new System.Drawing.Size(91, 147);
            this.lv_words.TabIndex = 7;
            this.lv_words.UseCompatibleStateImageBehavior = false;
            // 
            // lv_nouns
            // 
            this.lv_nouns.Location = new System.Drawing.Point(129, 31);
            this.lv_nouns.Name = "lv_nouns";
            this.lv_nouns.Size = new System.Drawing.Size(91, 147);
            this.lv_nouns.TabIndex = 8;
            this.lv_nouns.UseCompatibleStateImageBehavior = false;
            // 
            // lv_verbs
            // 
            this.lv_verbs.Location = new System.Drawing.Point(226, 31);
            this.lv_verbs.Name = "lv_verbs";
            this.lv_verbs.Size = new System.Drawing.Size(91, 147);
            this.lv_verbs.TabIndex = 9;
            this.lv_verbs.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nouns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Verbs";
            // 
            // greetingButton
            // 
            this.greetingButton.Location = new System.Drawing.Point(201, 82);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(75, 23);
            this.greetingButton.TabIndex = 13;
            this.greetingButton.Text = "Greeting";
            this.greetingButton.UseVisualStyleBackColor = true;
            this.greetingButton.Visible = false;
            this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
            // 
            // hiddenOutput
            // 
            this.hiddenOutput.Controls.Add(this.label3);
            this.hiddenOutput.Controls.Add(this.label2);
            this.hiddenOutput.Controls.Add(this.label1);
            this.hiddenOutput.Controls.Add(this.lv_verbs);
            this.hiddenOutput.Controls.Add(this.lv_nouns);
            this.hiddenOutput.Controls.Add(this.lv_words);
            this.hiddenOutput.Location = new System.Drawing.Point(297, 58);
            this.hiddenOutput.Name = "hiddenOutput";
            this.hiddenOutput.Size = new System.Drawing.Size(351, 195);
            this.hiddenOutput.TabIndex = 14;
            this.hiddenOutput.TabStop = false;
            this.hiddenOutput.Text = "Hidden Output";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.lblOutputLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(297, 5);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(348, 47);
            this.outputGroupBox.TabIndex = 15;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.greetingButton);
            this.controlGroupBox.Controls.Add(this.parse);
            this.controlGroupBox.Controls.Add(this.btnListVocabulary);
            this.controlGroupBox.Controls.Add(this.verbButton);
            this.controlGroupBox.Controls.Add(this.nounButton);
            this.controlGroupBox.Location = new System.Drawing.Point(2, 138);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(289, 125);
            this.controlGroupBox.TabIndex = 16;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Learning controls";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputWindow);
            this.inputGroupBox.Location = new System.Drawing.Point(5, 3);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(285, 103);
            this.inputGroupBox.TabIndex = 17;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // InOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 262);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.hiddenOutput);
            this.Name = "InOut";
            this.Text = "AIMind";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InOut_FormClosing);
            this.hiddenOutput.ResumeLayout(false);
            this.hiddenOutput.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutputLabel;
        private System.Windows.Forms.TextBox inputWindow;
        private System.Windows.Forms.Button nounButton;
        private System.Windows.Forms.Button verbButton;
        private System.Windows.Forms.Button btnListVocabulary;
        private System.Windows.Forms.Button parse;
        private System.Windows.Forms.ListView lv_words;
        private System.Windows.Forms.ListView lv_nouns;
        private System.Windows.Forms.ListView lv_verbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.GroupBox hiddenOutput;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.GroupBox inputGroupBox;

    }
}

