using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Actor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdActor { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<CharacterActor> CharacterActors { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Actor(int id)
        {
            IdActor = id;
        }

        public Actor()
        {

        }
        public Actor(IQueryable<Actor> queryable)
        {
            IdActor = queryable.First().IdActor;
            Name = queryable.First().Name;
        }

        public Actor(int id, string n)
        {
            IdActor = id;
            Name = n;
        }

        public Actor(string s)
        {
            string[] actorDetails;
            char[] delimiters = { '\u2024' };
            actorDetails = s.Split(delimiters);
            IdActor = int.Parse(actorDetails[0]);
            Name = actorDetails[1];
        }

        public override string ToString()
        {
            return "ActorId: " + IdActor + ", " + Name + ", "+Surname+" || ";
        }

        public static string ListToString(ICollection<Actor> la)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Actor a in la)
            {
                sb.Append(a.ToString());
            }
            return sb.ToString();
        }
    }
}
