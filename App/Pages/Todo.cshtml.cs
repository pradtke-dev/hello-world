using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace Hello.Pages;

public class TodoModel : PageModel
{
    private readonly ILogger<TodoModel> _logger;

    public List<string> Todos { get; set; } = new List<string>();

    public TodoModel(ILogger<TodoModel> logger)
    {
        _logger = logger;
    }

    public void OnPost()
    {
        var todo = Request.Form["todo-text"];
        if (StringValues.IsNullOrEmpty(todo)) return;
        Todos.Add(todo!);
    }
}
