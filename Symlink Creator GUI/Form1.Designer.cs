namespace SymlinkCreator.GUI
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
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetField = new System.Windows.Forms.TextBox();
            this.targetFieldSelect = new System.Windows.Forms.Button();
            this.destinationFieldSelect = new System.Windows.Forms.Button();
            this.destinationField = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.typeSelect = new System.Windows.Forms.ComboBox();
            this.moveBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(6, 22);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(41, 13);
            this.targetLabel.TabIndex = 0;
            this.targetLabel.Text = "Target:";
            // 
            // targetField
            // 
            this.targetField.Enabled = false;
            this.targetField.Location = new System.Drawing.Point(75, 19);
            this.targetField.Name = "targetField";
            this.targetField.Size = new System.Drawing.Size(379, 20);
            this.targetField.TabIndex = 1;
            this.targetField.TextChanged += new System.EventHandler(this.targetField_TextChanged);
            // 
            // targetFieldSelect
            // 
            this.targetFieldSelect.Location = new System.Drawing.Point(460, 19);
            this.targetFieldSelect.Name = "targetFieldSelect";
            this.targetFieldSelect.Size = new System.Drawing.Size(24, 23);
            this.targetFieldSelect.TabIndex = 2;
            this.targetFieldSelect.Text = "...";
            this.targetFieldSelect.UseVisualStyleBackColor = true;
            this.targetFieldSelect.Click += new System.EventHandler(this.targetFieldSelect_Click);
            // 
            // destinationFieldSelect
            // 
            this.destinationFieldSelect.Location = new System.Drawing.Point(460, 62);
            this.destinationFieldSelect.Name = "destinationFieldSelect";
            this.destinationFieldSelect.Size = new System.Drawing.Size(24, 23);
            this.destinationFieldSelect.TabIndex = 5;
            this.destinationFieldSelect.Text = "...";
            this.destinationFieldSelect.UseVisualStyleBackColor = true;
            this.destinationFieldSelect.Click += new System.EventHandler(this.destinationFieldSelect_Click);
            // 
            // destinationField
            // 
            this.destinationField.Enabled = false;
            this.destinationField.Location = new System.Drawing.Point(75, 64);
            this.destinationField.Name = "destinationField";
            this.destinationField.Size = new System.Drawing.Size(379, 20);
            this.destinationField.TabIndex = 4;
            this.destinationField.TextChanged += new System.EventHandler(this.destinationField_TextChanged);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(6, 67);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(63, 13);
            this.destinationLabel.TabIndex = 3;
            this.destinationLabel.Text = "Destination:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.targetField);
            this.groupBox1.Controls.Add(this.destinationFieldSelect);
            this.groupBox1.Controls.Add(this.targetLabel);
            this.groupBox1.Controls.Add(this.destinationField);
            this.groupBox1.Controls.Add(this.targetFieldSelect);
            this.groupBox1.Controls.Add(this.destinationLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 213);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(487, 34);
            this.progressBar.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(222, 265);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // typeSelect
            // 
            this.typeSelect.FormattingEnabled = true;
            this.typeSelect.Items.AddRange(new object[] {
            "File",
            "Folder"});
            this.typeSelect.Location = new System.Drawing.Point(15, 12);
            this.typeSelect.Name = "typeSelect";
            this.typeSelect.Size = new System.Drawing.Size(487, 21);
            this.typeSelect.TabIndex = 12;
            this.typeSelect.SelectedIndexChanged += new System.EventHandler(this.typeSelect_SelectedIndexChanged);
            // 
            // moveBox
            // 
            this.moveBox.AutoSize = true;
            this.moveBox.Location = new System.Drawing.Point(120, 175);
            this.moveBox.Name = "moveBox";
            this.moveBox.Size = new System.Drawing.Size(15, 14);
            this.moveBox.TabIndex = 14;
            this.moveBox.UseVisualStyleBackColor = true;
            this.moveBox.CheckedChanged += new System.EventHandler(this.moveBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Move to Destination:";
            // 
            // Form1
            // 
            this.AcceptButton = this.startButton;
            this.AccessibleName = "Symbolic Link Generator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 304);
            this.Controls.Add(this.moveBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeSelect);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 343);
            this.MinimumSize = new System.Drawing.Size(534, 343);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Symlink Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetField;
        private System.Windows.Forms.Button targetFieldSelect;
        private System.Windows.Forms.Button destinationFieldSelect;
        private System.Windows.Forms.TextBox destinationField;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox typeSelect;
        private System.Windows.Forms.CheckBox moveBox;
        private System.Windows.Forms.Label label2;
    }
}

