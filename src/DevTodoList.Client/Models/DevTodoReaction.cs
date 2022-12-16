using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTodoList.Client.Models
{
    public class DevTodoReaction
    {
        public int DevTodoId { get; set; }
        public bool IsPositive { get; set; }
    }
}