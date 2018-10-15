package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		
		
		Random random = new Random();
		int contadorIntentos =1, numeroAleatorio = random.nextInt(1000)+1;
		Scanner scanner = new Scanner(System.in);
		int numMinimo = 1;
		int numMaximo = 1000;
		
		System.out.printf("Adivina un número entre %s y %s", numMinimo, numMaximo);
		System.out.println();
		int numeroIntroducido = Integer.parseInt(scanner.nextLine());
		
		
		while(numeroIntroducido != numeroAleatorio){
			if (numeroIntroducido < numeroAleatorio) {
				numMinimo = numeroIntroducido+1;
				System.out.printf("Mi número es mayor. Dime otro entre %s y %s. [Intento %s]",numMinimo, numMaximo, contadorIntentos);
			}else {
				numMaximo = numeroIntroducido-1;
				System.out.printf("Mi número es menor. Dime otro entre %s y %s. [Intento %s]",numMinimo,numMaximo, contadorIntentos);
			}
			
			System.out.println();
			numeroIntroducido = Integer.parseInt(scanner.nextLine());
			contadorIntentos++;
		}
		
		System.out.println("¡Felicidades, has ganado!");
		System.out.println("Te ha costado " + contadorIntentos + " intentos");
	}
	
}
