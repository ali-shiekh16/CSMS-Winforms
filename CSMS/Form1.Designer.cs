
namespace CSMS
{
    partial class frmSignIn
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
            this.btnSignIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSignInHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmailInput = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmailInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPasswordInput = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPasswordInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(89)))), ((int)(((byte)(60)))));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 7;
            this.btnSignIn.ButtonText = "Sign-In";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Iconimage = null;
            this.btnSignIn.Iconimage_right = null;
            this.btnSignIn.Iconimage_right_Selected = null;
            this.btnSignIn.Iconimage_Selected = null;
            this.btnSignIn.IconMarginLeft = 0;
            this.btnSignIn.IconMarginRight = 0;
            this.btnSignIn.IconRightVisible = true;
            this.btnSignIn.IconRightZoom = 0D;
            this.btnSignIn.IconVisible = true;
            this.btnSignIn.IconZoom = 90D;
            this.btnSignIn.IsTab = false;
            this.btnSignIn.Location = new System.Drawing.Point(70, 425);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignIn.selected = false;
            this.btnSignIn.Size = new System.Drawing.Size(366, 51);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Textcolor = System.Drawing.Color.White;
            this.btnSignIn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblSignInHeading
            // 
            this.lblSignInHeading.AutoSize = true;
            this.lblSignInHeading.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInHeading.ForeColor = System.Drawing.Color.White;
            this.lblSignInHeading.Location = new System.Drawing.Point(46, 90);
            this.lblSignInHeading.Name = "lblSignInHeading";
            this.lblSignInHeading.Size = new System.Drawing.Size(431, 44);
            this.lblSignInHeading.TabIndex = 5;
            this.lblSignInHeading.Text = "Sign in to your account";
            // 
            // lblEmailInput
            // 
            this.lblEmailInput.AutoSize = true;
            this.lblEmailInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmailInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInput.ForeColor = System.Drawing.Color.White;
            this.lblEmailInput.Location = new System.Drawing.Point(70, 203);
            this.lblEmailInput.Name = "lblEmailInput";
            this.lblEmailInput.Size = new System.Drawing.Size(135, 21);
            this.lblEmailInput.TabIndex = 8;
            this.lblEmailInput.Text = "Type your e-mail";
            // 
            // txtEmailInput
            // 
            this.txtEmailInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtEmailInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtEmailInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtEmailInput.BorderThickness = 3;
            this.txtEmailInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEmailInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailInput.ForeColor = System.Drawing.Color.White;
            this.txtEmailInput.isPassword = false;
            this.txtEmailInput.Location = new System.Drawing.Point(70, 230);
            this.txtEmailInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailInput.Name = "txtEmailInput";
            this.txtEmailInput.Size = new System.Drawing.Size(370, 44);
            this.txtEmailInput.TabIndex = 7;
            this.txtEmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPasswordInput
            // 
            this.lblPasswordInput.AutoSize = true;
            this.lblPasswordInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPasswordInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInput.ForeColor = System.Drawing.Color.White;
            this.lblPasswordInput.Location = new System.Drawing.Point(70, 309);
            this.lblPasswordInput.Name = "lblPasswordInput";
            this.lblPasswordInput.Size = new System.Drawing.Size(162, 21);
            this.lblPasswordInput.TabIndex = 10;
            this.lblPasswordInput.Text = "Type your password";
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPasswordInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtPasswordInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPasswordInput.BorderThickness = 3;
            this.txtPasswordInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPasswordInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordInput.ForeColor = System.Drawing.Color.White;
            this.txtPasswordInput.isPassword = true;
            this.txtPasswordInput.Location = new System.Drawing.Point(70, 336);
            this.txtPasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.Size = new System.Drawing.Size(370, 44);
            this.txtPasswordInput.TabIndex = 9;
            this.txtPasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(522, 580);
            this.Controls.Add(this.lblPasswordInput);
            this.Controls.Add(this.txtPasswordInput);
            this.Controls.Add(this.lblEmailInput);
            this.Controls.Add(this.txtEmailInput);
            this.Controls.Add(this.lblSignInHeading);
            this.Controls.Add(this.btnSignIn);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSignIn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSignInHeading;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmailInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmailInput;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPasswordInput;
    }
}

