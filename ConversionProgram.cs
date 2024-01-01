/*
Class: CSE 1321
Section: 04
Term: Fall 2023
Instructor: Ermias Memo
Name: Alex Bates
Assignment: Conversion Program
*/

using System;

class Program {
  public static void Main (string[] args) {
    bool cont_menu = true;
    Console.WriteLine("[Currency Conversion Program]");
    do {
      Console.WriteLine("\n1) Temperature");
      Console.WriteLine("2) Distance");
      Console.WriteLine("3) Weight");
      Console.WriteLine("4) Currency");
      Console.Write("What conversion would you like to make?: ");
      int conv_type = int.Parse(Console.ReadLine());
      switch(conv_type) {
        case 1:
          tempConversion temp = new tempConversion();
          float temp_c, temp_f, temp_k;
          Console.WriteLine("\n1) Celsius to Fahrenheit");
          Console.WriteLine("2) Fahrenheit to Celsius");
          Console.WriteLine("3) Celsius to Kelvin");
          Console.WriteLine("4) Kelvin to Celsius");
          Console.WriteLine("5) Fahrenheit to Kelvin");
          Console.WriteLine("6) Kelvin to Fahrenheit");
          Console.Write("Which temperature conversion would you like to make?: ");
          int temp_type = int.Parse(Console.ReadLine());
          switch(temp_type) {
          case 1:
            Console.Write("\nEnter the temperature in Celsius: ");
            temp_c = float.Parse(Console.ReadLine());
            temp.setCelsius(temp_c);
            temp.convCtoF();
            Console.WriteLine("\n" + temp.getCelsius() + " degrees Celsius is equal to " + temp.getFahrenheit() + " degrees Fahrenheit.");
            break;
          case 2:
            Console.Write("Enter the temperature in Fahrenheit: ");
            temp_f = float.Parse(Console.ReadLine());
            temp.setFahrenheit(temp_f);
            temp.convFtoC();
            Console.WriteLine("\n" + temp.getFahrenheit() + " degrees Fahrenheit is equal to " + temp.getCelsius() + " degrees Celsius.");
            break;
          case 3:
            Console.Write("Enter the temperature in Celsius: ");
            temp_c = float.Parse(Console.ReadLine());
            temp.setCelsius(temp_c);
            temp.convCtoK();
            Console.WriteLine("\n" + temp.getCelsius() + " degrees Celsius is equal to " + temp.getKelvin() + " degrees Kelvin.");
            break;
          case 4:
            Console.Write("Enter the temperature in Kelvin: ");
            temp_k = float.Parse(Console.ReadLine());
            temp.setKelvin(temp_k);
            temp.convKtoC();
            Console.WriteLine("\n" + temp.getKelvin() + " degrees Kelvin is equal to " + temp.getCelsius() + " degrees Celsius.");
            break;
          case 5:
            Console.Write("Enter the temperature in Fehrenheit: ");
            temp_f = float.Parse(Console.ReadLine());
            temp.setFahrenheit(temp_f);
            temp.convFtoK();
            Console.WriteLine("\n" + temp.getFahrenheit() + " degrees Fahrenheit is equal to " + temp.getKelvin() + " degrees Kelvin.");
            break;
          default:
            Console.Write("Enter the temperature in Kelvin: ");
            temp_k = float.Parse(Console.ReadLine());
            temp.setKelvin(temp_k);
            temp.convKtoF();
            Console.WriteLine("\n" + temp.getKelvin() + " degrees Kelvin is equal to " + temp.getFahrenheit() + " degrees Fahrenheit.");
            break;
          }
          break;
        case 2:
          distConversion dist = new distConversion();
          float dist_i, dist_f, dist_y;
          Console.WriteLine("\n1) Inch to Foot");
          Console.WriteLine("2) Feet to Inches");
          Console.WriteLine("3) Inches to Yards");
          Console.WriteLine("4) Yards to Inches");
          Console.WriteLine("5) Feet to Yards");
          Console.WriteLine("6) Yards to Feet");
          Console.Write("Which distance conversion would you like to make?: ");
          int dist_type = int.Parse(Console.ReadLine());
          switch(dist_type) {
          case 1:
            Console.Write("\nEnter the distance in Inches: ");
            dist_i = float.Parse(Console.ReadLine());
            dist.setInch(dist_i);
            dist.convItoF();
            Console.WriteLine("\n" + dist.getInch() + " inches is equal to " + dist.getFoot() + " feet.");
            break;
          case 2:
            Console.Write("\nEnter the distance in Feet: ");
            dist_f = float.Parse(Console.ReadLine());
            dist.setFoot(dist_f);
            dist.convFtoI();
            Console.WriteLine("\n" + dist.getFoot() + " feet is equal to " + dist.getInch() + " inches.");
            break;
          case 3:
            Console.Write("\nEnter the distance in Inches: ");
            dist_i = float.Parse(Console.ReadLine());
            dist.setInch(dist_i);
            dist.convItoY();
            Console.WriteLine("\n" + dist.getInch() + " inches is equal to " + dist.getYard() + " yards.");
            break;
          case 4:
            Console.Write("\nEnter the distance in Yards: ");
            dist_y = float.Parse(Console.ReadLine());
            dist.setYard(dist_y);
            dist.convYtoI();
            Console.WriteLine("\n" + dist.getYard() + " yards is equal to " + dist.getInch() + " inches.");
            break;
          case 5:
            Console.Write("\nEnter the distance in Feet: ");
            dist_f = float.Parse(Console.ReadLine());
            dist.setFoot(dist_f);
            dist.convFtoY();
            Console.WriteLine("\n" + dist.getFoot() + " feet is equal to " + dist.getYard() + " yards.");
            break;
          default:
            Console.Write("\nEnter the distance in Yards: ");
            dist_y = float.Parse(Console.ReadLine());
            dist.setYard(dist_y);
            dist.convYtoF();
            Console.WriteLine("\n" + dist.getYard() + " yards are equal to " + dist.getFoot() + " feet.");
            break;
          }
          break;
        case 3:
          weightConversion weight = new weightConversion();
          float weight_l, weight_k;
          Console.WriteLine("\n1) Pound to Kilogram");
          Console.WriteLine("2) Kilogram to Pound");
          Console.Write("Which weight conversion would you like to make?: ");
          int weight_type = int.Parse(Console.ReadLine());
          switch(weight_type) {
            case 1:
              Console.Write("\nEnter the weight in Pounds: ");
              weight_l = float.Parse(Console.ReadLine());
              weight.setLb(weight_l);
              weight.convLtoK();
              Console.WriteLine("\n" + weight.getLb() + " pounds is equal to " + weight.getKg() + " kilograms.");
              break;
            default:
              Console.Write("\nEnter the weight in Kilograms: ");
              weight_k = float.Parse(Console.ReadLine());
              weight.setKg(weight_k);
              weight.convKtoL();
              Console.WriteLine("\n" + weight.getKg() + " kilograms is equal to " + weight.getLb() + " pounds.");
              break;
          }
          break;
        case 4:
          currencyConversion currency = new currencyConversion();
          float curr_u, curr_e, curr_j, curr_c;
          Console.WriteLine("\n1) USD to EUR");
          Console.WriteLine("2) USD to JPY");
          Console.WriteLine("3) USD to CAD");
          Console.WriteLine("4) EUR to USD");
          Console.WriteLine("5) EUR to JPY");
          Console.WriteLine("6) EUR to CAD");
          Console.WriteLine("7) JPY to USD");
          Console.WriteLine("8) JPY to EUR");
          Console.WriteLine("9) JPY to CAD");
          Console.WriteLine("10) CAD to USD");
          Console.WriteLine("11) CAD to EUR");
          Console.WriteLine("12) CAD to JPY");
          Console.Write("Which currency conversion would you like to make?: ");
          int curr_type = int.Parse(Console.ReadLine());
          switch(curr_type) {
            case 1:
              Console.Write("\nEnter the amount in USD: ");
              curr_u = float.Parse(Console.ReadLine());
              currency.setUsd(curr_u);
              currency.convUtoE();
              Console.WriteLine("\n" + currency.getUsd() + " USD is equal to " + currency.getEur() + " EUR.");
              break;
            case 2:
              Console.Write("\nEnter the amount in USD: ");
              curr_u = float.Parse(Console.ReadLine());
              currency.setUsd(curr_u);
              currency.convUtoJ();
              Console.WriteLine("\n" + currency.getUsd() + " USD is equal to " + currency.getJpy() + " JPY.");
              break;
            case 3:
              Console.Write("\nEnter the amount in USD: ");
              curr_u = float.Parse(Console.ReadLine());
              currency.setUsd(curr_u);
              currency.convUtoC();
              Console.WriteLine("\n" + currency.getUsd() + " USD is equal to " + currency.getCad() + " CAD.");
              break;
            case 4:
              Console.Write("\nEnter the amount in EUR: ");
              curr_e = float.Parse(Console.ReadLine());
              currency.setEur(curr_e);
              currency.convEtoU();
              Console.WriteLine("\n" + currency.getEur() + " EUR is equal to " + currency.getUsd() + " USD.");
              break;
            case 5:
              Console.Write("\nEnter the amount in EUR: ");
              curr_e = float.Parse(Console.ReadLine());
              currency.setEur(curr_e);
              currency.convEtoJ();
              Console.WriteLine("\n" + currency.getEur() + " EUR is equal to " + currency.getJpy() + " JPY.");
              break;
            case 6:
              Console.Write("\nEnter the amount in EUR: ");
              curr_e = float.Parse(Console.ReadLine());
              currency.setEur(curr_e);
              currency.convEtoC();
              Console.WriteLine("\n" + currency.getEur() + " EUR is equal to " + currency.getCad() + " CAD.");
              break;
            case 7:
              Console.Write("\nEnter the amount in JPY: ");
              curr_j = float.Parse(Console.ReadLine());
              currency.setJpy(curr_j);
              currency.convJtoU();
              Console.WriteLine("\n" + currency.getJpy() + " JPY is equal to " + currency.getUsd() + " USD.");
              break;
            case 8:
              Console.Write("\nEnter the amount in JPY: ");
              curr_j = float.Parse(Console.ReadLine());
              currency.setJpy(curr_j);
              currency.convJtoE();
              Console.WriteLine("\n" + currency.getJpy() + " JPY is equal to " + currency.getEur() + " EUR.");
              break;
            case 9:
              Console.Write("\nEnter the amount in JPY: ");
              curr_j = float.Parse(Console.ReadLine());
              currency.setJpy(curr_j);
              currency.convJtoC();
              Console.WriteLine("\n" + currency.getJpy() + " JPY is equal to " + currency.getCad() + " CAD.");
              break;
            case 10:
              Console.Write("\nEnter the amount in CAD: ");
              curr_c = float.Parse(Console.ReadLine());
              currency.setCad(curr_c);
              currency.convCtoU();
              Console.WriteLine("\n" + currency.getCad() + " CAD is equal to " + currency.getUsd() + " USD.");
              break;
            case 11:
              Console.Write("\nEnter the amount in CAD: ");
              curr_c = float.Parse(Console.ReadLine());
              currency.setCad(curr_c);
              currency.convCtoE();
              Console.WriteLine("\n" + currency.getCad() + " CAD is equal to " + currency.getEur() + " EUR.");
              break;
            default:
              Console.Write("\nEnter the amount in CAD: ");
              curr_c = float.Parse(Console.ReadLine());
              currency.setCad(curr_c);
              currency.convCtoJ();
              Console.WriteLine("\n" + currency.getCad() + " CAD is equal to " + currency.getJpy() + " JPY.");
              break;
          }
          break;
        default:
          Console.WriteLine("Invalid option.");
          break;
      }
      Console.WriteLine("\nWould you like to make another conversion? (yes/no): ");
      string question = Console.ReadLine();
      if(question == "no" || question == "No") {
        cont_menu = false;
        Console.WriteLine("\nThank you for using this conversion program!");
      }
    }
    while(cont_menu);
    
  }
}