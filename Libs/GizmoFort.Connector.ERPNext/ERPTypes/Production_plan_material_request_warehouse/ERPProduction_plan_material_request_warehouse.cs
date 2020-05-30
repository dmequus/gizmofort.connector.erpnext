using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_material_request_warehouse
{
    public class ERPProduction_plan_material_request_warehouse : ERPNextObjectBase
    {
        public ERPProduction_plan_material_request_warehouse() : this(new ERPObject(DocType.Production_plan_material_request_warehouse)) { }
        public ERPProduction_plan_material_request_warehouse(ERPObject obj) : base(obj) { }

        public static ERPProduction_plan_material_request_warehouse Create()

        {
            ERPProduction_plan_material_request_warehouse obj = new ERPProduction_plan_material_request_warehouse();
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


    }

    //Enums go here

}