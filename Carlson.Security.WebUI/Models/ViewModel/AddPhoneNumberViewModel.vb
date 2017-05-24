Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class AddPhoneNumberViewModel
    <Required>
    <Phone>
    <Display(Name:="Phone Number")>
    Public Property Number() As String
      Get
        Return m_Number
      End Get
      Set
        m_Number = Value
      End Set
    End Property
    Private m_Number As String
  End Class
End Namespace
