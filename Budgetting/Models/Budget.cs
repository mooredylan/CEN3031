using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Budgetting.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }

        //TODO Budget fields go here

        public int ProfileId { get; set; }
    }
}
