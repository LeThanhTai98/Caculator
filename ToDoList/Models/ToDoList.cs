using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoListItem
    {
        public int id { get; set; }
        public string content { get; set; }
    }
    public class ToDoListModel : List<ToDoListItem>
    {
        
    }
}
