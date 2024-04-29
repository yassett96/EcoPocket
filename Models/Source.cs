using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoPocket.Models
{
    /// <summary>
    /// Source
    /// </summary>
    internal class Source
    {
        /// <summary>
        /// Identity source
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Source { get; set; }

        /// <summary>
        /// Description source
        /// </summary>
        public string? Description { get; set; }
    }
}
