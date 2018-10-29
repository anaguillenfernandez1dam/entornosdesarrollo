package org.institutoserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class VectorTest {

	@Test
	void indexOf() {
		int[] v = new int[] {16, 12, 15, 14, 17};
		assertEquals(0, Vector.indexOf(v, 16));
		assertEquals(2, Vector.indexOf(v, 15));
		assertEquals(4, Vector.indexOf(v, 17));
		assertEquals(-1, Vector.indexOf(v, 33));
	}
	
	@Test
	void indexOfEmpty() {
		int[] v = new int[] {};
		assertEquals(-1, Vector.indexOf(v, 22));
	}
	
	@Test
	void min() {
		assertEquals(12, Vector.min(new int[] {16, 12, 15, 14, 17}));
		//assertEquals(9, min(new int[] {9, 12, 15, 14, 17}));
		assertEquals(16, Vector.min(new int[] {16}));
		assertEquals(12, Vector.min(new int[] {16, 12}));
		assertEquals(12, Vector.min(new int[] {16, 12, 15}));
		assertEquals(12, Vector.min(new int[] {16, 12, 15, 14}));
		//assertEquals(9, Vector.min(new int[] {16, 12, 15, 14}));
		//assertEquals(33, Vector.min(new int[] {16, 12, 15, 14}));
		assertEquals(11, Vector.min(new int[] {16, 12, 15, 14, 11}));
	}
	
	@Test
	void indexOfMin() {
		//assertEquals(0, Vector.indexOfMin(new int[] {16, 12, 15, 14, 17}));
		//assertEquals(1, Vector.indexOfMin(new int[] {16, 12, 15, 14, 11}));
		//assertEquals(1, Vector.indexOfMin(new int[] {16, 15, 14}));
		assertEquals(1, Vector.indexOfMin(new int[] {16, 12, 15, 14, 17}));
		assertEquals(4, Vector.indexOfMin(new int[] {16, 12, 15, 14, 11}));
	    assertEquals(2, Vector.indexOfMin(new int[] {16, 15, 14}));
	    assertEquals(0, Vector.indexOfMin(new int[] {55}));
	    assertEquals(0, Vector.indexOfMin(new int[] {55,89}));
	    assertEquals(2, Vector.indexOfMin(new int[] {55,89,41}));
		
	}
	
	@Test 
	void sort() {
		//int[] v = new int[] {15, 12};
		//sort(v);
	}

}