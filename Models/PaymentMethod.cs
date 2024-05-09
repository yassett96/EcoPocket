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
    /// PaymentsMethods
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// Identity of payment method
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ID_Payment_Method { get; set; }

        /// <summary>
        /// Payment method description
        /// </summary>
        public string? Description { get; set; } = "";

        /// <summary>
        /// Payment method icon
        /// </summary>
        public byte[]? Icon { get; set; }
    }
}
