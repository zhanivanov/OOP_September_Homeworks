package Geometry;

import java.util.List;

public class Cuboid extends SpaceShape{
	private double width;
	private double height;
	private double depth;
	
	public Cuboid(List<Vertex> vertices, double width, double height, double depth) {
		super(vertices);
		setWidth(width);
		setHeight(height);
		setDepth(depth);
	}
	
	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		this.depth = depth;
	}

	@Override
	public double getArea() {
		return 2 * (width * depth + depth * height + height * width);
	}

	@Override
	public double getVolume() {
		return width * depth * height;
	}

	@Override
	public String toString() {
		String vertices = "Vertices: \n";
		for (Vertex vertex : this.getVertecles()) {
			vertices += vertex;
		}
		
		return vertices + "\nWidth: " + this.getWidth() + "\nHeight: " + this.getHeight() + "\nDepth: " + this.getDepth();
	}
}
