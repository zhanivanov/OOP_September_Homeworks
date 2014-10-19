package Geometry;

import java.util.List;

public class SquarePeramid extends SpaceShape{
	private double baseWidth;
	private double height;
	
	public SquarePeramid(List<Vertex> vertices, double baseWidth, double height) {
		super(vertices);
		setBaseWidth(baseWidth);
		setHeight(height);
	}
	
	public double getSlantLength() {
		return Math.pow((this.baseWidth / 2), 2) + Math.pow(this.height, 2);
	}
	
	public double getBaseWidth() {
		return baseWidth;
	}


	public void setBaseWidth(double baseWidth) {
		this.baseWidth = baseWidth;
	}


	public double getHeight() {
		return height;
	}


	public void setHeight(double height) {
		this.height = height;
	}

	public double getBaseArea() {
		return this.baseWidth * this.baseWidth;
	}
	
	public double getBasePerimeter() {
		return this.baseWidth * 4;
	}

	@Override
	public double getArea() {
		return this.getBaseArea() + (this.getBasePerimeter() * this.getSlantLength()) / 2;
	}

	@Override
	public double getVolume() {
		return (this.getBaseArea() * this.height) / 3;
	}

	@Override
	public String toString() {
		String vertices = "Vertices: \n";
		for (Vertex vertex : this.getVertecles()) {
			vertices += vertex;
		}
		
		return vertices + "\nBase width: " + this.getBaseWidth() + "\nHeight: " + this.getHeight();
	}
}
