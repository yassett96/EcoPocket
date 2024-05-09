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
    /// ExpenseCategory
    /// </summary>
    public class ExpenseCategory
    {
        /// <summary>
        /// Identity of expenses categories, auto incremental
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Expense_Category { get; set; }

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
