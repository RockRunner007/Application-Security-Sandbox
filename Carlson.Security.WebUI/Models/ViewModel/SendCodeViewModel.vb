Namespace Models
  Public Class SendCodeViewModel
    Public Property SelectedProvider() As String
      Get
        Return m_SelectedProvider
      End Get
      Set
        m_SelectedProvider = Value
      End Set
    End Property
    Private m_SelectedProvider As String
    Public Property Providers() As ICollection(Of System.Web.Mvc.SelectListItem)
      Get
        Return m_Providers
      End Get
      Set
        m_Providers = Value
      End Set
    End Property
    Private m_Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl() As String
      Get
        Return m_ReturnUrl
      End Get
      Set
        m_ReturnUrl = Value
      End Set
    End Property
    Private m_ReturnUrl As String
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