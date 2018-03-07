using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simply_connected_list
{
    public class Generalized<T>
    {
        public Generalized(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Generalized<T> Next { get; set; }
    }
}
