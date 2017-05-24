Namespace Models
  Public Class ConfigureTwoFactorViewModel
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
  End Class
End Namespace