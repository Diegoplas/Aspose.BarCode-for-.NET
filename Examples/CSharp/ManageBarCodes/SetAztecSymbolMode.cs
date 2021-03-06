﻿using Aspose.BarCode;
using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetAztecSymbolMode
    {
        public static void Run()
        {
            // ExStart:SetAztecSymbolMode 
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create an instance of BarCodeGenerator class.
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Aztec, "25");

            // Set AztecSymbolMode property.
            generator.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.Rune;
            generator.Save(dataDir + "SetAztecSymbolMode_out.png");
            // ExEnd:SetAztecSymbolMode 
        }
    }
}
