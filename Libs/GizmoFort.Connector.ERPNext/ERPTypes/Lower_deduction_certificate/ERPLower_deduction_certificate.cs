using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lower_deduction_certificate
{
    public class ERPLower_deduction_certificate : ERPNextObjectBase
    {
        public ERPLower_deduction_certificate() : this(new ERPObject(DocType.Lower_deduction_certificate)) { }
        public ERPLower_deduction_certificate(ERPObject obj) : base(obj) { }

        public static ERPLower_deduction_certificate Create(string certificateno, Sectioncode sectioncode, string supplier, string panno, string validupto, double rate, double certificatelimit, string validfrom, string fiscalyear)

        {
            ERPLower_deduction_certificate obj = new ERPLower_deduction_certificate();
            obj.certificate_no = certificateno;
            obj.section_code = sectioncode;
            obj.supplier = supplier;
            obj.pan_no = panno;
            obj.valid_upto = validupto;
            obj.rate = rate;
            obj.certificate_limit = certificatelimit;
            obj.valid_from = validfrom;
            obj.fiscal_year = fiscalyear;
            return obj;
        }

        public string certificate_no
        {
            get { return data.certificate_no; }
            set
            {
                data.certificate_no = value;
                data.name = value;
            }

        }

        public Sectioncode section_code
        {
            get { return parseEnum<Sectioncode>(data.section_code); }
            set { data.section_code = value.ToString(); }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string pan_no
        {
            get { return data.pan_no; }
            set { data.pan_no = value; }
        }

        public string valid_upto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double certificate_limit
        {
            get { return data.certificate_limit; }
            set { data.certificate_limit = value; }
        }

        public string valid_from
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }


    }

    //Enums go here
    public enum Sectioncode
    {
        [Description("192")]
        num192,
        [Description("193")]
        num193,
        [Description("194")]
        num194,
        [Description("194A")]
        A,
        [Description("194C")]
        C,
        [Description("194D")]
        D,
        [Description("194H")]
        H,
        [Description("194I")]
        I,
        [Description("194J")]
        J,
        [Description("194LA")]
        LA,
        [Description("194LBB")]
        LBB,
        [Description("194LBC")]
        LBC,
        [Description("195")]
        num195,
    }


}