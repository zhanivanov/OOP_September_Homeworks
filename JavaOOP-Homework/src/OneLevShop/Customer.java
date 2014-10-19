package OneLevShop;

public class Customer {
	private String name;
	private int age;
	private double balance;
	
	public Customer(String name, int age, double balance) {
		super();
		this.name = name;
		this.setAge(age);
		this.setBalance(balance);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		if(this.getAge() < 0) {
			throw new IllegalArgumentException("Age cannot be negative!");
		}
		this.age = age;
	}

	public double getBalance() {
		return balance;
	}

	public void setBalance(double balance) {
		if (this.getBalance() < 0) {
			throw new IllegalArgumentException("Balance cannot be negative!");
		}
		this.balance = balance;
	}
	
}
