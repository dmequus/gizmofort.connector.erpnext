using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Inpatient_occupancy
{
    public class ERPInpatient_occupancy : ERPNextObjectBase
    {
        public ERPInpatient_occupancy() : this(new ERPObject(DocType.Inpatient_occupancy)) { }
        public ERPInpatient_occupancy(ERPObject obj) : base(obj) { }

        public static ERPInpatient_occupancy Create(string serviceunit, string checkin, int left, string checkout, int invoiced)

        {
            ERPInpatient_occupancy obj = new ERPInpatient_occupancy();
            obj.service_unit = serviceunit;
            obj.check_in = checkin;
            obj.left = left;
            obj.check_out = checkout;
            obj.invoiced = invoiced;
            return obj;
        }

        public string service_unit
        {
            get { return data.service_unit; }
            set
            {
                data.service_unit = value;
                data.name = value;
            }

        }

        public string check_in
        {
            get { return data.check_in; }
            set { data.check_in = value; }
        }

        private int _left = 0;
        public int left
        {
            get { return data._left; }
            set { data._left = value; }
        }

        public string check_out
        {
            get { return data.check_out; }
            set { data.check_out = value; }
        }

        private int _invoiced = 0;
        public int invoiced
        {
            get { return data._invoiced; }
            set { data._invoiced = value; }
        }


    }

    //Enums go here

}