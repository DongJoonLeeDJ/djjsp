package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;
import com.mh.jpa02.model.BoardTail;
import com.mh.jpa02.repository.BoardRepository;
import com.mh.jpa02.repository.BoardTailRepository;
import com.mh.jpa02.validator.BoardValidator;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Sort;
import org.springframework.security.core.Authentication;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import javax.validation.Valid;
import java.text.SimpleDateFormat;


@Controller
@RequestMapping("/boardtail")
public class BoardTailController {

    @Autowired
    BoardTailRepository boardTailRepository;

    @Autowired
    BoardRepository boardRepository;

    @PostMapping("/form")
    public String form(BoardTail boardtail,long board_id) {
        Board board = boardRepository.findById(board_id).orElse(new Board());
        System.out.println(boardtail);
//        boardtail.setBoard_id(1l);
        boardtail.setBoard(board);
        boardTailRepository.save(boardtail);
        return "redirect:/board/view?id="+board.getId();
    }

}
