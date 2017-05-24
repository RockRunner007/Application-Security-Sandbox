Imports System.ComponentModel.DataAnnotations

Namespace Models
  Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider() As String
      Get
        Return m_Provider
      End Get
      Set
        m_Provider = Value
      End Set
    End Property
    Private m_Provider As String

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
    Public Property ReturnUrl() As String
      Get
        Return m_ReturnUrl
      End Get
      Set
        m_ReturnUrl = Value
      End Set
    End Property
    Private m_ReturnUrl As String

    <Display(Name:="Remember this browser?")>
    Public Property RememberBrowser() As Boolean
      Get
        Return m_RememberBrowser
      End Get
      Set
        m_RememberBrowser = Value
      End Set
    End Property
    Private m_RememberBrowser As Boolean

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