package OneLevShop;

public abstract class Product implements Buyable{
	private String name;
	private double price;
	private int quantity;
	private AgeRestriction ageRestricton;
	
	public Product(String name, int price, int quantity,
			AgeRestriction ageRestricton) {
		super();
		this.name = name;
		this.setPrice(price);
		this.quantity = quantity;
		this.ageRestricton = ageRestricton;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public abstract double getPrice();

	public double getPriceProp() {
		return this.price;
	}
	public void setPrice(double price) {
		if (this.price < 0) {
			throw new IllegalArgumentException("Price cannot be negative value!");
		}
		this.price = price;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestricton() {
		return ageRestricton;
	}

	public void setAgeRestricton(AgeRestriction ageRestricton) {
		this.ageRestricton = ageRestricton;
	}
	
}
