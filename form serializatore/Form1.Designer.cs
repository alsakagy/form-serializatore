namespace form_serializatore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inserisci_Oggetto = new System.Windows.Forms.Button();
            this.Nome_Text = new System.Windows.Forms.TextBox();
            this.Cognome_Text = new System.Windows.Forms.TextBox();
            this.Età_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lista_Oggetti = new System.Windows.Forms.ListBox();
            this.Salva_Oggetti = new System.Windows.Forms.Button();
            this.Elimina_Oggetti = new System.Windows.Forms.Button();
            this.Modifica_Oggetti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inserisci_Oggetto
            // 
            this.Inserisci_Oggetto.Location = new System.Drawing.Point(94, 295);
            this.Inserisci_Oggetto.Name = "Inserisci_Oggetto";
            this.Inserisci_Oggetto.Size = new System.Drawing.Size(154, 47);
            this.Inserisci_Oggetto.TabIndex = 0;
            this.Inserisci_Oggetto.Text = "inserisci persona";
            this.Inserisci_Oggetto.UseVisualStyleBackColor = true;
            this.Inserisci_Oggetto.Click += new System.EventHandler(this.Inserisci_Oggetto_Click);
            // 
            // Nome_Text
            // 
            this.Nome_Text.Location = new System.Drawing.Point(74, 74);
            this.Nome_Text.Name = "Nome_Text";
            this.Nome_Text.Size = new System.Drawing.Size(193, 20);
            this.Nome_Text.TabIndex = 1;
            // 
            // Cognome_Text
            // 
            this.Cognome_Text.Location = new System.Drawing.Point(75, 155);
            this.Cognome_Text.Name = "Cognome_Text";
            this.Cognome_Text.Size = new System.Drawing.Size(192, 20);
            this.Cognome_Text.TabIndex = 2;
            // 
            // Età_Text
            // 
            this.Età_Text.Location = new System.Drawing.Point(75, 233);
            this.Età_Text.Name = "Età_Text";
            this.Età_Text.Size = new System.Drawing.Size(192, 20);
            this.Età_Text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "età:";
            // 
            // Lista_Oggetti
            // 
            this.Lista_Oggetti.FormattingEnabled = true;
            this.Lista_Oggetti.Location = new System.Drawing.Point(345, 34);
            this.Lista_Oggetti.Name = "Lista_Oggetti";
            this.Lista_Oggetti.Size = new System.Drawing.Size(550, 394);
            this.Lista_Oggetti.TabIndex = 7;
            // 
            // Salva_Oggetti
            // 
            this.Salva_Oggetti.Location = new System.Drawing.Point(358, 460);
            this.Salva_Oggetti.Name = "Salva_Oggetti";
            this.Salva_Oggetti.Size = new System.Drawing.Size(154, 47);
            this.Salva_Oggetti.TabIndex = 8;
            this.Salva_Oggetti.Text = "Salva";
            this.Salva_Oggetti.UseVisualStyleBackColor = true;
            this.Salva_Oggetti.Click += new System.EventHandler(this.Salva_Oggetti_Click);
            // 
            // Elimina_Oggetti
            // 
            this.Elimina_Oggetti.Enabled = false;
            this.Elimina_Oggetti.Location = new System.Drawing.Point(543, 460);
            this.Elimina_Oggetti.Name = "Elimina_Oggetti";
            this.Elimina_Oggetti.Size = new System.Drawing.Size(154, 47);
            this.Elimina_Oggetti.TabIndex = 9;
            this.Elimina_Oggetti.Text = "Elimina";
            this.Elimina_Oggetti.UseVisualStyleBackColor = true;
            this.Elimina_Oggetti.Click += new System.EventHandler(this.Elimina_Oggetti_Click);
            // 
            // Modifica_Oggetti
            // 
            this.Modifica_Oggetti.Enabled = false;
            this.Modifica_Oggetti.Location = new System.Drawing.Point(724, 460);
            this.Modifica_Oggetti.Name = "Modifica_Oggetti";
            this.Modifica_Oggetti.Size = new System.Drawing.Size(154, 47);
            this.Modifica_Oggetti.TabIndex = 10;
            this.Modifica_Oggetti.Text = "Modifica";
            this.Modifica_Oggetti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 587);
            this.Controls.Add(this.Modifica_Oggetti);
            this.Controls.Add(this.Elimina_Oggetti);
            this.Controls.Add(this.Salva_Oggetti);
            this.Controls.Add(this.Lista_Oggetti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Età_Text);
            this.Controls.Add(this.Cognome_Text);
            this.Controls.Add(this.Nome_Text);
            this.Controls.Add(this.Inserisci_Oggetto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inserisci_Oggetto;
        private System.Windows.Forms.TextBox Nome_Text;
        private System.Windows.Forms.TextBox Cognome_Text;
        private System.Windows.Forms.TextBox Età_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Lista_Oggetti;
        private System.Windows.Forms.Button Salva_Oggetti;
        private System.Windows.Forms.Button Elimina_Oggetti;
        private System.Windows.Forms.Button Modifica_Oggetti;
    }
}

