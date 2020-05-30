using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Prescription_duration
{
    public class ERPPrescription_duration : ERPNextObjectBase
    {
        public ERPPrescription_duration() : this(new ERPObject(DocType.Prescription_duration)) { }
        public ERPPrescription_duration(ERPObject obj) : base(obj) { }

        public static ERPPrescription_duration Create(int number, Period period)

        {
            ERPPrescription_duration obj = new ERPPrescription_duration();
            obj.number = number;
            obj.period = period;
            return obj;
        }

        private int _number = 0;
        public int number
        {
            get { return data._number; }
            set { data._number = value; }
        }

        public Period period
        {
            get { return parseEnum<Period>(data.period); }
            set { data.period = value.ToString(); }
        }


    }

    //Enums go here
    public enum Period
    {
        [Description("Hour")]
        Hour,
        [Description("Day")]
        Day,
        [Description("Week")]
        Week,
        [Description("Month")]
        Month,
    }


}