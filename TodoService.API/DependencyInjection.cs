using Microsoft.EntityFrameworkCore;
using TodoService.API.persistence;

namespace TodoService.API
{
    public static class DependencyInjection
    {
        // add db context with in-memory database
        public static IServiceCollection AddTodoDbContext(this IServiceCollection services)
        {
            services.AddDbContext<TodoDb>(options => options.UseInMemoryDatabase("TodoDb"));
            return services;
        }
    }
}
