using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pick_list
{
    public class ERPPick_list : ERPNextObjectBase
    {
        public ERPPick_list() : this(new ERPObject(DocType.Pick_list)) { }
        public ERPPick_list(ERPObject obj) : base(obj) { }

        public static ERPPick_list Create(string company, string namingseries)

        {
            ERPPick_list obj = new ERPPick_list();
            obj.company = company;
            obj.naming_series = namingseries;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string parent_warehouse
        {
            get { return data.parent_warehouse; }
            set { data.parent_warehouse = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string work_order
        {
            get { return data.work_order; }
            set { data.work_order = value; }
        }

        public string locations
        {
            get { return data.locations; }
            set { data.locations = value; }
        }

        private double _for_qty = 0.0;
        public double for_qty
        {
            get { return data._for_qty; }
            set { data._for_qty = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public Purpose purpose
        {
            get { return parseEnum<Purpose>(data.purpose); }
            set { data.purpose = value.ToString(); }
        }

        public string material_request
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }


    }

    //Enums go here
    public enum Purpose
    {
        [Description("Material Transfer for Manufacture")]
        MaterialTransferforManufacture,
        [Description("Material Transfer")]
        MaterialTransfer,
        [Description("Delivery")]
        Delivery,
    }


}