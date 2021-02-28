using IdStore.NetCore.Domain.Enums;

namespace IdStore.NetCore.Application.Contracts.Queries
{
    public class ProductQuery
    {
        //public int? FirmCode { get; set; }
        //public int? ItmsGrpCod { get; set; }
        //public string ItemName { get; set; }

        public bool Status { get; set; }

        public EnumDbConnName CodCompany { get; set; }
    }
}
