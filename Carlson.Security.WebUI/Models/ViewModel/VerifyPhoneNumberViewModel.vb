Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class VerifyPhoneNumberViewModel
    <Required>
    <Display(Name:="Code")>
    Public Property Code() As String
      Get
        Return m_Code
      End Get
      Set
        m_Code = Value
      End Set
    End Property
    Private m_Code As String

    <Required>
    <Phone>
    <Display(Name:="Phone Number")>
    Public Property PhoneNumber() As String
      Get
        Return m_PhoneNumber
      End Get
      Set
        m_PhoneNumber = Value
      End Set
    End Property
    Private m_PhoneNumber As String
  End Class
End Namespace