using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Allowed_to_transact_with
{
    public class ERPAllowed_to_transact_with : ERPNextObjectBase
    {
        public ERPAllowed_to_transact_with() : this(new ERPObject(DocType.Allowed_to_transact_with)) { }
        public ERPAllowed_to_transact_with(ERPObject obj) : base(obj) { }

        public static ERPAllowed_to_transact_with Create(string company)

        {
            ERPAllowed_to_transact_with obj = new ERPAllowed_to_transact_with();
            obj.company = company;
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


    }

    //Enums go here

}