using Microsoft.EntityFrameworkCore;

namespace Hello.Services;

public class TodoStore(TodoContext todoContext) : ITodoStore
{
    public void AddTodo(string todo, Priority priority)
    {
        todoContext.TodoItems.Add(new TodoItem { Description = todo, Priority = priority});
        todoContext.SaveChanges();
    }

    public List<TodoItem> GetTodos()
    {
        return todoContext.TodoItems.ToList();
    }

    public void ClearTodos()
    {
        todoContext.TodoItems.ExecuteDelete();
    }
}