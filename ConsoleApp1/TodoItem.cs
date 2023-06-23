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
        public TodoItem() { }
        public TodoItem(long id,string? n,bool ic, string s) 
        { 
            Id= id;
            Name= n;
            IsComplete= ic;
            Secret= s;
        }
    }
    public class TodoItemDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public TodoItemDto() { }
        public TodoItemDto (TodoItem todoItem) 
        { 
            Id= todoItem.Id; 
            Name= todoItem.Name;
            IsComplete = todoItem.IsComplete;
        }
    }
    /*public class TodoDO
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
        }*/
}
