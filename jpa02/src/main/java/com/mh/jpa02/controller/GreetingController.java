package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;

import com.mh.jpa02.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import javax.validation.Valid;
import java.util.List;

@Controller
public class GreetingController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("/greeting")
    public String greeting(@RequestParam(name = "name", required = false, defaultValue = "World") String name, Model model) {
        model.addAttribute("name", name);
        return "greeting";
    }

    @GetMapping("/")
    public String home() {
        return "home";
    }

    @GetMapping("/board")
    public String board(Model model) {
        List<Board> list = boardRepository.findAll();
        model.addAttribute("list", list);
        return "board/board";

    }

    @GetMapping("/form")
    public String form(Board board) {
        return "board/form";
    }

    @PostMapping("/form")
    public String form(@Valid Board board, BindingResult bindingResult) {
        if( bindingResult.hasErrors()){
//            System.out.println("일로오나");
            return "board/form";
        }
        boardRepository.save(board);
        return "board/form";
    }

    //    @PostMapping("/form")
//    public String form(@RequestParam(name = "title") String title,
//                       @RequestParam(name = "content") String content) {
//        System.out.println(title);
//        System.out.println(content);
//        Board board = new Board();
//        board.setTitle(title);
//        board.setContent(content);
//        boardRepository.save(board);
//        return "board/form";
//    }

}