Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class ChangePasswordViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Current password")>
    Public Property OldPassword() As String
      Get
        Return m_OldPassword
      End Get
      Set
        m_OldPassword = Value
      End Set
    End Property
    Private m_OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="New password")>
    Public Property NewPassword() As String
      Get
        Return m_NewPassword
      End Get
      Set
        m_NewPassword = Value
      End Set
    End Property
    Private m_NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm new password")>
    <Compare("NewPassword", ErrorMessage:="The new password and confirmation password do not match.")>
    Public Property ConfirmPassword() As String
      Get
        Return m_ConfirmPassword
      End Get
      Set
        m_ConfirmPassword = Value
      End Set
    End Property
    Private m_ConfirmPassword As String
  End Class
End Namespace