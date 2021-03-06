using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shift_type
{
    public class ERPShift_type : ERPNextObjectBase
    {
        public ERPShift_type() : this(new ERPObject(DocType.Shift_type)) { }
        public ERPShift_type(ERPObject obj) : base(obj) { }

        public static ERPShift_type Create(string starttime, string endtime)

        {
            ERPShift_type obj = new ERPShift_type();
            obj.start_time = starttime;
            obj.end_time = endtime;
            return obj;
        }

        public string start_time
        {
            get { return data.start_time; }
            set
            {
                data.start_time = value;
                data.name = value;
            }

        }

        public string end_time
        {
            get { return data.end_time; }
            set { data.end_time = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public Determinecheckinandcheckout determine_check_in_and_check_out
        {
            get { return parseEnum<Determinecheckinandcheckout>(data.determine_check_in_and_check_out); }
            set { data.determine_check_in_and_check_out = value.ToString(); }
        }

        public Workinghourscalculationbasedon working_hours_calculation_based_on
        {
            get { return parseEnum<Workinghourscalculationbasedon>(data.working_hours_calculation_based_on); }
            set { data.working_hours_calculation_based_on = value.ToString(); }
        }

        public double working_hours_threshold_for_half_day
        {
            get { return data.working_hours_threshold_for_half_day; }
            set { data.working_hours_threshold_for_half_day = value; }
        }

        public double working_hours_threshold_for_absent
        {
            get { return data.working_hours_threshold_for_absent; }
            set { data.working_hours_threshold_for_absent = value; }
        }

        public int begin_check_in_before_shift_start_time
        {
            get { return data.begin_check_in_before_shift_start_time; }
            set { data.begin_check_in_before_shift_start_time = value; }
        }

        public long enable_entry_grace_period
        {
            get { return data.enable_entry_grace_period; }
            set { data.enable_entry_grace_period = value; }
        }

        public int late_entry_grace_period
        {
            get { return data.late_entry_grace_period; }
            set { data.late_entry_grace_period = value; }
        }

        public long enable_exit_grace_period
        {
            get { return data.enable_exit_grace_period; }
            set { data.enable_exit_grace_period = value; }
        }

        public int early_exit_grace_period
        {
            get { return data.early_exit_grace_period; }
            set { data.early_exit_grace_period = value; }
        }

        public int allow_check_out_after_shift_end_time
        {
            get { return data.allow_check_out_after_shift_end_time; }
            set { data.allow_check_out_after_shift_end_time = value; }
        }

        public long enable_auto_attendance
        {
            get { return data.enable_auto_attendance; }
            set { data.enable_auto_attendance = value; }
        }

        public string process_attendance_after
        {
            get { return data.process_attendance_after; }
            set { data.process_attendance_after = value; }
        }

        public string last_sync_of_checkin
        {
            get { return data.last_sync_of_checkin; }
            set { data.last_sync_of_checkin = value; }
        }


    }

    //Enums go here
    public enum Determinecheckinandcheckout
    {
        [Description("Alternating entries as IN and OUT during the same shift")]
        AlternatingentriesasINandOUTduringthesameshift,
        [Description("Strictly based on Log Type in Employee Checkin")]
        StrictlybasedonLogTypeinEmployeeCheckin,
    }

    public enum Workinghourscalculationbasedon
    {
        [Description("First Check-in and Last Check-out")]
        FirstCheckinandLastCheckout,
        [Description("Every Valid Check-in and Check-out")]
        EveryValidCheckinandCheckout,
    }


}