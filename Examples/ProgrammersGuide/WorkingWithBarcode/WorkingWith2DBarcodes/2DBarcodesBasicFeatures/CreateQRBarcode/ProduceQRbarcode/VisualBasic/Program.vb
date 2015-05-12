'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.BarCode

Namespace ProduceQRbarcode
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			Dim b As Aspose.BarCode.BarCodeBuilder
			b = New Aspose.BarCode.BarCodeBuilder()
			b.SymbologyType = Aspose.BarCode.Symbology.QR
			b.CodeText = "1234567890"
			b.Save(dataDir & "test_qr.bmp", BarCodeImageFormat.Bmp)


		End Sub
	End Class
End Namespace