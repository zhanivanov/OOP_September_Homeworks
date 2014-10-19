package Geometry;

import java.util.ArrayList;
import java.util.List;


public class Shape {
	private List<Vertex> vertices = new ArrayList<Vertex>();
	
	public Shape(List<Vertex> vertices) {
		setVertecles(vertices);
	}

	public List<Vertex> getVertecles() {
		return vertices;
	}

	public void setVertecles(List<Vertex> vertices) {
		this.vertices = vertices;
	}
	
}