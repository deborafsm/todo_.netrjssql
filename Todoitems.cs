using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public bool Concluido { get; set; }
    }
}