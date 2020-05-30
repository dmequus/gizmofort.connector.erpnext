using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_update_tool
{
    public class ERPBom_update_tool : ERPNextObjectBase
    {
        public ERPBom_update_tool() : this(new ERPObject(DocType.Bom_update_tool)) { }
        public ERPBom_update_tool(ERPObject obj) : base(obj) { }

        public static ERPBom_update_tool Create(string currentbom, string newbom)

        {
            ERPBom_update_tool obj = new ERPBom_update_tool();
            obj.current_bom = currentbom;
            obj.new_bom = newbom;
            return obj;
        }

        public string current_bom
        {
            get { return data.current_bom; }
            set
            {
                data.current_bom = value;
                data.name = value;
            }

        }

        public string new_bom
        {
            get { return data.new_bom; }
            set { data.new_bom = value; }
        }


    }

    //Enums go here

}