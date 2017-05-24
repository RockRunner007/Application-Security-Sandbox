Imports System.Configuration
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Security.AntiXss

Public Class DemoDbContext
  Inherits DbContext
  Public Property DemoModels() As IDbSet(Of DemoModel)
    Get
      Return m_DemoModels
    End Get
    Set
      m_DemoModels = Value
    End Set
  End Property
  Private m_DemoModels As IDbSet(Of DemoModel)

  Public Sub New()
    MyBase.New(ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
  End Sub

  Public Overrides Function SaveChanges() As Integer
    ProcessContextAudit(ChangeTracker)
    'AntiXssEncode(ChangeTracker);
    Return MyBase.SaveChanges()
  End Function

  Public Overrides Function SaveChangesAsync() As Task(Of Integer)
    ProcessContextAudit(ChangeTracker)
    'AntiXssEncode(ChangeTracker);
    Return MyBase.SaveChangesAsync()
  End Function

  Public Overrides Function SaveChangesAsync(cancellationToken As CancellationToken) As Task(Of Integer)
    ProcessContextAudit(ChangeTracker)
    'AntiXssEncode(ChangeTracker);
    Return MyBase.SaveChangesAsync(cancellationToken)
  End Function

  Private Shared Sub ProcessContextAudit(tracker As DbChangeTracker)
    Dim entriesChangedWithBaseModel = tracker.Entries().Where(Function(e) TypeOf e.Entity Is BaseModel AndAlso (e.State = EntityState.Added Or e.State = EntityState.Modified))

    For Each ent In entriesChangedWithBaseModel
      Dim auditEntity = DirectCast(ent.Entity, BaseModel)
      If ent.State = EntityState.Added Then
        auditEntity.CreatedOn = DateTime.Now
      End If

      auditEntity.UpdatedOn = DateTime.Now
    Next
  End Sub

  Private Shared Sub AntiXssEncode(tracker As DbChangeTracker)
    Dim addedModifiedEntries = tracker.Entries().Where(Function(e) e.State = EntityState.Added Or e.State = EntityState.Modified)

    For Each ent In addedModifiedEntries
      Dim entity = ent.Entity
      Dim type = entity.[GetType]()
      Dim properties = type.GetProperties()

      For Each [property] In properties
        If [property].PropertyType <> GetType(String) Then
          Continue For
        End If

        Dim value = [property].GetValue(entity, Nothing)

        If value Is Nothing Then
          Continue For
        End If

        value = AntiXssEncoder.HtmlEncode(value.ToString(), True)

        [property].SetValue(entity, value, Nothing)
      Next
    Next
  End Sub
End Class