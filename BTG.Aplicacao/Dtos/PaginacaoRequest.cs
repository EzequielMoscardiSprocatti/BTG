namespace BTG.Aplicacao.Dtos;

public class PaginacaoRequest
{
    public int Pagina { get; set; } = 1;

    public int TotalPorPagina { get; set; } = 10;

}
