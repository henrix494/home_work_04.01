// See https://aka.ms/new-console-template for more information
// התחלה של משימה ראשונה


int h, m, s,TimeOfLand ,totalTimeInSec,landH,landM,landS;
float hTos,mTos;
    Console.WriteLine("Enter the hour of the lunch");
h = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the min of the lunch");
m = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the sec of the lunch");
s = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Time of Land (in sec)");


    TimeOfLand = int.Parse(Console.ReadLine());

    hTos =(float)( h * Math.Pow(60, 2));
    mTos = (m * 60);
    totalTimeInSec = (int)(hTos + mTos + s + TimeOfLand);
    landH = totalTimeInSec / 3600;
    landM = (totalTimeInSec % 3600) / 60;
    landS = totalTimeInSec % 60;




Console.WriteLine($"Lunch at Hour: {h} min:{m} , sec:{s}   \n");
Console.WriteLine("****************************************\n");
Console.WriteLine($"Landing time {landH}:{landM}:{landS}");
//סיום משימה ריאשונה


//התחלה של משימה שנייה

int firstNumber, secoundNumber,thirdNumber;

Console.WriteLine("Enter three numbers");

firstNumber = int.Parse(Console.ReadLine());
secoundNumber = int.Parse(Console.ReadLine());
thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber + 1 == secoundNumber && secoundNumber + 1 == thirdNumber 
    )
{
    Console.WriteLine("Numbers are ascending");
}

else if (firstNumber - 1 == secoundNumber && secoundNumber - 1 == thirdNumber 
    )

{
    Console.WriteLine("Numbers are descending");

}

else {
    Console.WriteLine("Not sorted");
}




if (firstNumber < secoundNumber && firstNumber < thirdNumber
  ) {
    Console.WriteLine("Numbers are ascending");
}
else if (firstNumber > secoundNumber && firstNumber > thirdNumber
       
    ) {
    Console.WriteLine("Numbers are descending");
}

else { Console.WriteLine("not sorted"); }


Console.ReadLine();
//סיום של משימה 2
