using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction_mapping
{
    public class ERPBank_transaction_mapping : ERPNextObjectBase
    {
        public ERPBank_transaction_mapping() : this(new ERPObject(DocType.Bank_transaction_mapping)) { }
        public ERPBank_transaction_mapping(ERPObject obj) : base(obj) { }

        public static ERPBank_transaction_mapping Create(string banktransactionfield, string filefield)

        {
            ERPBank_transaction_mapping obj = new ERPBank_transaction_mapping();
            obj.bank_transaction_field = banktransactionfield;
            obj.file_field = filefield;
            return obj;
        }

        public string bank_transaction_field
        {
            get { return data.bank_transaction_field; }
            set
            {
                data.bank_transaction_field = value;
                data.name = value;
            }

        }

        public string file_field
        {
            get { return data.file_field; }
            set { data.file_field = value; }
        }


    }

    //Enums go here

}