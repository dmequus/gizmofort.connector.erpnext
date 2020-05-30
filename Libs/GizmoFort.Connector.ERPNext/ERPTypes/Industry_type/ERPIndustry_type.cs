using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Industry_type
{
    public class ERPIndustry_type : ERPNextObjectBase
    {
        public ERPIndustry_type() : this(new ERPObject(DocType.Industry_type)) { }
        public ERPIndustry_type(ERPObject obj) : base(obj) { }

        public static ERPIndustry_type Create(string industry)

        {
            ERPIndustry_type obj = new ERPIndustry_type();
            obj.industry = industry;
            return obj;
        }

        public string industry
        {
            get { return data.industry; }
            set
            {
                data.industry = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}