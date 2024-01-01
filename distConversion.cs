/*
Class: CSE 1321
Section: 04
Term: Fall 2023
Instructor: Ermias Memo
Name: Alex Bates
Assignment: Conversion Program
*/

class distConversion {
  private float inch, foot, yard;
  public distConversion() {
    inch = 0.0f;
    foot = 0.0f;
    yard = 0.0f;
  }
  public distConversion(float inch, float foot, float yard) {
    this.inch = inch;
    this.foot = foot;
    this.yard = yard;
  }
  public float getInch() {return inch;}
  public float getFoot() {return foot;}
  public float getYard() {return yard;}
  public void setInch(float inch) {this.inch = inch;}
  public void setFoot(float foot) {this.foot = foot;}
  public void setYard(float yard) {this.yard = yard;}
  public float convItoF() {
    foot = inch / 12f;
    return foot;
  }
  public float convFtoI() {
    inch = foot * 12f;
    return inch;
  }
  public float convItoY() {
    yard = inch / 36f;
    return yard;
  }
  public float convYtoI() {
    inch = yard * 36f;
    return inch;
  }
  public float convFtoY() {
    yard = foot / 3f;
    return yard;
  }
  public float convYtoF() {
    foot = yard * 3f;
    return foot;
  }
}