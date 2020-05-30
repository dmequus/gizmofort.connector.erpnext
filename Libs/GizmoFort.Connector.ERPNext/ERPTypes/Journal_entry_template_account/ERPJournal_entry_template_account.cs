using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_template_account
{
    public class ERPJournal_entry_template_account : ERPNextObjectBase
    {
        public ERPJournal_entry_template_account() : this(new ERPObject(DocType.Journal_entry_template_account)) { }
        public ERPJournal_entry_template_account(ERPObject obj) : base(obj) { }

        public static ERPJournal_entry_template_account Create(string account)

        {
            ERPJournal_entry_template_account obj = new ERPJournal_entry_template_account();
            obj.account = account;
            return obj;
        }

        public string account
        {
            get { return data.account; }
            set
            {
                data.account = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}