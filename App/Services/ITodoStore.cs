
namespace Hello.Services;

public interface ITodoStore
{
    void AddTodo(string todo, Priority priority);
    List<TodoItem> GetTodos();
    void ClearTodos();
}