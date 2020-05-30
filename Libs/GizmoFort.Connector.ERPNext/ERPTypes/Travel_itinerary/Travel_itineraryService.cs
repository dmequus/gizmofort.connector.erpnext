using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Travel_itinerary
{
    public class Travel_itineraryService : SubServiceBase<ERPTravel_itinerary>
    {
        public Travel_itineraryService(ERPNextClient client)
            : base(DocType.Travel_itinerary, client) { }

        protected override ERPTravel_itinerary fromERPObject(ERPObject obj)
        {
            return new ERPTravel_itinerary(obj);
        }
    }
}