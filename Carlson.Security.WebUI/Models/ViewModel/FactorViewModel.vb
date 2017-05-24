Namespace Models
  Public Class FactorViewModel
    Public Property Purpose() As String
      Get
        Return m_Purpose
      End Get
      Set
        m_Purpose = Value
      End Set
    End Property
    Private m_Purpose As String
  End Class
End Namespace