/* Polymorphism is used to create a general structure that is flexible to plug-in new object types without modifying much the application.
 * 
 * "Abstract" classes are used to create class blueprints but cannot be instantiated. 
 * In the other hand, "Concrete" classes are fully-implemented derived classes of abstract classes, and designed to be instantiated.
 * 
 * Abstract methods force derived classes to create their implementation. Therefore, abstract methods do not have a body and cannot be called.
 * It is different than Virtual as the derived will likely have different implementation, thus having an inherited implementation does not make sense.
 */

using System;

namespace Chap_11 { 
   
   // Test Application
   public class PayrollSystemTest
   {
      public static void Main()
      {
         SalariedEmployee salariedEmployee = new SalariedEmployee("Nordine", "Sebkhi", "123", 800.00M);
         HourlyEmployee hourlyEmployee = new HourlyEmployee("Marwan", "Chawqi", "456", 16.75M, 40.0M);
         CommissionEmployee commissionEmployee = new CommissionEmployee("Joanna", "Bensliman", "789", 10000.00M, 0.06M);
         BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Victor", "Kapdebon", "1011", 5000.00M, 0.04M, 300.00M);

         // Employee Processed Individually
         Console.WriteLine("Employees processed individually:\n");
         Console.WriteLine("{0}\n{1} : {2:C}\n", salariedEmployee, "earned", salariedEmployee.Earnings());
         Console.WriteLine("{0}\n{1} : {2:C}\n", hourlyEmployee, "earned", hourlyEmployee.Earnings());
         Console.WriteLine("{0}\n{1} : {2:C}\n", commissionEmployee, "earned", commissionEmployee.Earnings());
         Console.WriteLine("{0}\n{1} : {2:C}\n", basePlusCommissionEmployee, "earned", basePlusCommissionEmployee.Earnings());

         // Create four-element Employee array
         Employee[] employees = new Employee[4];

         // Initialize Array
         employees[0] = salariedEmployee;
         employees[1] = hourlyEmployee;
         employees[2] = commissionEmployee;
         employees[3] = basePlusCommissionEmployee;

         // Employee Processed Polymorphically
         Console.WriteLine("Employees processed polymorphically:\n");

         foreach (Employee currentEmployee in employees)
         {
            Console.WriteLine(currentEmployee);

            // Add bonus (10%) to BasePlusCommission Employees 
            if (currentEmployee is BasePlusCommissionEmployee)
            {
               // Downcast Employee reference to BasePlusCommissionEmployee reference
               // This is needed to access the BaseSalary property
               BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee) currentEmployee;

               // Add bonus
               employee.BaseSalary *= 1.10M;
               Console.WriteLine("New base salary with 10% increase is: {0:C}", employee.BaseSalary);

            }//end if

            Console.WriteLine("earned {0:C}\n", currentEmployee.Earnings());
         }//end foreach

         // Get type name of each object in employees array
         for (int j = 0; j < employees.Length; j++)
            Console.WriteLine("Employee {0} is a {1}", j, employees[j].GetType());
         
         Console.ReadLine();
      }//end method Main

   }//end class PayrollSystem


   // Abstract base class Employee
   public abstract class Employee
   {
      /* Instance Variables */
      private string firstName;
      private string lastName;
      private string socialSecurityNumber;

      /* Constructor */
      public Employee(string first, string last, string ssn)
      {
         /* Properties cannot be used to set values as they are read-only */
         firstName = first;
         lastName = last;
         socialSecurityNumber = ssn;
      }//end constructor Employee

      /* Properties */
      public string FirstName
      {
         get { return firstName; }
      }// end read-only property FirstName

      public string LastName
      {
         get { return lastName; }
      }// end read-only property LastName

      public string SocialSecurityNumber
      {
         get { return socialSecurityNumber; }
      }// end read-only property SocialSecurityNumber

      /* Methods */
      public override string ToString()
      {
         return string.Format("{0} {1}\nSSN: {2}", FirstName, LastName, SocialSecurityNumber);
      }//end method ToString

      // Abstract methods cannot have a body
      public abstract decimal Earnings();

   }//end class Employee

   // Salaried-Employee
   public class SalariedEmployee : Employee
   {
      /* Enhanced Instance variables */
      private decimal weeklySalary;

      /* Enhanced Constructor */
      public SalariedEmployee(string first, string last, string ssn, decimal salary)
         : base(first, last, ssn)
      {
         WeeklySalary = salary;  // Validate salary through property
 
      }//end constructor SalariedEmployee

      /* Enhanced Property */
      public decimal WeeklySalary
      {
         get { return weeklySalary; }
         set { weeklySalary = (value >= 0) ? value : 0;}  // Validation

      }//end property WeeklySalary

      /* Enhanced Methods */
      // Override abstract base method
      public override decimal Earnings()
      {
         return WeeklySalary;
      }//end method Earnings

      public override string ToString()
      {
         return string.Format("Salaried employee: {0}\n{1}: {2:C}",
            base.ToString(), "Weekly Salary", WeeklySalary );
      }//end method ToString

   }//end class SalariedEmployee

   // Hourly Employee
   public class HourlyEmployee : Employee
   {
       /* Enhanced Instance variables */
      private decimal wage;
      private decimal hours;

      /* Enhanced Constructor */
      public HourlyEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked)
         : base(first, last, ssn)
      {
         Wage = hourlyWage;
         Hours = hoursWorked; 
 
      }//end constructor HourlyEmployee

      /* Enhanced Property */
      public decimal Wage
      {
         get { return wage; }
         set { wage = (value >= 0) ? value : 0;}  // Validation
      }//end property Wage

      public decimal Hours
      {
         get { return hours; }
         set { hours = ( (value >= 0) && (value <= 168) ) ? value : 0; }  // Validation
      }//end property Hours

      /* Enhanced Methods */
      // Override abstract base method
      public override decimal Earnings()
      {
         // No overtime
         if (Hours <= 40)
            return Hours * Wage;
         // Overtime
         else
            return (40*Wage) + ( (Hours-40) * Wage * 1.5M);

      }//end method Earnings

      public override string ToString()
      {
         return string.Format("Hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}",
            base.ToString(), 
            "Hourly wage", Wage,
            "hours worked", Hours );
      }//end method ToString

   }//end class HourlyEmployee

   // Commission Employee
   public class CommissionEmployee : Employee
   {
      /* Enhanced Instance variables */
      private decimal grossSales;
      private decimal commissionRate;

      /* Enhanced Constructor */
      public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
         : base(first, last, ssn)
      {
         GrossSales = sales;
         CommissionRate = rate;

      }//end constructor CommissionEmployee

      /* Enhanced Property */
      public decimal GrossSales
      {
         get { return grossSales; }
         set { grossSales = (value >= 0) ? value : 0; }  // Validation
      }//end property GrossSales

      public decimal CommissionRate
      {
         get { return commissionRate; }
         set { commissionRate = ((value >= 0) && (value < 1)) ? value : 0; }  // Validation
      }//end property CommissionRate

      /* Enhanced Methods */
      // Override abstract base method
      public override decimal Earnings()
      {
         return CommissionRate * GrossSales;
      }//end method Earnings

      public override string ToString()
      {
         return string.Format("Commission employee: {0}\n{1}: {2:C}\n{3}: {4:F2}",
            base.ToString(),
            "gross sales", GrossSales,
            "commission rate", CommissionRate );
      }//end method ToString

   }//end class CommissionEmployee

   // Base + Commission Employee
   public class BasePlusCommissionEmployee : CommissionEmployee
   {
      /* Enhanced Instance variables */
      private decimal baseSalary;

      /* Enhanced Constructor */
      public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
         : base(first, last, ssn, sales, rate)
      {
         BaseSalary = salary;
      }//end constructor BasePlusCommissionEmployee

      /* Enhanced Property */
      public decimal BaseSalary
      {
         get { return baseSalary; }
         set { baseSalary = (value >= 0) ? value : 0; }  // Validation
      }//end property BaseSalary

      /* Enhanced Methods */
      // Override abstract base method
      public override decimal Earnings()
      {
         return BaseSalary + base.Earnings();
      }//end method Earnings

      public override string ToString()
      {
         return string.Format("base-salaried: {0} ; {1}: {2:C}",
            base.ToString(),
            "base salary", BaseSalary );
      }//end method ToString

   }//end class BasePlusCommissionEmployee

}//end namespace Chap_11