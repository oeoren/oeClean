using oeClean.Application.Common.Mappings;
using oeClean.Domain.Entities;

namespace oeClean.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
