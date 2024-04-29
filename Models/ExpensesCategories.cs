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
    /// ExpensesCategories
    /// </summary>
    internal class ExpensesCategories
    {
        /// <summary>
        /// Identity of expenses categories, auto incremental
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Expenses_Categories { get; set; }

        /// <summary>
        /// Name of expenses categories
        /// </summary>
        public string? Name { get; set; } = "";

        /// <summary>
        /// Icon of category
        /// </summary>
        public byte[]? Icon { get; set; } = [];
    }
}
