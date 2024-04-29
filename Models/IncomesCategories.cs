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
    /// IncomesCategories
    /// </summary>
    internal class IncomesCategories
    {
        /// <summary>
        /// Identity of incomes categories, auto incrementable
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Incomes_Categories { get; set; }
        
        /// <summary>
        /// Name incomes categories
        /// </summary>
        public string? Name { get; set; } = "";

        /// <summary>
        /// Icon incomes categories
        /// </summary>
        public byte[]? Icon { get; set; } = [];

    }
}
