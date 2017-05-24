Public Class BaseModel
  Public Property CreatedOn() As DateTime
    Get
      Return m_CreatedOn
    End Get
    Set
      m_CreatedOn = Value
    End Set
  End Property
  Private m_CreatedOn As DateTime

  Public Property UpdatedOn() As DateTime
    Get
      Return m_UpdatedOn
    End Get
    Set
      m_UpdatedOn = Value
    End Set
  End Property
  Private m_UpdatedOn As DateTime
End Class