using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom_category
{
    public class ERPUom_category : ERPNextObjectBase
    {
        public ERPUom_category() : this(new ERPObject(DocType.Uom_category)) { }
        public ERPUom_category(ERPObject obj) : base(obj) { }

        public static ERPUom_category Create(string categoryname)

        {
            ERPUom_category obj = new ERPUom_category();
            obj.category_name = categoryname;
            return obj;
        }

        public string category_name
        {
            get { return data.category_name; }
            set
            {
                data.category_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}