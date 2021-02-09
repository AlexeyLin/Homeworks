using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Project5
{
    [Serializable]
    class ToDo
    {
        public int NumberTask { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }

        public ToDo(int numberTask, string title)
        {
            Title = title;
            NumberTask = numberTask;
            IsDone = false;
        }
        public ToDo()
        {
        }
    }
}
