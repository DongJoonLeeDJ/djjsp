package studyLamda;

public class MyLamda {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		MyAddable myAdd = (x,y) -> x+y;
		MyAddable PowerAdd = (x,y) -> (x*x)+(y*y);
		
		System.out.println(myAdd.add(2, 3));
		System.out.println(PowerAdd.add(2, 3));
		
		UseLamdaFunc((x,y)->x+x+y+y, 1,2);
	}
	
	static void UseLamdaFunc(MyAddable m, int a, int b)
	{
		for(int i = 0; i < 3; i++)
			System.out.println(m.add(a+i, b+i));
	}

}
