using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_accounts
{
    public class ERPCash_flow_mapping_accounts : ERPNextObjectBase
    {
        public ERPCash_flow_mapping_accounts() : this(new ERPObject(DocType.Cash_flow_mapping_accounts)) { }
        public ERPCash_flow_mapping_accounts(ERPObject obj) : base(obj) { }

        public static ERPCash_flow_mapping_accounts Create(string account)

        {
            ERPCash_flow_mapping_accounts obj = new ERPCash_flow_mapping_accounts();
            obj.account = account;
            return obj;
        }

        public string account
        {
            get { return data.account; }
            set
            {
                data.account = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}