using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Party_account
{
    public class ERPParty_account : ERPNextObjectBase
    {
        public ERPParty_account() : this(new ERPObject(DocType.Party_account)) { }
        public ERPParty_account(ERPObject obj) : base(obj) { }

        public static ERPParty_account Create(string company, string account)

        {
            ERPParty_account obj = new ERPParty_account();
            obj.company = company;
            obj.account = account;
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

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }


    }

    //Enums go here

}