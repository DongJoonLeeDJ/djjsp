package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.Arrays;
import java.util.List;

@Controller
public class GreetingController {
    @GetMapping("/greeting")
    public String greeting(@RequestParam(name="name", required=false, defaultValue="World") String name, Model model) {
        model.addAttribute("name", name);
        return "greeting";
    }

    @GetMapping("/")
    public String home() {
        return "home";
    }

    @GetMapping("/board")
    public String board(Model model) {
        List<Board> list = Arrays.asList(
                new Board(1l,"board1",
                        "title1111","1111content","20210916"),
                new Board(2l,"board2",
                        "title2222","2222content","20210917"));
        model.addAttribute("list",list);
        return "board/board";

    }

    /*
        react
        fetch(url).then((data)->{return data.json()}).then(

        )
        jquesy.getselector('id').val('asdf')
        useState()
     */

}