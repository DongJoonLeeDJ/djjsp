package com.mh.jpa02.repository;

import com.mh.jpa02.model.Board;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BoardRepository extends JpaRepository<Board,Long> {
}
