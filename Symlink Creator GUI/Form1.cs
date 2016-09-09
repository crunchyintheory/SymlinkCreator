using System;
using System.Windows.Forms;

namespace SymlinkCreator.GUI
{
    public partial class Form1 : Form
    {
        public bool moveToDest => moveBox.Checked;
        public string targetPath => targetField.Text;
        public string destinationPath => destinationField.Text;
        public LinkType linkType => (LinkType)typeSelect.SelectedIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeSelect.SelectedIndex = 0;
            progressBar.Step = 1;
            progressBar.Minimum = 0;
            progressBar.Maximum = 2;
            LinkCreator.LinkStepCompleted += (sS, eE) => {
                progressBar.PerformStep();
                
            };
        }

        private void targetFieldSelect_Click(object sender, EventArgs e)
        {
            if (linkType == LinkType.Directory)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    targetField.Text = dialog.SelectedPath;
                }
            } else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    targetField.Text = dialog.FileName;
                }
            }
            if(destinationPath != "" && targetPath != "" && targetPath != destinationPath)
            {
                startButton.Enabled = true;
            }
        }

        private void targetField_TextChanged(object sender, EventArgs e)
        {

        }

        private void destinationField_TextChanged(object sender, EventArgs e)
        {

        }

        private void destinationFieldSelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = false;
            if(linkType == LinkType.Directory)
            {
                dialog.Filter = "Folder|*";
            } else
            {
                dialog.Filter = "All files (*.*)|*.*";
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destinationField.Text = dialog.FileName;
            }
            if (destinationPath != "" && targetPath != "" && targetPath != destinationPath)
            {
                startButton.Enabled = true;
            }
        }

        private void retainExecutables_CheckedChanged(object sender, EventArgs e)
        {
            LinkCreator.completeLinkStep(new EventArgs());
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            if (moveToDest)
            {
                LinkCreator.createSymbolicLinkAndMove(destinationPath, targetPath, linkType);
            } else
            {
                LinkCreator.createSymbolicLink(destinationPath, targetPath, linkType);
            }
        }

        private void typeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationField.ResetText();
            targetField.ResetText();
            startButton.Enabled = false;
        }

        private void moveBox_CheckedChanged(object sender, EventArgs e)
        {
            if(moveBox.Checked)
            {
                progressBar.Maximum = 3;
            } else
            {
                progressBar.Maximum = 2;
            }
            progressBar.Value = 0;
        }
    }
}
