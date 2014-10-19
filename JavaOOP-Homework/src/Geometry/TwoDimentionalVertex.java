package Geometry;

public class TwoDimentionalVertex extends Vertex {

	public TwoDimentionalVertex(int x, int y) {
		super(x, y);
		
	}
	
	@Override
	public String toString() {
		return "x = " + this.getX() + "\ty = " + this.getY() + "\n";
	}
}
