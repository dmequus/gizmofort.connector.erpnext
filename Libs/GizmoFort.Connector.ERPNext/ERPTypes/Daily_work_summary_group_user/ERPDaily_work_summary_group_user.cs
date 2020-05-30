using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary_group_user
{
    public class ERPDaily_work_summary_group_user : ERPNextObjectBase
    {
        public ERPDaily_work_summary_group_user() : this(new ERPObject(DocType.Daily_work_summary_group_user)) { }
        public ERPDaily_work_summary_group_user(ERPObject obj) : base(obj) { }

        public static ERPDaily_work_summary_group_user Create(string user, string email)

        {
            ERPDaily_work_summary_group_user obj = new ERPDaily_work_summary_group_user();
            obj.user = user;
            obj.email = email;
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

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }


    }

    //Enums go here

}