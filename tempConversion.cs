/*
Class: CSE 1321
Section: 04
Term: Fall 2023
Instructor: Ermias Memo
Name: Alex Bates
Assignment: Conversion Program
*/

class tempConversion {
  private float celsius, fahrenheit, kelvin;
  public tempConversion() {
    celsius = 0.0f;
    fahrenheit = 0.0f;
    kelvin = 0.0f;
  }
  public tempConversion(float celsius, float fahrenheit, float kelvin) {
    this.celsius = celsius;
    this.fahrenheit = fahrenheit;
    this.kelvin = kelvin;
  }
  public float getCelsius() {return celsius;}
  public float getFahrenheit() {return fahrenheit;}
  public float getKelvin() {return kelvin;}
  public void setCelsius(float celsius) {this.celsius = celsius;}
  public void setFahrenheit(float fahrenheit) {this.fahrenheit = fahrenheit;}
  public void setKelvin(float kelvin) {this.kelvin = kelvin;}
  public float convCtoF() {
    fahrenheit = celsius * 9f / 5f + 32f;
    return fahrenheit;
  }
  public float convFtoC() {
    celsius = (fahrenheit - 32f) * (5f / 9f);
    return fahrenheit;
  }
  public float convCtoK() {
    kelvin = celsius + 273.15f;
    return kelvin;
  }
  public float convKtoC() {
    celsius = kelvin - 273.15f;
    return celsius;
  }
  public float convFtoK() {
    kelvin = (fahrenheit - 32f) * (5f / 9f) + 273.15f;
    return kelvin;
  }
  public float convKtoF() {
    fahrenheit = (kelvin - 273.15f) * (9f / 5f) + 32f;
    return fahrenheit;
  }
}