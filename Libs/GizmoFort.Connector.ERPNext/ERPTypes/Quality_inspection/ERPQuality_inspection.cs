using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection
{
    public class ERPQuality_inspection : ERPNextObjectBase
    {
        public ERPQuality_inspection() : this(new ERPObject(DocType.Quality_inspection)) { }
        public ERPQuality_inspection(ERPObject obj) : base(obj) { }

        public static ERPQuality_inspection Create(string namingseries, string reportdate, Inspectiontype inspectiontype, string itemcode, double samplesize, string inspectedby, Status status)

        {
            ERPQuality_inspection obj = new ERPQuality_inspection();
            obj.naming_series = namingseries;
            obj.report_date = reportdate;
            obj.inspection_type = inspectiontype;
            obj.item_code = itemcode;
            obj.sample_size = samplesize;
            obj.inspected_by = inspectedby;
            obj.status = status;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string report_date
        {
            get { return data.report_date; }
            set { data.report_date = value; }
        }

        public Inspectiontype inspection_type
        {
            get { return parseEnum<Inspectiontype>(data.inspection_type); }
            set { data.inspection_type = value.ToString(); }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        private double _sample_size = 0.0;
        public double sample_size
        {
            get { return data._sample_size; }
            set { data._sample_size = value; }
        }

        public string inspected_by
        {
            get { return data.inspected_by; }
            set { data.inspected_by = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public Referencetype reference_type
        {
            get { return parseEnum<Referencetype>(data.reference_type); }
            set { data.reference_type = value.ToString(); }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string item_serial_no
        {
            get { return data.item_serial_no; }
            set { data.item_serial_no = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string verified_by
        {
            get { return data.verified_by; }
            set { data.verified_by = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string quality_inspection_template
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = value; }
        }

        public string readings
        {
            get { return data.readings; }
            set { data.readings = value; }
        }


    }

    //Enums go here
    public enum Inspectiontype
    {
        [Description("Incoming")]
        Incoming,
        [Description("Outgoing")]
        Outgoing,
        [Description("In Process")]
        InProcess,
    }

    public enum Status
    {
        [Description("Accepted")]
        Accepted,
        [Description("Rejected")]
        Rejected,
    }

    public enum Referencetype
    {
        [Description("Purchase Receipt")]
        PurchaseReceipt,
        [Description("Purchase Invoice")]
        PurchaseInvoice,
        [Description("Delivery Note")]
        DeliveryNote,
        [Description("Sales Invoice")]
        SalesInvoice,
        [Description("Stock Entry")]
        StockEntry,
    }


}