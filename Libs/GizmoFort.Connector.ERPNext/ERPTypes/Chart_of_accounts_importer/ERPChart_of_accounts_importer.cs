using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Chart_of_accounts_importer
{
    public class ERPChart_of_accounts_importer : ERPNextObjectBase
    {
        public ERPChart_of_accounts_importer() : this(new ERPObject(DocType.Chart_of_accounts_importer)) { }
        public ERPChart_of_accounts_importer(ERPObject obj) : base(obj) { }

        public static ERPChart_of_accounts_importer Create()

        {
            ERPChart_of_accounts_importer obj = new ERPChart_of_accounts_importer();
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

        public string import_file
        {
            get { return data.import_file; }
            set { data.import_file = value; }
        }

        public string chart_tree
        {
            get { return data.chart_tree; }
            set { data.chart_tree = value; }
        }


    }

    //Enums go here

}