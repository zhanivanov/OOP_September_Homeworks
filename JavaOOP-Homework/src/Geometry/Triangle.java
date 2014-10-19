package Geometry;

import java.util.List;

public class Triangle extends PlaneShape{

	public Triangle(List<Vertex> vertices) {
		super(vertices);
	}

	@Override
	public double getPerimeter()  {
		double perimeter = 0;
		for (int i = 0; i < this.getVertecles().size(); i++) {
			if(i == getVertecles().size() - 1) {
				perimeter += Math.sqrt(Math.pow((getVertecles().get(i).getX() - 
						getVertecles().get(0).getX()), 2) +
						Math.pow((getVertecles().get(i).getY() - 
								getVertecles().get(0).getY()), 2));
				break;
			}
			
			perimeter += Math.sqrt(Math.pow((getVertecles().get(i).getX() - 
					getVertecles().get(i+1).getX()), 2) +
					Math.pow((getVertecles().get(i).getY() - 
							getVertecles().get(i+1).getY()), 2));
		}
		
		return perimeter;
	}

	@Override
	public double getArea() {
		double area = 0;
		area = Math.abs(this.getVertecles().get(0).getX() * (this.getVertecles().get(1).getY() - this.getVertecles().get(2).getY()) + 
				this.getVertecles().get(1).getX() * (this.getVertecles().get(2).getY() - this.getVertecles().get(0).getY()) + 
				this.getVertecles().get(2).getX() * (this.getVertecles().get(0).getY() - this.getVertecles().get(1).getY()));
		
		return area / 2;
	}
	
	@Override
	public String toString() {
		String vertices = "Vertices: \n";
		for (Vertex vertex : this.getVertecles()) {
			vertices += vertex;
		}
		
		return vertices;
	}
}
