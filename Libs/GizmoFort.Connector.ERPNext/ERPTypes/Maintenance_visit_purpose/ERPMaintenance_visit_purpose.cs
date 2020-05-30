using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_visit_purpose
{
    public class ERPMaintenance_visit_purpose : ERPNextObjectBase
    {
        public ERPMaintenance_visit_purpose() : this(new ERPObject(DocType.Maintenance_visit_purpose)) { }
        public ERPMaintenance_visit_purpose(ERPObject obj) : base(obj) { }

        public static ERPMaintenance_visit_purpose Create(string description, string serviceperson, string workdone)

        {
            ERPMaintenance_visit_purpose obj = new ERPMaintenance_visit_purpose();
            obj.description = description;
            obj.service_person = serviceperson;
            obj.work_done = workdone;
            return obj;
        }

        public string description
        {
            get { return data.description; }
            set
            {
                data.description = value;
                data.name = value;
            }

        }

        public string service_person
        {
            get { return data.service_person; }
            set { data.service_person = value; }
        }

        public string work_done
        {
            get { return data.work_done; }
            set { data.work_done = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string prevdoc_doctype
        {
            get { return data.prevdoc_doctype; }
            set { data.prevdoc_doctype = value; }
        }

        public string prevdoc_docname
        {
            get { return data.prevdoc_docname; }
            set { data.prevdoc_docname = value; }
        }

        public string prevdoc_detail_docname
        {
            get { return data.prevdoc_detail_docname; }
            set { data.prevdoc_detail_docname = value; }
        }


    }

    //Enums go here

}