using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Vehicle_service
{
    public class ERPVehicle_service : ERPNextObjectBase
    {
        public ERPVehicle_service() : this(new ERPObject(DocType.Vehicle_service)) { }
        public ERPVehicle_service(ERPObject obj) : base(obj) { }

        public static ERPVehicle_service Create(Serviceitem serviceitem, Type type, Frequency frequency, double expenseamount)

        {
            ERPVehicle_service obj = new ERPVehicle_service();
            obj.service_item = serviceitem;
            obj.type = type;
            obj.frequency = frequency;
            obj.expense_amount = expenseamount;
            return obj;
        }

        public Serviceitem service_item
        {
            get { return parseEnum<Serviceitem>(data.service_item); }
            set { data.service_item = value.ToString(); }
        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        public Frequency frequency
        {
            get { return parseEnum<Frequency>(data.frequency); }
            set { data.frequency = value.ToString(); }
        }

        public double expense_amount
        {
            get { return data.expense_amount; }
            set { data.expense_amount = value; }
        }


    }

    //Enums go here
    public enum Serviceitem
    {
        [Description("Brake Oil")]
        BrakeOil,
        [Description("Brake Pad")]
        BrakePad,
        [Description("Clutch Plate")]
        ClutchPlate,
        [Description("Engine Oil")]
        EngineOil,
        [Description("Oil Change")]
        OilChange,
        [Description("Wheels")]
        Wheels,
    }

    public enum Type
    {
        [Description("Inspection")]
        Inspection,
        [Description("Service")]
        Service,
        [Description("Change")]
        Change,
    }

    public enum Frequency
    {
        [Description("Mileage")]
        Mileage,
        [Description("Monthly")]
        Monthly,
        [Description("Quarterly")]
        Quarterly,
        [Description("Half Yearly")]
        HalfYearly,
        [Description("Yearly")]
        Yearly,
    }


}