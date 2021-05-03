using System;
using System.Xml.Serialization;

#nullable disable

namespace RotRut.Export
{
    
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/begaran/6.0")]
    [XmlRoot(Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/begaran/6.0", IsNullable = false)]
    public partial class Begaran
    {

        private string namnPaBegaranField;

        private RotBegaran rotBegaranField;
        private HushallBegaran hushallBegaranField;


        /// <remarks/>
        [XmlElement(Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
        public string NamnPaBegaran
        {
            get
            {
                return this.namnPaBegaranField;
            }
            set
            {
                this.namnPaBegaranField = value;
            }
        }

        /// <remarks/>
        [XmlElement("RotBegaran", Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0", IsNullable = false)]
        public RotBegaran RotBegaran
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

        /// <remarks/>
        [XmlElement("HushallBegaran", Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0", IsNullable = false)]
        public HushallBegaran HushallBegaran
        {
            get
            {
                return this.hushallBegaranField;
            }
            set
            {
                this.hushallBegaranField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class HushallBegaranArenden : IBegaranArende
    {

        private string kopareField;

        private DateTime betalningsDatumField;

        private int prisForArbeteField;

        private int betaltBeloppField;

        private int begartBeloppField;

        private int? fakturaNrField;

        private int? ovrigkostnadField;

        private HushallBegaranArendenUtfortArbete utfortArbeteField;

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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
        /// Uppgifter om utfört arbete för Rut 
        /// </summary>
        public HushallBegaranArendenUtfortArbete UtfortArbete
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
    public partial class HushallBegaranArendenUtfortArbete
    {

        private HushallBegaranArendenUtfortArbeteStadning stadningField;

        private HushallBegaranArendenUtfortArbeteKladOchTextilvard kladOchTextilvardField;

        private HushallBegaranArendenUtfortArbeteSnoskottning snoskottningField;

        private HushallBegaranArendenUtfortArbeteTradgardsarbete tradgardsarbeteField;

        private HushallBegaranArendenUtfortArbeteBarnpassning barnpassningField;

        private HushallBegaranArendenUtfortArbetePersonligomsorg personligomsorgField;

        private HushallBegaranArendenUtfortArbeteFlyttjanster flyttjansterField;

        private HushallBegaranArendenUtfortArbeteItTjanster itTjansterField;

        private HushallBegaranArendenUtfortArbeteReparationAvVitvaror reparationAvVitvarorField;

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteStadning Stadning
        {
            get
            {
                return this.stadningField;
            }
            set
            {
                this.stadningField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteKladOchTextilvard KladOchTextilvard
        {
            get
            {
                return this.kladOchTextilvardField;
            }
            set
            {
                this.kladOchTextilvardField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteSnoskottning Snoskottning
        {
            get
            {
                return this.snoskottningField;
            }
            set
            {
                this.snoskottningField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteTradgardsarbete Tradgardsarbete
        {
            get
            {
                return this.tradgardsarbeteField;
            }
            set
            {
                this.tradgardsarbeteField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteBarnpassning Barnpassning
        {
            get
            {
                return this.barnpassningField;
            }
            set
            {
                this.barnpassningField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbetePersonligomsorg Personligomsorg
        {
            get
            {
                return this.personligomsorgField;
            }
            set
            {
                this.personligomsorgField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteFlyttjanster Flyttjanster
        {
            get
            {
                return this.flyttjansterField;
            }
            set
            {
                this.flyttjansterField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteItTjanster ItTjanster
        {
            get
            {
                return this.itTjansterField;
            }
            set
            {
                this.itTjansterField = value;
            }
        }

        /// <remarks/>
        public HushallBegaranArendenUtfortArbeteReparationAvVitvaror ReparationAvVitvaror
        {
            get
            {
                return this.reparationAvVitvarorField;
            }
            set
            {
                this.reparationAvVitvarorField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0")]
    public partial class HushallBegaranArendenUtfortArbeteStadning: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteKladOchTextilvard: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteSnoskottning: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteTradgardsarbete: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteBarnpassning: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbetePersonligomsorg: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteFlyttjanster: ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteItTjanster : ITimmarMaterial
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
    public partial class HushallBegaranArendenUtfortArbeteReparationAvVitvaror: ITimmarMaterial
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
    [XmlRoot(Namespace = "http://xmls.skatteverket.se/se/skatteverket/ht/komponent/begaran/6.0", IsNullable = false)]
    public partial class HushallBegaran
    {

        private HushallBegaranArenden[] hushallBegaranField;


        /// <remarks/>
        [XmlElement("Arenden")]
        public HushallBegaranArenden[] Arenden
        {
            get
            {
                return this.hushallBegaranField;
            }
            set
            {
                this.hushallBegaranField = value;
            }
        }
    }
}