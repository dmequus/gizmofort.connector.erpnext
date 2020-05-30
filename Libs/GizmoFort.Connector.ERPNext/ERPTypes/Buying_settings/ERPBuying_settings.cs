using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying_settings
{
    public class ERPBuying_settings : ERPNextObjectBase
    {
        public ERPBuying_settings() : this(new ERPObject(DocType.Buying_settings)) { }
        public ERPBuying_settings(ERPObject obj) : base(obj) { }

        public static ERPBuying_settings Create()

        {
            ERPBuying_settings obj = new ERPBuying_settings();
            return obj;
        }

        public Suppmastername supp_master_name
        {
            get { return parseEnum<Suppmastername>(data.supp_master_name); }
            set { data.supp_master_name = value.ToString(); }
        }

        public string supplier_group
        {
            get { return data.supplier_group; }
            set { data.supplier_group = value; }
        }

        public string buying_price_list
        {
            get { return data.buying_price_list; }
            set { data.buying_price_list = value; }
        }

        public Porequired po_required
        {
            get { return parseEnum<Porequired>(data.po_required); }
            set { data.po_required = value.ToString(); }
        }

        public Prrequired pr_required
        {
            get { return parseEnum<Prrequired>(data.pr_required); }
            set { data.pr_required = value.ToString(); }
        }

        public long maintain_same_rate
        {
            get { return data.maintain_same_rate; }
            set { data.maintain_same_rate = value; }
        }

        public long allow_multiple_items
        {
            get { return data.allow_multiple_items; }
            set { data.allow_multiple_items = value; }
        }

        public Backflushrawmaterialsofsubcontractbasedon backflush_raw_materials_of_subcontract_based_on
        {
            get { return parseEnum<Backflushrawmaterialsofsubcontractbasedon>(data.backflush_raw_materials_of_subcontract_based_on); }
            set { data.backflush_raw_materials_of_subcontract_based_on = value.ToString(); }
        }

        public double over_transfer_allowance
        {
            get { return data.over_transfer_allowance; }
            set { data.over_transfer_allowance = value; }
        }


    }

    //Enums go here
    public enum Suppmastername
    {
        [Description("Supplier Name")]
        SupplierName,
        [Description("Naming Series")]
        NamingSeries,
    }

    public enum Porequired
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Prrequired
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Backflushrawmaterialsofsubcontractbasedon
    {
        [Description("BOM")]
        BOM,
        [Description("Material Transferred for Subcontract")]
        MaterialTransferredforSubcontract,
    }


}