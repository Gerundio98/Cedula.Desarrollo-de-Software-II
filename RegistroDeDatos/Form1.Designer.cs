namespace RegistroDeDatos
{
    partial class Form1
    {
      
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlantillaCedula = new System.Windows.Forms.PictureBox();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumeroCedula = new System.Windows.Forms.TextBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.ImagenCiudadano = new System.Windows.Forms.PictureBox();
            this.FechaDeNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoRegistro = new System.Windows.Forms.Button();
            this.CancelarButtom = new System.Windows.Forms.Button();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.SangreComboBox = new System.Windows.Forms.ComboBox();
            this.EstadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.FechaDeEmisionPicker = new System.Windows.Forms.DateTimePicker();
            this.EliminarButtom = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblLugarNacimiento = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.CargarEditarImagenButtom = new System.Windows.Forms.Button();
            this.dgvDatosCiudadanos = new System.Windows.Forms.DataGridView();
            this.openFileDialogImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCiudadano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCiudadanos)).BeginInit();
            this.SuspendLayout();
            // 
            // PlantillaCedula
            // 
            this.PlantillaCedula.Image = global::RegistroDeDatos.Properties.Resources.descarga;
            this.PlantillaCedula.Location = new System.Drawing.Point(12, 22);
            this.PlantillaCedula.Name = "PlantillaCedula";
            this.PlantillaCedula.Size = new System.Drawing.Size(811, 496);
            this.PlantillaCedula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlantillaCedula.TabIndex = 0;
            this.PlantillaCedula.TabStop = false;
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.BackColor = System.Drawing.Color.LimeGreen;
            this.GuardarButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GuardarButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButtom.Enabled = false;
            this.GuardarButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarButtom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuardarButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuardarButtom.Location = new System.Drawing.Point(348, 425);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(83, 85);
            this.GuardarButtom.TabIndex = 4;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.UseVisualStyleBackColor = false;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // txtNumeroCedula
            // 
            this.txtNumeroCedula.Location = new System.Drawing.Point(348, 136);
            this.txtNumeroCedula.Name = "txtNumeroCedula";
            this.txtNumeroCedula.Size = new System.Drawing.Size(291, 23);
            this.txtNumeroCedula.TabIndex = 6;
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(274, 198);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(237, 23);
            this.txtLugarNacimiento.TabIndex = 7;
            this.txtLugarNacimiento.Visible = false;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(397, 339);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(179, 23);
            this.txtOcupacion.TabIndex = 13;
            this.txtOcupacion.Visible = false;
            // 
            // ImagenCiudadano
            // 
            this.ImagenCiudadano.BackColor = System.Drawing.SystemColors.Window;
            this.ImagenCiudadano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenCiudadano.Location = new System.Drawing.Point(47, 127);
            this.ImagenCiudadano.Name = "ImagenCiudadano";
            this.ImagenCiudadano.Size = new System.Drawing.Size(202, 244);
            this.ImagenCiudadano.TabIndex = 15;
            this.ImagenCiudadano.TabStop = false;
            this.ImagenCiudadano.Visible = false;
            // 
            // FechaDeNacimientoPicker
            // 
            this.FechaDeNacimientoPicker.Location = new System.Drawing.Point(274, 250);
            this.FechaDeNacimientoPicker.Name = "FechaDeNacimientoPicker";
            this.FechaDeNacimientoPicker.Size = new System.Drawing.Size(237, 23);
            this.FechaDeNacimientoPicker.TabIndex = 18;
            this.FechaDeNacimientoPicker.Visible = false;
            // 
            // NuevoRegistro
            // 
            this.NuevoRegistro.BackColor = System.Drawing.Color.Wheat;
            this.NuevoRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NuevoRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NuevoRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NuevoRegistro.Location = new System.Drawing.Point(53, 484);
            this.NuevoRegistro.Name = "NuevoRegistro";
            this.NuevoRegistro.Size = new System.Drawing.Size(289, 25);
            this.NuevoRegistro.TabIndex = 19;
            this.NuevoRegistro.Text = "Nuevo Registro";
            this.NuevoRegistro.UseVisualStyleBackColor = false;
            this.NuevoRegistro.Click += new System.EventHandler(this.NuevoRegistro_Click);
            // 
            // CancelarButtom
            // 
            this.CancelarButtom.BackColor = System.Drawing.Color.Orange;
            this.CancelarButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButtom.Enabled = false;
            this.CancelarButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarButtom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelarButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelarButtom.Location = new System.Drawing.Point(437, 425);
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Size = new System.Drawing.Size(83, 41);
            this.CancelarButtom.TabIndex = 21;
            this.CancelarButtom.Text = "Cancelar";
            this.CancelarButtom.UseVisualStyleBackColor = false;
            this.CancelarButtom.Click += new System.EventHandler(this.CancelarButtom_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(421, 281);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(272, 23);
            this.txtNacionalidad.TabIndex = 9;
            this.txtNacionalidad.Visible = false;
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.SexoComboBox.Location = new System.Drawing.Point(335, 308);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SexoComboBox.Size = new System.Drawing.Size(32, 23);
            this.SexoComboBox.TabIndex = 22;
            this.SexoComboBox.Visible = false;
            // 
            // SangreComboBox
            // 
            this.SangreComboBox.FormattingEnabled = true;
            this.SangreComboBox.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.SangreComboBox.Location = new System.Drawing.Point(451, 308);
            this.SangreComboBox.Name = "SangreComboBox";
            this.SangreComboBox.Size = new System.Drawing.Size(51, 23);
            this.SangreComboBox.TabIndex = 23;
            this.SangreComboBox.Visible = false;
            // 
            // EstadoCivilComboBox
            // 
            this.EstadoCivilComboBox.FormattingEnabled = true;
            this.EstadoCivilComboBox.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Unión Libre"});
            this.EstadoCivilComboBox.Location = new System.Drawing.Point(632, 310);
            this.EstadoCivilComboBox.Name = "EstadoCivilComboBox";
            this.EstadoCivilComboBox.Size = new System.Drawing.Size(116, 23);
            this.EstadoCivilComboBox.TabIndex = 24;
            this.EstadoCivilComboBox.Visible = false;
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.BackColor = System.Drawing.Color.Moccasin;
            this.BuscarButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarButtom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuscarButtom.Location = new System.Drawing.Point(645, 136);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(75, 25);
            this.BuscarButtom.TabIndex = 25;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.UseVisualStyleBackColor = false;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // FechaDeEmisionPicker
            // 
            this.FechaDeEmisionPicker.Location = new System.Drawing.Point(451, 368);
            this.FechaDeEmisionPicker.Name = "FechaDeEmisionPicker";
            this.FechaDeEmisionPicker.Size = new System.Drawing.Size(237, 23);
            this.FechaDeEmisionPicker.TabIndex = 26;
            this.FechaDeEmisionPicker.Visible = false;
            // 
            // EliminarButtom
            // 
            this.EliminarButtom.BackColor = System.Drawing.Color.OrangeRed;
            this.EliminarButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButtom.Enabled = false;
            this.EliminarButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EliminarButtom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EliminarButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarButtom.Location = new System.Drawing.Point(437, 472);
            this.EliminarButtom.Name = "EliminarButtom";
            this.EliminarButtom.Size = new System.Drawing.Size(83, 38);
            this.EliminarButtom.TabIndex = 27;
            this.EliminarButtom.Text = "Eliminar";
            this.EliminarButtom.UseVisualStyleBackColor = false;
            this.EliminarButtom.Click += new System.EventHandler(this.EliminarButtom_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(144, 425);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(198, 23);
            this.txtNombres.TabIndex = 28;
            this.txtNombres.Visible = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(144, 454);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(198, 23);
            this.txtApellidos.TabIndex = 29;
            this.txtApellidos.Visible = false;
            // 
            // lblLugarNacimiento
            // 
            this.lblLugarNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLugarNacimiento.Location = new System.Drawing.Point(274, 175);
            this.lblLugarNacimiento.Name = "lblLugarNacimiento";
            this.lblLugarNacimiento.Size = new System.Drawing.Size(237, 20);
            this.lblLugarNacimiento.TabIndex = 32;
            this.lblLugarNacimiento.Text = "Lugar de Nacimiento :";
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCedula.Location = new System.Drawing.Point(274, 136);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(68, 23);
            this.lblCedula.TabIndex = 40;
            this.lblCedula.Text = "Cedula :";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(274, 227);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(237, 20);
            this.lblFechaNacimiento.TabIndex = 41;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento :";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidad.Location = new System.Drawing.Point(274, 279);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(141, 23);
            this.lblNacionalidad.TabIndex = 42;
            this.lblNacionalidad.Text = "Nacionalidad :";
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(274, 308);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(55, 23);
            this.lblSexo.TabIndex = 43;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblSangre
            // 
            this.lblSangre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSangre.Location = new System.Drawing.Point(373, 308);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(72, 23);
            this.lblSangre.TabIndex = 44;
            this.lblSangre.Text = "Sangre :";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoCivil.Location = new System.Drawing.Point(508, 308);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(118, 23);
            this.lblEstadoCivil.TabIndex = 45;
            this.lblEstadoCivil.Text = "Estado Civil :";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOcupacion.Location = new System.Drawing.Point(274, 337);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(117, 23);
            this.lblOcupacion.TabIndex = 46;
            this.lblOcupacion.Text = "Ocupación :";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaEmision.Location = new System.Drawing.Point(274, 366);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(171, 23);
            this.lblFechaEmision.TabIndex = 47;
            this.lblFechaEmision.Text = "Fecha de Emisión :";
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombres.Location = new System.Drawing.Point(53, 425);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(85, 23);
            this.lblNombres.TabIndex = 48;
            this.lblNombres.Text = "Nombres :";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidos.Location = new System.Drawing.Point(53, 454);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(85, 23);
            this.lblApellidos.TabIndex = 49;
            this.lblApellidos.Text = "Apellidos :";
            // 
            // CargarEditarImagenButtom
            // 
            this.CargarEditarImagenButtom.BackColor = System.Drawing.Color.PapayaWhip;
            this.CargarEditarImagenButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarEditarImagenButtom.Enabled = false;
            this.CargarEditarImagenButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CargarEditarImagenButtom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CargarEditarImagenButtom.Location = new System.Drawing.Point(47, 377);
            this.CargarEditarImagenButtom.Name = "CargarEditarImagenButtom";
            this.CargarEditarImagenButtom.Size = new System.Drawing.Size(202, 25);
            this.CargarEditarImagenButtom.TabIndex = 50;
            this.CargarEditarImagenButtom.Text = "Cargar / Editar Imagen";
            this.CargarEditarImagenButtom.UseVisualStyleBackColor = false;
            this.CargarEditarImagenButtom.Click += new System.EventHandler(this.CargarEditarImagenButtom_Click);
            // 
            // dgvDatosCiudadanos
            // 
            this.dgvDatosCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCiudadanos.Location = new System.Drawing.Point(829, 22);
            this.dgvDatosCiudadanos.Name = "dgvDatosCiudadanos";
            this.dgvDatosCiudadanos.RowTemplate.Height = 25;
            this.dgvDatosCiudadanos.Size = new System.Drawing.Size(384, 496);
            this.dgvDatosCiudadanos.TabIndex = 51;
            // 
            // openFileDialogImagen
            // 
            this.openFileDialogImagen.FileName = "openFileDialogImagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1225, 521);
            this.Controls.Add(this.dgvDatosCiudadanos);
            this.Controls.Add(this.CargarEditarImagenButtom);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblSangre);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblLugarNacimiento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.EliminarButtom);
            this.Controls.Add(this.FechaDeEmisionPicker);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.EstadoCivilComboBox);
            this.Controls.Add(this.SangreComboBox);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.NuevoRegistro);
            this.Controls.Add(this.FechaDeNacimientoPicker);
            this.Controls.Add(this.ImagenCiudadano);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtLugarNacimiento);
            this.Controls.Add(this.txtNumeroCedula);
            this.Controls.Add(this.GuardarButtom);
            this.Controls.Add(this.PlantillaCedula);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCiudadano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCiudadanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PlantillaCedula;
        private Button GuardarButtom;
        private BindingSource bindingSource1;
        private TextBox txtNumeroCedula;
        private TextBox txtLugarNacimiento;
        private TextBox txtOcupacion;
        private PictureBox ImagenCiudadano;
        private DateTimePicker FechaDeNacimientoPicker;
        private Button NuevoRegistro;
        private Button CancelarButtom;
        private TextBox txtNacionalidad;
        private ComboBox SexoComboBox;
        private ComboBox SangreComboBox;
        private ComboBox EstadoCivilComboBox;
        private Button BuscarButtom;
        private DateTimePicker FechaDeEmisionPicker;
        private Button EliminarButtom;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label lblLugarNacimiento;
        private Label lblCedula;
        private Label lblFechaNacimiento;
        private Label lblNacionalidad;
        private Label lblSexo;
        private Label lblSangre;
        private Label lblEstadoCivil;
        private Label lblOcupacion;
        private Label lblFechaEmision;
        private Label lblNombres;
        private Label lblApellidos;
        private Button CargarEditarImagenButtom;
        private DataGridView dgvDatosCiudadanos;
        private OpenFileDialog openFileDialogImagen;
    }
}