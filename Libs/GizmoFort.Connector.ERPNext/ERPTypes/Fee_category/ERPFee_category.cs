using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_category
{
    public class ERPFee_category : ERPNextObjectBase
    {
        public ERPFee_category() : this(new ERPObject(DocType.Fee_category)) { }
        public ERPFee_category(ERPObject obj) : base(obj) { }

        public static ERPFee_category Create(string categoryname, string description)

        {
            ERPFee_category obj = new ERPFee_category();
            obj.category_name = categoryname;
            obj.description = description;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}