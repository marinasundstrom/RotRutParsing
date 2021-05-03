using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

#nullable disable

namespace RotRut.Export
{
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    [XmlRoot(Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0", IsNullable = false)]
    public partial class RotBegaran
    {
        private RotBegaranArenden[] rotBegaranField;

        /// <remarks/>
        [XmlElement("Arenden")]
        public RotBegaranArenden[] Arenden
        {
            get
            {
                return this.rotBegaranField;
            }
            set
            {
                this.rotBegaranField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArenden : IBegaranArende
    {

        private string kopareField;

        private DateTime betalningsDatumField;

        private int prisForArbeteField;

        private int betaltBeloppField;

        private int begartBeloppField;

        private int? fakturaNrField;

        private int? ovrigkostnadField;

        private RotBegaranArendenUtfortArbete utfortArbeteField;

        private string fastighetsbeteckningField;

        private int? lagenhetsnrField;

        private string brforgnrField;

        /// <remarks/>
        public string Kopare
        {
            get
            {
                return this.kopareField;
            }
            set
            {
                this.kopareField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime BetalningsDatum
        {
            get
            {
                return this.betalningsDatumField;
            }
            set
            {
                this.betalningsDatumField = value;
            }
        }

        /// <remarks/>
        public int PrisForArbete
        {
            get
            {
                return this.prisForArbeteField;
            }
            set
            {
                this.prisForArbeteField = value;
            }
        }

        /// <remarks/>
        public int BetaltBelopp
        {
            get
            {
                return this.betaltBeloppField;
            }
            set
            {
                this.betaltBeloppField = value;
            }
        }

        /// <remarks/>
        public int BegartBelopp
        {
            get
            {
                return this.begartBeloppField;
            }
            set
            {
                this.begartBeloppField = value;
            }
        }

        /// <remarks/>
        public int? FakturaNr
        {
            get
            {
                return this.fakturaNrField;
            }
            set
            {
                this.fakturaNrField = value;
            }
        }

        /// <remarks/>
        [XmlElement("Ovrigkostnad")]
        public int? OvrigKostnad
        {
            get
            {
                return this.ovrigkostnadField;
            }
            set
            {
                this.ovrigkostnadField = value;
            }
        }

        /// <summary>
        /// Fastighetsbeteckning, ska fyllas i om rot-avdraget avser en fastighet 
        /// </summary>
        [XmlElement("Fastighetsbeteckning")]
        public string Fastighetsbeteckning
        {
            get
            {
                return this.fastighetsbeteckningField;
            }
            set
            {
                this.fastighetsbeteckningField = value;
            }
        }

        /// <summary>
        /// Lägenhetsnummer, ska fyllas i om rot-avdraget avser en lägenhet
        /// </summary>
        [XmlElement("LagenhetsNr")]
        public int? LagenhetsNr
        {
            get
            {
                return this.lagenhetsnrField;
            }
            set
            {
                this.lagenhetsnrField = value;
            }
        }

        /// <summary>
        /// Bostadsrättsförenings organisationsnummer, ska fyllas i om rot-avdraget avser en lägenhet 
        /// </summary>
        [XmlElement("BrfOrgNr")]
        public string BrfOrgNr
        {
            get
            {
                return this.brforgnrField;
            }
            set
            {
                this.brforgnrField = value;
            }
        }

        /// <summary>
        /// Uppgifter om utfört arbete för Rot 
        /// </summary>
        public RotBegaranArendenUtfortArbete UtfortArbete
        {
            get
            {
                return this.utfortArbeteField;
            }
            set
            {
                this.utfortArbeteField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbete
    {

        private RotBegaranArendenUtfortArbeteBygg byggField;

        private RotBegaranArendenUtfortArbeteEl elField;

        private RotBegaranArendenUtfortArbeteGlasPlatarbete glasplatarbeteField;

        private RotBegaranArendenUtfortArbeteMarkDraneringarbete markdraneringarbeteField;

        private RotBegaranArendenUtfortArbeteMurning murningField;

        private RotBegaranArendenUtfortArbeteMalningTapetsering malningtapetseringField;

        private RotBegaranArendenUtfortArbeteVvs vvsField;

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteBygg Bygg
        {
            get
            {
                return this.byggField;
            }
            set
            {
                this.byggField = value;
            }
        }

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteEl El
        {
            get
            {
                return this.elField;
            }
            set
            {
                this.elField = value;
            }
        }

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteGlasPlatarbete GlasPlatarbete
        {
            get
            {
                return this.glasplatarbeteField;
            }
            set
            {
                this.glasplatarbeteField = value;
            }
        }

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteMarkDraneringarbete MarkDraneringarbete
        {
            get
            {
                return this.markdraneringarbeteField;
            }
            set
            {
                this.markdraneringarbeteField = value;
            }
        }

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteMurning Murning
        {
            get
            {
                return this.murningField;
            }
            set
            {
                this.murningField = value;
            }
        }

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteMalningTapetsering MalningTapetsering
        {
            get
            {
                return this.malningtapetseringField;
            }
            set
            {
                this.malningtapetseringField = value;
            }
        }

        /// <remarks/>
        public RotBegaranArendenUtfortArbeteVvs Vvs
        {
            get
            {
                return this.vvsField;
            }
            set
            {
                this.vvsField = value;
            }
        }
    }

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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteBygg : ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteEl: ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }

     /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteGlasPlatarbete: ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }

     /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteMarkDraneringarbete: ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteMurning: ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteMalningTapetsering: ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class RotBegaranArendenUtfortArbeteVvs: ITimmarMaterial
    {

        private double antalTimmarField;

        private decimal materialkostnadField;

        /// <remarks/>
        public double AntalTimmar
        {
            get
            {
                return this.antalTimmarField;
            }
            set
            {
                this.antalTimmarField = value;
            }
        }

        /// <remarks/>
        public decimal Materialkostnad
        {
            get
            {
                return this.materialkostnadField;
            }
            set
            {
                this.materialkostnadField = value;
            }
        }
    }
}