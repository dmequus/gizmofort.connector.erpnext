using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_movement
{
    public class ERPAsset_movement : ERPNextObjectBase
    {
        public ERPAsset_movement() : this(new ERPObject(DocType.Asset_movement)) { }
        public ERPAsset_movement(ERPObject obj) : base(obj) { }

        public static ERPAsset_movement Create(string company, Purpose purpose, string transactiondate, string assets)

        {
            ERPAsset_movement obj = new ERPAsset_movement();
            obj.company = company;
            obj.purpose = purpose;
            obj.transaction_date = transactiondate;
            obj.assets = assets;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public Purpose purpose
        {
            get { return parseEnum<Purpose>(data.purpose); }
            set { data.purpose = value.ToString(); }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string assets
        {
            get { return data.assets; }
            set { data.assets = value; }
        }

        public string reference_doctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        public string reference_name
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Purpose
    {
        [Description("Issue")]
        Issue,
        [Description("Receipt")]
        Receipt,
        [Description("Transfer")]
        Transfer,
    }


}