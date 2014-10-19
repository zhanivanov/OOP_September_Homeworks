package Geometry;

import java.util.List;

public class Rectangle extends PlaneShape {
	private int width;
	private int height;
	
	public Rectangle(List<Vertex> vertices, int width, int height) {
		super(vertices);
		setHeight(height);
		setWidth(width);
	}
	
	public int getWidth() {
		return width;
	}

	public void setWidth(int width) {
		this.width = width;
	}

	public int getHeight() {
		return height;
	}

	public void setHeight(int height) {
		this.height = height;
	}

	@Override
	public double getPerimeter() {
		return 2 * this.width + 2 * this.height;
	}

	@Override
	public double getArea() {
		return this.width * this.height;
	}
	
	@Override
	public String toString() {
		String vertices = "Vertices: \n";
		for (Vertex vertex : this.getVertecles()) {
			vertices += vertex;
		}
		
		return vertices + "\nWidth: " + this.width + "\nHeight: " + this.height;
	}
}
