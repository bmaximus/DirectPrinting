using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DirectPrintingTest
{
    [TestClass]
    public class TestPriter
    {
        [TestMethod]
        public void Print1()
        {
            var printDialog = new PrintDialog();
            DirectPrinting.RawPrinterHelper.Printer(printDialog.PrinterSettings.PrinterName, "This is the best Receipt");
        }
    }
}
