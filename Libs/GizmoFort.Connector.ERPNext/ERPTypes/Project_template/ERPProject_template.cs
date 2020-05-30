using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_template
{
    public class ERPProject_template : ERPNextObjectBase
    {
        public ERPProject_template() : this(new ERPObject(DocType.Project_template)) { }
        public ERPProject_template(ERPObject obj) : base(obj) { }

        public static ERPProject_template Create(string tasks)

        {
            ERPProject_template obj = new ERPProject_template();
            obj.tasks = tasks;
            return obj;
        }

        public string tasks
        {
            get { return data.tasks; }
            set
            {
                data.tasks = value;
                data.name = value;
            }

        }

        public string project_type
        {
            get { return data.project_type; }
            set { data.project_type = value; }
        }


    }

    //Enums go here

}