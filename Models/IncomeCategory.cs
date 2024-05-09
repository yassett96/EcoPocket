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
    public class IncomeCategory
    {
        /// <summary>
        /// Identity of incomes categories, auto incrementable
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Income_Category { get; set; }
        
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
