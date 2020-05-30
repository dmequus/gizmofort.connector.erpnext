using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Depreciation_schedule
{
    public class ERPDepreciation_schedule : ERPNextObjectBase
    {
        public ERPDepreciation_schedule() : this(new ERPObject(DocType.Depreciation_schedule)) { }
        public ERPDepreciation_schedule(ERPObject obj) : base(obj) { }

        public static ERPDepreciation_schedule Create(string financebook, string scheduledate, double depreciationamount, double accumulateddepreciationamount, string journalentry, string financebookid, Depreciationmethod depreciationmethod)

        {
            ERPDepreciation_schedule obj = new ERPDepreciation_schedule();
            obj.finance_book = financebook;
            obj.schedule_date = scheduledate;
            obj.depreciation_amount = depreciationamount;
            obj.accumulated_depreciation_amount = accumulateddepreciationamount;
            obj.journal_entry = journalentry;
            obj.finance_book_id = financebookid;
            obj.depreciation_method = depreciationmethod;
            return obj;
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set
            {
                data.finance_book = value;
                data.name = value;
            }

        }

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        public double depreciation_amount
        {
            get { return data.depreciation_amount; }
            set { data.depreciation_amount = value; }
        }

        public double accumulated_depreciation_amount
        {
            get { return data.accumulated_depreciation_amount; }
            set { data.accumulated_depreciation_amount = value; }
        }

        public string journal_entry
        {
            get { return data.journal_entry; }
            set { data.journal_entry = value; }
        }

        public string finance_book_id
        {
            get { return data.finance_book_id; }
            set { data.finance_book_id = value; }
        }

        public Depreciationmethod depreciation_method
        {
            get { return parseEnum<Depreciationmethod>(data.depreciation_method); }
            set { data.depreciation_method = value.ToString(); }
        }


    }

    //Enums go here
    public enum Depreciationmethod
    {
        [Description("Straight Line")]
        StraightLine,
        [Description("Double Declining Balance")]
        DoubleDecliningBalance,
        [Description("Written Down Value")]
        WrittenDownValue,
        [Description("Manual")]
        Manual,
    }


}