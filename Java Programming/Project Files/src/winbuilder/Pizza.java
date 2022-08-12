package winbuilder;

import java.util.ArrayList;

public class Pizza {
	
	private String pizza;
	private double price;
	
	public Pizza(String pizza, double price) {
		this.pizza = pizza;
		this.price = price;
//		setPizza(pizza);
//		setPrice(price);
	}

	public String getPizza() {
		return pizza;
	}

	public void setPizza(String pizza) {
		this.pizza = pizza;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
	
}
