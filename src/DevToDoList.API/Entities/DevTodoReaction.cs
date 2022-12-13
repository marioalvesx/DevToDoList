namespace DevToDoList.API.Entities
{
    public class DevTodoReaction
    {
        public DevTodoReaction(bool isPositive)
        {
            IsPositive = isPositive;
        }

        public int Id { get; set; }
        public bool IsPositive { get; private set; }
        public int DevTodoId { get; private set; }
    }
}