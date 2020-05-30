using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list
{
    public class ERPLeave_block_list : ERPNextObjectBase
    {
        public ERPLeave_block_list() : this(new ERPObject(DocType.Leave_block_list)) { }
        public ERPLeave_block_list(ERPObject obj) : base(obj) { }

        public static ERPLeave_block_list Create(string leaveblocklistname, string company, long appliestoalldepartments, string leaveblocklistdates, string leaveblocklistallowed)

        {
            ERPLeave_block_list obj = new ERPLeave_block_list();
            obj.leave_block_list_name = leaveblocklistname;
            obj.company = company;
            obj.applies_to_all_departments = appliestoalldepartments;
            obj.leave_block_list_dates = leaveblocklistdates;
            obj.leave_block_list_allowed = leaveblocklistallowed;
            return obj;
        }

        public string leave_block_list_name
        {
            get { return data.leave_block_list_name; }
            set
            {
                data.leave_block_list_name = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public long applies_to_all_departments
        {
            get { return data.applies_to_all_departments; }
            set { data.applies_to_all_departments = value; }
        }

        public string leave_block_list_dates
        {
            get { return data.leave_block_list_dates; }
            set { data.leave_block_list_dates = value; }
        }

        public string leave_block_list_allowed
        {
            get { return data.leave_block_list_allowed; }
            set { data.leave_block_list_allowed = value; }
        }


    }

    //Enums go here

}