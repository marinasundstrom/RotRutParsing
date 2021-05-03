using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RotRut.Begaran
{
    /// <summary>
    /// Uppgifter om utfört arbete, timmar och material 
    /// </summary>
    public interface ITimmarMaterial
    {
        /// <summary>
        /// Antal timmar
        /// </summary>
        [Range(0, 999)]
        double AntalTimmar { get; set; }

        /// <summary>
        /// Materialkostnad
        /// </summary>
        [Range(0, 9999999)]
        decimal Materialkostnad { get; set; }
    }
}