using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_default
{
    public class ERPItem_default : ERPNextObjectBase
    {
        public ERPItem_default() : this(new ERPObject(DocType.Item_default)) { }
        public ERPItem_default(ERPObject obj) : base(obj) { }

        public static ERPItem_default Create(string company, string defaultwarehouse, string defaultpricelist, string buyingcostcenter, string defaultsupplier, string expenseaccount, string sellingcostcenter, string incomeaccount)

        {
            ERPItem_default obj = new ERPItem_default();
            obj.company = company;
            obj.default_warehouse = defaultwarehouse;
            obj.default_price_list = defaultpricelist;
            obj.buying_cost_center = buyingcostcenter;
            obj.default_supplier = defaultsupplier;
            obj.expense_account = expenseaccount;
            obj.selling_cost_center = sellingcostcenter;
            obj.income_account = incomeaccount;
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

        public string default_warehouse
        {
            get { return data.default_warehouse; }
            set { data.default_warehouse = value; }
        }

        public string default_price_list
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        public string buying_cost_center
        {
            get { return data.buying_cost_center; }
            set { data.buying_cost_center = value; }
        }

        public string default_supplier
        {
            get { return data.default_supplier; }
            set { data.default_supplier = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        public string selling_cost_center
        {
            get { return data.selling_cost_center; }
            set { data.selling_cost_center = value; }
        }

        public string income_account
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }


    }

    //Enums go here

}