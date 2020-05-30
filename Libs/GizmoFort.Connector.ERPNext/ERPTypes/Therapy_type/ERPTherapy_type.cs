using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Therapy_type
{
    public class ERPTherapy_type : ERPNextObjectBase
    {
        public ERPTherapy_type() : this(new ERPObject(DocType.Therapy_type)) { }
        public ERPTherapy_type(ERPObject obj) : base(obj) { }

        public static ERPTherapy_type Create(string therapytype, string itemcode, string itemgroup, string itemname)

        {
            ERPTherapy_type obj = new ERPTherapy_type();
            obj.therapy_type = therapytype;
            obj.item_code = itemcode;
            obj.item_group = itemgroup;
            obj.item_name = itemname;
            return obj;
        }

        public string therapy_type
        {
            get { return data.therapy_type; }
            set
            {
                data.therapy_type = value;
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

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
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

        public string exercises
        {
            get { return data.exercises; }
            set { data.exercises = value; }
        }

        private int _default_duration = 0;
        public int default_duration
        {
            get { return data._default_duration; }
            set { data._default_duration = value; }
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

        private int _change_in_item = 0;
        public int change_in_item
        {
            get { return data._change_in_item; }
            set { data._change_in_item = value; }
        }

        public string therapy_for
        {
            get { return data.therapy_for; }
            set { data.therapy_for = value; }
        }

        public string healthcare_service_unit
        {
            get { return data.healthcare_service_unit; }
            set { data.healthcare_service_unit = value; }
        }


    }

    //Enums go here

}