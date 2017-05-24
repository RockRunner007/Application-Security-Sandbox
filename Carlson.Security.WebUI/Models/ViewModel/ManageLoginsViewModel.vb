Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security

Namespace Models
  Public Class ManageLoginsViewModel
    Public Property CurrentLogins() As IList(Of UserLoginInfo)
      Get
        Return m_CurrentLogins
      End Get
      Set
        m_CurrentLogins = Value
      End Set
    End Property
    Private m_CurrentLogins As IList(Of UserLoginInfo)
    Public Property OtherLogins() As IList(Of AuthenticationDescription)
      Get
        Return m_OtherLogins
      End Get
      Set
        m_OtherLogins = Value
      End Set
    End Property
    Private m_OtherLogins As IList(Of AuthenticationDescription)
  End Class
End Namespace