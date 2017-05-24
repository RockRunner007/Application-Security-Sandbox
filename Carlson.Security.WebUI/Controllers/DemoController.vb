Imports System.Data.Entity
Imports System.Threading.Tasks
Imports System.Web.Http

Public Class DemoController
  Inherits ApiController
  Private ReadOnly _context As DemoDbContext

  Public Sub New()
    _context = New DemoDbContext()
  End Sub

  <HttpGet>
  Public Function GetModel() As Task(Of List(Of DemoModel))
    Return _context.DemoModels.ToListAsync()
  End Function

  <HttpGet>
  Public Function GetModel(id As Integer) As Task(Of DemoModel)
    Return _context.DemoModels.FirstOrDefaultAsync(Function(x) x.Id = id)
  End Function

  <HttpPost>
  Public Async Function PostModelAsync(<FromBody> model As DemoModel) As Task(Of DemoModel)
    _context.DemoModels.Add(model)
    Await _context.SaveChangesAsync()

    Return model
  End Function

  <HttpPut>
  Public Async Function UpdateModelAsync(<FromBody> model As DemoModel) As Task(Of DemoModel)
    Dim entity = Await _context.DemoModels.FirstOrDefaultAsync(Function(x) x.Id = model.Id)

    If entity IsNot Nothing Then
      entity.Data = model.Data
      Await _context.SaveChangesAsync()
    End If

    Return model
  End Function
End Class