using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
        public virtual int IdActor { get; set; }
        public string avatar { get; set; }
        public DateTime Date { get; set; }

        public Comment()
        {
            Date = DateTime.Now;
        }

        
    }
}
