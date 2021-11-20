using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojang.Utils
{
     sealed public class BarCodeGenerator
    {
        static public void generateBarCode(Panel barcodeContainer, Label labelUnderBarcode, string studentID, string studentName)
        {
            BarcodeLib.Barcode barCode = new BarcodeLib.Barcode();
            barCode.IncludeLabel = true;
            barcodeContainer.BackgroundImage = barCode.Encode(BarcodeLib.TYPE.CODE128, studentID, Color.Black, Color.White, 200, 50);
            labelUnderBarcode.Text = studentName.ToTitleCase();
        }
        static public void SaveBarcode(Panel panelContainer, Label labelUnderBarcode, string studentNumber)
        {
            int width = panelContainer.Size.Width;
            int height = panelContainer.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            panelContainer.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            using (SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog())
            {
            CajaDeDiaologoGuardar.FileName = studentNumber + labelUnderBarcode.Text;
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            if(CajaDeDiaologoGuardar.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
                    {
                        bm.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
                    }
                }
           
            }
        }
    }
    
}
