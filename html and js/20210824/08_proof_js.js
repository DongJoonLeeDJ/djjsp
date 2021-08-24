document.addEventListener('DOMContentLoaded',
()=>
{
    let BigCount = prompt("대수의 법칙을 증명할 수는?", 1000)
    //for문을 돌면서 계속 태그에 글자를 적을 예정
    for(let i = 0; i<BigCount; i++)
    {
        //1부터 6까지의 정수를 가져오는 부분
        let random = Math.floor(Math.random() * 6) + 1;
        //Math.random() : 0 이상 1미만의 실수를 가져옴
        //최소 0 최대 0.999999999999999999....
        //여기에 6을 곱하면 최소 0, 최대 5.99999999999 가 나옴
        //Math.floor : 소수점을 버리는 함수
        //0부터 5가 나오게 한 다음 여기에 1을 더함.
        //따라서 1부터 6을 뽑는 게 됨

        //num = h1태그 중에 클래스 명이 num1~num6중 하나인 것
        //innerHTML 해당 태그 안에 있는 모든 태그 및 XML 등
        //innerText 해당 태그 안에 있는 글자들
        let num = document.querySelector('h1.num'+random)
        let count = parseInt(num.innerText)
        count++;
        num.innerText = count
    }

    //가장 큰 숫자에 대하여 색깔도 칠하고
    //각각의 숫자에 대한 확률도 적어보자.
    let max = 0
    let maxIndex = 0

    for(let i = 1; i<=6; i++)
    {
        let value = document.querySelector('h1.num'+i).innerText
        if(max<value)
        {
            max = value
            maxIndex = i
        }
        value = (value/BigCount) * 100
        document.querySelector('h2.num'+i).innerText 
                                  = parseFloat(value).toFixed(2)+'%'
    }

    //색깔칠하기~~~~
    document.querySelector('h1.num'+maxIndex).setAttribute('class', 'max')
    document.querySelector('h2.num'+maxIndex).setAttribute('class', 'max')

    //참고사항
    //1. 지금 로직의 잘못된 점 : for이 1000번 돌면, 화면을 1000번 수정함...
    //2. jQuery에서 태그의 text 가져오는 방법
    //$('h1.num1').text()
}
)