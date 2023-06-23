using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
             List<TodoItem> lists = new List<TodoItem>()
             {
                new TodoItem (1, "Aiuuna ", true, "secret"),
                new TodoItem (2, "Anna ", true, "secret")
             };
             List<TodoItemDto> dtolists = new List<TodoItemDto>();

            foreach (TodoItem item in lists)
            {
                Console.WriteLine($"Id: {item.Id}, \tName: {item.Name}, \tIsComplete:{item.IsComplete}, \tSecret?: {item.Secret}");
            }
            foreach (TodoItem item in lists)
            {
                TodoItemDto request = new TodoItemDto(item);
                dtolists.Add(request);
                Console.WriteLine($"Id: {item.Id}, \tName: {item.Name}, \tIsComplete: {item.IsComplete}");
            }
            foreach (TodoItemDto item in dtolists)
            {
                Console.WriteLine(JsonSerializer.Serialize(item).ToString());
            }
        }

    }
}