package org.institutoserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class VectorTest {

	@Test
	void indexOfX() {
		int[] v = new int[] {11, 16, 19, 13, 15};
		assertEquals(0,Vector.indexOf(v, 11));
		assertEquals(2,Vector.indexOf(v, 19));
		assertEquals(-1,Vector.indexOf(v, 33));
	}
	
	@Test
	void indexOfEmpty() {
		int[] v = new int[] {};
		assertEquals(-1, Vector.indexOf(v, 22));
	}

}
