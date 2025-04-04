
namespace Hello.Services;

public class InMemoryTodoStore : ITodoStore
{
    private readonly List<TodoItem> _todos = [];

    public void AddTodo(string todo, int priority)
    {
        if (string.IsNullOrWhiteSpace(todo)) return;
        _todos.Add(new TodoItem { Id = _todos.Count, Description = todo, Priority = priority });
    }

    public List<TodoItem> GetTodos()
    {
        return _todos;
    }

    public void ClearTodos()
    {
        _todos.Clear();
    }
}