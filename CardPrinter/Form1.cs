using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CardPrinter
{
    public partial class Form1 : Form
    {
        private Projekt projekt = new Projekt();

        public Form1()
        {
            InitializeComponent();
            karty.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            savePDF.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openProject.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveProject.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openProject.FileName = "Project.xml";
            saveProject.FileName = openProject.FileName;
            savePDF.FileName = "Project.pdf";
        }




        private void loadFilesToListView()
        {
            string[] filePaths = Directory.GetFiles(projekt.Sciezka, "*");
            pliki.Items.Clear();
            foreach (var file in filePaths)
            {
                FileInfo f = new FileInfo(file);
                pliki.Items.Add(f.Name);
                revers.Items.Add(f.Name);
            }
            para.Enabled = true;
        }

        private void katalog_Click(object sender, EventArgs e)
        {
            var result = folderBrowser.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                projekt.Sciezka = folderBrowser.SelectedPath;
                loadFilesToListView();
            }
        }

        private void pliki_SelectedIndexChanged(object sender, EventArgs e)
        {
            lewy.Image = getImage(pliki.SelectedItem.ToString());
        }


        private System.Drawing.Image getImage(string fileName)
        {
            var bytes = File.ReadAllBytes(projekt.getFullName(fileName));
            var ms = new MemoryStream(bytes);
            var img = System.Drawing.Image.FromStream(ms);
            return img;
        }

        private void revers_SelectedIndexChanged(object sender, EventArgs e)
        {
            prawy.Image = getImage(revers.SelectedItem.ToString());
        }

        private void zapisz_Click(object sender, EventArgs e)
        {

            var result = saveProject.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                serializeProject(saveProject.FileName);
            }
        }

        private void setProjectProperties()
        {
            try
            {
                projekt.Wysokosc = int.Parse(wysokosc.Text);
                projekt.Szerokosc = int.Parse(szerokosc.Text);
                projekt.OdstepX = int.Parse(odstepX.Text);
                projekt.OdstepY = int.Parse(odstepY.Text);
                projekt.Marks = marks.Checked;
            }
            catch (Exception)
            {
            }
        }


        private void serializeProject(string fileName)
        {
            setProjectProperties();
            try
            {
                XmlSerializer x = new XmlSerializer(projekt.GetType());
                using (var file = File.Create(fileName))
                {
                    x.Serialize(file, projekt);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się zapisać");
            }
        }


        private void para_Click(object sender, EventArgs e)
        {
            if (pliki.SelectedItem == null)
            {
                MessageBox.Show("Wybierz awers");
                return; 
            }

            if (revers.SelectedItem == null)
            {
                MessageBox.Show("Wybierz rewers");
                return;
            }

            projekt.dodajPare(pliki.SelectedItem.ToString(), revers.SelectedItem.ToString());

            wyswietlKarty(); 
        }

        private void enableButtons() {
            bool e = projekt.Karty.Count > 0;
            zapisz.Enabled = e;
            delete.Enabled = e;
            zapisz.Enabled = e;
            generuj.Enabled = e;
        }

        private void wyswietlKarty()
        {
            karty.Rows.Clear();
            foreach (var karta in projekt.Karty)
                karty.Rows.Add(karta);
            kart.Text = string.Format("Kart w projekcie: {0}", projekt.Karty.Count);
            projektlabel.Text = projekt.Sciezka;
            enableButtons();
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {

            var result = openProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    deserializeProject(openProject.FileName);
                    wyswietlKarty();

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się wczytać");
                }
            }
        }

        private void deserializeProject(string path)
        {

            XmlSerializer x = new XmlSerializer(typeof(Projekt));
            var data = File.ReadAllText(path);
            projekt = (Projekt)x.Deserialize(new StringReader(data));

            loadFilesToListView();

            if (projekt.Karty.Count > 0)
            {
                pliki.SetSelected(pliki.Items.IndexOf(projekt.Karty[0].Awers), true);
                revers.SelectedText = projekt.Karty[0].Rewers;
                revers.Text = projekt.Karty[0].Rewers;
            }

        }

        private void generuj_Click(object sender, EventArgs e)
        {

            var result = savePDF.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    new PDFCreator(projekt, savePDF.FileName, duplex.Checked).Create();

                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać pdf");
                }
            }
        }

        private void szerokosc_TextChanged(object sender, EventArgs e)
        {
            setProjectProperties();
        }

        private void karty_SelectionChanged(object sender, EventArgs e)
        {
            if (karty.SelectedCells.Count != 1)
                return;

            Karta karta = karty.SelectedCells[0].Value as Karta;
            if (karta == null)
                return;

            lewy.Image = getImage(karta.Awers);
            prawy.Image = getImage(karta.Rewers);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (karty.SelectedCells.Count != 1)
                return;

            Karta karta = karty.SelectedCells[0].Value as Karta;
            if (karta == null)
                return;

            projekt.Karty.Remove(karta);
            wyswietlKarty();
        }
    }
}
