using System;

class Equação2ºgrau {
  private double a, b, c;

  public Equação2ºgrau (double a, double b, double c) {
    if (a > 0) this.a = a;
    if (b > 0) this.b = b;
    if (c > 0) this.c = c;
  }

  public void SetABC (double a, double b, double c) {
    if (a > 0) this.a = a;
    if (b > 0) this.b = b;
    if (c > 0) this.c = c;
  }
  public void GetABC (out double a, out double b, out double c) {
    a = this.a;
    b = this.b;
    c = this.c;
  }

  public double Delta () {
    return ((b * b) - (4 * a * c));
  }

  public bool RaizesReais (out double x1, out double x2) {
    if (Delta() < 0) {
      return false;
    }
    else {
      if (Delta() == 0) {
        x1 = ((-b) + Delta()) / (2 * a);
        return true;
      }
      else {
        if (Delta () > 0) {
          x1 = ((-b) + Delta()) / (2 * a);
          x2 = ((-b) - Delta()) / (2 * a);
          return true;
        }
      }
    }
  }

  public override string ToString () {
    return $"A: {a}\nB: {b}\nC: {c}";
  } 
}

class MainClass {
  public static void Main () {
    Equação2ºgrau x = new Equação2ºgrau (30, 50, 20);
    double z, g, y;
    x.GetABC(out z, out g, out y);
    Console.WriteLine ($"{z}, {g}, {y}");
  }
}