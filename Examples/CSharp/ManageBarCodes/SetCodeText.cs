﻿using System;
using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetCodeText
    {
        public static void Run()
        {
            // ExStart:SetCodeText  
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set differnt barcode properties
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Code128, "1234567");
            generator.Parameters.Barcode.XDimension.Millimeters = 1f;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "barcode-codetext_out.jpg", BarCodeImageFormat.Jpeg);
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "barcode-codetext_out.jpg");
            // ExEnd:SetCodeText  
        }
    }
}