package com.mh.jpa02.repository;

import com.mh.jpa02.model.Board;
import com.mh.jpa02.model.BoardTail;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BoardTailRepository extends JpaRepository<BoardTail,Long> {
}
