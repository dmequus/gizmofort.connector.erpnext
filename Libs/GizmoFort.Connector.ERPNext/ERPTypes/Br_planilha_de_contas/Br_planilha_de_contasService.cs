using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Br_planilha_de_contas
{
    public class Br_planilha_de_contasService : SubServiceBase<ERPBr_planilha_de_contas>
    {
        public Br_planilha_de_contasService(ERPNextClient client)
            : base(DocType.Br_planilha_de_contas, client) { }

        protected override ERPBr_planilha_de_contas fromERPObject(ERPObject obj)
        {
            return new ERPBr_planilha_de_contas(obj);
        }
    }
}