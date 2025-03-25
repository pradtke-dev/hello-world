
namespace Hello.Services;

public class InMemoryTodoStore : ITodoStore
{
    private readonly List<string> _todos = [];

    public void AddTodo(string todo)
    {
        if (string.IsNullOrWhiteSpace(todo)) return;
        _todos.Add(todo);
    }

    public List<string> GetTodos()
    {
        return _todos;
    }

    public void ClearTodos()
    {
        _todos.Clear();
    }
}