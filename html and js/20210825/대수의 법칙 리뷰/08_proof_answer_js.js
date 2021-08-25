//로직의 잘못된 점을 개선하기
//타이틀?에 해당하는 부분에 색깔칠해주기
document.addEventListener('DOMContentLoaded',
()=>
{
    let BigCount = prompt("대수의 법칙을 증명할 수는?", 1000)
    let numArr = [0,0,0,0,0,0]
    for(let i = 0; i<BigCount; i++)
    {
        //0이상 6미만의 값을 넣는다.
      let random = Math.floor(Math.random()*6)
      numArr[random]++
      //배열의 인덱스는 0부터 시작하니까...

      //random이 0이 나와서
      //numArr 0번째의 값에 1을 더하게 되면
      //주사위 던져서 1이 나온 거랑 똑같은 효과임
    }
    //6칸짜리 배열에 숫자가 잘 나오는 걸 확인할 수 있다.
    console.log(numArr)

    for(let i = 0; i<numArr.length; i++)
    {
        document.querySelector('h1.num'+(i+1)).innerText = numArr[i]
    }


    //가장 큰 숫자에 대하여 색깔도 칠하고
    //각각의 숫자에 대한 확률도 적어보자.
    let max = numArr[0]
    let maxIndex = 0

    for(let i = 1; i<=6; i++)
    {
        // if(max<numArr[i])
        // {
        //     max = numArr[i]
        //     maxIndex = i
        // }
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

    //nth-child(2)
    // document.querySelector('h1:last-child').style.background = 'yellow'

    
    //태그에 직접 스타일 주는 게 우선순위가 더 높다.
    //따라서 클래스 주는 거를 먼저 배치하고
    //그 밑에 태그에 직접 스타일 주는 걸 배치하였다.
    document.querySelector('h1.numTitle'+maxIndex).setAttribute('class', 'max')
    document.querySelector('h1.num'+maxIndex).setAttribute('class', 'max')
    document.querySelector('h2.num'+maxIndex).setAttribute('class', 'max')
    
    let list = document.querySelectorAll('h1')
    for(let i = 1; i<=list.length; i++)
    {
        //h1태그들 중에서
        //i번째에 해당하는태그의 스타일을 바꾼다.
        //h1:nth-of-type(${i}) = 
        // h1:nth-of-type(1), h1:nth-of-type(2).... 이런식으로 선택하는 거...
        if(i%2 == 1)
            document.querySelector(`h1:nth-of-type(${i})`).style.background = 'yellow'
    }
    
    
}
)