using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hub_user
{
    public class ERPHub_user : ERPNextObjectBase
    {
        public ERPHub_user() : this(new ERPObject(DocType.Hub_user)) { }
        public ERPHub_user(ERPObject obj) : base(obj) { }

        public static ERPHub_user Create(string user, string hubusername, string password)

        {
            ERPHub_user obj = new ERPHub_user();
            obj.user = user;
            obj.hub_user_name = hubusername;
            obj.password = password;
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

        public string hub_user_name
        {
            get { return data.hub_user_name; }
            set { data.hub_user_name = value; }
        }

        public string password
        {
            get { return data.password; }
            set { data.password = value; }
        }


    }

    //Enums go here

}