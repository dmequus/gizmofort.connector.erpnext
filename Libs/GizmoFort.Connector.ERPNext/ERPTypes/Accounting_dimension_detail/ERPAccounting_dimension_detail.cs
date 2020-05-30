using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounting_dimension_detail
{
    public class ERPAccounting_dimension_detail : ERPNextObjectBase
    {
        public ERPAccounting_dimension_detail() : this(new ERPObject(DocType.Accounting_dimension_detail)) { }
        public ERPAccounting_dimension_detail(ERPObject obj) : base(obj) { }

        public static ERPAccounting_dimension_detail Create()

        {
            ERPAccounting_dimension_detail obj = new ERPAccounting_dimension_detail();
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

        public string reference_document
        {
            get { return data.reference_document; }
            set { data.reference_document = value; }
        }

        public string default_dimension
        {
            get { return data.default_dimension; }
            set { data.default_dimension = value; }
        }

        private int _mandatory_for_bs = 0;
        public int mandatory_for_bs
        {
            get { return data._mandatory_for_bs; }
            set { data._mandatory_for_bs = value; }
        }

        private int _mandatory_for_pl = 0;
        public int mandatory_for_pl
        {
            get { return data._mandatory_for_pl; }
            set { data._mandatory_for_pl = value; }
        }


    }

    //Enums go here

}