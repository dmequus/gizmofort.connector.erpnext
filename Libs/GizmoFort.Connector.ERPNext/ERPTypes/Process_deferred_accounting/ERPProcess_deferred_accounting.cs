using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Process_deferred_accounting
{
    public class ERPProcess_deferred_accounting : ERPNextObjectBase
    {
        public ERPProcess_deferred_accounting() : this(new ERPObject(DocType.Process_deferred_accounting)) { }
        public ERPProcess_deferred_accounting(ERPObject obj) : base(obj) { }

        public static ERPProcess_deferred_accounting Create(Type type, string startdate, string enddate, string postingdate, string company)

        {
            ERPProcess_deferred_accounting obj = new ERPProcess_deferred_accounting();
            obj.type = type;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.posting_date = postingdate;
            obj.company = company;
            return obj;
        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string account
        {
            get { return data.account; }
            set { data.account = value; }
        }


    }

    //Enums go here
    public enum Type
    {
        [Description("Income")]
        Income,
        [Description("Expense")]
        Expense,
    }


}