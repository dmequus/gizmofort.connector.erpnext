using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hub_users
{
    public class ERPHub_users : ERPNextObjectBase
    {
        public ERPHub_users() : this(new ERPObject(DocType.Hub_users)) { }
        public ERPHub_users(ERPObject obj) : base(obj) { }

        public static ERPHub_users Create(string user)

        {
            ERPHub_users obj = new ERPHub_users();
            obj.user = user;
            return obj;
        }

        public string user
        {
            get { return data.user; }
            set
            {
                data.user = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}