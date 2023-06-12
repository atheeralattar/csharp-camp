using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class trainYourMind
    {

        public static void Q1(double num1, double num2)
        {
            Console.WriteLine("1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.");
            double q1result = num1 + num2;
            if (num1 == num2)
            {
                Console.WriteLine("input1:{0} \ninput2:{1} \nresult:{2}", num1, num2, q1result * 3);
            }
            else
            {
                Console.WriteLine("input1:{0} \ninput2:{1} \nresult:{2}", num1, num2, q1result);
            }
        }


        public static void Q2(int n)
        {
            Console.WriteLine("2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.");
            double result = Math.Abs(n - 51);
            if (n > 51)
            {
                Console.WriteLine("input1:{0} \nresult:{1}", n, result * 3);

            }
            else
            {
                Console.WriteLine("input1:{0} \nresult:{1}", n, result);
            }
        }

        static void Q3(int num1, int num2)
        {
            Console.WriteLine("3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.");

            if ((num1 == 30 || num2 == 30) || (num2 + num1 == 30))
            {
                Console.WriteLine("input1:{0} \ninput2:{1} \nresult:{2}", num1, num2, "True");
            }
            else
            {
                Console.WriteLine("input1:{0} \ninput2:{1} \nresult:{2}", num1, num2, "False");
            }
        }


        static void Q4(int num)
        {
            Console.WriteLine("4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.");
            if (Math.Abs(num - 100) <= 10 || Math.Abs(num - 200) <= 10)
            {
                Console.WriteLine("input1:{0} \nresult:{1}", num, "True");
            }
            else
            {
                Console.WriteLine("input1:{0} \nresult:{1}", num, "False");
            }
        }



        static void Q5(string inputString)
        {
            Console.WriteLine("5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.");
            if (inputString.StartsWith("if"))
            {
                Console.WriteLine("input:{0} \nresult{1}", inputString, inputString);
            }
            else
            {
                Console.WriteLine("input:{0} \nresult:{1}", inputString, "if" + inputString);
            }
        }

        static void Q6(string inputString, int position)
        {
            Console.WriteLine("6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.");
            string result = inputString.Remove(position, 1);
            Console.WriteLine("input string:{0} \ninput position:{1} \nresult:{2}", inputString, position, result);
        }

        static void Q7(string inputString)
        {
            Console.WriteLine("7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.");
            char last = inputString.Last();
            char first = inputString.First();
            if (inputString.Length == 1)
            {
                Console.WriteLine(inputString);
            }
            else
            {
                string subStirng = inputString.Substring(1, inputString.Length - 2);
                string newString = last + subStirng + first;
                Console.WriteLine(newString);

            }
        }



        static void Q8(string inpString)
        {
            Console.WriteLine("8.Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.");
            if (inpString.Length < 2)
            {
                Console.WriteLine("input:{0} \nresult:{1}");
            }
            else
            {
                string frontLetters = inpString.Substring(0, 2);
                Console.WriteLine("input:{0} \nresult:{1}", inpString, string.Concat(Enumerable.Repeat(frontLetters, 4)));

            }

        }



        static void Q9(string inpString)
        {
            Console.WriteLine("9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.");
            string result = inpString.Last() + inpString+ inpString.Last();
            Console.WriteLine("input:{0} \nresult:{1}", inpString, result);

        }


        static void Q10(double num)
        {
            Console.WriteLine("10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.");
            if (num % 3 == 0 || num % 7 == 0)
            {
                Console.WriteLine("input:{0} \nresult:{1}", num, "True");
            }
            else
            {
                Console.WriteLine("input:{0} \nresult:{1}", num, "False");
            }
        }



        static void Q11(string inpString)
        {
            Console.WriteLine("11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. " +
                "Return the string with the 3 characters added at both the front and back. If the given string length is " +
                "less than 3, use whatever characters are there.");
            if (inpString.Length < 3)
            {
                Console.WriteLine("input:{0} \nresult{1}", inpString, inpString + inpString + inpString);

            }
            else
            {
                string threeChars = inpString.Substring(0, 3);
                Console.WriteLine("input:{0} \nresult{1}", inpString, threeChars + inpString + threeChars);
            }




        }

        static void Q12(string inpString)
        {
            Console.WriteLine("12. Write a C# Sharp program to check if a given string starts with 'C#' or not.");
            bool result = inpString.Substring(0, 2) == "C#";
            Console.WriteLine("input:{0} \nresult:{1}", inpString, result);

        }

        static void Q13(double num1, double num2)
        {
            Console.WriteLine("13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.");
            bool result = (num1 > 100 & num2 < 0) || (num2 > 100 & num1 < 0);
            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, num2, result);
        }

        static void Q14(int num1, int num2)
        {
            Console.WriteLine("14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive");
            bool result = ((100 <= num1 && num1 <= 200) || (100 <= num2 && num2 <= 200));
            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, num2, result);
        }

        static void Q15(int num1, int num2, int num3)
        {

            Console.WriteLine("15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 " +
                "inclusive. Return true if 1 or more of them are in the said range otherwise false.");
            bool result = ((20 <= num1 && num1 <= 50) || (20 <= num2 && num2 <= 50) || (20 <= num3 && num3 <= 50));
            Console.WriteLine("input:{0},{1}, {2} \nresult:{3}", num1, num2, num3, result);
        }


        static void Q16(int num1, int num2)
        {
            Console.WriteLine("16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.");
            bool result = ((20 <= num1 && num1 <= 50) || (20 <= num2 && num2 <= 50));
            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, num2, result);
        }


        static void Q17(string inpString)
        {
            Console.WriteLine("17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. " +
                "If it appears return a string without 'yt' otherwise return the original string.");
            if (inpString.Substring(1, 2) == "yt")
            {
                string result = inpString.Remove(1, 2);
                Console.WriteLine("input:{0} \nresult:{2}", inpString, result);
            }
            else
            {
                string result = inpString;
                Console.WriteLine("input:{0} \nresult:{1}", inpString, result);
            }


        }

        static void Q18(int num1, int num2, int num3)
        {
            Console.WriteLine("18. Write a C# Sharp program to check the largest number among three given integers.");
            int result = Math.Max(Math.Max(num1, num2), num3);
            Console.WriteLine("input:{0},{1},{2} \nresult:{3}", num1, num2, num3, result);
        }


        static void Q19(int num1, int num2)
        {
            Console.WriteLine("19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.");
            int diff1 = Math.Abs(num1 - 100);
            int diff2 = Math.Abs(num2 - 100);
            if (diff1 > diff2)
            {
                int result = num2;
                Console.WriteLine("1.input:{0},{1} \nresult:{2}", num1, num2, result);
            }
            else if ((diff1 < diff2))
            {
                int result = num1;
                Console.WriteLine("2.input:{0},{1} \nresult:{2}", num1, num2, result);
            }
            else
            {
                int result = 0;
                Console.WriteLine("3.input:{0},{1} \nresult:{2}", num1, num2, result);
            }
        }


        static void Q20(int num1, int num2)
        {
            Console.WriteLine("20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.");
            bool result = (((40 <= num1 && num1 <= 50) && (40 <= num2 && num2 <= 50)) || ((50 <= num1 && num1 <= 60) && (50 <= num2 && num2 <= 60)));
            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, num2, result);

        }


        static void Q21(int num1, int num2)
        {
            Console.WriteLine("21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.");
            int result = 0;
            if (((20 <= num1 && num1 <= 30) && (20 <= num2 && num2 <= 30)))
            {
                result = Math.Max(num1, num2);

            }
            else
            {
                result = 0;
            }

            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, num2, result);


        }


        static void Q22(string inpString)
        {
            Console.WriteLine("22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.");
            int count = inpString.Count(c => c == 'z');
            bool result = 2 <= count && count <= 4;
            Console.WriteLine("input:{0} \nresult:{1}", inpString, result);
        }



        static void Q23(int num1, int num2)
        {
            Console.WriteLine("23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.");
            bool result = num1 % 10 == num2 % 10;
            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, num2, result);
        }


        static void Q24(string inpString) {
            Console.WriteLine("24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. " +
                "If the length of the string is less than 3, then uppercase all the characters.");
            string result = "";
            if (inpString.Length < 3)
            {
                result = inpString.ToUpper();
            }
            else
            {
                string part2 = inpString.Substring(inpString.Length - 3, 3).ToUpper();
                string part1 = inpString.Substring(0, inpString.Length - 3);
                result = part1 + part2;
            }

            Console.WriteLine("input:{0} \nresult:{1}", inpString, result);

        }


        static void Q25(int num1, string inpString)
        {
            Console.WriteLine("25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.");
            string result = string.Concat(Enumerable.Repeat(inpString, num1));
            Console.WriteLine("input:{0},{1} \nresult:{2}", num1, inpString, result);
        }

        static void Q26(int num1, int num2)
        {
            Console.WriteLine("1. Write a C# Sharp program to accept two integers and check whether they are equal or not.");
            string result = num1 == num2 ? "are equal" : "are not equal";

            Console.WriteLine("input:{0},{1} \nresult:{2} and {3} {4}", num1, num2, num1, num2, result);
        }



        static void Q27(int num1)
        {
            Console.WriteLine("2. Write a C# Sharp program to check whether a given number is even or odd.");
            string result = num1 % 2 == 0 ? "Even" : "Odd";
            {
                Console.WriteLine("input:{0} \nresult:{1}", num1, result);
            }


        }


        static void Q28(int num1)
        {
            int sign = Math.Sign(num1);
            string result = sign == 0 ? "sign-less" : sign == -1 ? "negative" : "positive";
            Console.WriteLine("input:{0} \nresult:{0} is a {1} number", num1, result);

        }




        static void Q29(int num1)
        {
            Console.WriteLine("4. Write a C# Sharp program to find out whether a given year is a leap year or not.");
            string result = DateTime.IsLeapYear(num1) ? "is leap year" : "is not leap year";
            Console.WriteLine("input:{0} \nresult:{0} {1}", num1, result);
        }


        static void Q30(int num1)
        {

            Console.WriteLine("5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.");
            string result = num1 >= 18 ? "Congratulation! You are eligible for casting your vote." : "You aren't eligible to cast your vote";
            Console.WriteLine("input:{0} \nresult:{1}", num1, result);
        }

        static void Q31(int num1)
        {
            Console.WriteLine("6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.");
            int result = Math.Sign(num1);
            Console.WriteLine("input:{0} \nresult:{1} ", num1, result);
        }


        static void Q32(int num1)
        {
            Console.WriteLine("7. Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.");
            string result = num1 <= 135 ? "The person is Dwarf " : "The person is not Dwarf";
            Console.WriteLine("input:{0} \nresult:{1} ", num1, result);
        }
        static void Q33()
        {
            Console.WriteLine("8. Write a C# Sharp program to find the largest of three numbers.");

            Console.WriteLine("input num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input num3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result = Math.Max(Math.Max(num1, num2), num3);
            //Console.WriteLine("input:{0} \nresult:{1} ", num1, result);}

            var list = new Dictionary<string, int>
            {
                { "1st" ,num1  }, { "2nd",num2 }, { "3rd",num3 }};

            var maxValue = list.Values.Max();
            var maxKey = list.Keys.FirstOrDefault(k => list[k] == maxValue);
            Console.WriteLine("The " + maxKey + " Number is the greatest among three");
        }

        static void Q34(double x, double y)
        {
            Console.WriteLine("9. Write a C# Sharp program to accept a coordinate point in an XY " +
                "coordinate system and determine in which quadrant the coordinate point lies.");
            string xSign = Convert.ToString(Math.Sign(x));
            string ySign = Convert.ToString(Math.Sign(y));
            string finalSign = xSign + ySign;

            switch (finalSign)
            {
                case ("11"):
                    Console.WriteLine("The coordinate point ({0}, {1}) lies in the First quadrant", x, y);
                    break;
                case ("-11"):
                    Console.WriteLine("The coordinate point ({0}, {1}) lies in the Second quadrant", x, y);
                    break;
                case ("-1-1"):
                    Console.WriteLine("The coordinate point ({0}, {1}) lies in the Third quadrant", x, y);
                    break;
                case ("1-1"):
                    Console.WriteLine("The coordinate point ({0}, {1}) lies in the Fourth quadrant", x, y);
                    break;

            }


        }

        static void Q35()
        {
            Console.WriteLine("10. Write a C# Sharp program to determine the eligibility for admission to a professional " +
                "course based on the following criteria:");

            Console.WriteLine("input math score:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input phys score:");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input chem score:");
            int chem = Convert.ToInt32(Console.ReadLine());
            string result = "";

            if (math + phy + chem >= 180)
            {
                result = "The candidate is eligible for admission.";
            } else
            {
                result = "The candidate is not eligible for admission.";
            }
            Console.WriteLine(result);
        }


        static void Q36(int a, int b, int c)
        {
            Console.WriteLine("11. Write a C# Sharp program to calculate the root of a quadratic equation.");

            string result = "";
            double root1 = 0;
            double root2 = 0;
            if (4 * a * c > Math.Pow(b, 2))
            {
                result = "Root are imaginary; No Solution.";
                Console.Write(result);

            }
            else
            {
                root1 = -b + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                root2 = -b - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.Write("Root#1: {0} \nRoot#2:{1}", root1, root2);
            }

        }

        static void Q37()
        {
        
            Console.WriteLine("12. Write a C# Sharp program to read roll no, name and marks of " +
                "three subjects and calculate the total, percentage and division.");
            Console.WriteLine("Input the Roll Number of the student:");
            int roll= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the name of the student:");
            string name = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application");
            string marks = Console.ReadLine();
            string[] marksArr = marks.Split(' ');
            int phy = Convert.ToInt32(marksArr[0]);
            int chm = Convert.ToInt32(marksArr[1]);
            int cap = Convert.ToInt32(marksArr[2]);
            double total = phy + chm + cap;
            double percentage = total / 3;
            string division = percentage >= 80? "First" : "Not First";
            Console.WriteLine("Roll No: {0} \nName of Student: {1}\nMarks in Physics: {2}\nMarks in Chemistry: {3}" +
                "\nMarks in Computer Application: {4}\nTotal Marks: {5}\nPercentage: {6}\nDivision: {7}", 
                roll, name, phy, chm, cap, total, percentage, division);

        }


        static void Q38(int num)
        {
            Console.WriteLine("13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state");
            string result = "";
            if (num < 0)
            {
                result = "Freezing weather";
            } 
            else if (num>=0 && num <= 10)
            {
                result = "Very Cold weather";
            }
            else if (num >10 && num <= 20)
            {
                result = "Cold weather";
            }
            else if (num >20 && num <= 30)
            {
                result = "Its Hot";
            }
            else if (num >= 40)
            {
                result = "Its very Hot";

            }

            Console.WriteLine("input:{0}\nresult:{1}", num, result);

        }


        static void Q39()
        {


            Console.WriteLine("14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.");
            Console.WriteLine("Input the sides measures spearated by space:");
            string sides = Console.ReadLine();
            string[] sidesArr = sides.Split(' ');
            var check  = sidesArr.Distinct().Count();
            string result = check <= 2 ? "Isosceles" : "Scalene";
            Console.WriteLine("Result: {0}", result);


        }


        static void Q40()
        {
            Console.WriteLine("15.Write a C# Sharp program to check whether a triangle can be formed by the given angles value.");
            Console.WriteLine("Enter angles values seprataed by spaces:");
            string sides = Console.ReadLine();
            string[] sidesArr = sides.Split(' ');
            int[] integers = Array.ConvertAll(sidesArr, int.Parse);
            string result = integers.Sum() == 180 ? "The triangle is valid." : "The triangle is not valid.";
            Console.WriteLine("result:{0}", result);
        }


        static void Q41(char letter)
        {
            Console.WriteLine(" 16.Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string result = vowels.Contains(Char.ToLower(letter)) ? "The alphabet is a vowel" : "The alphabet is a consonant";
            Console.WriteLine("input:{0}\nresult:{1}", letter, result);

        }

        static void Q42(int num1, int num2)
        {
            Console.WriteLine("17. Write a C# Sharp program to calculate profit and loss on a transaction.");
            int result = num2 - num1;
            Console.WriteLine("Input:{0}, {1}\nresult:you can book your profit at{2}", num1, num2, result);
        }


        static void Q43()
        {
            Console.WriteLine("18. Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, " +
                "ID, and unit consumed should be taken and displayed along with the total amount due.The charge are as follow :");

            Console.WriteLine("Enter customer ID:");
            int customerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer Name:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter units consumed:");
            int unitsConsumed= Convert.ToInt32(Console.ReadLine());
            double baseCost = 0;
            double surchargeAmount = 0;
            double amountPerUnit = 0;
            if (unitsConsumed <= 199)
            {
                amountPerUnit = 1.2;
                baseCost = unitsConsumed * 1.2;
            } else if (unitsConsumed>199 && unitsConsumed < 400)
            {
                amountPerUnit = 1.5;
                baseCost = unitsConsumed * 1.5;
            } else if (unitsConsumed>= 400 && unitsConsumed < 600)
            {   
                amountPerUnit = 1.8;
                baseCost = unitsConsumed * 1.8;
            } else if (unitsConsumed >= 600)
            {
                amountPerUnit = 2;
                baseCost = unitsConsumed * 2;
            }

            int surchargFlag = baseCost > 400 ? 1 : 0;
            surchargeAmount = surchargFlag * 0.15 * baseCost;
            double modifiedCost = baseCost + surchargeAmount;

            Console.WriteLine("Customer IDNO: {0}\nCustomer Name: {1}\nUnits consumed:{2}" +
                "\nAmount charged @Rs. {3} per unit: {4}\nSurcharge Amount: {5}\nNet Amount Paid by the Customer: {6}", customerID,
                customerName, unitsConsumed, amountPerUnit, baseCost, surchargeAmount, modifiedCost);
        }


        static void Q44(char mark)
        {
            Console.WriteLine("19. Write a program in C# Sharp to accept a grade and declare the equivalent description:");
            string result = "";
            switch (mark)
            {
                case ('E'):
                    result = "You have chosen: Excellent";
                    break;
                case ('V'):
                    result = "You have chosen: Very Good";
                    break;
                case ('G'):
                    result = "You have chosen: Good";
                    break;
                case ('A'):
                    result = "You have chosen: Average";
                    break;
                case ('F'):
                    result = "You have chosen: Fail";
                    break;
            }
            Console.WriteLine("input: {0}\n result:{1}", mark, result);
        
        }

        static void Q45(int num)
        {
            Console.WriteLine("20. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.");
            List<string> strings = new List<string> { "Sunday", "Saturday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string result = strings[num];
            Console.WriteLine("input:{0}\nresult: {1}", num, result);

        }

        static void Q46(int num)
        {
            Console.WriteLine("21. Write a program in C# Sharp to read any digit, display in the word.");
            List<string> numbers= new List<string> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string result = numbers[num];
            Console.WriteLine("input:{0}\nresult: {1}", num, result);
        }

        static void Q47(int num)
        {
            Console.WriteLine("22. Write C# Sharp program to read any Month Number in integer and display Month name.");
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string result = months[num];
            Console.WriteLine("input:{0}\nresult: {1}", num, result);
        }


        static void Q48(int num)
        {
            Console.WriteLine("23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.");
            int result = DateTime.DaysInMonth(2023, num);
            Console.WriteLine("input:{0}\nresult: Month have {1} days", num, result);
        }

        static void Q49(int choice, double radius)
        {
            Console.WriteLine("24. Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.");
            double result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("input:{0}, {1}\nresult: {2}", choice, radius, result);
        }


        static void Q50()
        {
            Console.WriteLine("1. Write a program in C# Sharp to input a string and print it.");
            Console.WriteLine("Input string:");
            string inputString = Console.ReadLine();
            string result = "The string you entered is :" + inputString;
            Console.WriteLine("input:{0}\nresult: {1}", inputString, result);
        }

        static void Q51(string sentence)
        {
            Console.WriteLine("2. Write a C# Sharp program to find the length of a string without using a library function.");
            char[] letters= sentence.ToCharArray();
            int result = letters.Count();
            Console.WriteLine("input:{0}\nresult: {1}",sentence, result);

        }

        static void Q52(string inpString)
        {
            Console.WriteLine("3. Write a C# Sharp program to separate individual characters from a string.");
            string result = string.Join(" ", inpString.ToCharArray());
            Console.WriteLine("input:{0}\nresult: {1}", inpString, result);
        }


        static void Q53(string inpString)
        {
            Console.WriteLine("4. Write a program in C# Sharp to print individual characters of the string in reverse order.");
            char[] inpStringArr = inpString.ToCharArray();
            Array.Reverse(inpStringArr);
            string result = string.Join(" ", inpStringArr);
            Console.WriteLine("input:{0}\nresult: {1}", inpString, result);
        }



        static void Q54(string inpString)
        {
            Console.WriteLine("5. Write a program in C# Sharp to count the total number of words in a string.");
            string[] inpStringArr = inpString.Split(' ');
            int result = inpStringArr.Length;
            Console.WriteLine("input:{0}\nresult: {1}", inpString, result);
        }

        static void Q55(string inpString1, string inpString2)
        {
            Console.WriteLine("6. Write a program in C# Sharp to compare two strings without using a string library functions.");
            string content = inpString1 == inpString2 ? "The two strings are equal" : "The two strings are not equal";
            string length= inpString1.Length == inpString2.Length ? "The two strings length is equal" : "The two strings length is not equal";
            string result = content + " and " + length;
            Console.WriteLine("input:{0}, {1}\nresult: {2}", inpString1, inpString2, result);

        }


        static void Q56(string inpString)
        {
            Console.WriteLine("7. Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.");
            int digits = 0;
            int chars = 0;
            int specialChar = 0;
            foreach (char c in inpString)
            {
                if (Char.IsDigit(c))
                {
                    digits += 1;
                } else if (Char.IsLetter(c)) {
                    chars += 1;
                } else if (!Char.IsLetterOrDigit(c) && !Char.IsWhiteSpace(c))
                {
                    specialChar += 1;
                }



            }


            Console.WriteLine("input:{0}, \nresult: Number of letters: {1}\nNumber of digits: {2}" +
                "\nNumber of special chars: {3}", inpString, chars, digits, specialChar);

        }

        static void Q57(string inpString)
        {
            Console.WriteLine("8. Write a program in C# Sharp to copy one string to another string.");
            string newString = inpString;
            int result = inpString.ToCharArray().Length;
            Console.WriteLine("First string is: {0}\n Second string is: {1}\n{2} characters copied", 
                inpString, newString,result );

        }

        static void Q58(string inpString)
        {
            Console.WriteLine("9. Write a C# Sharp program to count the number of vowels or consonants in a string.");
            string vowels = "aeiou";
            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach (Char c in inpString)
            {
                if (Char.IsLetter(c) && vowels.Contains(c))
                {
                    vowelsCount += 1;
                } else if ((Char.IsLetter(c) && !vowels.Contains(c)))
                {
                    consonantsCount += 1;
                }

                

            }
            Console.WriteLine("input: {0}\nThe total number of vowel in the string is :{1}" +
                    "\nThe total number of consonant in the string is:{2}", inpString, vowelsCount, consonantsCount);
        }


        static void Q59(string inpString)
        {
            Console.WriteLine("10. Write a C# Sharp program to find the maximum number of characters in a string.");
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char c in inpString)
            {
                if (letters.ContainsKey(c))
                {
                    letters[c]++;
                }

                else
                {

                    letters[c] = 1;

                }
            }

            char keyOfMaxValue = letters.OrderByDescending(x => x.Value).FirstOrDefault().Key;
            int maxValue = letters.OrderByDescending(x => x.Value).FirstOrDefault().Value;

            Console.WriteLine("The Highest frequency of character {0}\nappears number of times : {1}", keyOfMaxValue, maxValue);


        }

        static void Q60(string inpString)
        {
            Console.WriteLine("11. Write a C# Sharp program to sort a string array in ascending order.");
            char[] charArr = inpString.ToCharArray();
            Array.Sort(charArr);
            string result = string.Join("", charArr);
            Console.WriteLine("input:{0}\nresult:{1}",inpString, result);


        }


     
            static void Main(string[] args)

        {

            Q1(20, 30);
            Console.WriteLine("----------------------------------");
            Q2(30);
            Console.WriteLine("----------------------------------");
            Q3(20, 40);
            Console.WriteLine("----------------------------------");
            Q4(20);
            Console.WriteLine("----------------------------------");
            Q5("WINDHAVEN");
            Console.WriteLine("----------------------------------");
            Q6("CYPRESS", 3);
            Console.WriteLine("----------------------------------");
            Q7("ELAINE");
            Console.WriteLine("----------------------------------");
            Q8("ELIA");
            Console.WriteLine("----------------------------------");
            Q9("REEMAN");
            Console.WriteLine("----------------------------------");
            Q10(20);
            Console.WriteLine("----------------------------------");
            Q11("TOYOTA");
            Console.WriteLine("----------------------------------");
            Q12("ATHEER");
            Console.WriteLine("----------------------------------"); 
            Q13(20, 30);
            Console.WriteLine("----------------------------------");
            Q14(20, 30);
            Console.WriteLine("----------------------------------");
            Q15(10, 30, 5);
            Console.WriteLine("----------------------------------");
            Q16(10, 20);
            Console.WriteLine("----------------------------------");
            Q17("ATHEER");
            Console.WriteLine("----------------------------------");
            Q18(10, 20, 30);
            Console.WriteLine("----------------------------------");
            Q19(30, 30);
            Console.WriteLine("----------------------------------");
            Q20(10, 20);
            Console.WriteLine("----------------------------------");
            Q21(10, 30);
            Console.WriteLine("----------------------------------");
            Q22("ATHEER");
            Console.WriteLine("----------------------------------");
            Q23(10, 20);
            Console.WriteLine("----------------------------------");
            Q24("ATHEER");
            Console.WriteLine("----------------------------------");
            Q25(30, "ATHEER");
            Console.WriteLine("----------------------------------");
            Q26(20, 30);
            Console.WriteLine("----------------------------------");
            Q27(30);
            Console.WriteLine("----------------------------------");
            Q28(30);
            Console.WriteLine("----------------------------------");
            Q29(2002);
            Console.WriteLine("----------------------------------");
            Q30(20);
            Console.WriteLine("----------------------------------");
            Q31(10);
            Console.WriteLine("----------------------------------");
            Q32(10);
            Console.WriteLine("----------------------------------");
            Q33();
            Console.WriteLine("----------------------------------");
            Q34(20, 30);
            Console.WriteLine("----------------------------------");
            Q35();
            Console.WriteLine("----------------------------------");
            Q36(10, 20, 30);
            Console.WriteLine("----------------------------------");
            Q37();
            Console.WriteLine("----------------------------------");
            Q38(10);
            Console.WriteLine("----------------------------------");
            Q39();
            Console.WriteLine("----------------------------------");
            Q40();
            Console.WriteLine("----------------------------------");
            Q41('A');
            Console.WriteLine("----------------------------------");
            Q42(10, 20);
            Console.WriteLine("----------------------------------");
            Q43();
            Console.WriteLine("----------------------------------");
            Q44('E');
            Console.WriteLine("----------------------------------");
            Q45(5);
            Console.WriteLine("----------------------------------");
            Q46(9);
            Console.WriteLine("----------------------------------");
            Q47(10);
            Console.WriteLine("----------------------------------");
            Q48(10);
            Console.WriteLine("----------------------------------");
            Q49(1, 33);
            Console.WriteLine("----------------------------------");
            Q50();
            Console.WriteLine("----------------------------------");
            Q51("I WENT TO THE PARK");
            Console.WriteLine("----------------------------------");
            Q52("A HIPPO IS A DANGEROUS ANIMAL");
            Console.WriteLine("----------------------------------");
            Q53(" A SHARK A DANGEOURS ANIMAL");
            Console.WriteLine("----------------------------------");
            Q54("MY NAME IS ATHEER");
            Console.WriteLine("----------------------------------");
            Q55("I DRIVE A CAR", " MY CAR IS RED");
            Console.WriteLine("----------------------------------");
            Q55("I DRIVE A CAR", "I DRIVE A CAR");
            Console.WriteLine("----------------------------------");
            Q56("I LIVE IN HOUSTON!!");
            Console.WriteLine("----------------------------------");
            Q57("WEATHER IS GOOD");
            Console.WriteLine("----------------------------------");
            Q58("TEXAS IS A US STATE");
            Console.WriteLine("----------------------------------");
            Q59("IRAQI AND PROUD");
            Console.WriteLine("----------------------------------");
            Q60("BAGHDAD");
        }
    }
}
    