namespace TestoTeacher.View
{
    partial class MainMenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuWindow));
            this.label_tittle = new System.Windows.Forms.Label();
            this.rep_label = new System.Windows.Forms.Label();
            this.rep_wrong_label = new System.Windows.Forms.Label();
            this.button_resume = new System.Windows.Forms.Button();
            this.buton_start = new System.Windows.Forms.Button();
            this.loadFile_label = new System.Windows.Forms.Label();
            this.label_fileTemplate = new System.Windows.Forms.Label();
            this.textBox_repNumber = new System.Windows.Forms.TextBox();
            this.textBox_repWrongNumber = new System.Windows.Forms.TextBox();
            this.label_instructions = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_tittle
            // 
            this.label_tittle.AutoSize = true;
            this.label_tittle.Font = new System.Drawing.Font("Microsoft Tai Le", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tittle.Location = new System.Drawing.Point(12, 9);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(292, 55);
            this.label_tittle.TabIndex = 0;
            this.label_tittle.Text = "TestoTeacher";
            // 
            // rep_label
            // 
            this.rep_label.AutoSize = true;
            this.rep_label.Location = new System.Drawing.Point(19, 237);
            this.rep_label.Name = "rep_label";
            this.rep_label.Size = new System.Drawing.Size(149, 16);
            this.rep_label.TabIndex = 1;
            this.rep_label.Text = "Set questions repetition:";
            // 
            // rep_wrong_label
            // 
            this.rep_wrong_label.AutoSize = true;
            this.rep_wrong_label.Location = new System.Drawing.Point(19, 275);
            this.rep_wrong_label.Name = "rep_wrong_label";
            this.rep_wrong_label.Size = new System.Drawing.Size(260, 16);
            this.rep_wrong_label.TabIndex = 2;
            this.rep_wrong_label.Text = "Set question repetition after wrong answer:";
            // 
            // button_resume
            // 
            this.button_resume.Location = new System.Drawing.Point(22, 384);
            this.button_resume.Name = "button_resume";
            this.button_resume.Size = new System.Drawing.Size(185, 23);
            this.button_resume.TabIndex = 3;
            this.button_resume.Text = "Resume";
            this.button_resume.UseVisualStyleBackColor = true;
            // 
            // buton_start
            // 
            this.buton_start.Location = new System.Drawing.Point(226, 384);
            this.buton_start.Name = "buton_start";
            this.buton_start.Size = new System.Drawing.Size(200, 23);
            this.buton_start.TabIndex = 4;
            this.buton_start.Text = "Start";
            this.buton_start.UseVisualStyleBackColor = true;
            // 
            // loadFile_label
            // 
            this.loadFile_label.AutoSize = true;
            this.loadFile_label.Location = new System.Drawing.Point(443, 237);
            this.loadFile_label.Name = "loadFile_label";
            this.loadFile_label.Size = new System.Drawing.Size(121, 16);
            this.loadFile_label.TabIndex = 5;
            this.loadFile_label.Text = "Load your file here:";
            // 
            // label_fileTemplate
            // 
            this.label_fileTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_fileTemplate.Location = new System.Drawing.Point(432, 68);
            this.label_fileTemplate.Name = "label_fileTemplate";
            this.label_fileTemplate.Padding = new System.Windows.Forms.Padding(5);
            this.label_fileTemplate.Size = new System.Drawing.Size(360, 153);
            this.label_fileTemplate.TabIndex = 6;
            this.label_fileTemplate.Text = "How files need to look like:\n1. Question content\na)Answer_+\nb)Answer\nc)Answer_+\nd" +
    ")Answer\n_+ :means good anser\nFile also need to be .txt file";
            // 
            // textBox_repNumber
            // 
            this.textBox_repNumber.Location = new System.Drawing.Point(392, 232);
            this.textBox_repNumber.Name = "textBox_repNumber";
            this.textBox_repNumber.Size = new System.Drawing.Size(34, 24);
            this.textBox_repNumber.TabIndex = 7;
            // 
            // textBox_repWrongNumber
            // 
            this.textBox_repWrongNumber.Location = new System.Drawing.Point(392, 267);
            this.textBox_repWrongNumber.Name = "textBox_repWrongNumber";
            this.textBox_repWrongNumber.Size = new System.Drawing.Size(34, 24);
            this.textBox_repWrongNumber.TabIndex = 8;
            // 
            // label_instructions
            // 
            this.label_instructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_instructions.Location = new System.Drawing.Point(22, 68);
            this.label_instructions.Name = "label_instructions";
            this.label_instructions.Padding = new System.Windows.Forms.Padding(5);
            this.label_instructions.Size = new System.Drawing.Size(404, 153);
            this.label_instructions.TabIndex = 9;
            this.label_instructions.Text = "Please load your file with test and enjoy learning or testing \nsome rules: \nif qu" +
    "estion have couple good answers, You get point only if you 100% right.";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(446, 267);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 26);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "ADD FILE";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(528, 269);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(264, 24);
            this.textBox_fileName.TabIndex = 11;
            // 
            // textBox_adres
            // 
            this.textBox_adres.Location = new System.Drawing.Point(446, 300);
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(346, 24);
            this.textBox_adres.TabIndex = 12;
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.textBox_adres);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label_instructions);
            this.Controls.Add(this.textBox_repWrongNumber);
            this.Controls.Add(this.textBox_repNumber);
            this.Controls.Add(this.label_fileTemplate);
            this.Controls.Add(this.loadFile_label);
            this.Controls.Add(this.buton_start);
            this.Controls.Add(this.button_resume);
            this.Controls.Add(this.rep_wrong_label);
            this.Controls.Add(this.rep_label);
            this.Controls.Add(this.label_tittle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestoTeacherApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tittle;
        private System.Windows.Forms.Label rep_label;
        private System.Windows.Forms.Label rep_wrong_label;
        private System.Windows.Forms.Button button_resume;
        private System.Windows.Forms.Button buton_start;
        private System.Windows.Forms.Label loadFile_label;
        private System.Windows.Forms.Label label_fileTemplate;
        private System.Windows.Forms.TextBox textBox_repNumber;
        private System.Windows.Forms.TextBox textBox_repWrongNumber;
        private System.Windows.Forms.Label label_instructions;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.TextBox textBox_adres;
    }
}