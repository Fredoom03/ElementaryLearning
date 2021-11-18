
namespace ElementaryLearning
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.pnlRegistrarUsuario = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.tbConfirmarContrasena = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnCancel = new Guna.UI.WinForms.GunaCircleButton();
            this.btnRegistrarUsuario = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tbEdad = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbNombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.tbCrearContraseña = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.tbNuevoUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnlLoginTb = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLineTextBox4 = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblCrearCuenta = new Guna.UI.WinForms.GunaLabel();
            this.gunaLineTextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.pbUser = new Guna.UI.WinForms.GunaPictureBox();
            this.pbPassword = new Guna.UI.WinForms.GunaPictureBox();
            this.btnIniciar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tbPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlRegistrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.pnlLoginTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BackgroundImage = global::ElementaryLearning.Properties.Resources.login;
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.pnlRegistrarUsuario);
            this.pnlLogin.Controls.Add(this.pnlLoginTb);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1333, 738);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Location = new System.Drawing.Point(1264, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(150)))), ((int)(((byte)(46)))));
            this.btnExit.Size = new System.Drawing.Size(53, 49);
            this.btnExit.TabIndex = 15;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlRegistrarUsuario
            // 
            this.pnlRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegistrarUsuario.BaseColor = System.Drawing.Color.White;
            this.pnlRegistrarUsuario.Controls.Add(this.gunaLineTextBox3);
            this.pnlRegistrarUsuario.Controls.Add(this.gunaPictureBox3);
            this.pnlRegistrarUsuario.Controls.Add(this.tbConfirmarContrasena);
            this.pnlRegistrarUsuario.Controls.Add(this.btnCancel);
            this.pnlRegistrarUsuario.Controls.Add(this.btnRegistrarUsuario);
            this.pnlRegistrarUsuario.Controls.Add(this.tbEdad);
            this.pnlRegistrarUsuario.Controls.Add(this.tbNombre);
            this.pnlRegistrarUsuario.Controls.Add(this.gunaPictureBox2);
            this.pnlRegistrarUsuario.Controls.Add(this.tbCrearContraseña);
            this.pnlRegistrarUsuario.Controls.Add(this.gunaPictureBox1);
            this.pnlRegistrarUsuario.Controls.Add(this.tbNuevoUsuario);
            this.pnlRegistrarUsuario.Location = new System.Drawing.Point(327, 74);
            this.pnlRegistrarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRegistrarUsuario.Name = "pnlRegistrarUsuario";
            this.pnlRegistrarUsuario.Size = new System.Drawing.Size(725, 566);
            this.pnlRegistrarUsuario.TabIndex = 1;
            this.pnlRegistrarUsuario.Visible = false;
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.Transparent;
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLineTextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.Transparent;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(196, 21);
            this.gunaLineTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.Size = new System.Drawing.Size(365, 68);
            this.gunaLineTextBox3.TabIndex = 17;
            this.gunaLineTextBox3.Text = "REGISTRAR USUARIO";
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = global::ElementaryLearning.Properties.Resources.password;
            this.gunaPictureBox3.Location = new System.Drawing.Point(44, 399);
            this.gunaPictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(53, 49);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 15;
            this.gunaPictureBox3.TabStop = false;
            // 
            // tbConfirmarContrasena
            // 
            this.tbConfirmarContrasena.BackColor = System.Drawing.Color.White;
            this.tbConfirmarContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmarContrasena.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmarContrasena.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbConfirmarContrasena.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbConfirmarContrasena.Location = new System.Drawing.Point(107, 399);
            this.tbConfirmarContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirmarContrasena.Name = "tbConfirmarContrasena";
            this.tbConfirmarContrasena.PasswordChar = '·';
            this.tbConfirmarContrasena.Size = new System.Drawing.Size(587, 49);
            this.tbConfirmarContrasena.TabIndex = 16;
            this.tbConfirmarContrasena.Text = "Contraseña";
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::ElementaryLearning.Properties.Resources.Cancel;
            this.btnCancel.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCancel.Location = new System.Drawing.Point(508, 487);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(150)))), ((int)(((byte)(46)))));
            this.btnCancel.Size = new System.Drawing.Size(53, 49);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Animated = true;
            this.btnRegistrarUsuario.AnimationHoverSpeed = 0.07F;
            this.btnRegistrarUsuario.AnimationSpeed = 0.03F;
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarUsuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.btnRegistrarUsuario.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuario.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRegistrarUsuario.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuario.CheckedForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.CheckedImage = global::ElementaryLearning.Properties.Resources.user;
            this.btnRegistrarUsuario.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRegistrarUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrarUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarUsuario.Image")));
            this.btnRegistrarUsuario.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrarUsuario.LineBottom = 1;
            this.btnRegistrarUsuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(178)))), ((int)(((byte)(95)))));
            this.btnRegistrarUsuario.LineLeft = 1;
            this.btnRegistrarUsuario.LineRight = 1;
            this.btnRegistrarUsuario.LineTop = 1;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(172, 487);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.btnRegistrarUsuario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuario.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.OnHoverImage = null;
            this.btnRegistrarUsuario.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.btnRegistrarUsuario.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(150)))), ((int)(((byte)(46)))));
            this.btnRegistrarUsuario.Radius = 5;
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(299, 49);
            this.btnRegistrarUsuario.TabIndex = 14;
            this.btnRegistrarUsuario.Text = "Registrar";
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // tbEdad
            // 
            this.tbEdad.BackColor = System.Drawing.Color.White;
            this.tbEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEdad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbEdad.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbEdad.Location = new System.Drawing.Point(44, 159);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.PasswordChar = '\0';
            this.tbEdad.Size = new System.Drawing.Size(649, 49);
            this.tbEdad.TabIndex = 11;
            this.tbEdad.Text = "Edad";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbNombre.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbNombre.Location = new System.Drawing.Point(44, 85);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.Size = new System.Drawing.Size(649, 49);
            this.tbNombre.TabIndex = 10;
            this.tbNombre.Text = "Nombre";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::ElementaryLearning.Properties.Resources.password;
            this.gunaPictureBox2.Location = new System.Drawing.Point(44, 318);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(53, 49);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 7;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // tbCrearContraseña
            // 
            this.tbCrearContraseña.BackColor = System.Drawing.Color.White;
            this.tbCrearContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCrearContraseña.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbCrearContraseña.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCrearContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbCrearContraseña.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbCrearContraseña.Location = new System.Drawing.Point(107, 318);
            this.tbCrearContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCrearContraseña.Name = "tbCrearContraseña";
            this.tbCrearContraseña.PasswordChar = '·';
            this.tbCrearContraseña.Size = new System.Drawing.Size(587, 49);
            this.tbCrearContraseña.TabIndex = 13;
            this.tbCrearContraseña.Text = "Contraseña";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::ElementaryLearning.Properties.Resources.user;
            this.gunaPictureBox1.Location = new System.Drawing.Point(44, 230);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(53, 49);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 8;
            this.gunaPictureBox1.TabStop = false;
            // 
            // tbNuevoUsuario
            // 
            this.tbNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.tbNuevoUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNuevoUsuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbNuevoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbNuevoUsuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbNuevoUsuario.Location = new System.Drawing.Point(107, 230);
            this.tbNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNuevoUsuario.Name = "tbNuevoUsuario";
            this.tbNuevoUsuario.PasswordChar = '\0';
            this.tbNuevoUsuario.Size = new System.Drawing.Size(587, 49);
            this.tbNuevoUsuario.TabIndex = 12;
            this.tbNuevoUsuario.Text = "Usuario";
            // 
            // pnlLoginTb
            // 
            this.pnlLoginTb.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginTb.BaseColor = System.Drawing.Color.White;
            this.pnlLoginTb.Controls.Add(this.gunaLineTextBox4);
            this.pnlLoginTb.Controls.Add(this.lblCrearCuenta);
            this.pnlLoginTb.Controls.Add(this.gunaLineTextBox2);
            this.pnlLoginTb.Controls.Add(this.pbUser);
            this.pnlLoginTb.Controls.Add(this.pbPassword);
            this.pnlLoginTb.Controls.Add(this.btnIniciar);
            this.pnlLoginTb.Controls.Add(this.tbPassword);
            this.pnlLoginTb.Controls.Add(this.tbUsuario);
            this.pnlLoginTb.Location = new System.Drawing.Point(77, 165);
            this.pnlLoginTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLoginTb.Name = "pnlLoginTb";
            this.pnlLoginTb.Size = new System.Drawing.Size(408, 316);
            this.pnlLoginTb.TabIndex = 0;
            this.pnlLoginTb.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLoginTb_Paint);
            // 
            // gunaLineTextBox4
            // 
            this.gunaLineTextBox4.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox4.FocusedLineColor = System.Drawing.Color.Transparent;
            this.gunaLineTextBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLineTextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLineTextBox4.LineColor = System.Drawing.Color.Transparent;
            this.gunaLineTextBox4.Location = new System.Drawing.Point(52, 15);
            this.gunaLineTextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLineTextBox4.Name = "gunaLineTextBox4";
            this.gunaLineTextBox4.PasswordChar = '\0';
            this.gunaLineTextBox4.Size = new System.Drawing.Size(292, 68);
            this.gunaLineTextBox4.TabIndex = 18;
            this.gunaLineTextBox4.Text = "INICIAR SESION";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.ForeColor = System.Drawing.Color.Black;
            this.lblCrearCuenta.Location = new System.Drawing.Point(205, 246);
            this.lblCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(160, 23);
            this.lblCrearCuenta.TabIndex = 4;
            this.lblCrearCuenta.Text = "¿No tienes Cuenta?";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // gunaLineTextBox2
            // 
            this.gunaLineTextBox2.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.gunaLineTextBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLineTextBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.gunaLineTextBox2.Location = new System.Drawing.Point(199, 238);
            this.gunaLineTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLineTextBox2.Name = "gunaLineTextBox2";
            this.gunaLineTextBox2.PasswordChar = '·';
            this.gunaLineTextBox2.Size = new System.Drawing.Size(185, 47);
            this.gunaLineTextBox2.TabIndex = 7;
            // 
            // pbUser
            // 
            this.pbUser.BaseColor = System.Drawing.Color.White;
            this.pbUser.Image = global::ElementaryLearning.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(37, 94);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(40, 37);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 6;
            this.pbUser.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.BaseColor = System.Drawing.Color.White;
            this.pbPassword.ErrorImage = global::ElementaryLearning.Properties.Resources.password;
            this.pbPassword.Image = global::ElementaryLearning.Properties.Resources.password;
            this.pbPassword.Location = new System.Drawing.Point(37, 170);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(40, 37);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 5;
            this.pbPassword.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Animated = true;
            this.btnIniciar.AnimationHoverSpeed = 0.07F;
            this.btnIniciar.AnimationSpeed = 0.03F;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.btnIniciar.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnIniciar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnIniciar.CheckedForeColor = System.Drawing.Color.White;
            this.btnIniciar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.CheckedImage")));
            this.btnIniciar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnIniciar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciar.FocusedColor = System.Drawing.Color.Empty;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIniciar.LineBottom = 1;
            this.btnIniciar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(178)))), ((int)(((byte)(95)))));
            this.btnIniciar.LineLeft = 1;
            this.btnIniciar.LineRight = 1;
            this.btnIniciar.LineTop = 1;
            this.btnIniciar.Location = new System.Drawing.Point(37, 234);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.btnIniciar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIniciar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIniciar.OnHoverImage = null;
            this.btnIniciar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.btnIniciar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(150)))), ((int)(((byte)(46)))));
            this.btnIniciar.Radius = 5;
            this.btnIniciar.Size = new System.Drawing.Size(133, 49);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.Enter += new System.EventHandler(this.btnIniciar_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPassword.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbPassword.Location = new System.Drawing.Point(84, 164);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '·';
            this.tbPassword.Size = new System.Drawing.Size(275, 49);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.White;
            this.tbUsuario.CausesValidation = false;
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUsuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(106)))));
            this.tbUsuario.Location = new System.Drawing.Point(84, 87);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.Size = new System.Drawing.Size(275, 49);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.Enter += new System.EventHandler(this.tbUsuario_Enter);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlRegistrarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.pnlLoginTb.ResumeLayout(false);
            this.pnlLoginTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private Guna.UI.WinForms.GunaElipsePanel pnlLoginTb;
        private Guna.UI.WinForms.GunaLineTextBox tbUsuario;
        private Guna.UI.WinForms.GunaAdvenceButton btnIniciar;
        private Guna.UI.WinForms.GunaLineTextBox tbPassword;
        private Guna.UI.WinForms.GunaLabel lblCrearCuenta;
        private Guna.UI.WinForms.GunaPictureBox pbUser;
        private Guna.UI.WinForms.GunaPictureBox pbPassword;
        private Guna.UI.WinForms.GunaElipsePanel pnlRegistrarUsuario;
        private Guna.UI.WinForms.GunaAdvenceButton btnRegistrarUsuario;
        private Guna.UI.WinForms.GunaLineTextBox tbEdad;
        private Guna.UI.WinForms.GunaLineTextBox tbNombre;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLineTextBox tbCrearContraseña;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox tbNuevoUsuario;
        private Guna.UI.WinForms.GunaCircleButton btnCancel;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaLineTextBox tbConfirmarContrasena;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox4;
    }
}

