package OneLevShop;

import java.time.LocalDate;
import java.sql.Date;

public class PurchaseManager {
	public static void processPurchase(Product product, Customer customer) {
		if (product.getQuantity() <= 0) {
			throw new IllegalArgumentException("Out of stock!");
		}
		if (checkExpirationDate(product)) {
			throw new RuntimeException(product.getName() + " is past its date." );
		}
		if (customer.getBalance() < product.getPrice()) {
			throw new IllegalArgumentException("You do not have enough money!");
		}
		if (checkForAgeRestrictions(customer, product)) {
			throw new IllegalArgumentException("You are too young!");
		}
		
		product.setQuantity(product.getQuantity() - 1);
		customer.setBalance(customer.getBalance() - product.getPrice());
	}
	
	private static boolean checkExpirationDate(Product product){
		if (product instanceof Expirable) {
			Expirable expirableProduct = (Expirable)product;
			Date now = Date.valueOf(LocalDate.now());
			if (expirableProduct.getExpirationDate().before(now)) {
				return true;
			}
		}
		
		return false;
	}
	
	private static boolean checkForAgeRestrictions(Customer customer, Product product){
		if (product.getAgeRestricton() == AgeRestriction.ADULT && customer.getAge() < 18) {
			return true;
		}
		
		return false;
	}
}
