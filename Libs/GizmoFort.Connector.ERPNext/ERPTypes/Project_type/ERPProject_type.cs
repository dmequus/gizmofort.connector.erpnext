using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_type
{
    public class ERPProject_type : ERPNextObjectBase
    {
        public ERPProject_type() : this(new ERPObject(DocType.Project_type)) { }
        public ERPProject_type(ERPObject obj) : base(obj) { }

        public static ERPProject_type Create(string projecttype, string description)

        {
            ERPProject_type obj = new ERPProject_type();
            obj.project_type = projecttype;
            obj.description = description;
            return obj;
        }

        public string project_type
        {
            get { return data.project_type; }
            set
            {
                data.project_type = value;
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