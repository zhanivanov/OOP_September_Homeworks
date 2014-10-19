package OneLevShop;

public class Appliance extends ElectronicsProduct{

	public Appliance(String name, int price, int quantity,
			AgeRestriction ageRestricton, int guaranteePeriod) {
		super(name, price, quantity, ageRestricton, 6);
		// TODO Auto-generated constructor stub
	}

	@Override
	public double getPrice() {
		if (this.getQuantity() < 50) {
			return (this.getPriceProp() * 105) / 100;
		}
		
		return this.getPriceProp();
	}

}
