using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_location
{
    public class ERPLinked_location : ERPNextObjectBase
    {
        public ERPLinked_location() : this(new ERPObject(DocType.Linked_location)) { }
        public ERPLinked_location(ERPObject obj) : base(obj) { }

        public static ERPLinked_location Create(string location)

        {
            ERPLinked_location obj = new ERPLinked_location();
            obj.location = location;
            return obj;
        }

        public string location
        {
            get { return data.location; }
            set
            {
                data.location = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}