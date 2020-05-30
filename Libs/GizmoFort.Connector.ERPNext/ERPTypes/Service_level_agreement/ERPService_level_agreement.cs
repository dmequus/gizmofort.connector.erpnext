using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Service_level_agreement
{
    public class ERPService_level_agreement : ERPNextObjectBase
    {
        public ERPService_level_agreement() : this(new ERPObject(DocType.Service_level_agreement)) { }
        public ERPService_level_agreement(ERPObject obj) : base(obj) { }

        public static ERPService_level_agreement Create(string servicelevel)

        {
            ERPService_level_agreement obj = new ERPService_level_agreement();
            obj.service_level = servicelevel;
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

        public long default_service_level_agreement
        {
            get { return data.default_service_level_agreement; }
            set { data.default_service_level_agreement = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public string employee_group
        {
            get { return data.employee_group; }
            set { data.employee_group = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
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

        public string default_priority
        {
            get { return data.default_priority; }
            set { data.default_priority = value; }
        }

        public long active
        {
            get { return data.active; }
            set { data.active = value; }
        }

        public string entity
        {
            get { return data.entity; }
            set { data.entity = value; }
        }

        public Entitytype entity_type
        {
            get { return parseEnum<Entitytype>(data.entity_type); }
            set { data.entity_type = value.ToString(); }
        }

        public long enable
        {
            get { return data.enable; }
            set { data.enable = value; }
        }


    }

    //Enums go here
    public enum Entitytype
    {
        [Description("Customer")]
        Customer,
        [Description("Customer Group")]
        CustomerGroup,
        [Description("Territory")]
        Territory,
    }


}