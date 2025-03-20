using System.ComponentModel.DataAnnotations;

namespace BTG.Aplicacao.Dtos;

public record PedidoReadModel(
    Guid Id,
    int CodigoPedido,
    int CodigoCliente,
    List<ProdutoReadModel> Itens);
