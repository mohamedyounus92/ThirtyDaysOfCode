using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfCode.Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            testScores = scores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            char result = 'T';
            int sum = 0;
            foreach (int mark in testScores)
                sum += mark;
            int average = sum / (testScores.Length);
            if (100 >= average && average >= 90)
                result = 'O';
            else if (90 >= average && average >= 80)
                result = 'E';
            else if (80 >= average && average >= 70)
                result = 'A';
            else if (70 >= average && average >= 55)
                result = 'P';
            else if (55 >= average && average >= 40)
                result = 'D';
            else if (40 > average)
                result = 'T';

            return result;
        }
    }
    class Solution
    {
        public void solve()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadKey();
        }
    }
}
