package OneLevShop;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class FoodProduct extends Product implements Expirable{
	private Date expirationDate;
	
	public FoodProduct(String name, int price, int quantity,
			AgeRestriction ageRestricton, String expirationDate) {
		super(name, price, quantity, ageRestricton);
		this.setExpirationDate(expirationDate);
	}
	
	public void setExpirationDate(String expirationDate) {
		SimpleDateFormat myFormat = new SimpleDateFormat("dd.MM.yyyy");
		try {
			this.expirationDate = myFormat.parse(expirationDate);
		} catch (ParseException e) {
			e.printStackTrace();
		}
	}

	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}
	
	@Override
	public double getPrice() {
		Date now = new Date();
		if (daysBetween(this.expirationDate, now) <= 15) {
			return (this.getPriceProp() * 70) / 100;
		}
		
		return this.getPriceProp();
	}
	
	public long daysBetween(Date first, Date second) {
		long diff = first.getTime() - second.getTime();
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		
		return days;
	}
}
