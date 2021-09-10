package com.mh.org;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.mh.org.domain.Customer;
import com.mh.org.repository.CustomerRepository;

@Controller
public class HomeController {

	@Autowired
	private CustomerRepository customerRepository;
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);

	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Model model) {

		model.addAttribute("mh", "haha");
		demo();
		
//		aa.doA();

		return "home";
	}

	public void demo() {
		customerRepository.save(new Customer("aaaa", "bbbb"));
		// save a few customers
//		customerRepository.save(new Customer("Jack", "Bauer"));
//		customerRepository.save(new Customer("Chloe", "O'Brian"));
//		customerRepository.save(new Customer("Kim", "Bauer"));
//		customerRepository.save(new Customer("David", "Palmer"));
//		customerRepository.save(new Customer("Michelle", "Dessler"));
//
//		// fetch all customers
//		logger.info("Customers found with findAll():");
//		logger.info("-------------------------------");
//		for (Customer customer : customerRepository.findAll()) {
//			logger.info(customer.toString());
//		}
//		logger.info("");
//
//		// fetch an individual customer by ID
//		Customer customer = customerRepository.findById(1L);
//		logger.info("Customer found with findById(1L):");
//		logger.info("--------------------------------");
//		logger.info(customer.toString());
//		logger.info("");
//
//		
//		// fetch customers by last name
//		logger.info("Customer found with findByLastName('Bauer'):");
//		logger.info("--------------------------------------------");
//		customerRepository.findByLastName("Bauer").forEach(
//			(Customer bauer) -> {
//				logger.info(bauer.toString());
//			}
//		);
//		// for (Customer bauer : repository.findByLastName("Bauer")) {
//		// log.info(bauer.toString());
//		// }
//		logger.info("");
	}

}
