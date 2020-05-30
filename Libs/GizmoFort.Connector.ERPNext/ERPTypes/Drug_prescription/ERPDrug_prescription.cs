using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Drug_prescription
{
    public class ERPDrug_prescription : ERPNextObjectBase
    {
        public ERPDrug_prescription() : this(new ERPObject(DocType.Drug_prescription)) { }
        public ERPDrug_prescription(ERPObject obj) : base(obj) { }

        public static ERPDrug_prescription Create(string drugcode)

        {
            ERPDrug_prescription obj = new ERPDrug_prescription();
            obj.drug_code = drugcode;
            return obj;
        }

        public string drug_code
        {
            get { return data.drug_code; }
            set
            {
                data.drug_code = value;
                data.name = value;
            }

        }

        public string drug_name
        {
            get { return data.drug_name; }
            set { data.drug_name = value; }
        }

        public string dosage
        {
            get { return data.dosage; }
            set { data.dosage = value; }
        }

        public string period
        {
            get { return data.period; }
            set { data.period = value; }
        }

        public string dosage_form
        {
            get { return data.dosage_form; }
            set { data.dosage_form = value; }
        }

        public string comment
        {
            get { return data.comment; }
            set { data.comment = value; }
        }

        private int _interval = 0;
        public int interval
        {
            get { return data._interval; }
            set { data._interval = value; }
        }

        private int _update_schedule = 0;
        public int update_schedule
        {
            get { return data._update_schedule; }
            set { data._update_schedule = value; }
        }

        public Intervaluom interval_uom
        {
            get { return parseEnum<Intervaluom>(data.interval_uom); }
            set { data.interval_uom = value.ToString(); }
        }

        private int _usage_interval = 0;
        public int usage_interval
        {
            get { return data._usage_interval; }
            set { data._usage_interval = value; }
        }


    }

    //Enums go here
    public enum Intervaluom
    {
        [Description("Hour")]
        Hour,
        [Description("Day")]
        Day,
    }


}