namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.retainExecutables = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.typeSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Include Executables:";
            // 
            // retainExecutables
            // 
            this.retainExecutables.AutoSize = true;
            this.retainExecutables.Location = new System.Drawing.Point(121, 176);
            this.retainExecutables.Name = "retainExecutables";
            this.retainExecutables.Size = new System.Drawing.Size(15, 14);
            this.retainExecutables.TabIndex = 8;
            this.retainExecutables.UseVisualStyleBackColor = true;
            this.retainExecutables.CheckedChanged += new System.EventHandler(this.retainExecutables_CheckedChanged);
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
            "Folder",
            "File"});
            this.typeSelect.Location = new System.Drawing.Point(15, 12);
            this.typeSelect.Name = "typeSelect";
            this.typeSelect.Size = new System.Drawing.Size(487, 21);
            this.typeSelect.TabIndex = 12;
            this.typeSelect.SelectedIndexChanged += new System.EventHandler(this.typeSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Symlink name:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(222, 173);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(278, 20);
            this.nameField.TabIndex = 14;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleName = "Symbolic Link Generator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 304);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeSelect);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.retainExecutables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox retainExecutables;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox typeSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
    }
}

