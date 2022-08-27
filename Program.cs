// int SecondNumber(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is " + num);
//     int dec = num / 10;
//     int result = dec % 10;
//     return result;
    
// }

// int number = SecondNumber();
// Console.WriteLine("Second number is " + number);





// void ThirdSign(){ 
//     Console.WriteLine("Enter the number: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     string numS = Convert.ToString(num);
//     if (numS.Length > 2){
//         Console.WriteLine("The third sign is " + numS[2]);
//     }
//     else{
//     Console.WriteLine("The third sign doesn't exist");
//     }  

// }

//     ThirdSign();
   




// void DayOfTheWeek(int num){
//     if(num == 6 || num == 7){
//         Console.WriteLine("This is a day off");
//     }
//     else if (num > 0 && num < 6){
//         Console.WriteLine("This is a bussiness day");
//     }
//     else{
//         Console.WriteLine("Enter the correct day number");
//     }
// }
// while(true){
//     Console.WriteLine("Enter a day number: ");
//     int dayNumber = Convert.ToInt32(Console.ReadLine());
//     DayOfTheWeek(dayNumber);
// }
