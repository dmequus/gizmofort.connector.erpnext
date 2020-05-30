using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_category_account
{
    public class ERPAsset_category_account : ERPNextObjectBase
    {
        public ERPAsset_category_account() : this(new ERPObject(DocType.Asset_category_account)) { }
        public ERPAsset_category_account(ERPObject obj) : base(obj) { }

        public static ERPAsset_category_account Create(string companyname, string fixedassetaccount, string accumulateddepreciationaccount, string depreciationexpenseaccount, string capitalworkinprogressaccount)

        {
            ERPAsset_category_account obj = new ERPAsset_category_account();
            obj.company_name = companyname;
            obj.fixed_asset_account = fixedassetaccount;
            obj.accumulated_depreciation_account = accumulateddepreciationaccount;
            obj.depreciation_expense_account = depreciationexpenseaccount;
            obj.capital_work_in_progress_account = capitalworkinprogressaccount;
            return obj;
        }

        public string company_name
        {
            get { return data.company_name; }
            set
            {
                data.company_name = value;
                data.name = value;
            }

        }

        public string fixed_asset_account
        {
            get { return data.fixed_asset_account; }
            set { data.fixed_asset_account = value; }
        }

        public string accumulated_depreciation_account
        {
            get { return data.accumulated_depreciation_account; }
            set { data.accumulated_depreciation_account = value; }
        }

        public string depreciation_expense_account
        {
            get { return data.depreciation_expense_account; }
            set { data.depreciation_expense_account = value; }
        }

        public string capital_work_in_progress_account
        {
            get { return data.capital_work_in_progress_account; }
            set { data.capital_work_in_progress_account = value; }
        }


    }

    //Enums go here

}