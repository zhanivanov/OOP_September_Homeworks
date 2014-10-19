package OneLevShop;

public abstract class ElectronicsProduct extends Product{
	private int guaranteePeriod;
	
	public ElectronicsProduct(String name, int price, int quantity,
			AgeRestriction ageRestricton, int guaranteePeriod) {
		super(name, price, quantity, ageRestricton);
		this.setGuaranteePeriod(guaranteePeriod);
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		this.guaranteePeriod = guaranteePeriod;
	}

	@Override
	public double getPrice() {
		return this.getPriceProp();
	}
	
	
}
