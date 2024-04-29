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
    /// Expenses
    /// </summary>
    internal class Expenses
    {
        /// <summary>
        /// Identity of expenses, auto incrementable
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Expenses { get; set; }

        /// <summary>
        /// Description of expenses
        /// </summary>
        public string? Description { get; set; } = "";

        /// <summary>
        /// Amount that cost expense
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Date expense
        /// </summary>
        public DateTime? Date { get; set; } = DateTime.MinValue;

        /// Foreign keys

        /// <summary>
        /// Connection expense categories
        /// </summary>
        public int? ID_Expense_Category { get; set; }

        /// <summary>
        /// Connection paymente method
        /// </summary>
        public int? ID_Payment_Method { get; set; }


        /// For navigation

        /// <summary>
        /// Navigation expenses categories
        /// </summary>
        public ExpensesCategories? ExpensesCategories { get; set; }

        /// <summary>
        /// Navigation payment methods
        /// </summary>
        public PaymentMethods? PaymentMethods { get; set; }

    }
}
