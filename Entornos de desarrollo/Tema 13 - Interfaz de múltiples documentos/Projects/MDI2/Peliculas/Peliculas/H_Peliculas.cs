using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace H_Peliculas
{
    public partial class H_EjercicioPeliculas : Form
    {
        MDI2_PADRE padre; 
        public H_EjercicioPeliculas(MDI2_PADRE padre)
        {
            InitializeComponent();
            this.padre = padre;
            addItems();
        }

        int i = 1;

        public void addItems()
        {
            cbPeliculas.Items.Add("Kill Bill");
            cbPeliculas.Items.Add("Django");
            cbPeliculas.Items.Add("Abierto hasta el amanacer");
        }

        private void cbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Start();
            lFichaText.Visible = true;
            lSinopsisText.Visible = true;
            String sinopsis = "";
            String fichatecnica = "";
            switch (cbPeliculas.SelectedItem.ToString()) 
            {
                case "Kill Bill":
                    pbImagenes.Image = ilKillBill.Images[0];
                    fichatecnica = "Dirección: Llonito Quintanio Tarantino \nProducción: Lawrence Bender \nActores: Uma Thurman, David Carradine, Daryl Hannah";
                    sinopsis = "Kill Bill es una película de acción y suspense estadounidense de dos partes estrenada en 2003 y 2004 respectivamente, que fue escrita y dirigida por Quentin Tarantino. Kill Bill originalmente fue propuesta para tener un lanzamiento único en los cines, pero con una duración de más de cuatro horas, fue separada en dos volúmenes: Kill Bill: Volumen 1, lanzada a finales de 2003, y Kill Bill: Volumen 2, lanzada a inicios de 2004.";
                    break;
                case "Django":
                    pbImagenes.Image = ilDjango.Images[0];
                    fichatecnica = "Dirección: Llonito Quintanio Tarantino \nProducción: Brad Pitt, Pilar Savone \nGuion: Llonito Quintanio Tarantino";
                    sinopsis = "Un dentista alemán y cazador de recompensas, el doctor King Schultz (Christoph Waltz) consigue liberar a Django (Jamie Foxx), un esclavo negro vendido a los hermanos Speck (James Remar y James Russo). Después de comprar a Django, Schultz se vale de él para encontrar a los criminales más buscados del Sur como los tres hermanos Brittle (antiguos esclavistas que oprimieron a Django), vivos o muertos, sobre los que pesan sendas recompensas.";
                    break;
                case "Abierto hasta el amanacer":
                    pbImagenes.Image = ilAbierto.Images[0];
                    fichatecnica = "Dirección: Roberto Rodríguez \nProducción: Gianni Nunnari, Meir Teper\nGuion: Llonito Quintanio Tarantino";
                    sinopsis = "From Dusk Till Dawn (Del crepúsculo al amanecer en Hispanoamérica y Abierto hasta el amanecer en España) es una película estadounidense de acción-comedia negra y terror de 1996 dirigida por Robert Rodríguez y escrita por Quentin Tarantino. Es protagonizada por George Clooney, Quentin Tarantino, Harvey Keitel, Juliette Lewis, Salma Hayek, Danny Trejo y Tom Savini. También participa: Cheech Marín interpretando varios personajes, destacando como Chet Pussy.";
                    break;
            }
            lFichaTecnicaDescripcion.Text = fichatecnica;
            lSinopsisDescripcion.Text = sinopsis;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (cbPeliculas.SelectedItem.ToString())
            {
                case "Kill Bill":
                    if (i >= ilKillBill.Images.Count - 1)
                        i = 0;
                    else
                        i++;
                    pbImagenes.Image = ilKillBill.Images[i];
                    break;
                case "Django":
                    if (i >= ilDjango.Images.Count - 1)
                        i = 0;
                    else
                        i++;
                    pbImagenes.Image = ilDjango.Images[i];
                    break;
                case "Abierto hasta el amanacer":
                    if (i >= ilAbierto.Images.Count - 1)
                        i = 0;
                    else
                        i++;
                    pbImagenes.Image = ilAbierto.Images[i];
                    break;
            }
        }

        private void H_EjercicioPeliculas_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
