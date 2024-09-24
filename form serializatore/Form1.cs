using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_serializatore
{
    public partial class Form1 : Form
    {
        private List<Persona> PersonaLista;
        private string File = "Elenco.txt";
        private StreamWriter Sw;
        private StreamReader Sr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonaLista = new List<Persona>();
            // caricamento lista
            try
            {
                Sr = new StreamReader(File);
                string Riga = Sr.ReadLine();
                while (Riga != null)
                {
                    Persona Oggetto = new Persona(Riga.Split(';')[0], Riga.Split(';')[1], Riga.Split(';')[2]);
                    PersonaLista.Add(Oggetto);
                    Lista_Oggetti.Items.Add($"Nome: {Oggetto.Nome}   Cognome: {Oggetto.Cognome}   Età: {Oggetto.Età}");
                    Riga = Sr.ReadLine();
                }
                Sr.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("il file non esiste verrà creato");
            }
        }

        private void Inserisci_Oggetto_Click(object sender, EventArgs e)
        {
            Persona Oggetto = new Persona(Nome_Text.Text, Cognome_Text.Text, Età_Text.Text);
            PersonaLista.Add(Oggetto);
            Lista_Oggetti.Items.Add($"Nome: {Oggetto.Nome}   Cognome: {Oggetto.Cognome}   Età: {Oggetto.Età}");
            Nome_Text.Text = "";
            Cognome_Text.Text = "";
            Età_Text.Text = "";
        }

        private void Salva_Oggetti_Click(object sender, EventArgs e)
        {
            Sw = new StreamWriter(File);
            for (int i = 0; i < PersonaLista.Count; i++)
            {
                Sw.WriteLine($"{PersonaLista[i].Nome};{PersonaLista[i].Cognome};{PersonaLista[i].Età}");
            }
            Sw.Close();
        }

        private void Elimina_Oggetti_Click(object sender, EventArgs e)
        {
            PersonaLista.RemoveAt(Lista_Oggetti.SelectedIndex);
            Lista_Oggetti.Items.RemoveAt(Lista_Oggetti.SelectedIndex);
            Elimina_Oggetti.Enabled = false;
            Modifica_Oggetti.Enabled = false;
        }

        private void Lista_Oggetti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Elimina_Oggetti.Enabled = true;
            Modifica_Oggetti.Enabled = true;
        }

        private void Modifica_Oggetti_Click(object sender, EventArgs e)
        {
            if(Nome_Text.Text != "")
            {
                PersonaLista[Lista_Oggetti.SelectedIndex].Nome = Nome_Text.Text;
            }

            if (Cognome_Text.Text != "")
            {
                PersonaLista[Lista_Oggetti.SelectedIndex].Cognome = Cognome_Text.Text;
            }
            
            if (Età_Text.Text != "")
            {
                PersonaLista[Lista_Oggetti.SelectedIndex].Età = Età_Text.Text;
            }

            Lista_Oggetti.Items.Clear();
            for (int i = 0; i < PersonaLista.Count; i++)
            {
                Lista_Oggetti.Items.Add($"Nome: {PersonaLista[i].Nome}   Cognome: {PersonaLista[i].Cognome}   Età: {PersonaLista[i].Età}");
            }
        }

        private void Ricerca_Oggetti_Click(object sender, EventArgs e)
        {
            Inserisci_Oggetto.Enabled = false;
            Elimina_Oggetti.Enabled = false;
            Modifica_Oggetti.Enabled = false;
            Salva_Oggetti.Enabled = false;
            Ricerca_Oggetti.Enabled = false;
            Lista_Oggetti.Enabled = false;
            Avvia_Ricerca.Visible = true;
        }

        private void Avvia_Ricerca_Click(object sender, EventArgs e)
        {
            Avvia_Ricerca.Enabled = false;
            Fine_Ricerca.Visible = true;
            List<Persona> PersonaRicercata = new List<Persona>();
            PersonaRicercata = PersonaLista.FindAll(Criterio);
            Lista_Oggetti.Items.Clear();
            for (int i = 0; i < PersonaRicercata.Count; i++)
            {
                Lista_Oggetti.Items.Add($"Nome: {PersonaRicercata[i].Nome}   Cognome: {PersonaRicercata[i].Cognome}   Età: {PersonaRicercata[i].Età}");
            }
        }

        public bool Criterio(Persona a)
        {
            if (a.Nome == Nome_Text.Text && a.Cognome == Cognome_Text.Text && a.Età == Età_Text.Text)
            {
                return true;
            }
            else if (a.Nome == Nome_Text.Text && a.Cognome == Cognome_Text.Text)
            {
                return true;
            }
            else if (a.Nome == Nome_Text.Text && a.Età == Età_Text.Text)
            {
                return true;
            }
            else if (a.Cognome == Cognome_Text.Text && a.Età == Età_Text.Text)
            {
                return true;
            }
            else if (a.Nome == Nome_Text.Text || a.Cognome == Cognome_Text.Text || a.Età == Età_Text.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Fine_Ricerca_Click(object sender, EventArgs e)
        {
            Inserisci_Oggetto.Enabled = true;
            Elimina_Oggetti.Enabled = true;
            Modifica_Oggetti.Enabled = true;
            Ricerca_Oggetti.Enabled = true;
            Salva_Oggetti.Enabled = true;
            Lista_Oggetti.Enabled = true;
            Avvia_Ricerca.Enabled = true;
            Avvia_Ricerca.Visible = false;
            Fine_Ricerca.Visible = false;

            Lista_Oggetti.Items.Clear();
            for (int i = 0; i < PersonaLista.Count; i++)
            {
                Lista_Oggetti.Items.Add($"Nome: {PersonaLista[i].Nome}   Cognome: {PersonaLista[i].Cognome}   Età: {PersonaLista[i].Età}");
            }
        }
    }
    public class Persona
    {
        private string nome;
        private string cognome;
        private string età;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public string Età
        {
            get { return età; }
            set { età = value; }
        }
        public Persona(string a, string b, string c)
        {
            nome = a;
            cognome = b;
            età = c;
        }
    }
}
