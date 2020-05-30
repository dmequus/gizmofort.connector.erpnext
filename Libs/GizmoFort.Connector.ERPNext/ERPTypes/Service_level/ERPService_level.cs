using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_level
{
    public class ERPService_level : ERPNextObjectBase
    {
        public ERPService_level() : this(new ERPObject(DocType.Service_level)) { }
        public ERPService_level(ERPObject obj) : base(obj) { }

        public static ERPService_level Create(string servicelevel, string holidaylist, string supportandresolution, string priorities)

        {
            ERPService_level obj = new ERPService_level();
            obj.service_level = servicelevel;
            obj.holiday_list = holidaylist;
            obj.support_and_resolution = supportandresolution;
            obj.priorities = priorities;
            return obj;
        }

        public string service_level
        {
            get { return data.service_level; }
            set
            {
                data.service_level = value;
                data.name = value;
            }

        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public string support_and_resolution
        {
            get { return data.support_and_resolution; }
            set { data.support_and_resolution = value; }
        }

        public string priorities
        {
            get { return data.priorities; }
            set { data.priorities = value; }
        }

        public string employee_group
        {
            get { return data.employee_group; }
            set { data.employee_group = value; }
        }

        public string default_priority
        {
            get { return data.default_priority; }
            set { data.default_priority = value; }
        }


    }

    //Enums go here

}