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

        private double _reserved_qty = 0.0;
        public double reserved_qty
        {
            get { return data._reserved_qty; }
            set { data._reserved_qty = value; }
        }

        private double _actual_qty = 0.0;
        public double actual_qty
        {
            get { return data._actual_qty; }
            set { data._actual_qty = value; }
        }

        private double _ordered_qty = 0.0;
        public double ordered_qty
        {
            get { return data._ordered_qty; }
            set { data._ordered_qty = value; }
        }

        private double _indented_qty = 0.0;
        public double indented_qty
        {
            get { return data._indented_qty; }
            set { data._indented_qty = value; }
        }

        private double _planned_qty = 0.0;
        public double planned_qty
        {
            get { return data._planned_qty; }
            set { data._planned_qty = value; }
        }

        private double _projected_qty = 0.0;
        public double projected_qty
        {
            get { return data._projected_qty; }
            set { data._projected_qty = value; }
        }

        private double _reserved_qty_for_production = 0.0;
        public double reserved_qty_for_production
        {
            get { return data._reserved_qty_for_production; }
            set { data._reserved_qty_for_production = value; }
        }

        private double _reserved_qty_for_sub_contract = 0.0;
        public double reserved_qty_for_sub_contract
        {
            get { return data._reserved_qty_for_sub_contract; }
            set { data._reserved_qty_for_sub_contract = value; }
        }

        private double _ma_rate = 0.0;
        public double ma_rate
        {
            get { return data._ma_rate; }
            set { data._ma_rate = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        private double _fcfs_rate = 0.0;
        public double fcfs_rate
        {
            get { return data._fcfs_rate; }
            set { data._fcfs_rate = value; }
        }

        private double _valuation_rate = 0.0;
        public double valuation_rate
        {
            get { return data._valuation_rate; }
            set { data._valuation_rate = value; }
        }

        private double _stock_value = 0.0;
        public double stock_value
        {
            get { return data._stock_value; }
            set { data._stock_value = value; }
        }


    }

    //Enums go here

}