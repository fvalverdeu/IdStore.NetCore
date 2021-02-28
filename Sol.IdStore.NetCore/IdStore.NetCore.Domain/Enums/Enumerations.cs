namespace IdStore.NetCore.Domain.Enums
{
    public enum EnumDbConnName
    {
        IdStore = 1,
        IdStoreReports = 2
    }
    public enum EnumStatusCode
    {
        Ok = 20001,
        Created = 20101,
        NoContent = 20401,
        BadRequest_DatosInvalidos = 40001,
        BadRequest_RegistroExiste = 40002,
        Unauthorized = 40101,
        NotFount = 40401,
        InternalError = 50001
    }
    public enum EnumEstadoEnvio : short
    {
        PENDIENTE = 1,
        INT_EXITOSO = 2,
        INT_ERROR = 3,
        SAP_EXITOSO = 4,
        SAP_ERROR = 5
    }
}
