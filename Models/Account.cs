using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPocket.Models
{
    /// <summary>
    /// Account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Identity account
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Account { get; set; }

        /// <summary>
        /// Description source
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Icon account
        /// </summary>
        public byte[]? Icon { get; set; }
    }
}
