Imports Microsoft.AspNet.Identity
Namespace Models
  Public Class IndexViewModel
    Public Property HasPassword() As Boolean
      Get
        Return m_HasPassword
      End Get
      Set
        m_HasPassword = Value
      End Set
    End Property
    Private m_HasPassword As Boolean
    Public Property Logins() As IList(Of UserLoginInfo)
      Get
        Return m_Logins
      End Get
      Set
        m_Logins = Value
      End Set
    End Property
    Private m_Logins As IList(Of UserLoginInfo)
    Public Property PhoneNumber() As String
      Get
        Return m_PhoneNumber
      End Get
      Set
        m_PhoneNumber = Value
      End Set
    End Property
    Private m_PhoneNumber As String
    Public Property TwoFactor() As Boolean
      Get
        Return m_TwoFactor
      End Get
      Set
        m_TwoFactor = Value
      End Set
    End Property
    Private m_TwoFactor As Boolean
    Public Property BrowserRemembered() As Boolean
      Get
        Return m_BrowserRemembered
      End Get
      Set
        m_BrowserRemembered = Value
      End Set
    End Property
    Private m_BrowserRemembered As Boolean
  End Class
End Namespace