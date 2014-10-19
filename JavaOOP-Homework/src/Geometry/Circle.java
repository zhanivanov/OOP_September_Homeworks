package Geometry;

import java.util.List;

public class Circle extends PlaneShape{
	private double radius;
	
	public Circle(List<Vertex> vertices, double radius) {
		super(vertices);
		setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}

	@Override
	public double getPerimeter() {
		return 2 * Math.PI * this.radius;
	}

	@Override
	public double getArea() {
		return 2 * Math.PI * radius * radius;
	}
	
	@Override
	public String toString() {
		String vertices = "Vertices: \n";
		for (Vertex vertex : this.getVertecles()) {
			vertices += vertex;
		}
		
		return vertices + "\nRadius = " + getRadius();
	}
}
