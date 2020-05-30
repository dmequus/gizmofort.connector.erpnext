using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Finance_book
{
    public class ERPFinance_book : ERPNextObjectBase
    {
        public ERPFinance_book() : this(new ERPObject(DocType.Finance_book)) { }
        public ERPFinance_book(ERPObject obj) : base(obj) { }

        public static ERPFinance_book Create(string financebookname)

        {
            ERPFinance_book obj = new ERPFinance_book();
            obj.finance_book_name = financebookname;
            return obj;
        }

        public string finance_book_name
        {
            get { return data.finance_book_name; }
            set
            {
                data.finance_book_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}