using System;

class Data {
  private int dia, mes, ano;

  public Data (int dia, int mes, int ano) {
    if (dia > 0 && dia <= 31) this.dia = dia;
    if (mes > 0 && mes <= 12) this.mes = mes;
    if (ano > 0) this.ano = ano;
  }
  public Data (string data) {};

  public void SetData (int dia, int mes, int ano) {
    if (dia > 0 && dia <= 31) this.dia = dia;
    if (mes > 0 && mes <= 12) this.mes = mes;
    if (ano > 0) this.ano = ano;
  }

  public int GetDia () {
    return dia;
  }
  public int GetMes () {
    return mes;
  }
  public int GetAno () {
    return ano;
  }

  public override string ToString () {
    return $"{dia}/{mes}/{ano}";
  }
}