
namespace Hello.Services;

public interface ITodoStore
{
    void AddTodo(string todo, int priority);
    List<TodoItem> GetTodos();
    void ClearTodos();
}