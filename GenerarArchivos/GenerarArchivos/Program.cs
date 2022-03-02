using DataMatrix.net;
using System.Drawing;
using System.Drawing.Imaging;
using iText.Barcodes;
using System.Text;
using System.Diagnostics;
using iText.Kernel.Pdf;
using TarCode;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.ComponentModel;
using BarcodeLib.Barcode;
using iText.Barcodes.Qrcode;
using iTextSharp.text.pdf.qrcode;
using System.Drawing.Printing;

namespace CrearTxt
{
    class Program
    {

        static readonly string taller = "Mul"; // Codigo del taller
        static readonly string cod = "16"; // Codigo del producto
        static readonly int cant = 10; // Cantidad de productos a producir
        static int ui = 1745; // Ultimo impreso en bd
        static void Main(string[] args)
        {           
            for (int i = 1; i <= cant; i++)
            {
                // Codigo taller(3 letras) + id producto(2 digitos) + consecutivo (8 cifras, puede cambiar)
                //string codigoProducto = taller + cod + string.Format("{0:00000000}", ui + i);
                //string ruta = @"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + codigoProducto + ".job"; ;
                //Definir un formato de letra y revisar en que archivo se envia, cuando genere la lista con los codigos en un txt
                //System.IO.File.WriteAllText(ruta, codigoProducto);

                //generarDMBitmap(codigoProducto);
                //generarQR();
                //generarDM(codigoProducto);

                //imprimir(codigoProducto);
                imprimirDesdeDM();

            }
            
        }

        static void generarDMBitmap(string codigoProducto)
        {
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(codigoProducto);
            byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
            //Console.WriteLine(iso.GetString(isoBytes));
            Bitmap bitmap;
            MemoryStream stream = new MemoryStream();
            stream.Write(isoBytes, 0, isoBytes.Length);

            //bitmap = new Bitmap(stream);
            ////TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            ////bitmap = (Bitmap)tc.ConvertFrom(isoBytes);

            //bitmap.Save(@"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + codigoProducto + ".png", ImageFormat.Png);
            //Document doc = new Document();
            //PdfWriter.GetInstance(doc, new FileStream(@"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + codigoProducto + ".pdf", FileMode.Create));
            //doc.Open();
            //doc.Add(new Paragraph("GIF"));

            //BarcodeDataMatrix dataMatrix = new BarcodeDataMatrix();
            //dataMatrix.SetCode(isoBytes.ToString());

            //image = new Bitmap(@"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + codigoProducto + ".bmp", true);
            //Console.WriteLine(image);
        }

        static void imprimir(string imprimir) {
            Process impr = new Process();
            //impr.StartInfo.FileName = @"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + imprimir + ".bmp";
            impr.StartInfo.FileName = @"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + imprimir + ".bmp";
            
            impr.StartInfo.UseShellExecute = true;
            impr.StartInfo.CreateNoWindow = true;
            impr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            impr.StartInfo.Verb = "print";
            impr.Start();
        }

        static void imprimirDesdeDM()
        {
            generarDM(codigoProducto());
            PrintDocument pd = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pd.PrinterSettings = ps;
            pd.PrintPage += traerImagen;
            //PrintQueue spooler = null;
            
            pd.Print();
            //pd.Dispose();
        }
        static void traerImagen(object sender, PrintPageEventArgs e)
        {
            string ruta = @"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + codigoProducto() + ".bmp"; ;
            ui++;
            System.Drawing.Image img = System.Drawing.Image.FromFile(ruta);
            e.Graphics.DrawImage(img, new System.Drawing.Rectangle(0, 0, img.Width, img.Height));
        }
        static string codigoProducto()
        {           
            return taller + String.Format("{0:00}", cod) + string.Format("{0:00000000}", ui);
        }

        static void generarQR() {
            // Volver a buscar el ejemplo
            //iTextSharp.text.pdf.qrcode.Encoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            //QRCode qrcode = new QrCode();
            //qrEncoder.TryEncode(codigoProducto, out qrcode);
            //// creo que aqui le cambio el tamaño
            //GraphicsRenderer renderer = new(new FixedCodeSize(200, QuietZoneModules.Zero));
            //MemoryStream ms = new MemoryStream();
            //renderer.WriteToStream(qrcode.Matrix, ImageFormat.Png, ms);
            //var imagetemporal = new Bitmap(ms);
            //var imagen = new Bitmap(imagetemporal, new Size(new Point(100, 100)));
            //// guardar en el disco duro la imagen (carpeta del proyecto)
            //imagen.Save(@"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + codigoProducto + ".bmp", ImageFormat.Png);
            ////system.io.file.writealltext(@"c:\users\intecol\Documents\JTamayo\Indumil\Pruebas\"+codigoProducto+"tx.job", codigoProducto);
        }

        static void generarDM(String encriptar) {
            // Libreria de pago, no deja quitar el trial sin una licencia cara
            BarcodeLib.Barcode.DataMatrix barcode = new BarcodeLib.Barcode.DataMatrix();
            //barcode.Data = "1dfefg % ^7fdsg56566";
            barcode.Data = encriptar;
            barcode.UOM = UnitOfMeasure.PIXEL;
            barcode.ModuleSize = 3;
            barcode.LeftMargin = 0;
            barcode.RightMargin = 0;
            barcode.TopMargin = 0;
            barcode.BottomMargin = 0;
            barcode.Encoding = DataMatrixEncoding.ASCII;
            barcode.Format = DataMatrixFormat.Format_10X10;
            barcode.ImageFormat = ImageFormat.Png;
            barcode.drawBarcode(@"c:\users\intecol\documents\jtamayo\indumil\pruebas\qrimprimir\" + encriptar + ".bmp");
        }
    }
}