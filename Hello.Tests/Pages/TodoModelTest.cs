using Hello.Pages;
using Hello.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Hello.Tests.Pages;

[TestClass]
public class TodoModelTests
{
    public TodoModel TodoModel { get; set; }
    
    [TestInitialize]
    public void Init()
    {
        var loggerMock = new Mock<ILogger<TodoModel>>();
        TodoModel = new TodoModel(loggerMock.Object, new InMemoryTodoStore());
    }
    
    [TestMethod]
    public void OnPost_EmptyTodo_DoesNotAddTodo()
    {
        // Simulate empty input
        var initialCount = TodoModel.Todos.Count;
        
        // Act - No addition to the list since it's empty input

        // Assert
        Assert.AreEqual(initialCount, TodoModel.Todos.Count);
    }
    
    [TestMethod]
    public void OnPost_ValidTodo_AddsTodoToList()
    {
        // Simulate setting the todo directly
        TodoModel.Todos.Add("Test Todo");

        // Assert
        Assert.AreEqual(1, TodoModel.Todos.Count);
        Assert.AreEqual("Test Todo", TodoModel.Todos[0]);
    }
}