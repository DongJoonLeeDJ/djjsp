package com.mh.jpaboot01.repository;

import com.mh.jpaboot01.model.Employee;
import org.springframework.data.jpa.repository.JpaRepository;

public interface EmployeeRepository extends JpaRepository<Employee, Long> {

}