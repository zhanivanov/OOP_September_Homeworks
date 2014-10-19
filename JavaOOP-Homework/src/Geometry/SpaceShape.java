package Geometry;

import java.util.ArrayList;
import java.util.List;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.VolumeMeasurable;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable{
	List<ThreeDimentionalVertex> threeDimentionalVertices = new ArrayList<ThreeDimentionalVertex>();
	
	public SpaceShape(List<Vertex> vertices) {
		super(vertices);
	}

	public List<ThreeDimentionalVertex> getThreeDimentionalVertices() {
		return threeDimentionalVertices;
	}

	public void setThreeDimentionalVertices(List<ThreeDimentionalVertex> threeDimentionalVertices) {
		this.threeDimentionalVertices = threeDimentionalVertices;
	}

}
