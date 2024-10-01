using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;

            //// Create and configure the PictureBox as the background
            //PictureBox backgroundImage = new PictureBox();
            //backgroundImage.Dock = DockStyle.Fill;
            //backgroundImage.Image = Image.FromFile(@"C:\Users\PC1\Downloads\8673365_3973006.jpg");
            //backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //// Add the PictureBox to the MDI parent form
            //this.Controls.Add(backgroundImage);

            //// Send PictureBox to the back, so child forms appear in front of it
            //backgroundImage.SendToBack();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void accountsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form existingForm = Application.OpenForms["Form2"];

            if (existingForm == null)  // If form doesn't exist, create a new one
            {
                Form2 form2 = new Form2();
                form2.MdiParent = this;  // Set as child of MDI parent if this is an MDI form
                form2.Show();
            }
            else
            {
                // Minimize all other open forms except the one being brought to the front
                foreach (Form form in this.MdiChildren)
                {
                    if (form != existingForm)
                    {
                        form.WindowState = FormWindowState.Minimized;
                    }
                }

                // Bring the existing form to the front and restore it if it was minimized
                existingForm.WindowState = FormWindowState.Normal;
                existingForm.BringToFront();
            }
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            Form existingForm = Application.OpenForms["Form1"];

            if (existingForm == null)  // If form doesn't exist, create a new one
            {
                Form1 form1 = new Form1();
                form1.MdiParent = this;  // Set as child of MDI parent if this is an MDI form
                form1.Show();
            }
            else
            {
                // Minimize all other open forms except the one being brought to the front
                foreach (Form form in this.MdiChildren)
                {
                    if (form != existingForm)
                    {
                        form.WindowState = FormWindowState.Minimized;
                    }
                }

                // Bring the existing form to the front and restore it if it was minimized
                existingForm.WindowState = FormWindowState.Normal;
                existingForm.BringToFront();
            }
        }
    }
}
