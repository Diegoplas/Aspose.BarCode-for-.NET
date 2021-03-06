﻿using Aspose.BarCode.Generation;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class ReduceCodeTextFontSize
    {
        public static void Run()
        {
            //ExStart:ReduceCodeTextFontSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();
            string codeText = "The quick brown fox jumps over the lazy dog\n" + "The quick brown fox jumps over the lazy dog\n";

            // Instantiate barcode object, Set CodeText, Symbology and CodeLocation
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.DataMatrix, codeText);
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;

            generator.Save(dataDir + "HideBarcodeCodeText_out.png", BarCodeImageFormat.Png);
            //ExEnd:ReduceCodeTextFontSize
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "HideBarcodeCodeText_out.png");
        }
    }
}
