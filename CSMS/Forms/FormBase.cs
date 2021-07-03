using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSMS.Forms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            AddCloseButton();
        }

        private void AddCloseButton()
        {
            var panel = new Panel()
            {
                Dock = DockStyle.Top,
                BackColor = Color.Transparent,
                Height = 40,
            };



            var closeButton = new PictureBox()
            {
                Size = new Size(40, 40),
                Image = CSMS.Properties.Resources.close,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Right,
                Name = "btnClose"
            };

            
            panel.Controls.Add(closeButton);
            Controls.Add(panel);
            closeButton.Click += new EventHandler(CloseButton_Click);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void FormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
