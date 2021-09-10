package com.mh.org.repository;

import java.util.List;

import org.springframework.data.repository.CrudRepository;

import com.mh.org.domain.Customer;

/*
 * crud
 * create -> insert
 * read -> select
 * update -> update
 * delete -> delete
 * 
 * select * from user;
 * insert into user values ();
 * update user set
 * dlete * from user where 
 */

public interface CustomerRepository extends CrudRepository<Customer, Long> {

	// select * from user where lastName = '';
	List<Customer> findByLastName(String lastName);

	Customer findById(long id);
	
//	@Query("select * from user")
	List<Customer> findAll();

}