namespace Hello.Services;

public class TodoStore(TodoContext todoContext) : ITodoStore
{
    public void AddTodo(string todo)
    {
        todoContext.TodoItems.Add(new TodoItem { Description = todo });
        todoContext.SaveChanges();
    }

    public List<string> GetTodos()
    {
        return todoContext.TodoItems.Select(todo => todo.Description).ToList();
    }

    public void ClearTodos()
    {
        todoContext.TodoItems.RemoveRange(todoContext.TodoItems);
        todoContext.SaveChanges();
    }
}