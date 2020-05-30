using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Projects_settings
{
    public class ERPProjects_settings : ERPNextObjectBase
    {
        public ERPProjects_settings() : this(new ERPObject(DocType.Projects_settings)) { }
        public ERPProjects_settings(ERPObject obj) : base(obj) { }

        public static ERPProjects_settings Create(int ignoreworkstationtimeoverlap, int ignoreusertimeoverlap, int ignoreemployeetimeoverlap)

        {
            ERPProjects_settings obj = new ERPProjects_settings();
            obj.ignore_workstation_time_overlap = ignoreworkstationtimeoverlap;
            obj.ignore_user_time_overlap = ignoreusertimeoverlap;
            obj.ignore_employee_time_overlap = ignoreemployeetimeoverlap;
            return obj;
        }

        private int _ignore_workstation_time_overlap = 0;
        public int ignore_workstation_time_overlap
        {
            get { return data._ignore_workstation_time_overlap; }
            set { data._ignore_workstation_time_overlap = value; }
        }

        private int _ignore_user_time_overlap = 0;
        public int ignore_user_time_overlap
        {
            get { return data._ignore_user_time_overlap; }
            set { data._ignore_user_time_overlap = value; }
        }

        private int _ignore_employee_time_overlap = 0;
        public int ignore_employee_time_overlap
        {
            get { return data._ignore_employee_time_overlap; }
            set { data._ignore_employee_time_overlap = value; }
        }


    }

    //Enums go here

}