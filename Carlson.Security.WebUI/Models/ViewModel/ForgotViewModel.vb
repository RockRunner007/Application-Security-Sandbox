Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class ForgotViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email() As String
      Get
        Return m_Email
      End Get
      Set
        m_Email = Value
      End Set
    End Property
    Private m_Email As String
  End Class
End Namespace
