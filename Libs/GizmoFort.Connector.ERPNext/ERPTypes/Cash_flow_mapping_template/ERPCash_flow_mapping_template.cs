using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_template
{
    public class ERPCash_flow_mapping_template : ERPNextObjectBase
    {
        public ERPCash_flow_mapping_template() : this(new ERPObject(DocType.Cash_flow_mapping_template)) { }
        public ERPCash_flow_mapping_template(ERPObject obj) : base(obj) { }

        public static ERPCash_flow_mapping_template Create(string templatename, string mapping)

        {
            ERPCash_flow_mapping_template obj = new ERPCash_flow_mapping_template();
            obj.template_name = templatename;
            obj.mapping = mapping;
            return obj;
        }

        public string template_name
        {
            get { return data.template_name; }
            set
            {
                data.template_name = value;
                data.name = value;
            }

        }

        public string mapping
        {
            get { return data.mapping; }
            set { data.mapping = value; }
        }


    }

    //Enums go here

}