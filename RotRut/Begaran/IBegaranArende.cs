using System;
using System.ComponentModel.DataAnnotations;

namespace RotRut.Begaran
{
    public interface IBegaranArende
    {
        /// <summary>
        /// Köparens personnummer, obligatorisk
        /// </summary>
        [Required]
        [RegularExpression(@"^(\d{10}|\d{12})$")]
        string Kopare { get; set; }

        /// <summary>
        /// Datum för betalning, obligatorisk. Anges enligt följande exempel: 2019-07-01
        /// </summary>
        [Required]
        [RegularExpression(@"^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$")]
        DateTime BetalningsDatum { get; set; }

        /// <summary>
        /// Pris för arbetet (arbetskostnaden), obligatorisk 
        /// </summary>
        [Required]
        [Range(2, 99999999999)]
        int PrisForArbete { get; set; }

        /// <summary>
        /// Belopp du fått betalt för arbetet, obligatorisk 
        /// </summary>
        [Required]
        [Range(0, 99999999999)]
        int BetaltBelopp { get; set; }

        /// <summary>
        /// Belopp du begär, obligatorisk 
        /// </summary>
        [Required]
        [Range(0, 99999999999)]
        int BegartBelopp { get; set; }

        /// <summary>
        /// Ärendets fakturanummer
        /// </summary>
        [Required]
        [StringLength(20)]
        string FakturaNr { get; set; }

        /// <summary>
        /// Uppgifter om övrig kostnad. Ska fyllas i om timmar eller material angetts för någon tjänst i utfört arbete
        /// </summary>
        [Range(0, 99999999999)]
        int? OvrigKostnad { get; set; }
    }
}