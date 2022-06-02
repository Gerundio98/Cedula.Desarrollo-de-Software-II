namespace RegistroDeDatos
{
    public partial class Form1 : Form
    {

        List<Ciudadano> Ciudadanos = new List<Ciudadano>();


        public Form1()
        {

            InitializeComponent();

        }

        private void NuevoRegistro_Click(object sender, EventArgs e)
        {
            //Habilitación de botones.
            NuevoRegistro.Enabled = false;
            CancelarButtom.Enabled = true;
            GuardarButtom.Enabled = true;
            EliminarButtom.Enabled = false;
            CargarEditarImagenButtom.Enabled = true;

            BorradoCamposRellenables();
            VisibilidadCamposRellenables();
        }
        public void GuardarButtom_Click(object sender, EventArgs e)
        {

            Editar_Guardar();
            BorradoCamposRellenables();
            OcultamientoCamposRellenables();
            GetCiudadanos();

            //Habilitación de botones.
            NuevoRegistro.Enabled = true;
            CancelarButtom.Enabled = false;
            GuardarButtom.Enabled = false;
            EliminarButtom.Enabled=false;
            CargarEditarImagenButtom.Enabled = false;
        }
        private void GetCiudadanos()
        {
            dgvDatosCiudadanos.DataSource = null;
            dgvDatosCiudadanos.DataSource = Ciudadanos;
        }

        private void AgregarCidudadanoNulo()
        {
            Ciudadanos.Add(new Ciudadano()
            {
                ID = Guid.NewGuid(),
                NumeroCedula = "",
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                LugarNacimiento = txtLugarNacimiento.Text,
                FechaDeNacimiento = FechaDeNacimientoPicker.Value,
                Nacionalidad = txtNacionalidad.Text,
                Ocupacion = txtOcupacion.Text,
                Sexo = SexoComboBox.SelectedItem,
                Sangre = SangreComboBox.SelectedItem,
                EstadoCivil = EstadoCivilComboBox.SelectedItem,
                FechaEmision = FechaDeEmisionPicker.Value,
                Imagen = ImagenCiudadano.Image,
            });

        }
        public void Editar_Guardar()
        {
            int t = 0;
                AgregarCidudadanoNulo();
            int Elementos = Ciudadanos.Count;
                for (int i = 0; i < Elementos; i++)
                {

                if (Ciudadanos[i].NumeroCedula.ToString() == txtNumeroCedula.Text)
                    {
                        Ciudadanos.Remove(Ciudadanos[Ciudadanos.Count - 1]);
                        Elementos= Ciudadanos.Count;
                        Ciudadanos[i].NumeroCedula = txtNumeroCedula.Text;
                        Ciudadanos[i].Nombres = txtNombres.Text;
                        Ciudadanos[i].Apellidos = txtApellidos.Text;
                        Ciudadanos[i].LugarNacimiento = txtLugarNacimiento.Text;
                        Ciudadanos[i].FechaDeNacimiento = FechaDeNacimientoPicker.Value;
                        Ciudadanos[i].Nacionalidad = txtNacionalidad.Text;
                        Ciudadanos[i].Ocupacion = txtOcupacion.Text;
                        Ciudadanos[i].Sexo = SexoComboBox.SelectedItem;
                        Ciudadanos[i].Sangre = SangreComboBox.SelectedItem;
                        Ciudadanos[i].EstadoCivil = EstadoCivilComboBox.SelectedItem;
                        Ciudadanos[i].FechaEmision = FechaDeEmisionPicker.Value;
                        Ciudadanos[i].Imagen = ImagenCiudadano.Image;
                        t = 1;
                    }
                    else
                    {
                    if (i == 0 && Ciudadanos[0].NumeroCedula=="")
                    {
                        Ciudadanos[0].NumeroCedula = txtNumeroCedula.Text;

                    }
                    if (i == Ciudadanos.Count-1 && t != 1 && i!=0)
                        {
                        Ciudadanos[i].NumeroCedula = txtNumeroCedula.Text;
                        }
                }

                }


        }
        
        public void Eliminar()
        {
            for (int i = 0; i < Ciudadanos.Count; i++)
            {
                if (Ciudadanos[i].NumeroCedula.ToString() == txtNumeroCedula.Text)
                {
                    Ciudadanos.Remove(Ciudadanos[i]);
                    MessageBox.Show($"El Ciudadano de cedula {txtNumeroCedula.Text}, {txtNombres.Text} {txtApellidos.Text}, ha sido eliminado");
                }
            }
        }
        private void BorradoCamposRellenables() 
        {
            //Borrado de información previa.
            txtNumeroCedula.Text = string.Empty;
            txtLugarNacimiento.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtOcupacion.Text = string.Empty;
            SangreComboBox.SelectedItem=null;
            SexoComboBox.SelectedItem = null;
            EstadoCivilComboBox.SelectedItem = null;
            txtNombres.Text= string.Empty;
            txtApellidos.Text= string.Empty;  
            ImagenCiudadano.Image = null;
        }
        private void VisibilidadCamposRellenables()
        {
            //Visibilidad de campos rellenables.
            txtNumeroCedula.Visible = true;
            txtLugarNacimiento.Visible = true;
            FechaDeNacimientoPicker.Visible = true;
            txtNacionalidad.Visible = true;
            FechaDeNacimientoPicker.Visible = true;
            SangreComboBox.Visible = true;
            SexoComboBox.Visible = true;
            EstadoCivilComboBox.Visible = true;
            FechaDeEmisionPicker.Visible = true;
            txtNombres.Visible=true;
            txtApellidos.Visible = true;
            txtOcupacion.Visible = true;
            ImagenCiudadano.Visible = true;

        }
        //Metodo de guardado
        private void OcultamientoCamposRellenables()
        {
            //Ocultamiento de campos rellenables.

            txtLugarNacimiento.Visible = false;
            FechaDeNacimientoPicker.Visible = false;
            txtNacionalidad.Visible = false;
            FechaDeNacimientoPicker.Visible = false;
            SangreComboBox.Visible = false;
            SexoComboBox.Visible = false;
            EstadoCivilComboBox.Visible = false;
            FechaDeEmisionPicker.Visible = false;
            txtNombres.Visible = false;
            txtApellidos.Visible = false;
            txtOcupacion.Visible = false;
            ImagenCiudadano.Visible = false;

        }
        //Definición de la clase ciudadano.
        public class Ciudadano
        {
            public Guid ID { get; set; }
            public string NumeroCedula { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string LugarNacimiento { get; set; }
            public DateTime FechaDeNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public object Sexo { get; set; }
            public object Sangre { get; set; }
            public object EstadoCivil { get; set; }
            public string Ocupacion { get; set; }
            public DateTime FechaEmision { get; set; }
            public Image Imagen { get; set; }
        }
        private void CancelarButtom_Click(object sender, EventArgs e)
        {
            BorradoCamposRellenables();
            OcultamientoCamposRellenables();
            NuevoRegistro.Enabled = true; 
            CancelarButtom.Enabled = false;
            GuardarButtom.Enabled = false;
            EliminarButtom.Enabled = false;
            CargarEditarImagenButtom.Enabled = false;

        }
        private  void BuscarButtom_Click(object sender, EventArgs e)
        {
            
            EliminarButtom.Enabled = true;
            CancelarButtom.Enabled = true;
            GuardarButtom.Enabled = true;
            CargarEditarImagenButtom.Enabled = true;

            OcultamientoCamposRellenables();
            txtNumeroCedula.Visible = true;

            if (txtNumeroCedula.Text==String.Empty)
            {
                MessageBox.Show("No ha ingresado en el cuadro de cedula un numero de cedula aún");
            }
            else
            {
                int t = 0;
                for (int i = 0; i < Ciudadanos.Count; i++)
                {
                    if (Ciudadanos[i].NumeroCedula.ToString() == txtNumeroCedula.Text)
                    {
                        txtNumeroCedula.Text=Ciudadanos[i].NumeroCedula.ToString();
                        txtNombres.Text=Ciudadanos[i].Nombres.ToString();
                        txtApellidos.Text=Ciudadanos[i].Apellidos.ToString();
                        txtLugarNacimiento.Text=Ciudadanos[i].LugarNacimiento.ToString();
                        FechaDeNacimientoPicker.Value = Ciudadanos[i].FechaDeNacimiento;
                        txtNacionalidad.Text=Ciudadanos[i].Nacionalidad.ToString();
                        txtOcupacion.Text=Ciudadanos[i].Ocupacion.ToString();
                        SexoComboBox.SelectedItem = Ciudadanos[i].Sexo;
                        SangreComboBox.SelectedItem = Ciudadanos[i].Sangre;
                        EstadoCivilComboBox.SelectedItem = Ciudadanos[i].EstadoCivil;
                        FechaDeEmisionPicker.Value = Ciudadanos[i].FechaEmision;
                        ImagenCiudadano.Image = Ciudadanos[i].Imagen;
                        t = 1;
                    }
                    else
                    {
                        if (i == Ciudadanos.Count && t!=1)
                        {
                            MessageBox.Show("Dicha cedula no existe en nuestra base de datos, favor intentar con otro registro.");
                        }
                        else
                        {
                            VisibilidadCamposRellenables();
                        }
                    }
                }
            }
        }

        private void EliminarButtom_Click(object sender, EventArgs e)
        {
            CancelarButtom.Enabled = false;
            GuardarButtom.Enabled = false;
            EliminarButtom.Enabled = false;
            CargarEditarImagenButtom.Enabled = false;
            Eliminar();
            GetCiudadanos();
            OcultamientoCamposRellenables();
        }

        private void dataGridViewCiudadanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarEditarImagenButtom_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogImagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialogImagen.FileName;
                    ImagenCiudadano.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }

}