using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Installation_note_item
{
    public class ERPInstallation_note_item : ERPNextObjectBase
    {
        public ERPInstallation_note_item() : this(new ERPObject(DocType.Installation_note_item)) { }
        public ERPInstallation_note_item(ERPObject obj) : base(obj) { }

        public static ERPInstallation_note_item Create(string itemcode, string serialno, double qty, string description, string prevdocdetaildocname, string prevdocdocname, string prevdocdoctype)

        {
            ERPInstallation_note_item obj = new ERPInstallation_note_item();
            obj.item_code = itemcode;
            obj.serial_no = serialno;
            obj.qty = qty;
            obj.description = description;
            obj.prevdoc_detail_docname = prevdocdetaildocname;
            obj.prevdoc_docname = prevdocdocname;
            obj.prevdoc_doctype = prevdocdoctype;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string prevdoc_detail_docname
        {
            get { return data.prevdoc_detail_docname; }
            set { data.prevdoc_detail_docname = value; }
        }

        public string prevdoc_docname
        {
            get { return data.prevdoc_docname; }
            set { data.prevdoc_docname = value; }
        }

        public string prevdoc_doctype
        {
            get { return data.prevdoc_doctype; }
            set { data.prevdoc_doctype = value; }
        }


    }

    //Enums go here

}