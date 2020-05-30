using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Price_list_country
{
    public class ERPPrice_list_country : ERPNextObjectBase
    {
        public ERPPrice_list_country() : this(new ERPObject(DocType.Price_list_country)) { }
        public ERPPrice_list_country(ERPObject obj) : base(obj) { }

        public static ERPPrice_list_country Create(string country)

        {
            ERPPrice_list_country obj = new ERPPrice_list_country();
            obj.country = country;
            return obj;
        }

        public string country
        {
            get { return data.country; }
            set
            {
                data.country = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}