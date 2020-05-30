using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure_template
{
    public class ERPClinical_procedure_template : ERPNextObjectBase
    {
        public ERPClinical_procedure_template() : this(new ERPObject(DocType.Clinical_procedure_template)) { }
        public ERPClinical_procedure_template(ERPObject obj) : base(obj) { }

        public static ERPClinical_procedure_template Create(string template, string itemcode, string itemgroup, string description)

        {
            ERPClinical_procedure_template obj = new ERPClinical_procedure_template();
            obj.template = template;
            obj.item_code = itemcode;
            obj.item_group = itemgroup;
            obj.description = description;
            return obj;
        }

        public string template
        {
            get { return data.template; }
            set
            {
                data.template = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string medical_department
        {
            get { return data.medical_department; }
            set { data.medical_department = value; }
        }

        private int _is_billable = 0;
        public int is_billable
        {
            get { return data._is_billable; }
            set { data._is_billable = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private int _consume_stock = 0;
        public int consume_stock
        {
            get { return data._consume_stock; }
            set { data._consume_stock = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string sample
        {
            get { return data.sample; }
            set { data.sample = value; }
        }

        public string sample_uom
        {
            get { return data.sample_uom; }
            set { data.sample_uom = value; }
        }

        private double _sample_qty = 0.0;
        public double sample_qty
        {
            get { return data._sample_qty; }
            set { data._sample_qty = value; }
        }

        public string sample_details
        {
            get { return data.sample_details; }
            set { data.sample_details = value; }
        }

        private int _change_in_item = 0;
        public int change_in_item
        {
            get { return data._change_in_item; }
            set { data._change_in_item = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }


    }

    //Enums go here

}