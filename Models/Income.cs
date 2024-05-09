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
    /// Incomes
    /// </summary>
    public class Income
    {
        /// <summary>
        /// Identity incomes
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Income { get; set; }

        /// <summary>
        /// Description income
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Amoutn income
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Date of income
        /// </summary>
        public DateTime Date { get; set; } = DateTime.MinValue;

        /// Foreign keys

        /// <summary>
        /// Connection income categories
        /// </summary>
        public int ID_Income_Category { get; set; }

        /// <summary>
        /// Connection source income
        /// </summary>
        public int ID_Account { get; set; }

        /// For navigation

        /// <summary>
        /// Navigation incomes categories
        /// </summary>
        public IncomeCategory? IncomeCategory { get; set; }

        /// <summary>
        /// Navigation source incomes
        /// </summary>
        public Account? Account { get; set; }
    }
}
