using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_template_details
{
    public class ERPCash_flow_mapping_template_details : ERPNextObjectBase
    {
        public ERPCash_flow_mapping_template_details() : this(new ERPObject(DocType.Cash_flow_mapping_template_details)) { }
        public ERPCash_flow_mapping_template_details(ERPObject obj) : base(obj) { }

        public static ERPCash_flow_mapping_template_details Create(string mapping)

        {
            ERPCash_flow_mapping_template_details obj = new ERPCash_flow_mapping_template_details();
            obj.mapping = mapping;
            return obj;
        }

        public string mapping
        {
            get { return data.mapping; }
            set
            {
                data.mapping = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}