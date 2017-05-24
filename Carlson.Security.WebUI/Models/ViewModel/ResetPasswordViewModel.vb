Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
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

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
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

    <DataType(DataType.Password)>
    <Display(Name:="Confirm password")>
    <Compare("Password", ErrorMessage:="The password and confirmation password do not match.")>
    Public Property ConfirmPassword() As String
      Get
        Return m_ConfirmPassword
      End Get
      Set
        m_ConfirmPassword = Value
      End Set
    End Property
    Private m_ConfirmPassword As String

    Public Property Code() As String
      Get
        Return m_Code
      End Get
      Set
        m_Code = Value
      End Set
    End Property
    Private m_Code As String
  End Class
End Namespace