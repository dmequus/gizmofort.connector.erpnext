using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Blanket_order
{
    public class ERPBlanket_order : ERPNextObjectBase
    {
        public ERPBlanket_order() : this(new ERPObject(DocType.Blanket_order)) { }
        public ERPBlanket_order(ERPObject obj) : base(obj) { }

        public static ERPBlanket_order Create(string namingseries, Blanketordertype blanketordertype, string fromdate, string todate, string company, string items)

        {
            ERPBlanket_order obj = new ERPBlanket_order();
            obj.naming_series = namingseries;
            obj.blanket_order_type = blanketordertype;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.company = company;
            obj.items = items;
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

        public Blanketordertype blanket_order_type
        {
            get { return parseEnum<Blanketordertype>(data.blanket_order_type); }
            set { data.blanket_order_type = value.ToString(); }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string supplier_name
        {
            get { return data.supplier_name; }
            set { data.supplier_name = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string tc_name
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }


    }

    //Enums go here
    public enum Blanketordertype
    {
        [Description("Selling")]
        Selling,
        [Description("Purchasing")]
        Purchasing,
    }


}