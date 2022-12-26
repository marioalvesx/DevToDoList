using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevToDoList.API.Entities
{
    public class DevTodo
    {
        public DevTodo(string title, string description, bool isDone)
        {
            Title = title;
            Description = description;
            IsDone = isDone;

            Reactions = new List<DevTodoReaction>();
            CreatedAt = DateTime.Now;
        }

        public int Id { get; private set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<DevTodoReaction> Reactions { get; private set; }
        private int LimitLength = 20;

        public bool TitleLengthValid() {
            if (Title.Count() > LimitLength)
                return false;
            
            return true;
        }

        public bool AddReaction(bool isPositive) {
            Reactions.Add(new DevTodoReaction(isPositive));
            return true;
        }        

    }
}