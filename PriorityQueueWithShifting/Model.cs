using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithShifting
{
    public class Model
    {
        public int value;
        public int priority;

        public Model(int value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }
    }
}
