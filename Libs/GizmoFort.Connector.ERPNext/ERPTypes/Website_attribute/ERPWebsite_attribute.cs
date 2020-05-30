using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Website_attribute
{
    public class ERPWebsite_attribute : ERPNextObjectBase
    {
        public ERPWebsite_attribute() : this(new ERPObject(DocType.Website_attribute)) { }
        public ERPWebsite_attribute(ERPObject obj) : base(obj) { }

        public static ERPWebsite_attribute Create(string attribute)

        {
            ERPWebsite_attribute obj = new ERPWebsite_attribute();
            obj.attribute = attribute;
            return obj;
        }

        public string attribute
        {
            get { return data.attribute; }
            set
            {
                data.attribute = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}