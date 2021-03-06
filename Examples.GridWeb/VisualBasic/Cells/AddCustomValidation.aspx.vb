﻿Imports Aspose.Cells.GridWeb.Data

Namespace Cells
    Public Class AddCustomValidation
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub

        Protected Sub btnAddCustomValidation_Click(sender As Object, e As EventArgs)
            ' ExStart:AddCustomValidation
            ' Accessing the cells collection of the worksheet that is currently active
            Dim sheet As WebWorksheet = GridWeb1.WebWorksheets(GridWeb1.ActiveSheetIndex)

            ' Accessing "B1" cell
            Dim cell As WebCell = sheet.Cells(0, 1)

            ' Putting value to "B1" cell
            cell.PutValue("Date (yyyy-mm-dd):")

            ' Accessing "C1" cell
            cell = sheet.Cells(0, 2)

            ' Creating a custom expression validation for the "C1" cell
            cell.CreateValidation(ValidationType.CustomExpression, True)

            ' Setting regular expression for the validation to accept dates in yyyy-mm-dd format
            cell.Validation.RegEx = "\d{4}-\d{2}-\d{2}"
            ' ExEnd:AddCustomValidation

            sheet.Cells.SetColumnWidth(1, New Unit(100, UnitType.Point))

            ' Assigning the name of JavaScript function to OnValidationErrorClientFunction property of GridWeb
            GridWeb1.OnValidationErrorClientFunction = "ValidationErrorFunction"
        End Sub
    End Class
End Namespace
