using WebApplication2.model;

namespace WebApplication2.services
{
    public class Todoservice
    {
        public List<Todo> Alltodo()
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test",
                Description = "The exam is good",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = Todostatus.New


            };
            todos.Add(todo1);
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test 1",
                Description = "The exam is good",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = Todostatus.Completed


            };
            todos.Add(todo2);


            return todos;
        }
    }
}
