using System;

class ConversorDB {
  private int numero;

  public ConversorDB (int numero) {
    if (numero > 0) this.numero = numero;
  }

  public void SetNumero (int numero) {
    if (numero > 0) this.numero = numero;
  }
  public int GetNumero (int numero) {
    return 0;
  }

  public int Binario () {
    private int ControleDivisao = 1;
    private int bin = 0;
    
    bin = bin ((numero % 2) * ControleDivisao);
    numero = numero / 2;

    ControleDivisao = ControleDivisao * 10;  
    bin = bin ((numero % 2) * ControleDivisao);
    numero = numero / 2
    return bin;
  }
  
}

class MainClass {
  public static void Main () {
    ConversorDB x = new ConversorDB (4);
    Console.WriteLine(x.Binario());
  }
}