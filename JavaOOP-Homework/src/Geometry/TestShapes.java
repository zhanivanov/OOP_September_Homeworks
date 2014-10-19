package Geometry;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

import Geometry.Interfaces.PerimeterMeasurable;
import Geometry.Interfaces.VolumeMeasurable;

public class TestShapes {
	public static void main(String[] args) {
		List<Vertex> trianglePoints = new ArrayList<Vertex>();
		trianglePoints.add(new TwoDimentionalVertex(15, 15));
		trianglePoints.add(new TwoDimentionalVertex(23, 30));
		trianglePoints.add(new TwoDimentionalVertex(35, 24));
		
		List<Vertex> threeDimentionalVertices = new ArrayList<Vertex>();
		threeDimentionalVertices.add(new ThreeDimentionalVertex(1, 1, 1));
		threeDimentionalVertices.add(new ThreeDimentionalVertex(3, 4, 6));
		threeDimentionalVertices.add(new ThreeDimentionalVertex(9, 9, 9));
		
		PlaneShape triangle = new Triangle(trianglePoints);
		PlaneShape rectangle = new Rectangle(trianglePoints.subList(0, 1), 5, 10);
		PlaneShape circle = new Circle(trianglePoints.subList(1, 2), 7);
		SpaceShape pyramid = new SquarePeramid(threeDimentionalVertices.subList(0, 1), 10, 5);
		SpaceShape cuboid = new Cuboid(threeDimentionalVertices.subList(1, 2), 5, 10, 7);
		SpaceShape sphere = new Sphere(threeDimentionalVertices.subList(2, 3), 20);
		
		Shape[] shapes = {triangle, rectangle, circle, pyramid, cuboid, sphere};
		
//		for (Shape shape : shapes) {
//			System.out.println(shape);
//		}
		
		Comparator<PerimeterMeasurable> comparatorByPerimeter = (
				PerimeterMeasurable s1, PerimeterMeasurable s2) -> {
			double diff = s1.getPerimeter() - s2.getPerimeter();
			if (diff < 0) {
				return -1;
			}

			if (diff > 0) {
				return 1;
			}

			return 0;
		};
		
		List<VolumeMeasurable> filteredVolume = Arrays.asList(shapes)
				.stream()
				.filter(s -> s instanceof SpaceShape)
				.map(s -> (SpaceShape) s)
				.filter(v -> v.getVolume() > 40)
				.collect(Collectors.toList());
		
		System.out.println(filteredVolume);
		
		List<PerimeterMeasurable> planeShapesPerimeter = Arrays.asList(shapes)
				.stream()
				.filter(s -> s instanceof PerimeterMeasurable)
				.map(s -> (PerimeterMeasurable) s)
				.sorted(comparatorByPerimeter)
				.collect(Collectors.toList());
		
		System.out.println(planeShapesPerimeter);
	}
}
