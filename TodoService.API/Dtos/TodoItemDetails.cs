using TodoService.API.Models;

namespace TodoService.API.Dtos;

public class TodoItemDetails
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    //create implicit conversion operator from TodoItem to TodoItemDetails
    public static implicit operator TodoItemDetails(TodoItem todoItem)
    {
        return new TodoItemDetails
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
        };
    }
}
