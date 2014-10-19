package OneLevShop;

public class Computer extends ElectronicsProduct{

	public Computer(String name, int price, int quantity,
			AgeRestriction ageRestricton, int guaranteePeriod) {
		super(name, price, quantity, ageRestricton, 24);
		
	}
	
	@Override
	public double getPrice() {
		if (this.getQuantity() > 1000) {
			return (this.getPriceProp() * 95) / 100;
		}
		
		return this.getPriceProp();
	}
}
