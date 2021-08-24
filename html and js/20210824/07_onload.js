//DOMContentLoaded 해당화면을 불러들일 때 
//body를 다 불러들이고 나서 실행되는 함수
//방법1(js) - 좀 더 최신 문법
// document.addEventListener('DOMContentLoaded', () => 
// {
//     let ex = document.getElementById('ex')
//     ex.style.backgroundColor = 'red'
//     ex.style.color = 'blue'
//     ex.style.border = '4px solid cyan'
// }

// )

//방법2(js) - 좀 옛날
//웹 창이 불러와 질 때 수행하는 함수
window.onload = function() 
{
    let ex = document.getElementById('ex')
    ex.style.backgroundColor = 'red'
    ex.style.color = 'blue'
    ex.style.border = '4px solid cyan'

    //이 안에서 이벤트 생성도 가능함
    ex.onclick = function() 
    {
        this.style.color = 'pink'
    }
}



