using System;

class Paciente {
  private string nome;
  private string cpf;
  private string numero;
  private DataTime nascimento;

  public Paciente (string nome, string cpf, string numero, DataTime nascimento) {
    this.nome = nome;
    this.cpf = cpf;
    this.numero = numero;
    this.nascimento = nascimento;
  }

  public string Idade () {
    DataTime dataAtual = DataTime.Now;

    return $"idade: {dataAtual.Year - nascimento.Year}";
  }

  public override string ToString () {
    return $"Nome {nome}\nCpf {cpf}\nNumero {numero}\nData de nascimento {nascimento}";
  }
}