Namespace Models
  Public Class ExternalLoginListViewModel
    Public Property ReturnUrl() As String
      Get
        Return m_ReturnUrl
      End Get
      Set
        m_ReturnUrl = Value
      End Set
    End Property
    Private m_ReturnUrl As String
  End Class
End Namespace
