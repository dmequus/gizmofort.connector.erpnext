using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_value_adjustment
{
    public class ERPAsset_value_adjustment : ERPNextObjectBase
    {
        public ERPAsset_value_adjustment() : this(new ERPObject(DocType.Asset_value_adjustment)) { }
        public ERPAsset_value_adjustment(ERPObject obj) : base(obj) { }

        public static ERPAsset_value_adjustment Create(string asset, string date, double currentassetvalue, double newassetvalue)

        {
            ERPAsset_value_adjustment obj = new ERPAsset_value_adjustment();
            obj.asset = asset;
            obj.date = date;
            obj.current_asset_value = currentassetvalue;
            obj.new_asset_value = newassetvalue;
            return obj;
        }

        public string asset
        {
            get { return data.asset; }
            set
            {
                data.asset = value;
                data.name = value;
            }

        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public double current_asset_value
        {
            get { return data.current_asset_value; }
            set { data.current_asset_value = value; }
        }

        public double new_asset_value
        {
            get { return data.new_asset_value; }
            set { data.new_asset_value = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string asset_category
        {
            get { return data.asset_category; }
            set { data.asset_category = value; }
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        public string journal_entry
        {
            get { return data.journal_entry; }
            set { data.journal_entry = value; }
        }

        public double difference_amount
        {
            get { return data.difference_amount; }
            set { data.difference_amount = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}