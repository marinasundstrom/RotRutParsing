using System;
using System.ComponentModel.DataAnnotations;

namespace RotRut.Export
{
    public interface IBegaranArende
    {
        /// <summary>
        /// Köparens personnummer, obligatorisk
        /// </summary>
        string Kopare { get; set; }

        /// <summary>
        /// Datum för betalning, obligatorisk. Anges enligt följande exempel: 2019-07-01
        /// </summary>
        DateTime BetalningsDatum { get; set; }

        /// <summary>
        /// Pris för arbetet (arbetskostnaden), obligatorisk 
        /// </summary>
        [Range(2, 99999999999)]
        int PrisForArbete { get; set; }

        /// <summary>
        /// Belopp du fått betalt för arbetet, obligatorisk 
        /// </summary>
        [Range(0, 99999999999)]
        int BetaltBelopp { get; set; }

        /// <summary>
        /// Belopp du begär, obligatorisk 
        /// </summary>
        int BegartBelopp { get; set; }

        /// <summary>
        /// Ärendets fakturanummer
        /// </summary>
        int? FakturaNr { get; set; }

        /// <summary>
        /// Uppgifter om övrig kostnad. Ska fyllas i om timmar eller material angetts för någon tjänst i utfört arbete
        /// </summary>
        int? OvrigKostnad { get; set; }
    }
}