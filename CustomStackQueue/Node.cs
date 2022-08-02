using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackQueue
{
    public class Node
    {
        public object value { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public object? next { get; set; }
        public object? prev { get; set; }

        public Node(object value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }
}
