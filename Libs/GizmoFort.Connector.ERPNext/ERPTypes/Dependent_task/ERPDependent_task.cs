using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Dependent_task
{
    public class ERPDependent_task : ERPNextObjectBase
    {
        public ERPDependent_task() : this(new ERPObject(DocType.Dependent_task)) { }
        public ERPDependent_task(ERPObject obj) : base(obj) { }

        public static ERPDependent_task Create(string task)

        {
            ERPDependent_task obj = new ERPDependent_task();
            obj.task = task;
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


    }

    //Enums go here

}