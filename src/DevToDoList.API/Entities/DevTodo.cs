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
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<DevTodoReaction> Reactions { get; private set; }

        public void AddReaction(bool isPositive) {
            // if (!IsDone) // Só manda a reação se tiver concluida a tarefa
            //     throw new InvalidOperationException();
            
            Reactions.Add(new DevTodoReaction(isPositive));
        
        }

    }
}