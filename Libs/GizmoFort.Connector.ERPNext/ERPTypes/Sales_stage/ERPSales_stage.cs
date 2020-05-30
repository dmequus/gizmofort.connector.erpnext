using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_stage
{
    public class ERPSales_stage : ERPNextObjectBase
    {
        public ERPSales_stage() : this(new ERPObject(DocType.Sales_stage)) { }
        public ERPSales_stage(ERPObject obj) : base(obj) { }

        public static ERPSales_stage Create()

        {
            ERPSales_stage obj = new ERPSales_stage();
            return obj;
        }

        public string stage_name
        {
            get { return data.stage_name; }
            set
            {
                data.stage_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}