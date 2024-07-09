using System.Text.Json.Serialization;
using TodoService.API.Models;

namespace TodoService.API.Dtos;

public class CreateTodoItem
{
    public string? Name { get; set; }
    [JsonIgnore]
    public bool? IsComplete { get; set; } = false;


    // create explicit conversion operator from CreateTodoItem to TodoItem
    public static explicit operator TodoItem(CreateTodoItem createTodoItem)
    {
        return new TodoItem
        {
            Name = createTodoItem.Name,
            IsComplete = createTodoItem.IsComplete ?? false
        };
    }
}
