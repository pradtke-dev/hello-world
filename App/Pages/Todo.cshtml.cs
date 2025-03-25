using Hello.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace Hello.Pages;

public class TodoModel : PageModel
{
    private readonly ILogger<TodoModel> _logger;
    private readonly ITodoStore _todoStore;

    public List<string> Todos => _todoStore.GetTodos();

    public TodoModel(ILogger<TodoModel> logger, ITodoStore todoStore)
    {
        _logger = logger;
        _todoStore = todoStore;
    }

    public void OnPost()
    {
        var todo = Request.Form["todo-text"];
        if (StringValues.IsNullOrEmpty(todo)) return;
        _todoStore.AddTodo(todo!);
    }

    public IActionResult OnPostClear()
    {
        _todoStore.ClearTodos();
        return RedirectToPage();
    }
}
