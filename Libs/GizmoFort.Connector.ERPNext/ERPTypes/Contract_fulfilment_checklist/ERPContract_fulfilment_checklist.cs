using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract_fulfilment_checklist
{
    public class ERPContract_fulfilment_checklist : ERPNextObjectBase
    {
        public ERPContract_fulfilment_checklist() : this(new ERPObject(DocType.Contract_fulfilment_checklist)) { }
        public ERPContract_fulfilment_checklist(ERPObject obj) : base(obj) { }

        public static ERPContract_fulfilment_checklist Create(int fulfilled, string requirement, string notes, string amendedfrom)

        {
            ERPContract_fulfilment_checklist obj = new ERPContract_fulfilment_checklist();
            obj.fulfilled = fulfilled;
            obj.requirement = requirement;
            obj.notes = notes;
            obj.amended_from = amendedfrom;
            return obj;
        }

        private int _fulfilled = 0;
        public int fulfilled
        {
            get { return data._fulfilled; }
            set { data._fulfilled = value; }
        }

        public string requirement
        {
            get { return data.requirement; }
            set { data.requirement = value; }
        }

        public string notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}