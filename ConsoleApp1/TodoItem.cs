using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
    public class TodoDO
    {
        public static TodoItem ConvertToEntity(
            TodoItem
            TodoItemDTO)
        {
            TodoItem Td = new TodoItem();
            Td.Id = TodoItemDTO.Id;
            Td.Name = TodoItemDTO.Name;
            Td.IsComplete = TodoItemDTO.IsComplete;
            return Td;
        }
    }
}