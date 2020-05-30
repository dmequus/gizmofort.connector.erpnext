using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom
{
    public class ERPUom : ERPNextObjectBase
    {
        public ERPUom() : this(new ERPObject(DocType.Uom)) { }
        public ERPUom(ERPObject obj) : base(obj) { }

        public static ERPUom Create(string uomname, int mustbewholenumber)

        {
            ERPUom obj = new ERPUom();
            obj.uom_name = uomname;
            obj.must_be_whole_number = mustbewholenumber;
            return obj;
        }

        public string uom_name
        {
            get { return data.uom_name; }
            set
            {
                data.uom_name = value;
                data.name = value;
            }

        }

        private int _must_be_whole_number = 0;
        public int must_be_whole_number
        {
            get { return data._must_be_whole_number; }
            set { data._must_be_whole_number = value; }
        }


    }

    //Enums go here

}