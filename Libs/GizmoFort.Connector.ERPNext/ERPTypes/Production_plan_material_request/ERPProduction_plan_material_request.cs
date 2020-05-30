using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_material_request
{
    public class ERPProduction_plan_material_request : ERPNextObjectBase
    {
        public ERPProduction_plan_material_request() : this(new ERPObject(DocType.Production_plan_material_request)) { }
        public ERPProduction_plan_material_request(ERPObject obj) : base(obj) { }

        public static ERPProduction_plan_material_request Create(string materialrequest, string materialrequestdate)

        {
            ERPProduction_plan_material_request obj = new ERPProduction_plan_material_request();
            obj.material_request = materialrequest;
            obj.material_request_date = materialrequestdate;
            return obj;
        }

        public string material_request
        {
            get { return data.material_request; }
            set
            {
                data.material_request = value;
                data.name = value;
            }

        }

        public string material_request_date
        {
            get { return data.material_request_date; }
            set { data.material_request_date = value; }
        }


    }

    //Enums go here

}