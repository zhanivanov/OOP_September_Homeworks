package Geometry;

import java.util.ArrayList;
import java.util.List;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.PerimeterMeasurable;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {
	private List<TwoDimentionalVertex> twoDimentionalVertices = new ArrayList<TwoDimentionalVertex>();
	
	public PlaneShape(List<Vertex> vertices) {
		super(vertices);
		setTwoDimentionalVertices(twoDimentionalVertices);
	}

	public List<TwoDimentionalVertex> getTwoDimentionalVertices() {
		return twoDimentionalVertices;
	}

	public void setTwoDimentionalVertices(
			List<TwoDimentionalVertex> twoDimentionalVertices) {
		this.twoDimentionalVertices = twoDimentionalVertices;
	}

	@Override
	public abstract double getPerimeter();

	@Override
	public abstract double getArea();

	
}
