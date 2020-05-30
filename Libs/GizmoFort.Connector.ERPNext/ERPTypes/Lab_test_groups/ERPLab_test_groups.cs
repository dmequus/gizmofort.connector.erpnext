using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_groups
{
    public class ERPLab_test_groups : ERPNextObjectBase
    {
        public ERPLab_test_groups() : this(new ERPObject(DocType.Lab_test_groups)) { }
        public ERPLab_test_groups(ERPObject obj) : base(obj) { }

        public static ERPLab_test_groups Create(Templateornewline templateornewline, string labtesttemplate, double labtestrate, string labtestdescription, string groupevent, string grouptestuom, string grouptestnormalrange)

        {
            ERPLab_test_groups obj = new ERPLab_test_groups();
            obj.template_or_new_line = templateornewline;
            obj.lab_test_template = labtesttemplate;
            obj.lab_test_rate = labtestrate;
            obj.lab_test_description = labtestdescription;
            obj.group_event = groupevent;
            obj.group_test_uom = grouptestuom;
            obj.group_test_normal_range = grouptestnormalrange;
            return obj;
        }

        public Templateornewline template_or_new_line
        {
            get { return parseEnum<Templateornewline>(data.template_or_new_line); }
            set { data.template_or_new_line = value.ToString(); }
        }

        public string lab_test_template
        {
            get { return data.lab_test_template; }
            set { data.lab_test_template = value; }
        }

        private double _lab_test_rate = 0.0;
        public double lab_test_rate
        {
            get { return data._lab_test_rate; }
            set { data._lab_test_rate = value; }
        }

        public string lab_test_description
        {
            get { return data.lab_test_description; }
            set { data.lab_test_description = value; }
        }

        public string group_event
        {
            get { return data.group_event; }
            set { data.group_event = value; }
        }

        public string group_test_uom
        {
            get { return data.group_test_uom; }
            set { data.group_test_uom = value; }
        }

        public string group_test_normal_range
        {
            get { return data.group_test_normal_range; }
            set { data.group_test_normal_range = value; }
        }


    }

    //Enums go here
    public enum Templateornewline
    {
        [Description("Add Test")]
        AddTest,
        [Description("Add new line")]
        Addnewline,
    }


}