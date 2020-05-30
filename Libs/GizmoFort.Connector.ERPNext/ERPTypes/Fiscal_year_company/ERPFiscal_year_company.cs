using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fiscal_year_company
{
    public class ERPFiscal_year_company : ERPNextObjectBase
    {
        public ERPFiscal_year_company() : this(new ERPObject(DocType.Fiscal_year_company)) { }
        public ERPFiscal_year_company(ERPObject obj) : base(obj) { }

        public static ERPFiscal_year_company Create(string company)

        {
            ERPFiscal_year_company obj = new ERPFiscal_year_company();
            obj.company = company;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}