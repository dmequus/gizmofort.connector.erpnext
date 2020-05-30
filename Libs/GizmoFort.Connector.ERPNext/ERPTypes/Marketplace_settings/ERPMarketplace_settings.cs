using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Marketplace_settings
{
    public class ERPMarketplace_settings : ERPNextObjectBase
    {
        public ERPMarketplace_settings() : this(new ERPObject(DocType.Marketplace_settings)) { }
        public ERPMarketplace_settings(ERPObject obj) : base(obj) { }

        public static ERPMarketplace_settings Create(long disablemarketplace, string marketplaceurl, long registered, long syncinprogress, string company, string hubsellername, string users, string lastsyncdatetime, string customdata)

        {
            ERPMarketplace_settings obj = new ERPMarketplace_settings();
            obj.disable_marketplace = disablemarketplace;
            obj.marketplace_url = marketplaceurl;
            obj.registered = registered;
            obj.sync_in_progress = syncinprogress;
            obj.company = company;
            obj.hub_seller_name = hubsellername;
            obj.users = users;
            obj.last_sync_datetime = lastsyncdatetime;
            obj.custom_data = customdata;
            return obj;
        }

        public long disable_marketplace
        {
            get { return data.disable_marketplace; }
            set { data.disable_marketplace = value; }
        }

        public string marketplace_url
        {
            get { return data.marketplace_url; }
            set { data.marketplace_url = value; }
        }

        public long registered
        {
            get { return data.registered; }
            set { data.registered = value; }
        }

        public long sync_in_progress
        {
            get { return data.sync_in_progress; }
            set { data.sync_in_progress = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string hub_seller_name
        {
            get { return data.hub_seller_name; }
            set { data.hub_seller_name = value; }
        }

        public string users
        {
            get { return data.users; }
            set { data.users = value; }
        }

        public string last_sync_datetime
        {
            get { return data.last_sync_datetime; }
            set { data.last_sync_datetime = value; }
        }

        public string custom_data
        {
            get { return data.custom_data; }
            set { data.custom_data = value; }
        }


    }

    //Enums go here

}