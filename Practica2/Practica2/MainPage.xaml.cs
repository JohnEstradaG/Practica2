using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Presionar.Clicked += Presionar_clicked;
        }

        public void Presionar_clicked(Object sender,EventArgs e) {
            DisplayAlert(" "+titulo1.Text,"Hola" + "\n "+"Nombre´s: " +  Nombre.Text + "\n" + "Apellido Paterno: " +  Ape_pat.Text + "\n" + "Apellido Materno: " +  Ape_mat.Text + "\n" + "Fecha de Nacimiento: "+ Fecha.Date + "\n" + "Direccion: " + Direccion.Text + "\n" + "Telefono: " + Telefono.Text + "\n" + "\n" + titulo2.Text + "\n" + "Carrera: " + Carrera.Text + "\n" + "Semestre: " + Semestre.Text + "\n" + "Matricula: " + Matricula.Text + "\n"+ "\n" + titulo3.Text +"\n" + "Correo: " + Correo.Text + "\n" + "Github: " + Github.Text  ,"ok");
        }
    }
}
