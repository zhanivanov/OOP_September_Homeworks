package Geometry;

public class ThreeDimentionalVertex extends Vertex{
	private int z;
	
	public ThreeDimentionalVertex(int x, int y, int z) {
		super(x, y);
		setZ(z);
	}

	public int getZ() {
		return z;
	}
	
	public void setZ(int z) {
		this.z = z;
	}

	@Override
	public String toString() {
		return "x = " + this.getX() + "\ty = " + this.getY() + "\tz = " + this.getZ() + "\n";
	}
}
