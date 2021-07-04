using System;

class ConversorDB {
  private int numero;

  public ConversorDB (int numero) {
    if (numero > 0) this.numero = numero;
  }

  public void SetNumero (int numero) {
    if (numero > 0) this.numero = numero;
  }
  public int GetNumero () {
    return numero;
  }

  public string Binario () {
    int resto;
    string resultado = "";
    
    while (numero > 0) {
      resto = numero % 2;
      numero = numero / 2;
      resultado = resto.ToString() + resultado;
    }

    return resultado;
  }

  public override string ToString () {
    return $"Decimal {numero}\nBinario {Binario()}";
  }
  
}

class MainClass {
  public static void Main () {
    ConversorDB x = new ConversorDB (4);
    Console.WriteLine(x);
  }
}