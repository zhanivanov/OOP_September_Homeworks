package OneLevShop;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Map;
import java.util.function.Predicate;
import java.util.stream.Collectors;

import Geometry.Interfaces.PerimeterMeasurable;


public class TestShop {

	public static void main(String[] args) {

		FoodProduct bread = new FoodProduct("Bread", 4, 24,	AgeRestriction.NONE, "16.10.2014");
		FoodProduct milk = new FoodProduct("Milk", 2, 50, AgeRestriction.NONE, "16.11.2014");
		FoodProduct cigars = new FoodProduct("Cigars", 6, 50, AgeRestriction.ADULT, "16.11.2014");
		FoodProduct apples = new FoodProduct("Apples", 2, 0, AgeRestriction.ADULT, "16.11.2014");

		Customer dimitarPetrov = new Customer("Dimitar Petrov", 14, 100);
		Customer asenIvanov = new Customer("Asen Ivanov", 14, 1.5);
		Customer ivanSimeonov = new Customer("Ivan Simeonov", 20, 10.5);

		try {
			PurchaseManager.processPurchase(bread, dimitarPetrov);
		} catch (RuntimeException ex) {
			System.out.println(ex.getMessage());
		}

		try {
			PurchaseManager.processPurchase(cigars, dimitarPetrov);
		} catch (RuntimeException ex) {
			System.out.println(ex.getMessage());
		}

		try {
			PurchaseManager.processPurchase(milk, asenIvanov);
		} catch (RuntimeException ex) {
			System.out.println(ex.getMessage());
		}

		try {
			PurchaseManager.processPurchase(apples, ivanSimeonov);
		} catch (RuntimeException ex) {
			System.out.println(ex.getMessage());
		}

		System.out.println(bread.getPrice());
		System.out.println();

		List<Product> products = new ArrayList<Product>();
		products.add(bread);
		products.add(milk);
		products.add(cigars);
		products.add(apples);

		Product productWithMostRecentExpirationDate = products.stream()
				.filter(p -> p instanceof Expirable)
				.map(p -> (Expirable) p)
				.sorted((p1, p2) -> p1.getExpirationDate().compareTo(p2.getExpirationDate()))
				.map(p -> (Product) p)
				.findFirst()
				.get();
		
		System.out.println(productWithMostRecentExpirationDate.getName());
		System.out.println();
		
		products.stream()
				.filter(p -> p.getAgeRestricton() == AgeRestriction.ADULT)
				.sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
				.collect(Collectors.toList())
				.forEach(p -> System.out.println(p.getName() + " price: " + p.getPrice()));
	}

}
