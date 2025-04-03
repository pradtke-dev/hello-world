using Hello.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using static System.Int32;

namespace Hello.Pages;

public class TodoModel : PageModel
{
    private readonly ILogger<TodoModel> _logger;
    private readonly ITodoStore _todoStore;

    public List<TodoItem> Todos => _todoStore.GetTodos();

    public TodoModel(ILogger<TodoModel> logger, ITodoStore todoStore)
    {
        _logger = logger;
        _todoStore = todoStore;
    }

    public void OnPost()
    {
        var todo = Request.Form["todo-text"];
        var priority = Request.Form["todo-priority"];
        if (StringValues.IsNullOrEmpty(todo)) return;
        TryParse(priority, out var priorityInt);
            
        _todoStore.AddTodo(todo!, priorityInt);
    }

    public IActionResult OnPostClear()
    {
        _todoStore.ClearTodos();
        return RedirectToPage();
    }
}
