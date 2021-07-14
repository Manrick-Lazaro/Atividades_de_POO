using System;

class Premio {
  private string cliente;
  private DateTime data;
  private object premio;

  public Premio (string cliente, DateTime data) {
    this.cliente = cliente;
    this.data = data;
  }

  public void SetPremio (object premio) {
    this.premio = premio;
  }
  
  public object GetPremio () {
    return premio;
  }

  public override string ToString () {
    return $"Cliente: {cliente}\nData: {data}\nPremio: {premio}";
  }
}

class ValeCompras {
  private DateTime dataValidade;
  private decimal valor;

  public ValeCompras (DateTime dataValidade, decimal valor) {
    this.dataValidade = dataValidade;
    this.valor = valor;
  }

  public override string ToString () {
    return $"Validade da data: {dataValidade}\nValor: {valor}";
  }
}

class Produto {
  private string descricao;
  private decimal valor;

  public Produto (string descricao, decimal valor) {
    this.descricao = descricao;
    this.valor = valor;
  }

  public override string ToString () {
    return $"Descricao do produto: {descricao}\nValor: {valor}";
  }
}