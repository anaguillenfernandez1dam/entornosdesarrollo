package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		
		
		Random random = new Random();
		int contadorIntentos =1, numeroAleatorio = random.nextInt(1000)+1;
		Scanner scanner = new Scanner(System.in);
		System.out.println("Dime un número");
		int numeroIntroducido = Integer.parseInt(scanner.nextLine());
		
		
		while(numeroIntroducido != numeroAleatorio){
		if (numeroIntroducido < numeroAleatorio)
			System.out.println("Mi número es mayor. Dime otro");
		else 
			System.out.println("Mi número es menor. Dime otro");
			
		numeroIntroducido = Integer.parseInt(scanner.nextLine());
		contadorIntentos++;
		}
		
		System.out.println("¡Felicidades, has ganado!");
		System.out.println("Te ha costado " + contadorIntentos + " intentos");
	}
	
}
