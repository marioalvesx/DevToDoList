using DevToDoList.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevToDoList.API.Persistence
{
    public class DevTodoDbContext : DbContext
    {
        public DevTodoDbContext(DbContextOptions<DevTodoDbContext> options) : base(options) {

        }

        public DbSet<DevTodo> DevTodos { get; set; }
        public DbSet<DevTodoReaction> DevTodoReactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<DevTodo>(e => {
                e.HasKey(s => s.Id);

                e.HasMany(s => s.Reactions)
                    .WithOne()
                    .HasForeignKey(r => r.DevTodoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<DevTodoReaction>(sn => {
                sn.HasKey(s => s.Id);
            });
        }

    }
}