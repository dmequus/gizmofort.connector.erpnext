using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_field
{
    public class ERPPos_field : ERPNextObjectBase
    {
        public ERPPos_field() : this(new ERPObject(DocType.Pos_field)) { }
        public ERPPos_field(ERPObject obj) : base(obj) { }

        public static ERPPos_field Create()

        {
            ERPPos_field obj = new ERPPos_field();
            return obj;
        }

        public string fieldname
        {
            get { return data.fieldname; }
            set
            {
                data.fieldname = value;
                data.name = value;
            }

        }

        public string fieldtype
        {
            get { return data.fieldtype; }
            set { data.fieldtype = value; }
        }

        public string label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        public string options
        {
            get { return data.options; }
            set { data.options = value; }
        }

        private int _reqd = 0;
        public int reqd
        {
            get { return data._reqd; }
            set { data._reqd = value; }
        }

        private int _read_only = 0;
        public int read_only
        {
            get { return data._read_only; }
            set { data._read_only = value; }
        }

        public string default_value
        {
            get { return data.default_value; }
            set { data.default_value = value; }
        }


    }

    //Enums go here

}