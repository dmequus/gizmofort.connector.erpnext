using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_user
{
    public class ERPProject_user : ERPNextObjectBase
    {
        public ERPProject_user() : this(new ERPObject(DocType.Project_user)) { }
        public ERPProject_user(ERPObject obj) : base(obj) { }

        public static ERPProject_user Create(string user)

        {
            ERPProject_user obj = new ERPProject_user();
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

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string full_name
        {
            get { return data.full_name; }
            set { data.full_name = value; }
        }

        public long welcome_email_sent
        {
            get { return data.welcome_email_sent; }
            set { data.welcome_email_sent = value; }
        }

        public long view_attachments
        {
            get { return data.view_attachments; }
            set { data.view_attachments = value; }
        }

        public string project_status
        {
            get { return data.project_status; }
            set { data.project_status = value; }
        }


    }

    //Enums go here

}