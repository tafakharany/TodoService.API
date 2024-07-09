using TodoService.API.Models;

namespace TodoService.API.Dtos;

public class UpdateTodoItem
{
    public string? Name { get; set; }
    public bool? IsComplete { get; set; }


    // create explicit conversion operator from UpdateTodoItem to TodoItem
    public static explicit operator TodoItem(UpdateTodoItem updateTodoItem)
    {
        return new TodoItem
        {
            Name = updateTodoItem.Name,
            IsComplete = updateTodoItem.IsComplete ?? false
        };
    }
}

