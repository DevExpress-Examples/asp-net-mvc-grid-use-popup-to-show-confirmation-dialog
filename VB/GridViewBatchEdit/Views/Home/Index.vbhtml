<script type="text/javascript">
    var visibleIndex;
    function OnCustomButtonClick(s, e) {
        if (e.buttonID = "deleteButton") {
            visibleIndex = e.visibleIndex;
            popup.Show();
        }
    }
    function OnClickYes(s, e) {
        GridView.DeleteRow(visibleIndex);
        popup.Hide();
    }
    function OnClickNo(s, e) {
        popup.Hide();
    }
</script>

@Html.Action("GridViewPartial")

@Html.DevExpress().PopupControl(Sub(settings)

    settings.Name = "popup"
    settings.ShowHeader = true
    settings.AllowDragging = true
    settings.AllowResize = true
    
    settings.PopupElementID = "GridView"
    settings.PopupVerticalAlign = PopupVerticalAlign.Middle
    settings.PopupHorizontalAlign = PopupHorizontalAlign.Center

    settings.HeaderText = "Confirm Delete?"
    
    settings.SetContent(Sub ()
    

        Html.DevExpress().Button( Sub(buttonSettings)
        
            buttonSettings.Name = "ButtonYes"
            buttonSettings.Text="Yes"
            buttonSettings.UseSubmitBehavior = false
            buttonSettings.ClientSideEvents.Click = "OnClickYes"
        End Sub).Render()
        Html.DevExpress().Button(Sub(buttonSettings)
        
            buttonSettings.Name = "ButtonNo"
            buttonSettings.Text="No"
            buttonSettings.UseSubmitBehavior = false
            buttonSettings.ClientSideEvents.Click = "OnClickNo"
        End Sub).Render()

    End Sub)
End Sub).GetHtml()
