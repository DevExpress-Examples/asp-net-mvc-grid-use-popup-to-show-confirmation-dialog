Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports Models

Namespace GridViewBatchEdit.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		<ValidateInput(False)> _
		Public Function GridViewPartial() As ActionResult
			Return PartialView("_GridViewPartial", GridViewData.GridData)
		End Function
		<HttpPost, ValidateInput(False)> _
		Public Function DeleteRowPartial(ByVal ID As Integer) As ActionResult
			If ID >= 0 Then
				Try
					GridViewData.DeleteItem(ID)
				Catch e As Exception
					ViewData("EditError") = e.Message
				End Try
			End If
			Return PartialView("_GridViewPartial", GridViewData.GridData)
		End Function

	End Class
End Namespace