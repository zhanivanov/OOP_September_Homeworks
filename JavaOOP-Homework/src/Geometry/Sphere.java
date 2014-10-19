package Geometry;

import java.util.List;

public class Sphere extends SpaceShape{
	private double radius;
	
	public Sphere(List<Vertex> vertices, double radius) {
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
	public double getArea() {
		return 4 * Math.PI * Math.pow(this.radius, 2);
	}

	@Override
	public double getVolume() {
		return (4 * Math.PI * Math.pow(this.radius, 3)) / 3;
	}

	@Override
	public String toString() {
		String vertices = "Vertices: \n";
		for (Vertex vertex : this.getVertecles()) {
			vertices += vertex;
		}
		
		return vertices + "\nRadius: " + this.getRadius();
	}
}
