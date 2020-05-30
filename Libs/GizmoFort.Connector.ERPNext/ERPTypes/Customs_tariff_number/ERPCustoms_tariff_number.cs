using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Customs_tariff_number
{
    public class ERPCustoms_tariff_number : ERPNextObjectBase
    {
        public ERPCustoms_tariff_number() : this(new ERPObject(DocType.Customs_tariff_number)) { }
        public ERPCustoms_tariff_number(ERPObject obj) : base(obj) { }

        public static ERPCustoms_tariff_number Create(string tariffnumber, string description)

        {
            ERPCustoms_tariff_number obj = new ERPCustoms_tariff_number();
            obj.tariff_number = tariffnumber;
            obj.description = description;
            return obj;
        }

        public string tariff_number
        {
            get { return data.tariff_number; }
            set
            {
                data.tariff_number = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}