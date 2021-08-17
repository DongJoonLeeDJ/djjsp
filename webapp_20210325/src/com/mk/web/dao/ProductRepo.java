package com.mk.web.dao;

import java.util.ArrayList;

import com.mk.web.dto.Product;

public class ProductRepo {
	private ArrayList<Product> listOfProducts = new ArrayList<Product>();
	
	public ProductRepo() {
		Product iphone = new Product("p1111", "iPhone12", 1090000);
		iphone.setDescription("6.1-inch, 2532x1170 Super Retina XDR OLED Display, A14 Bionic, IP68, Dual 12MP Camera System");
		iphone.setCategory("Mobile");
		iphone.setManufacturer("Apple");
		iphone.setUnitInStock(1000);
		iphone.setCondition("2020 Brand New Product");
		listOfProducts.add(iphone);

		Product notebook = new Product("p2111", "2021 LG Gram17", 1719000);
		notebook.setDescription("17-inch, 2560x1600 WQXGA IPS Display, Intel i5 11g, Memory LPDDR4");
		notebook.setCategory("Laptop");
		notebook.setManufacturer("LG");
		notebook.setUnitInStock(1000);
		notebook.setCondition("2021 Brand New Product");
		listOfProducts.add(notebook);

		Product tablet = new Product("p3111", "Samsung GalaxyTab S7", 899800);
		tablet.setDescription("278.1mm, 2560x1660 WQXGA TFT Display, Memory 256G");
		tablet.setCategory("Tablet");
		tablet.setManufacturer("Samsung");
		tablet.setUnitInStock(1000);
		tablet.setCondition("2021 Brand New Product");
		listOfProducts.add(tablet);
	}
	
	public ArrayList<Product> getAllProduct(){
		return listOfProducts;
	}
	
	public Product getProductById(String productId) {
		Product productById = null;
		for (int i = 0; i < listOfProducts.size(); i++) {
			Product product = listOfProducts.get(i);
			if(product != null && product.getProductId() != null && product.getProductId().equals(productId)) {
				productById = product;
				break;
			}
		}
		return productById;
	}
}
