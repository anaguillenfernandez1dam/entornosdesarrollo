package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] v = new int[] {16, 12, 15, 14, 17};
		for (int item : v)
			System.out.println(item);
		
		int index = indexOf(v, 12);
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
	
	public static void sort(int[] v) {
		for (int index = 0; index < v.length; index++) {
			if (v[index] >= v[0]) {
				if (v[index] >= v[1]) {
					if (v[index] >= v[2]) {
						if (v[index] >= v[3]) {
							v[4] = v[index];
						}else {
							v[3] = v[index];
						}
					}else {
						v[3] = v[index];
					}
				}else {
					v[1] = v[index];
				}
			}else {
				v[0] = v[index];
			}
		}
		
	}
}