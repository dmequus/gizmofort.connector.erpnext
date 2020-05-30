using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Weather
{
    public class WeatherService : SubServiceBase<ERPWeather>
    {
        public WeatherService(ERPNextClient client)
            : base(DocType.Weather, client) { }

        protected override ERPWeather fromERPObject(ERPObject obj)
        {
            return new ERPWeather(obj);
        }
    }
}