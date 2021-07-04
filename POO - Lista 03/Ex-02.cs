using System;

class Frete
{
  private double distancia, peso;

  public Frete (double distancia, double peso)
  {
    if (distancia > 0) this.distancia = distancia;
    if (peso > 0) this.peso = peso;
  }

  public void SetDistancia (double distancia)
  {
    if (distancia > 0) this.distancia = distancia;
  }
  public void SetPeso (double peso)
  {
    if (peso > 0) this.peso = peso;
  }

  public double GetDistancia ()
  {
    return distancia;
  }
  public double GetPeso ()
  {
    return peso;
  }

  public double CalcFrete ()
  {
    // peso * 0.01 * distancia == Frete
    return ((peso * 0.01) * distancia);
  }

  public override string ToString ()
  {
    return $"Distancia: {distancia}\nPeso: {peso}";
  }
}