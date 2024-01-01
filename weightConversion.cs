/*
Class: CSE 1321
Section: 04
Term: Fall 2023
Instructor: Ermias Memo
Name: Alex Bates
Assignment: Conversion Program
*/

class weightConversion {
  private float lb, kg;
  public weightConversion() {
    lb = 0.0f;
    kg = 0.0f;
  }
  public weightConversion(float lb, float kg) {
    this.lb = lb;
    this.kg = kg;
  }
  public float getLb() {return lb;}
  public float getKg() {return kg;}
  public void setLb(float lb) {this.lb = lb;}
  public void setKg(float kg) {this.kg = kg;}
  public float convLtoK() {
    kg = lb / 2.205f;
    return kg;
  }
  public float convKtoL() {
    lb = kg * 2.205f;
    return lb;
  }
  
}