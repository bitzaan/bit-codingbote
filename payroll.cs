//this is a c# project that creates a payroll
using System;

namespace PayrollCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employee name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter number of days worked: ");
            int daysWorked = Convert.ToInt32(Console.ReadLine());

            const int rate = 1000; 

           
            int basicPay = daysWorked * rate;

            
            double houseAllowance = basicPay * 0.03;
            double transportAllowance = basicPay * 0.02;
            double medicalAllowance = basicPay * 0.015;

           
            double grossPay = basicPay + houseAllowance + transportAllowance + medicalAllowance;

         
            double payeDeductions = grossPay * 0.05;
            double shifDeductions = grossPay * 0.06;
            double nhifDeductions = grossPay * 0.02;

         
            double netPay = grossPay - payeDeductions - shifDeductions - nhifDeductions;

            
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Employee Name: {employeeName}");
            Console.WriteLine($"Basic Pay: {basicPay} shillings");
            Console.WriteLine($"Transport Allowance: {transportAllowance} shillings");
            Console.WriteLine($"House Allowance: {houseAllowance} shillings");
            Console.WriteLine($"Medical Allowance: {medicalAllowance} shillings");
            Console.WriteLine($"PAYE Deductions: {payeDeductions} shillings");
            Console.WriteLine($"SHIF Deductions: {shifDeductions} shillings");
            Console.WriteLine($"NHIF Deductions: {nhifDeductions} shillings");
            Console.WriteLine($"Net Pay: {netPay} shillings");

            Console.ReadLine();
        }
    }
}