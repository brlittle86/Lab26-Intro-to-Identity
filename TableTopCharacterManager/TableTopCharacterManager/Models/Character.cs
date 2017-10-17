using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableTopCharacterManager.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CharacterName { get; set; }

        [Required]
        public string CharacterClass { get; set; }

        [Required]
        public string CharacterRace { get; set; }

        [Required]
        [Range(1, 20)]
        public int Level { get; set; }

        [Range(14, 750)]
        public int Age { get; set; }
        public string PhysicalDescription { get; set; }
        public string Equipment { get; set; }

        [Range(0, 99999999)]
        public int Gold { get; set; }

        [Required]
        public bool IsAlive { get; set; }
    }
}
