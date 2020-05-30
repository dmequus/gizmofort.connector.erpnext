using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Market_segment
{
    public class ERPMarket_segment : ERPNextObjectBase
    {
        public ERPMarket_segment() : this(new ERPObject(DocType.Market_segment)) { }
        public ERPMarket_segment(ERPObject obj) : base(obj) { }

        public static ERPMarket_segment Create(string marketsegment)

        {
            ERPMarket_segment obj = new ERPMarket_segment();
            obj.market_segment = marketsegment;
            return obj;
        }

        public string market_segment
        {
            get { return data.market_segment; }
            set
            {
                data.market_segment = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}