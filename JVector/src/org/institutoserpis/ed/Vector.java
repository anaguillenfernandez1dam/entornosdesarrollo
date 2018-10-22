package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		
		//int[] v = new int[] {11, 16, 19, 13, 15};
		int[] v = new int[] {};
		int x = 16;
		int index = indexOf(v,x);
		
		System.out.println("ERROR");
		
	}
	
	public static int indexOf (int[] v, int x) {
//		int indexOfX = 0;
//		while (indexOfX < v.length && v[indexOfX] != x) 
//			indexOfX++;
//		if (indexOfX == v.length)
//			return -1;
//		return indexOfX;
		
		for (int index=0; index <v.length; index++)
			if (v[index]==x)
				return index;
		return -1;
		
	}
}
