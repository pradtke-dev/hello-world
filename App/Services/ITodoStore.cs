
namespace Hello.Services;

public interface ITodoStore
{
    void AddTodo(string todo);
    List<string> GetTodos();
    void ClearTodos();
}