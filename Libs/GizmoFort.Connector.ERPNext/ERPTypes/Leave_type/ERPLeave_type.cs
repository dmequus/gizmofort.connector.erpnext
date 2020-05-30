using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_type
{
    public class ERPLeave_type : ERPNextObjectBase
    {
        public ERPLeave_type() : this(new ERPObject(DocType.Leave_type)) { }
        public ERPLeave_type(ERPObject obj) : base(obj) { }

        public static ERPLeave_type Create(string leavetypename)

        {
            ERPLeave_type obj = new ERPLeave_type();
            obj.leave_type_name = leavetypename;
            return obj;
        }

        public string leave_type_name
        {
            get { return data.leave_type_name; }
            set
            {
                data.leave_type_name = value;
                data.name = value;
            }

        }

        public int max_leaves_allowed
        {
            get { return data.max_leaves_allowed; }
            set { data.max_leaves_allowed = value; }
        }

        public int applicable_after
        {
            get { return data.applicable_after; }
            set { data.applicable_after = value; }
        }

        public int max_continuous_days_allowed
        {
            get { return data.max_continuous_days_allowed; }
            set { data.max_continuous_days_allowed = value; }
        }

        public long is_carry_forward
        {
            get { return data.is_carry_forward; }
            set { data.is_carry_forward = value; }
        }

        public long is_lwp
        {
            get { return data.is_lwp; }
            set { data.is_lwp = value; }
        }

        public long is_optional_leave
        {
            get { return data.is_optional_leave; }
            set { data.is_optional_leave = value; }
        }

        public long allow_negative
        {
            get { return data.allow_negative; }
            set { data.allow_negative = value; }
        }

        public long include_holiday
        {
            get { return data.include_holiday; }
            set { data.include_holiday = value; }
        }

        public long is_compensatory
        {
            get { return data.is_compensatory; }
            set { data.is_compensatory = value; }
        }

        public int expire_carry_forwarded_leaves_after_days
        {
            get { return data.expire_carry_forwarded_leaves_after_days; }
            set { data.expire_carry_forwarded_leaves_after_days = value; }
        }

        public long allow_encashment
        {
            get { return data.allow_encashment; }
            set { data.allow_encashment = value; }
        }

        public int encashment_threshold_days
        {
            get { return data.encashment_threshold_days; }
            set { data.encashment_threshold_days = value; }
        }

        public string earning_component
        {
            get { return data.earning_component; }
            set { data.earning_component = value; }
        }

        public long is_earned_leave
        {
            get { return data.is_earned_leave; }
            set { data.is_earned_leave = value; }
        }

        public Earnedleavefrequency earned_leave_frequency
        {
            get { return parseEnum<Earnedleavefrequency>(data.earned_leave_frequency); }
            set { data.earned_leave_frequency = value.ToString(); }
        }

        public Rounding rounding
        {
            get { return parseEnum<Rounding>(data.rounding); }
            set { data.rounding = value.ToString(); }
        }

        public double maximum_carry_forwarded_leaves
        {
            get { return data.maximum_carry_forwarded_leaves; }
            set { data.maximum_carry_forwarded_leaves = value; }
        }


    }

    //Enums go here
    public enum Earnedleavefrequency
    {
        [Description("Monthly")]
        Monthly,
        [Description("Quarterly")]
        Quarterly,
        [Description("Half-Yearly")]
        HalfYearly,
        [Description("Yearly")]
        Yearly,
    }

    public enum Rounding
    {
        [Description("0.5")]
        num05,
        [Description("1.0")]
        num10,
    }


}