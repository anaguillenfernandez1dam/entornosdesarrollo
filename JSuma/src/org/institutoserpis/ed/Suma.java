package org.institutoserpis.ed;

import java.math.BigDecimal;
import java.util.Scanner;

public class Suma {

	public static void main(String[] args) {
	
		//Sumando con BigDecimal 
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("Introduce un número");

		BigDecimal numero1 = new BigDecimal(scanner.nextLine());
		System.out.println("Primer numero = " + numero1);
		
		System.out.println("Introduce otro número");

		BigDecimal numero2 = new BigDecimal(scanner.nextLine());
		System.out.println("Segundo numero = " + numero2);
		
		BigDecimal suma = numero1.add(numero2);
		BigDecimal resta = numero1.subtract(numero2);
		BigDecimal producto = numero1.multiply(numero2);
		BigDecimal division = numero1.divide(numero2);
		System.out.println(numero1 + " + " + numero2 + " = " + suma);
		System.out.println(numero1 + " - " + numero2 + " = " + resta);
		System.out.println(numero1 + " * " + numero2 + " = " + producto);
		System.out.println(numero1 + " / " + numero2 + " = " + division);
		
		
	}

}
