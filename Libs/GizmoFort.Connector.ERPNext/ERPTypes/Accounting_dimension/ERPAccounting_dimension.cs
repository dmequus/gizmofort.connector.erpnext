using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounting_dimension
{
    public class ERPAccounting_dimension : ERPNextObjectBase
    {
        public ERPAccounting_dimension() : this(new ERPObject(DocType.Accounting_dimension)) { }
        public ERPAccounting_dimension(ERPObject obj) : base(obj) { }

        public static ERPAccounting_dimension Create(string documenttype)

        {
            ERPAccounting_dimension obj = new ERPAccounting_dimension();
            obj.document_type = documenttype;
            return obj;
        }

        public string document_type
        {
            get { return data.document_type; }
            set
            {
                data.document_type = value;
                data.name = value;
            }

        }

        public string label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        public string fieldname
        {
            get { return data.fieldname; }
            set { data.fieldname = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string dimension_defaults
        {
            get { return data.dimension_defaults; }
            set { data.dimension_defaults = value; }
        }


    }

    //Enums go here

}