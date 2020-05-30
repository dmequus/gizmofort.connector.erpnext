using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_category
{
    public class ERPTax_category : ERPNextObjectBase
    {
        public ERPTax_category() : this(new ERPObject(DocType.Tax_category)) { }
        public ERPTax_category(ERPObject obj) : base(obj) { }

        public static ERPTax_category Create(string title)

        {
            ERPTax_category obj = new ERPTax_category();
            obj.title = title;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}