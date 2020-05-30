using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Routing
{
    public class ERPRouting : ERPNextObjectBase
    {
        public ERPRouting() : this(new ERPObject(DocType.Routing)) { }
        public ERPRouting(ERPObject obj) : base(obj) { }

        public static ERPRouting Create(string routingname, long disabled, string operations)

        {
            ERPRouting obj = new ERPRouting();
            obj.routing_name = routingname;
            obj.disabled = disabled;
            obj.operations = operations;
            return obj;
        }

        public string routing_name
        {
            get { return data.routing_name; }
            set
            {
                data.routing_name = value;
                data.name = value;
            }

        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string operations
        {
            get { return data.operations; }
            set { data.operations = value; }
        }


    }

    //Enums go here

}