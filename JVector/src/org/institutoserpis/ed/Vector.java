package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] v = new int[] {16, 12, 15, 14, 17};
		for (int item : v)
		   System.out.println(item);
		
		int index = indexOf(v, 12);
		sort(v);
		System.out.println("index="+index);
		
	}

	
	public static int indexOf(int[] v, int x) {
//		int index = 0;
//		while (index < v.length && v[index] != x)
//			index++;
//		if (index == v.length)
//			return -1;
//		return index;
		for (int index = 0; index < v.length; index++)
			if (v[index] == x)
				return index;
		return -1;
	}
	
	public static int min(int[] v) {
		//return -33;
		
//		int numMin = v[0];
//		
//		for (int index = 1; index < v.length; index++)
//			if (v[index] < numMin)
//				numMin = v[index];
//						
//		return numMin;
//				
		
		int indexOfMin = indexOfMin(v);
		return v[indexOfMin];
	}
	
	public static int indexOfMin(int[] v) {
		//int numMin = min(v);
		//int indexMin = indexOf(v, numMin);
		//return indexMin;
		
		int indexOfMin = 0;
		for (int index = 1; index < v.length; index++)
			if (v[index] < v[indexOfMin])
				indexOfMin = index;
		return indexOfMin;
		
	}
	
	public static int indexOfMin(int[]v, int initialIndex) {
		
		int indexOfMin = initialIndex;
		for (int index = initialIndex; index < v.length; index++)
			if (v[index] < v[indexOfMin])
				indexOfMin = index;
		return indexOfMin;
		
	}
	
	private static void swap(int[]v, int indexOne, int indexTwo) {
		int aux = v[indexOne];
		v[indexOne] = v[indexTwo];
		v[indexTwo] = aux;
	}
	
	public static void sort(int[] v) {

//		int indexOfSelected = 0;
//		int indexOfMin = 0;
//		
//		for (indexOfSelected = 0; indexOfSelected <v.length-1;
//				indexOfSelected++) {
//			indexOfMin = indexOfSelected;
//			for (int index=indexOfSelected +1 ; index < v.length; index++)
//				if(v[index] < v[indexOfMin])
//					indexOfMin = index;
//		
//			int aux = v[indexOfSelected];
//			v[indexOfSelected] = v[indexOfMin];
//			v[indexOfMin] = aux;
//		 
//		}
		
		for (int index=0; index <v.length-1; index++)
			swap(v,index,indexOfMin(v,index));
	
	}
}