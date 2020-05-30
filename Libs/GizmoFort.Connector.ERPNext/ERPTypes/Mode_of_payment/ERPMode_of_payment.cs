using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Mode_of_payment
{
    public class ERPMode_of_payment : ERPNextObjectBase
    {
        public ERPMode_of_payment() : this(new ERPObject(DocType.Mode_of_payment)) { }
        public ERPMode_of_payment(ERPObject obj) : base(obj) { }

        public static ERPMode_of_payment Create(string modeofpayment)

        {
            ERPMode_of_payment obj = new ERPMode_of_payment();
            obj.mode_of_payment = modeofpayment;
            return obj;
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set
            {
                data.mode_of_payment = value;
                data.name = value;
            }

        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }


    }

    //Enums go here
    public enum Type
    {
        [Description("Cash")]
        Cash,
        [Description("Bank")]
        Bank,
        [Description("General")]
        General,
    }


}