using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bin
{
    public class ERPBin : ERPNextObjectBase
    {
        public ERPBin() : this(new ERPObject(DocType.Bin)) { }
        public ERPBin(ERPObject obj) : base(obj) { }

        public static ERPBin Create()

        {
            ERPBin obj = new ERPBin();
            return obj;
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set
            {
                data.warehouse = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public double reserved_qty
        {
            get { return data.reserved_qty; }
            set { data.reserved_qty = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        public double ordered_qty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        public double indented_qty
        {
            get { return data.indented_qty; }
            set { data.indented_qty = value; }
        }

        public double planned_qty
        {
            get { return data.planned_qty; }
            set { data.planned_qty = value; }
        }

        public double projected_qty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        public double reserved_qty_for_production
        {
            get { return data.reserved_qty_for_production; }
            set { data.reserved_qty_for_production = value; }
        }

        public double reserved_qty_for_sub_contract
        {
            get { return data.reserved_qty_for_sub_contract; }
            set { data.reserved_qty_for_sub_contract = value; }
        }

        public double ma_rate
        {
            get { return data.ma_rate; }
            set { data.ma_rate = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public double fcfs_rate
        {
            get { return data.fcfs_rate; }
            set { data.fcfs_rate = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public double stock_value
        {
            get { return data.stock_value; }
            set { data.stock_value = value; }
        }


    }

    //Enums go here

}