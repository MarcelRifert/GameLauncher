namespace Game_Launcher
{
    partial class fGameLauncher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSpiele = new System.Windows.Forms.ListBox();
            this.bSpielHinzufügen = new System.Windows.Forms.Button();
            this.lTitel = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.bPfadKopieren = new System.Windows.Forms.Button();
            this.tbInstallationsDatum = new System.Windows.Forms.TextBox();
            this.lInstallationsDatum = new System.Windows.Forms.Label();
            this.tbZuletztGespielt = new System.Windows.Forms.TextBox();
            this.lZuletztGespielt = new System.Windows.Forms.Label();
            this.tbInstallationsPfad = new System.Windows.Forms.TextBox();
            this.lInstallationsPfad = new System.Windows.Forms.Label();
            this.tbKategorien = new System.Windows.Forms.TextBox();
            this.lKategorien = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lPublisher = new System.Windows.Forms.Label();
            this.tbUSK = new System.Windows.Forms.TextBox();
            this.lUSK = new System.Windows.Forms.Label();
            this.bStarten = new System.Windows.Forms.Button();
            this.bSpielEntfernen = new System.Windows.Forms.Button();
            this.gbSpielHinzufügen = new System.Windows.Forms.GroupBox();
            this.tbUSKHinzufügen = new System.Windows.Forms.TextBox();
            this.lUSKHinzufügen = new System.Windows.Forms.Label();
            this.tbKategorienHinzufügen = new System.Windows.Forms.TextBox();
            this.lKategorienHinzufügen = new System.Windows.Forms.Label();
            this.tbPfadHinzufügen = new System.Windows.Forms.TextBox();
            this.lPfadHinzufügen = new System.Windows.Forms.Label();
            this.bSuchen = new System.Windows.Forms.Button();
            this.ofdSpielSuchen = new System.Windows.Forms.OpenFileDialog();
            this.gbDetails.SuspendLayout();
            this.gbSpielHinzufügen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSpiele
            // 
            this.lbSpiele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpiele.FormattingEnabled = true;
            this.lbSpiele.ItemHeight = 25;
            this.lbSpiele.Location = new System.Drawing.Point(12, 12);
            this.lbSpiele.Name = "lbSpiele";
            this.lbSpiele.Size = new System.Drawing.Size(331, 429);
            this.lbSpiele.TabIndex = 0;
            this.lbSpiele.SelectedIndexChanged += new System.EventHandler(this.lbSpiele_SelectedIndexChanged);
            // 
            // bSpielHinzufügen
            // 
            this.bSpielHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpielHinzufügen.Location = new System.Drawing.Point(349, 410);
            this.bSpielHinzufügen.Name = "bSpielHinzufügen";
            this.bSpielHinzufügen.Size = new System.Drawing.Size(219, 40);
            this.bSpielHinzufügen.TabIndex = 1;
            this.bSpielHinzufügen.Text = "Spiel Hinzufügen";
            this.bSpielHinzufügen.UseVisualStyleBackColor = true;
            this.bSpielHinzufügen.Click += new System.EventHandler(this.bSpielHinzufügen_Click);
            // 
            // lTitel
            // 
            this.lTitel.AutoSize = true;
            this.lTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitel.Location = new System.Drawing.Point(6, 16);
            this.lTitel.Name = "lTitel";
            this.lTitel.Size = new System.Drawing.Size(42, 20);
            this.lTitel.TabIndex = 2;
            this.lTitel.Text = "Titel:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.bStarten);
            this.gbDetails.Controls.Add(this.tbUSK);
            this.gbDetails.Controls.Add(this.lUSK);
            this.gbDetails.Controls.Add(this.tbPublisher);
            this.gbDetails.Controls.Add(this.lPublisher);
            this.gbDetails.Controls.Add(this.tbKategorien);
            this.gbDetails.Controls.Add(this.lKategorien);
            this.gbDetails.Controls.Add(this.bPfadKopieren);
            this.gbDetails.Controls.Add(this.tbInstallationsPfad);
            this.gbDetails.Controls.Add(this.lInstallationsPfad);
            this.gbDetails.Controls.Add(this.tbZuletztGespielt);
            this.gbDetails.Controls.Add(this.lZuletztGespielt);
            this.gbDetails.Controls.Add(this.tbInstallationsDatum);
            this.gbDetails.Controls.Add(this.lInstallationsDatum);
            this.gbDetails.Controls.Add(this.tbTitel);
            this.gbDetails.Controls.Add(this.lTitel);
            this.gbDetails.Location = new System.Drawing.Point(349, 12);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(440, 246);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Spielinformationen";
            // 
            // tbTitel
            // 
            this.tbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitel.Location = new System.Drawing.Point(54, 13);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbTitel.Size = new System.Drawing.Size(293, 26);
            this.tbTitel.TabIndex = 4;
            // 
            // bPfadKopieren
            // 
            this.bPfadKopieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPfadKopieren.Location = new System.Drawing.Point(353, 107);
            this.bPfadKopieren.Name = "bPfadKopieren";
            this.bPfadKopieren.Size = new System.Drawing.Size(81, 31);
            this.bPfadKopieren.TabIndex = 5;
            this.bPfadKopieren.Text = "Kopieren";
            this.bPfadKopieren.UseVisualStyleBackColor = true;
            this.bPfadKopieren.Click += new System.EventHandler(this.bPfadKopieren_Click);
            // 
            // tbInstallationsDatum
            // 
            this.tbInstallationsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstallationsDatum.Location = new System.Drawing.Point(162, 45);
            this.tbInstallationsDatum.Name = "tbInstallationsDatum";
            this.tbInstallationsDatum.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbInstallationsDatum.Size = new System.Drawing.Size(185, 26);
            this.tbInstallationsDatum.TabIndex = 6;
            // 
            // lInstallationsDatum
            // 
            this.lInstallationsDatum.AutoSize = true;
            this.lInstallationsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInstallationsDatum.Location = new System.Drawing.Point(6, 48);
            this.lInstallationsDatum.Name = "lInstallationsDatum";
            this.lInstallationsDatum.Size = new System.Drawing.Size(150, 20);
            this.lInstallationsDatum.TabIndex = 5;
            this.lInstallationsDatum.Text = "Installations Datum:";
            // 
            // tbZuletztGespielt
            // 
            this.tbZuletztGespielt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZuletztGespielt.Location = new System.Drawing.Point(137, 77);
            this.tbZuletztGespielt.Name = "tbZuletztGespielt";
            this.tbZuletztGespielt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbZuletztGespielt.Size = new System.Drawing.Size(210, 26);
            this.tbZuletztGespielt.TabIndex = 8;
            // 
            // lZuletztGespielt
            // 
            this.lZuletztGespielt.AutoSize = true;
            this.lZuletztGespielt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZuletztGespielt.Location = new System.Drawing.Point(6, 80);
            this.lZuletztGespielt.Name = "lZuletztGespielt";
            this.lZuletztGespielt.Size = new System.Drawing.Size(125, 20);
            this.lZuletztGespielt.TabIndex = 7;
            this.lZuletztGespielt.Text = "Zuletzt Gespielt:";
            // 
            // tbInstallationsPfad
            // 
            this.tbInstallationsPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstallationsPfad.Location = new System.Drawing.Point(147, 109);
            this.tbInstallationsPfad.Name = "tbInstallationsPfad";
            this.tbInstallationsPfad.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbInstallationsPfad.Size = new System.Drawing.Size(200, 26);
            this.tbInstallationsPfad.TabIndex = 10;
            // 
            // lInstallationsPfad
            // 
            this.lInstallationsPfad.AutoSize = true;
            this.lInstallationsPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInstallationsPfad.Location = new System.Drawing.Point(6, 112);
            this.lInstallationsPfad.Name = "lInstallationsPfad";
            this.lInstallationsPfad.Size = new System.Drawing.Size(135, 20);
            this.lInstallationsPfad.TabIndex = 9;
            this.lInstallationsPfad.Text = "Installations Pfad:";
            // 
            // tbKategorien
            // 
            this.tbKategorien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKategorien.Location = new System.Drawing.Point(102, 141);
            this.tbKategorien.Name = "tbKategorien";
            this.tbKategorien.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbKategorien.Size = new System.Drawing.Size(245, 26);
            this.tbKategorien.TabIndex = 12;
            // 
            // lKategorien
            // 
            this.lKategorien.AutoSize = true;
            this.lKategorien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKategorien.Location = new System.Drawing.Point(6, 144);
            this.lKategorien.Name = "lKategorien";
            this.lKategorien.Size = new System.Drawing.Size(90, 20);
            this.lKategorien.TabIndex = 11;
            this.lKategorien.Text = "Kategorien:";
            // 
            // tbPublisher
            // 
            this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublisher.Location = new System.Drawing.Point(90, 173);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbPublisher.Size = new System.Drawing.Size(257, 26);
            this.tbPublisher.TabIndex = 14;
            // 
            // lPublisher
            // 
            this.lPublisher.AutoSize = true;
            this.lPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPublisher.Location = new System.Drawing.Point(6, 176);
            this.lPublisher.Name = "lPublisher";
            this.lPublisher.Size = new System.Drawing.Size(78, 20);
            this.lPublisher.TabIndex = 13;
            this.lPublisher.Text = "Publisher:";
            // 
            // tbUSK
            // 
            this.tbUSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUSK.Location = new System.Drawing.Point(137, 205);
            this.tbUSK.Name = "tbUSK";
            this.tbUSK.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbUSK.Size = new System.Drawing.Size(210, 26);
            this.tbUSK.TabIndex = 16;
            // 
            // lUSK
            // 
            this.lUSK.AutoSize = true;
            this.lUSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUSK.Location = new System.Drawing.Point(6, 208);
            this.lUSK.Name = "lUSK";
            this.lUSK.Size = new System.Drawing.Size(128, 20);
            this.lUSK.TabIndex = 15;
            this.lUSK.Text = "USK-Einstufung:";
            // 
            // bStarten
            // 
            this.bStarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStarten.Location = new System.Drawing.Point(353, 11);
            this.bStarten.Name = "bStarten";
            this.bStarten.Size = new System.Drawing.Size(81, 31);
            this.bStarten.TabIndex = 17;
            this.bStarten.Text = "Starten";
            this.bStarten.UseVisualStyleBackColor = true;
            this.bStarten.Click += new System.EventHandler(this.bStarten_Click);
            // 
            // bSpielEntfernen
            // 
            this.bSpielEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpielEntfernen.Location = new System.Drawing.Point(574, 410);
            this.bSpielEntfernen.Name = "bSpielEntfernen";
            this.bSpielEntfernen.Size = new System.Drawing.Size(215, 40);
            this.bSpielEntfernen.TabIndex = 4;
            this.bSpielEntfernen.Text = "Spiel Entfernen";
            this.bSpielEntfernen.UseVisualStyleBackColor = true;
            this.bSpielEntfernen.Click += new System.EventHandler(this.bSpielEntfernen_Click);
            // 
            // gbSpielHinzufügen
            // 
            this.gbSpielHinzufügen.Controls.Add(this.bSuchen);
            this.gbSpielHinzufügen.Controls.Add(this.tbUSKHinzufügen);
            this.gbSpielHinzufügen.Controls.Add(this.tbKategorienHinzufügen);
            this.gbSpielHinzufügen.Controls.Add(this.lUSKHinzufügen);
            this.gbSpielHinzufügen.Controls.Add(this.lPfadHinzufügen);
            this.gbSpielHinzufügen.Controls.Add(this.tbPfadHinzufügen);
            this.gbSpielHinzufügen.Controls.Add(this.lKategorienHinzufügen);
            this.gbSpielHinzufügen.Location = new System.Drawing.Point(349, 264);
            this.gbSpielHinzufügen.Name = "gbSpielHinzufügen";
            this.gbSpielHinzufügen.Size = new System.Drawing.Size(440, 130);
            this.gbSpielHinzufügen.TabIndex = 5;
            this.gbSpielHinzufügen.TabStop = false;
            this.gbSpielHinzufügen.Text = "Spiel hinzufügen";
            // 
            // tbUSKHinzufügen
            // 
            this.tbUSKHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUSKHinzufügen.Location = new System.Drawing.Point(137, 83);
            this.tbUSKHinzufügen.Name = "tbUSKHinzufügen";
            this.tbUSKHinzufügen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbUSKHinzufügen.Size = new System.Drawing.Size(210, 26);
            this.tbUSKHinzufügen.TabIndex = 23;
            // 
            // lUSKHinzufügen
            // 
            this.lUSKHinzufügen.AutoSize = true;
            this.lUSKHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUSKHinzufügen.Location = new System.Drawing.Point(6, 86);
            this.lUSKHinzufügen.Name = "lUSKHinzufügen";
            this.lUSKHinzufügen.Size = new System.Drawing.Size(128, 20);
            this.lUSKHinzufügen.TabIndex = 22;
            this.lUSKHinzufügen.Text = "USK-Einstufung:";
            // 
            // tbKategorienHinzufügen
            // 
            this.tbKategorienHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKategorienHinzufügen.Location = new System.Drawing.Point(102, 51);
            this.tbKategorienHinzufügen.Name = "tbKategorienHinzufügen";
            this.tbKategorienHinzufügen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbKategorienHinzufügen.Size = new System.Drawing.Size(245, 26);
            this.tbKategorienHinzufügen.TabIndex = 21;
            // 
            // lKategorienHinzufügen
            // 
            this.lKategorienHinzufügen.AutoSize = true;
            this.lKategorienHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKategorienHinzufügen.Location = new System.Drawing.Point(6, 54);
            this.lKategorienHinzufügen.Name = "lKategorienHinzufügen";
            this.lKategorienHinzufügen.Size = new System.Drawing.Size(90, 20);
            this.lKategorienHinzufügen.TabIndex = 20;
            this.lKategorienHinzufügen.Text = "Kategorien:";
            // 
            // tbPfadHinzufügen
            // 
            this.tbPfadHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPfadHinzufügen.Location = new System.Drawing.Point(54, 19);
            this.tbPfadHinzufügen.Name = "tbPfadHinzufügen";
            this.tbPfadHinzufügen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbPfadHinzufügen.Size = new System.Drawing.Size(293, 26);
            this.tbPfadHinzufügen.TabIndex = 19;
            // 
            // lPfadHinzufügen
            // 
            this.lPfadHinzufügen.AutoSize = true;
            this.lPfadHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPfadHinzufügen.Location = new System.Drawing.Point(6, 22);
            this.lPfadHinzufügen.Name = "lPfadHinzufügen";
            this.lPfadHinzufügen.Size = new System.Drawing.Size(46, 20);
            this.lPfadHinzufügen.TabIndex = 18;
            this.lPfadHinzufügen.Text = "Pfad:";
            // 
            // bSuchen
            // 
            this.bSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSuchen.Location = new System.Drawing.Point(353, 17);
            this.bSuchen.Name = "bSuchen";
            this.bSuchen.Size = new System.Drawing.Size(81, 31);
            this.bSuchen.TabIndex = 18;
            this.bSuchen.Text = "Suchen";
            this.bSuchen.UseVisualStyleBackColor = true;
            this.bSuchen.Click += new System.EventHandler(this.bSuchen_Click);
            // 
            // ofdSpielSuchen
            // 
            this.ofdSpielSuchen.FileName = "Spiel";
            // 
            // fGameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.bSpielEntfernen);
            this.Controls.Add(this.gbSpielHinzufügen);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.bSpielHinzufügen);
            this.Controls.Add(this.lbSpiele);
            this.Name = "fGameLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Launcher";
            this.Load += new System.EventHandler(this.fGameLauncher_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbSpielHinzufügen.ResumeLayout(false);
            this.gbSpielHinzufügen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSpiele;
        private System.Windows.Forms.Button bSpielHinzufügen;
        private System.Windows.Forms.Label lTitel;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button bStarten;
        private System.Windows.Forms.TextBox tbUSK;
        private System.Windows.Forms.Label lUSK;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label lPublisher;
        private System.Windows.Forms.TextBox tbKategorien;
        private System.Windows.Forms.Label lKategorien;
        private System.Windows.Forms.Button bPfadKopieren;
        private System.Windows.Forms.TextBox tbInstallationsPfad;
        private System.Windows.Forms.Label lInstallationsPfad;
        private System.Windows.Forms.TextBox tbZuletztGespielt;
        private System.Windows.Forms.Label lZuletztGespielt;
        private System.Windows.Forms.TextBox tbInstallationsDatum;
        private System.Windows.Forms.Label lInstallationsDatum;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Button bSpielEntfernen;
        private System.Windows.Forms.GroupBox gbSpielHinzufügen;
        private System.Windows.Forms.TextBox tbUSKHinzufügen;
        private System.Windows.Forms.TextBox tbKategorienHinzufügen;
        private System.Windows.Forms.Label lUSKHinzufügen;
        private System.Windows.Forms.Label lPfadHinzufügen;
        private System.Windows.Forms.TextBox tbPfadHinzufügen;
        private System.Windows.Forms.Label lKategorienHinzufügen;
        private System.Windows.Forms.Button bSuchen;
        private System.Windows.Forms.OpenFileDialog ofdSpielSuchen;
    }
}

