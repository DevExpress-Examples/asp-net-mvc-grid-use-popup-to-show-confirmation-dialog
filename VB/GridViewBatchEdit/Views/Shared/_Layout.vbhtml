<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
     @Html.DevExpress().GetStyleSheets(
        new StyleSheet with { .ExtensionSuite = ExtensionSuite.GridView },
         new StyleSheet with { .ExtensionSuite = ExtensionSuite.NavigationAndLayout }
    )
    @Html.DevExpress().GetScripts(
        New Script With { .ExtensionSuite = ExtensionSuite.GridView },
        New Script With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout }
    )
</head>
<body>
    @RenderBody()
</body>
</html>