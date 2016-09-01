using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeSelect.SelectedIndex = 0;
        }

        private void targetFieldSelect_Click(object sender, EventArgs e)
        {
            if (typeSelect.SelectedIndex == 0)
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
            if(destinationField.Text != "" && targetField.Text != "" && targetField.Text != destinationField.Text && nameField.Text != "")
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
            if (typeSelect.SelectedIndex == 0)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    destinationField.Text = dialog.SelectedPath;
                }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    destinationField.Text = dialog.FileName;
                }
            }
            if (destinationField.Text != "" && targetField.Text != "" && targetField.Text != destinationField.Text && nameField.Text != "")
            {
                startButton.Enabled = true;
            }
        }

        private void retainExecutables_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void typeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationField.ResetText();
            targetField.ResetText();
            startButton.Enabled = false;
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            if (destinationField.Text != "" && targetField.Text != "" && targetField.Text != destinationField.Text && nameField.Text != "")
            {
                startButton.Enabled = true;
            }
        }
    }
}
