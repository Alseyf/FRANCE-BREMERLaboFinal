using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommentDTO
    {
        public string Content { get; set; }
        public int Rate { get; set; }
        public string avatar { get; set; }
        public DateTime Date { get; set; }

        public CommentDTO()
        {
            //Date = DateTime.Now;
        }

        public override string ToString()
        {
            return "Avatar: " + avatar + ",Rate: " + Rate + ",Content: " + Content + ", Date: " + Date;
        }
    }
}
