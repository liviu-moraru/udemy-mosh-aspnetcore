using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Entities
{
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("MakeId")] // Nu este necesar, caci prin conventie foreignkey-ul e ales ca numele clasei + "Id"
        public Make Make { get; set; }
        public int MakeId { get; set; }
        public IEnumerable<Feature> Features { get; set; }
    }
}