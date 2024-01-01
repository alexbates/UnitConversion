/*
Class: CSE 1321
Section: 04
Term: Fall 2023
Instructor: Ermias Memo
Name: Alex Bates
Assignment: Conversion Program
*/

class currencyConversion {
  private float usd, eur, jpy, cad;
  public currencyConversion() {
    usd = 0.0f;
    eur = 0.0f;
    jpy = 0.0f;
    cad = 0.0f;
  }
  public currencyConversion(float usd, float eur, float jpy, float cad) {
    this.usd = usd;
    this.eur = eur;
    this.jpy = jpy;
    this.cad = cad;
  }
  public float getUsd() {return usd;}
  public float getEur() {return eur;}
  public float getJpy() {return jpy;}
  public float getCad() {return cad;}
  public void setUsd(float usd) {this.usd = usd;}
  public void setEur(float eur) {this.eur = eur;}
  public void setJpy(float jpy) {this.jpy = jpy;}
  public void setCad(float cad) {this.cad = cad;}
  public float convUtoE() {
    eur = usd * 0.92f;
    return eur;
  }
  public float convUtoJ() {
    jpy = usd * 149.75f;
    return jpy;
  }
  public float convUtoC() {
    cad = usd * 1.37f;
    return cad;
  }
  public float convEtoU() {
    usd = eur / 0.92f;
    return usd;
  }
  public float convEtoJ() {
    jpy = eur * 163.02f;
    return jpy;
  }
  public float convEtoC() {
    cad = eur * 1.5f;
    return cad;
  }
  public float convJtoU() {
    usd = jpy / 149.75f;
    return cad;
  }
  public float convJtoE() {
    eur = jpy / 163.02f;
    return eur;
  }
  public float convJtoC() {
    cad = jpy / 109.03f;
    return cad;
  }
  public float convCtoU() {
    usd = cad / 1.37f;
    return cad;
  }
  public float convCtoE() {
    eur = cad / 1.5f;
    return eur;
  }
  public float convCtoJ() {
    jpy = cad * 109.03f;
    return jpy;
  }

}