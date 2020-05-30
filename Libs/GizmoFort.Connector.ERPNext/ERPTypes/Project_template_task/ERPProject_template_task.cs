using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_template_task
{
    public class ERPProject_template_task : ERPNextObjectBase
    {
        public ERPProject_template_task() : this(new ERPObject(DocType.Project_template_task)) { }
        public ERPProject_template_task(ERPObject obj) : base(obj) { }

        public static ERPProject_template_task Create(string subject, int start, int duration, double taskweight, string description)

        {
            ERPProject_template_task obj = new ERPProject_template_task();
            obj.subject = subject;
            obj.start = start;
            obj.duration = duration;
            obj.task_weight = taskweight;
            obj.description = description;
            return obj;
        }

        public string subject
        {
            get { return data.subject; }
            set
            {
                data.subject = value;
                data.name = value;
            }

        }

        private int _start = 0;
        public int start
        {
            get { return data._start; }
            set { data._start = value; }
        }

        private int _duration = 0;
        public int duration
        {
            get { return data._duration; }
            set { data._duration = value; }
        }

        private double _task_weight = 0.0;
        public double task_weight
        {
            get { return data._task_weight; }
            set { data._task_weight = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}