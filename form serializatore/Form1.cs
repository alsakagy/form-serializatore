﻿using System;
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
            Sr = new StreamReader(File);
            string Riga = Sr.ReadLine();
            do
            {

                Riga = Sr.ReadLine();
            } while (Riga != null);
            Sr.Close();
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

        }
    }
    class Persona
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
