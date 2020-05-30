using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_program
{
    public class ERPLoyalty_program : ERPNextObjectBase
    {
        public ERPLoyalty_program() : this(new ERPObject(DocType.Loyalty_program)) { }
        public ERPLoyalty_program(ERPObject obj) : base(obj) { }

        public static ERPLoyalty_program Create(string loyaltyprogramname, string fromdate, string collectionrules)

        {
            ERPLoyalty_program obj = new ERPLoyalty_program();
            obj.loyalty_program_name = loyaltyprogramname;
            obj.from_date = fromdate;
            obj.collection_rules = collectionrules;
            return obj;
        }

        public string loyalty_program_name
        {
            get { return data.loyalty_program_name; }
            set
            {
                data.loyalty_program_name = value;
                data.name = value;
            }

        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string collection_rules
        {
            get { return data.collection_rules; }
            set { data.collection_rules = value; }
        }

        public Loyaltyprogramtype loyalty_program_type
        {
            get { return parseEnum<Loyaltyprogramtype>(data.loyalty_program_type); }
            set { data.loyalty_program_type = value.ToString(); }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string customer_territory
        {
            get { return data.customer_territory; }
            set { data.customer_territory = value; }
        }

        public long auto_opt_in
        {
            get { return data.auto_opt_in; }
            set { data.auto_opt_in = value; }
        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        public int expiry_duration
        {
            get { return data.expiry_duration; }
            set { data.expiry_duration = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string loyalty_program_help
        {
            get { return data.loyalty_program_help; }
            set { data.loyalty_program_help = value; }
        }


    }

    //Enums go here
    public enum Loyaltyprogramtype
    {
        [Description("Single Tier Program")]
        SingleTierProgram,
        [Description("Multiple Tier Program")]
        MultipleTierProgram,
    }


}