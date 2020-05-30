using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_person
{
    public class Sales_personService : SubServiceBase<ERPSales_person>
    {
        public Sales_personService(ERPNextClient client)
            : base(DocType.Sales_person, client) { }

        protected override ERPSales_person fromERPObject(ERPObject obj)
        {
            return new ERPSales_person(obj);
        }
    }
}