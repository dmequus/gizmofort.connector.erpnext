using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Packing_slip
{
    public class ERPPacking_slip : ERPNextObjectBase
    {
        public ERPPacking_slip() : this(new ERPObject(DocType.Packing_slip)) { }
        public ERPPacking_slip(ERPObject obj) : base(obj) { }

        public static ERPPacking_slip Create(string deliverynote, string namingseries, int fromcaseno, string items)

        {
            ERPPacking_slip obj = new ERPPacking_slip();
            obj.delivery_note = deliverynote;
            obj.naming_series = namingseries;
            obj.from_case_no = fromcaseno;
            obj.items = items;
            return obj;
        }

        public string delivery_note
        {
            get { return data.delivery_note; }
            set
            {
                data.delivery_note = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public int from_case_no
        {
            get { return data.from_case_no; }
            set { data.from_case_no = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public int to_case_no
        {
            get { return data.to_case_no; }
            set { data.to_case_no = value; }
        }

        public double net_weight_pkg
        {
            get { return data.net_weight_pkg; }
            set { data.net_weight_pkg = value; }
        }

        public string net_weight_uom
        {
            get { return data.net_weight_uom; }
            set { data.net_weight_uom = value; }
        }

        public double gross_weight_pkg
        {
            get { return data.gross_weight_pkg; }
            set { data.gross_weight_pkg = value; }
        }

        public string gross_weight_uom
        {
            get { return data.gross_weight_uom; }
            set { data.gross_weight_uom = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}