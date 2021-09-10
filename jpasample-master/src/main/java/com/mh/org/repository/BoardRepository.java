package com.mh.org.repository;

import org.springframework.data.repository.CrudRepository;

import com.mh.org.domain.Board;

public interface BoardRepository extends CrudRepository<Board, Long> {

}