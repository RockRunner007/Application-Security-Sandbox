
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class DemoModel
  Inherits BaseModel
  <Key>
  <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
  <Required>
  Public Property Id() As Integer
    Get
      Return m_Id
    End Get
    Set
      m_Id = Value
    End Set
  End Property
  Private m_Id As Integer

  Public Property Data() As String
    Get
      Return m_Data
    End Get
    Set
      m_Data = Value
    End Set
  End Property
  Private m_Data As String
End Class