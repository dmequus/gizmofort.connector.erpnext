using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_template
{
    public class ERPLab_test_template : ERPNextObjectBase
    {
        public ERPLab_test_template() : this(new ERPObject(DocType.Lab_test_template)) { }
        public ERPLab_test_template(ERPObject obj) : base(obj) { }

        public static ERPLab_test_template Create(string labtestname, string labtestcode, string labtestgroup, string department)

        {
            ERPLab_test_template obj = new ERPLab_test_template();
            obj.lab_test_name = labtestname;
            obj.lab_test_code = labtestcode;
            obj.lab_test_group = labtestgroup;
            obj.department = department;
            return obj;
        }

        public string lab_test_name
        {
            get { return data.lab_test_name; }
            set
            {
                data.lab_test_name = value;
                data.name = value;
            }

        }

        public string lab_test_code
        {
            get { return data.lab_test_code; }
            set { data.lab_test_code = value; }
        }

        public string lab_test_group
        {
            get { return data.lab_test_group; }
            set { data.lab_test_group = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        public Labtesttemplatetype lab_test_template_type
        {
            get { return parseEnum<Labtesttemplatetype>(data.lab_test_template_type); }
            set { data.lab_test_template_type = value.ToString(); }
        }

        public long is_billable
        {
            get { return data.is_billable; }
            set { data.is_billable = value; }
        }

        public double lab_test_rate
        {
            get { return data.lab_test_rate; }
            set { data.lab_test_rate = value; }
        }

        public string lab_test_uom
        {
            get { return data.lab_test_uom; }
            set { data.lab_test_uom = value; }
        }

        public string lab_test_normal_range
        {
            get { return data.lab_test_normal_range; }
            set { data.lab_test_normal_range = value; }
        }

        public string normal_test_templates
        {
            get { return data.normal_test_templates; }
            set { data.normal_test_templates = value; }
        }

        public long sensitivity
        {
            get { return data.sensitivity; }
            set { data.sensitivity = value; }
        }

        public string special_test_template
        {
            get { return data.special_test_template; }
            set { data.special_test_template = value; }
        }

        public string lab_test_groups
        {
            get { return data.lab_test_groups; }
            set { data.lab_test_groups = value; }
        }

        public string lab_test_description
        {
            get { return data.lab_test_description; }
            set { data.lab_test_description = value; }
        }

        public string sample
        {
            get { return data.sample; }
            set { data.sample = value; }
        }

        public string sample_uom
        {
            get { return data.sample_uom; }
            set { data.sample_uom = value; }
        }

        public long change_in_item
        {
            get { return data.change_in_item; }
            set { data.change_in_item = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public double sample_qty
        {
            get { return data.sample_qty; }
            set { data.sample_qty = value; }
        }

        public string sample_details
        {
            get { return data.sample_details; }
            set { data.sample_details = value; }
        }


    }

    //Enums go here
    public enum Labtesttemplatetype
    {
        [Description("Single")]
        Single,
        [Description("Compound")]
        Compound,
        [Description("Descriptive")]
        Descriptive,
        [Description("Grouped")]
        Grouped,
        [Description("No Result")]
        NoResult,
    }


}