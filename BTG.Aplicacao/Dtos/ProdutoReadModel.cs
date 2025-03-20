namespace BTG.Aplicacao.Dtos;

public record ProdutoReadModel(
    Guid id,
    string Nome,
    int Quantidade,
    decimal Preco);
