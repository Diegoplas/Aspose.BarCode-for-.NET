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

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class CreateX12DatamatrixBarCode
    {
        public static void Run()
        {
            //ExStart:createX12datamatrixbarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create an instance of BarcodeGenerator  class
            // Set codetext value and EncodeType
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, "ABCDEF123456");

            // Set the DataMatrix encoding mode to X12
            generator.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.ANSIX12;

            // Save the barcode image
            generator.Save(dataDir + "X12dataMatrix.png");
            //ExEnd:createX12datamatrixbarcode
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "X12dataMatrix.png");
        }
    }
}

