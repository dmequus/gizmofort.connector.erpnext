using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Task_depends_on
{
    public class ERPTask_depends_on : ERPNextObjectBase
    {
        public ERPTask_depends_on() : this(new ERPObject(DocType.Task_depends_on)) { }
        public ERPTask_depends_on(ERPObject obj) : base(obj) { }

        public static ERPTask_depends_on Create(string task, string subject, string project)

        {
            ERPTask_depends_on obj = new ERPTask_depends_on();
            obj.task = task;
            obj.subject = subject;
            obj.project = project;
            return obj;
        }

        public string task
        {
            get { return data.task; }
            set
            {
                data.task = value;
                data.name = value;
            }

        }

        public string subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }


    }

    //Enums go here

}