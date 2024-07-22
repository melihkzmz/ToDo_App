using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace todo_app.entity
{
        public class Tasks
        {
                    public int Id{get; set;}

                    [Required]
                    public string Name{ get; set;}

             
        }
}