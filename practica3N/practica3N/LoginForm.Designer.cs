namespace practica3N
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbUser = new MetroFramework.Controls.MetroTextBox();
            this.mtbPsw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbtnIniciar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mtbUser
            // 
            // 
            // 
            // 
            this.mtbUser.CustomButton.Image = null;
            this.mtbUser.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.mtbUser.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbUser.CustomButton.Name = "";
            this.mtbUser.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.mtbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbUser.CustomButton.TabIndex = 1;
            this.mtbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbUser.CustomButton.UseSelectable = true;
            this.mtbUser.CustomButton.Visible = false;
            this.mtbUser.Lines = new string[0];
            this.mtbUser.Location = new System.Drawing.Point(106, 54);
            this.mtbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbUser.MaxLength = 32767;
            this.mtbUser.Name = "mtbUser";
            this.mtbUser.PasswordChar = '\0';
            this.mtbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbUser.SelectedText = "";
            this.mtbUser.SelectionLength = 0;
            this.mtbUser.SelectionStart = 0;
            this.mtbUser.ShortcutsEnabled = true;
            this.mtbUser.Size = new System.Drawing.Size(127, 19);
            this.mtbUser.TabIndex = 0;
            this.mtbUser.UseSelectable = true;
            this.mtbUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbPsw
            // 
            // 
            // 
            // 
            this.mtbPsw.CustomButton.Image = null;
            this.mtbPsw.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.mtbPsw.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPsw.CustomButton.Name = "";
            this.mtbPsw.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.mtbPsw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPsw.CustomButton.TabIndex = 1;
            this.mtbPsw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPsw.CustomButton.UseSelectable = true;
            this.mtbPsw.CustomButton.Visible = false;
            this.mtbPsw.Lines = new string[0];
            this.mtbPsw.Location = new System.Drawing.Point(106, 77);
            this.mtbPsw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPsw.MaxLength = 32767;
            this.mtbPsw.Name = "mtbPsw";
            this.mtbPsw.PasswordChar = '\0';
            this.mtbPsw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPsw.SelectedText = "";
            this.mtbPsw.SelectionLength = 0;
            this.mtbPsw.SelectionStart = 0;
            this.mtbPsw.ShortcutsEnabled = true;
            this.mtbPsw.Size = new System.Drawing.Size(127, 19);
            this.mtbPsw.TabIndex = 1;
            this.mtbPsw.UseSelectable = true;
            this.mtbPsw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPsw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 54);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuario:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 77);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // mbtnIniciar
            // 
            this.mbtnIniciar.Location = new System.Drawing.Point(24, 100);
            this.mbtnIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mbtnIniciar.Name = "mbtnIniciar";
            this.mbtnIniciar.Size = new System.Drawing.Size(209, 24);
            this.mbtnIniciar.TabIndex = 4;
            this.mbtnIniciar.Text = "Iniciar Sesion";
            this.mbtnIniciar.UseSelectable = true;
            this.mbtnIniciar.Click += new System.EventHandler(this.mbtnIniciar_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.mbtnIniciar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbPsw);
            this.Controls.Add(this.mtbUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtbUser;
        private MetroFramework.Controls.MetroTextBox mtbPsw;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbtnIniciar;
    }
}

