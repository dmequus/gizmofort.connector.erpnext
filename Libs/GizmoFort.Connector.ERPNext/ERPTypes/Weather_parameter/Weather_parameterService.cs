using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Weather_parameter
{
    public class Weather_parameterService : SubServiceBase<ERPWeather_parameter>
    {
        public Weather_parameterService(ERPNextClient client)
            : base(DocType.Weather_parameter, client) { }

        protected override ERPWeather_parameter fromERPObject(ERPObject obj)
        {
            return new ERPWeather_parameter(obj);
        }
    }
}