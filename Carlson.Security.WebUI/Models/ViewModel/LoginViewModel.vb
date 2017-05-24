Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class LoginViewModel
    <Required>
    <Display(Name:="Email")>
    <EmailAddress>
    Public Property Email() As String
      Get
        Return m_Email
      End Get
      Set
        m_Email = Value
      End Set
    End Property
    Private m_Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password() As String
      Get
        Return m_Password
      End Get
      Set
        m_Password = Value
      End Set
    End Property
    Private m_Password As String

    <Display(Name:="Remember me?")>
    Public Property RememberMe() As Boolean
      Get
        Return m_RememberMe
      End Get
      Set
        m_RememberMe = Value
      End Set
    End Property
    Private m_RememberMe As Boolean
  End Class
End Namespace
