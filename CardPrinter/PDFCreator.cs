using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPrinter
{
    class PDFCreator
    {
        Projekt projekt;
        Document pdf;

        string filePath;
        int cols, rows;
        float pageW, pageH, imgW, imgH;
        int pages = 0;
        int perPage;
        int cardsLeft;
        float spacingX, spacingY;
        float marginLR, marginTB;
        bool duplex = true;

        public bool Duplex
        {
            get
            {
                return duplex;
            }

            set
            {
                duplex = value;
            }
        }

        public PDFCreator(Projekt projekt, string file, bool duplex)
        {
            this.projekt = projekt;
            filePath = file;
            Duplex = duplex;
        }

        public void Create()
        {
            pdf = new Document(PageSize.A4);

            createPageMetrics();
            createPage();

        }

        private void createPageMetrics()
        {
            pageW = pdf.PageSize.Width;
            pageH = pdf.PageSize.Height;

            imgW = mm2point(projekt.Szerokosc);
            imgH = mm2point(projekt.Wysokosc);
            spacingX = mm2point(projekt.OdstepX);
            spacingY = mm2point(projekt.OdstepY);

            cols = (int)(pageW / (imgW + spacingX));
            rows = (int)(pageH / (imgH + spacingY));

            marginLR = pageW - ((imgW + spacingX) * (cols - 1) + imgW);
            marginTB = pageH - ((imgH + spacingY) * (rows - 1) + imgH);

            marginLR /= 2;
            marginTB /= 2;

            perPage = cols * rows;
            cardsLeft = projekt.Karty.Count;
            pages = (int)Math.Ceiling(cardsLeft / (double)perPage);

            pdf.SetMargins(marginLR, marginLR, marginTB, marginTB);
        }



        private void createPage()
        {
            PdfWriter writer = PdfWriter.GetInstance(pdf, new FileStream(filePath, FileMode.OpenOrCreate));
            pdf.Open();
            PdfContentByte cb = writer.DirectContent;
            if (duplex)
                autoDuplex(cb);
            else
                manualDuplex(cb);

            pdf.Close();
        }

        private void autoDuplex(PdfContentByte cb)
        {
            for (int page = 0; page < pages; page++)
            {
                // Dodaj awersy
                addCards(cb, page);
                // Dodaj rewersy
                addCards(cb, page, false);
                cardsLeft -= perPage;
            }
        }

        private void manualDuplex(PdfContentByte cb)
        {
            int cards = cardsLeft;
            for (int page = 0; page < pages; page++)
            {
                // Dodaj awersy
                addCards(cb, page);
                cardsLeft -= perPage;
            }

            cardsLeft = cards;
            for (int page = 0; page < pages; page++)
            {
                // Dodaj rewersy
                addCards(cb, page, false);
                cardsLeft -= perPage;
            }
        }

        private void addCards(PdfContentByte cb, int page, bool awers = true)
        {
            int start = page * perPage;
            for (int i = start; i < start + Math.Min(perPage, cardsLeft); i++)
            {
                var image = loadImage(projekt.getFullName(awers ? projekt.Karty[i].Awers : projekt.Karty[i].Rewers));
                image.SetAbsolutePosition(calculateXPosition(i % perPage, awers), calculateYPosition(i % perPage));
                image.ScaleAbsolute(imgW, imgH);
                cb.AddImage(image);
            }
            pdf.NewPage();

        }

        private float calculateXPosition(int img, bool awers)
        {
            float s = spacingX;
            int c = img % cols;
           
            if (awers)
                s = (c == 0) ? 0 : s;
            else
            {
                c = cols - c - 1;
                s = (2 == 0) ? 0 : s;
            }

            return marginLR + (c * (imgW+ s));
        }

        private float calculateYPosition(int img)
        {
            float s = spacingY;
            s = (img == 0) ? 0 : s;
            int r = img / cols;

            return marginTB +  (r * (imgH + s));
        }

        private Image loadImage(string file)
        {
            using (var input = new FileStream(file, FileMode.Open))
            {
                return Image.GetInstance(input);
            }
        }



        private float mm2point(float v)
        {
            return v / .353F;
        }
    }
}
