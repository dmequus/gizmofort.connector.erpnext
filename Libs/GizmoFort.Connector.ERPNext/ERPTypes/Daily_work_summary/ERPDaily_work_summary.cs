using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary
{
    public class ERPDaily_work_summary : ERPNextObjectBase
    {
        public ERPDaily_work_summary() : this(new ERPObject(DocType.Daily_work_summary)) { }
        public ERPDaily_work_summary(ERPObject obj) : base(obj) { }

        public static ERPDaily_work_summary Create(string dailyworksummarygroup, Status status, string emailsentto)

        {
            ERPDaily_work_summary obj = new ERPDaily_work_summary();
            obj.daily_work_summary_group = dailyworksummarygroup;
            obj.status = status;
            obj.email_sent_to = emailsentto;
            return obj;
        }

        public string daily_work_summary_group
        {
            get { return data.daily_work_summary_group; }
            set
            {
                data.daily_work_summary_group = value;
                data.name = value;
            }

        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string email_sent_to
        {
            get { return data.email_sent_to; }
            set { data.email_sent_to = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Sent")]
        Sent,
    }


}