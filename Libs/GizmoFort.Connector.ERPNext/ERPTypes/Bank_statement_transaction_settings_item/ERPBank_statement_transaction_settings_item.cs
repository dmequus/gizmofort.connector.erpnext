using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_settings_item
{
    public class ERPBank_statement_transaction_settings_item : ERPNextObjectBase
    {
        public ERPBank_statement_transaction_settings_item() : this(new ERPObject(DocType.Bank_statement_transaction_settings_item)) { }
        public ERPBank_statement_transaction_settings_item(ERPObject obj) : base(obj) { }

        public static ERPBank_statement_transaction_settings_item Create(string mappingtype, string bankdata, Mappeddatatype mappeddatatype, string mappeddata)

        {
            ERPBank_statement_transaction_settings_item obj = new ERPBank_statement_transaction_settings_item();
            obj.mapping_type = mappingtype;
            obj.bank_data = bankdata;
            obj.mapped_data_type = mappeddatatype;
            obj.mapped_data = mappeddata;
            return obj;
        }

        public string mapping_type
        {
            get { return data.mapping_type; }
            set
            {
                data.mapping_type = value;
                data.name = value;
            }

        }

        public string bank_data
        {
            get { return data.bank_data; }
            set { data.bank_data = value; }
        }

        public Mappeddatatype mapped_data_type
        {
            get { return parseEnum<Mappeddatatype>(data.mapped_data_type); }
            set { data.mapped_data_type = value.ToString(); }
        }

        public string mapped_data
        {
            get { return data.mapped_data; }
            set { data.mapped_data = value; }
        }


    }

    //Enums go here
    public enum Mappeddatatype
    {
        [Description("Account")]
        CustomerAccount,
        [Description("Customer")]
        Customer,
        [Description("Supplier")]
        Supplier,
        [Description("Account")]
        SupplierAccount,
    }


}