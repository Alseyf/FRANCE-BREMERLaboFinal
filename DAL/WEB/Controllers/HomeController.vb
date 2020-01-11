Imports System.Windows
Imports DTO
Imports MySql.Data.MySqlClient.Memcached
Imports WPF

Public Class HomeController
    Inherits System.Web.Mvc.Controller
    'Public ServiceReference1.Service1Client client = New ServiceReference1.Service1Client()


    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult

        ViewData("Message") = "Your application description page."
        ViewData("test") = New ServiceReference1.Service1Client().GetFullActor(Integer.Parse(Session("selection")))


        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function VueActeurs(inc As Integer) As ActionResult
        If inc = 1 Then
            Session("selection") = Integer.Parse(Session("selection")) - 10
        ElseIf inc = 0 Then
            Session("selection") = Integer.Parse(Session("selection")) + 10
        End If


        Return View(New ServiceReference1.Service1Client().GetFullActor(Integer.Parse(Session("selection"))))
    End Function

    Function ViewMoreDetails(id As Integer) As ActionResult
        Return View(New ServiceReference1.Service1Client().GetListFilmsByIdActor(id))
    End Function

    Function ViewCommentaire(id As Integer) As ActionResult
        ViewData("id") = id
        Return View(New ServiceReference1.Service1Client().GetComments(id))
    End Function

    Function PostComment() As ActionResult


        Return ViewCommentaire(ViewData("id"))
    End Function


End Class
