using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry_type
{
    public class ERPStock_entry_type : ERPNextObjectBase
    {
        public ERPStock_entry_type() : this(new ERPObject(DocType.Stock_entry_type)) { }
        public ERPStock_entry_type(ERPObject obj) : base(obj) { }

        public static ERPStock_entry_type Create(Purpose purpose)

        {
            ERPStock_entry_type obj = new ERPStock_entry_type();
            obj.purpose = purpose;
            return obj;
        }

        public Purpose purpose
        {
            get { return parseEnum<Purpose>(data.purpose); }
            set { data.purpose = value.ToString(); }
        }


    }

    //Enums go here
    public enum Purpose
    {
        [Description("Material Issue")]
        MaterialIssue,
        [Description("Material Receipt")]
        MaterialReceipt,
        [Description("Material Transfer")]
        MaterialTransfer,
        [Description("Material Transfer for Manufacture")]
        MaterialTransferforManufacture,
        [Description("Material Consumption for Manufacture")]
        MaterialConsumptionforManufacture,
        [Description("Manufacture")]
        Manufacture,
        [Description("Repack")]
        Repack,
        [Description("Send to Subcontractor")]
        SendtoSubcontractor,
        [Description("Send to Warehouse")]
        SendtoWarehouse,
        [Description("Receive at Warehouse")]
        ReceiveatWarehouse,
    }


}