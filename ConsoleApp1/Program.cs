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
                new TodoItem (1, "Aiuuna ", true, " j"),
                new TodoItem (2, "Anna ", true, " j")
             };
             List<TodoItemDto> dtolists = new List<TodoItemDto>();

            foreach (TodoItem element in lists)
            {
                Console.WriteLine($"Id: {element.Id}, \tName: {element.Name}, \tIsComplete:{element.IsComplete}, \tSecret?: {element.Secret}");
            }
            foreach (TodoItem todo in lists)
            {
                TodoItemDto request = new TodoItemDto(todo);
                dtolists.Add(request);
                Console.WriteLine($"Id: {todo.Id}, \tName: {todo.Name}, \tIsComplete: {todo.IsComplete}");
                Console.WriteLine($" {JsonSerializer.Serialize(todo).ToString()}");
            }
        }

    }
}