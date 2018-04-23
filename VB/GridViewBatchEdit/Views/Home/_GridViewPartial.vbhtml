@Code
    Dim grid = Html.DevExpress().GridView(Sub(settings)
        settings.Name = "GridView"
        settings.CallbackRouteValues = new With { .Controller = "Home", .Action = "GridViewPartial" }
        settings.SettingsEditing.DeleteRowRouteValues = new With { .Controller = "Home", .Action = "DeleteRowPartial" }
        
        settings.CommandColumn.Visible = true


        Dim customButton As New GridViewCommandColumnCustomButton() With {.ID = "deleteButton", .Text = "Delete"}
        settings.CommandColumn.CustomButtons.Add(customButton)
        settings.ClientSideEvents.CustomButtonClick = "function(s, e) { OnCustomButtonClick(s, e); }"
     
        settings.KeyFieldName = "ID"

        settings.Columns.Add("C1")
        settings.Columns.Add(Sub(column)
            column.FieldName = "C2"
            column.ColumnType = MVCxGridViewColumnType.SpinEdit
        End Sub)
        settings.Columns.Add("C3")
        settings.Columns.Add(Sub(column) 
            column.FieldName = "C4"
            column.ColumnType = MVCxGridViewColumnType.CheckBox
        End Sub)
        settings.Columns.Add(Sub(column)        
            column.FieldName = "C5"
            column.ColumnType = MVCxGridViewColumnType.DateEdit
        End Sub)
    End Sub)
      If ViewData("EditError") IsNot Nothing Then
		grid.SetEditErrorText(CStr(ViewData("EditError")))
   End If
End Code
@grid.Bind(Model).GetHtml()