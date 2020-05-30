using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Party_type
{
    public class ERPParty_type : ERPNextObjectBase
    {
        public ERPParty_type() : this(new ERPObject(DocType.Party_type)) { }
        public ERPParty_type(ERPObject obj) : base(obj) { }

        public static ERPParty_type Create(string partytype, Accounttype accounttype)

        {
            ERPParty_type obj = new ERPParty_type();
            obj.party_type = partytype;
            obj.account_type = accounttype;
            return obj;
        }

        public string party_type
        {
            get { return data.party_type; }
            set
            {
                data.party_type = value;
                data.name = value;
            }

        }

        public Accounttype account_type
        {
            get { return parseEnum<Accounttype>(data.account_type); }
            set { data.account_type = value.ToString(); }
        }


    }

    //Enums go here
    public enum Accounttype
    {
        [Description("Payable")]
        Payable,
        [Description("Receivable")]
        Receivable,
    }


}