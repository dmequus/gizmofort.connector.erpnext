using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Amazon_mws_settings
{
    public class ERPAmazon_mws_settings : ERPNextObjectBase
    {
        public ERPAmazon_mws_settings() : this(new ERPObject(DocType.Amazon_mws_settings)) { }
        public ERPAmazon_mws_settings(ERPObject obj) : base(obj) { }

        public static ERPAmazon_mws_settings Create(string sellerid, string awsaccesskeyid, string mwsauthtoken, string secretkey, string marketplaceid, Region region, string domain, string company, string warehouse, string itemgroup, string pricelist, string customergroup, string territory, Customertype customertype, string marketplaceaccountgroup, string afterdate)

        {
            ERPAmazon_mws_settings obj = new ERPAmazon_mws_settings();
            obj.seller_id = sellerid;
            obj.aws_access_key_id = awsaccesskeyid;
            obj.mws_auth_token = mwsauthtoken;
            obj.secret_key = secretkey;
            obj.market_place_id = marketplaceid;
            obj.region = region;
            obj.domain = domain;
            obj.company = company;
            obj.warehouse = warehouse;
            obj.item_group = itemgroup;
            obj.price_list = pricelist;
            obj.customer_group = customergroup;
            obj.territory = territory;
            obj.customer_type = customertype;
            obj.market_place_account_group = marketplaceaccountgroup;
            obj.after_date = afterdate;
            return obj;
        }

        public string seller_id
        {
            get { return data.seller_id; }
            set
            {
                data.seller_id = value;
                data.name = value;
            }

        }

        public string aws_access_key_id
        {
            get { return data.aws_access_key_id; }
            set { data.aws_access_key_id = value; }
        }

        public string mws_auth_token
        {
            get { return data.mws_auth_token; }
            set { data.mws_auth_token = value; }
        }

        public string secret_key
        {
            get { return data.secret_key; }
            set { data.secret_key = value; }
        }

        public string market_place_id
        {
            get { return data.market_place_id; }
            set { data.market_place_id = value; }
        }

        public Region region
        {
            get { return parseEnum<Region>(data.region); }
            set { data.region = value.ToString(); }
        }

        public string domain
        {
            get { return data.domain; }
            set { data.domain = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string price_list
        {
            get { return data.price_list; }
            set { data.price_list = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public Customertype customer_type
        {
            get { return parseEnum<Customertype>(data.customer_type); }
            set { data.customer_type = value.ToString(); }
        }

        public string market_place_account_group
        {
            get { return data.market_place_account_group; }
            set { data.market_place_account_group = value; }
        }

        public string after_date
        {
            get { return data.after_date; }
            set { data.after_date = value; }
        }

        public long enable_amazon
        {
            get { return data.enable_amazon; }
            set { data.enable_amazon = value; }
        }

        public long taxes_charges
        {
            get { return data.taxes_charges; }
            set { data.taxes_charges = value; }
        }

        public int max_retry_limit
        {
            get { return data.max_retry_limit; }
            set { data.max_retry_limit = value; }
        }

        public long enable_sync
        {
            get { return data.enable_sync; }
            set { data.enable_sync = value; }
        }


    }

    //Enums go here
    public enum Region
    {
        [Description("AE")]
        AE,
        [Description("AU")]
        AU,
        [Description("BR")]
        BR,
        [Description("CA")]
        CA,
        [Description("CN")]
        CN,
        [Description("DE")]
        DE,
        [Description("ES")]
        ES,
        [Description("FR")]
        FR,
        [Description("IN")]
        IN,
        [Description("JP")]
        JP,
        [Description("IT")]
        IT,
        [Description("MX")]
        MX,
        [Description("UK")]
        UK,
        [Description("US")]
        US,
    }

    public enum Customertype
    {
        [Description("Individual")]
        Individual,
        [Description("Company")]
        Company,
    }


}