using System;
using System.Windows.Forms;
using System.Collections;
using BibliotecaPersonas;

namespace Agenda_Ejercicio11
{
    public partial class Form1 : Form
    {
        ArrayList personas;
        private int indice;

        public int Indice 
        {
            get => indice;
            set
            {
                if(personas.Count > 0 && value > personas.Count)
                {
                    indice = value;
                }
                else
                {
                    indice = 0;
                }
                
            }
        }
        public Form1()
        {
            InitializeComponent();
            personas = new ArrayList();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Guardar();


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {

                Persona persona = (Persona)personas[Indice++];


                txtbNombre.Text = persona.Nombre;
                txtbTelefono.Text = persona.Telefono;
                txtbEdad.Text = persona.Edad.ToString();
                txtbDireccion.Text = persona.Direccion;
            }

            catch(NullReferenceException error)
            {

                MessageBox.Show("");

            }
            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show("Error: Debes agregar al menos una persona");
            }

        }

        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                Guardar();
        }

        private void Guardar()
        {
            personas.Add(new Persona(txtbNombre.Text, txtbTelefono.Text, byte.Parse(txtbEdad.Text), txtbDireccion.Text));
            
            txtbNombre.Clear();
            txtbTelefono.Clear();
            txtbEdad.Clear();
            txtbDireccion.Clear();

        }
    }
}
