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

        private int _max_leaves_allowed = 0;
        public int max_leaves_allowed
        {
            get { return data._max_leaves_allowed; }
            set { data._max_leaves_allowed = value; }
        }

        private int _applicable_after = 0;
        public int applicable_after
        {
            get { return data._applicable_after; }
            set { data._applicable_after = value; }
        }

        private int _max_continuous_days_allowed = 0;
        public int max_continuous_days_allowed
        {
            get { return data._max_continuous_days_allowed; }
            set { data._max_continuous_days_allowed = value; }
        }

        private int _is_carry_forward = 0;
        public int is_carry_forward
        {
            get { return data._is_carry_forward; }
            set { data._is_carry_forward = value; }
        }

        private int _is_lwp = 0;
        public int is_lwp
        {
            get { return data._is_lwp; }
            set { data._is_lwp = value; }
        }

        private int _is_optional_leave = 0;
        public int is_optional_leave
        {
            get { return data._is_optional_leave; }
            set { data._is_optional_leave = value; }
        }

        private int _allow_negative = 0;
        public int allow_negative
        {
            get { return data._allow_negative; }
            set { data._allow_negative = value; }
        }

        private int _include_holiday = 0;
        public int include_holiday
        {
            get { return data._include_holiday; }
            set { data._include_holiday = value; }
        }

        private int _is_compensatory = 0;
        public int is_compensatory
        {
            get { return data._is_compensatory; }
            set { data._is_compensatory = value; }
        }

        private int _expire_carry_forwarded_leaves_after_days = 0;
        public int expire_carry_forwarded_leaves_after_days
        {
            get { return data._expire_carry_forwarded_leaves_after_days; }
            set { data._expire_carry_forwarded_leaves_after_days = value; }
        }

        private int _allow_encashment = 0;
        public int allow_encashment
        {
            get { return data._allow_encashment; }
            set { data._allow_encashment = value; }
        }

        private int _encashment_threshold_days = 0;
        public int encashment_threshold_days
        {
            get { return data._encashment_threshold_days; }
            set { data._encashment_threshold_days = value; }
        }

        public string earning_component
        {
            get { return data.earning_component; }
            set { data.earning_component = value; }
        }

        private int _is_earned_leave = 0;
        public int is_earned_leave
        {
            get { return data._is_earned_leave; }
            set { data._is_earned_leave = value; }
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

        private double _maximum_carry_forwarded_leaves = 0.0;
        public double maximum_carry_forwarded_leaves
        {
            get { return data._maximum_carry_forwarded_leaves; }
            set { data._maximum_carry_forwarded_leaves = value; }
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