package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;
import com.mh.jpa02.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Sort;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.validation.Valid;
import java.text.SimpleDateFormat;
import java.util.List;

@Controller
@RequestMapping("/board")
public class BoardController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("/list")
    public String board(Model model) {
        List<Board> list = boardRepository.findAll(Sort.by(Sort.Direction.DESC, "id"));
        model.addAttribute("list", list);
        return "board/list";

    }

    @GetMapping("/view")
    public String view(long id,Model model) {
        Board board = boardRepository.findById(id).orElse(null);
        model.addAttribute("board",board);
        return "board/view";
    }

    @GetMapping("/form")
    public String form(Board board) {
        return "board/form";
    }

    @PostMapping("/form")
    public String form(Model model, @Valid Board board, BindingResult bindingResult) {
        model.addAttribute("board",board);
        if( bindingResult.hasErrors()){
            return "board/form";
        }
        long nano = System.currentTimeMillis();
        String curDate = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(nano);
        board.setDate(curDate);
        boardRepository.save(board);
        return "redirect:/board/list";
    }

}
