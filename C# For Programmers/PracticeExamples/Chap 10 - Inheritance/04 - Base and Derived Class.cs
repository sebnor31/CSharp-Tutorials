/* A derived class is a class than inherits members from a base class.
 * In our exple, CommissionEmployee is derived from Object class.
 * Object class is the lowest one in C#, all classes implicitly derive from it.
 * 
 * "virtual" access modifier enables a method to be override by derived classes.
 * 
 * "protected" enables derived class to access instance variables, but still remain unaccessible for other classes.
 * 
 * "M" is a suffix used to treat the value as a decimal rather than double. It is NOT a million-scaling factor, only data conversion.
 */

using System;

public class BasePlusCommissionEmployeeTest
{
   public static void Main()
   {
      BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee("Nordine", "Sebkhi", "999-99-9999", 5000.00M, 0.06M, 300.00M);

      Console.WriteLine("Employee info obtained by properties and methods: \n");
      Console.WriteLine("{0} {1}", "First name is", employee.FirstName);
      Console.WriteLine("{0} {1}", "Last name is", employee.LastName);
      Console.WriteLine("{0} {1}", "SSN is", employee.SocialSecurityNumber);
      Console.WriteLine("{0} {1:C}", "Gross sale is", employee.GrossSales);
      Console.WriteLine("{0} {1:F2}", "Commission rate is", employee.CommissionRate);
      Console.WriteLine("{0} {1:C}", "Earnings are", employee.Earnings());
      Console.WriteLine("{0} {1:C}", "Base salary is", employee.BaseSalary);

      employee.BaseSalary = 100.00M; 

      Console.WriteLine("\n{0}:\n\n{1}", "Updated employee info obtained by ToString", employee);
      Console.WriteLine("Earnings: {0:C}", employee.Earnings());

      Console.ReadLine();

   }// end class Main

}// end class CommissionEmployeeTest


// "CommissionEmployee" is derived from base class "Object", but will also be base class of "BasePlusCommissionEmployee"
public class CommissionEmployee : Object
{
   /* Instance variables */
   protected string firstName;            // this instance variable can be directly access by derived classes
   protected string lastName;             // this instance variable can be directly access by derived classes
   private string socialSecurityNumber;   // However, this one cannot has it is declared private
   private decimal grossSales;      // gross weekly sales
   private decimal commissionRate;  // commmision percentage

   /* Constructor */
   public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
   {
      firstName = first;
      lastName = last;
      socialSecurityNumber = ssn;
      GrossSales = sales;     // validate via property
      CommissionRate = rate;  // validate via property
   }// end constructor CommissionEmployee

   /* Properties */
   // Read-Only
   public string FirstName
   {
      get { return firstName; }
   }//end property FirstName

   public string LastName
   {
      get { return lastName; }
   }//end property LastName

   public string SocialSecurityNumber
   {
      get { return socialSecurityNumber; }
   }//end property SocialSecurityNumber

   // Non Read-Only
   public decimal GrossSales
   {
      get { return grossSales; }
      set { grossSales = (value < 0) ? 0 : value ;}

   }//end property GrossSales

   public decimal CommissionRate
   {
      get { return commissionRate; }
      set { commissionRate = ((value > 0) && (value < 1)) ? value : 0; }

   }//end property CommissionRate

   /* Methods */

   // calculate commission employee's pay
   // VIRTUAL is used to allow the method to be override in derived class
   public virtual decimal Earnings()
   {
      return commissionRate * grossSales;
   }//end method Earnings

   // return string representation of CommissionEmployee object
   public override string ToString()
   {
      return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}","commission employee", FirstName, LastName,
         "social security number", SocialSecurityNumber, 
         "gross sales", GrossSales, "commission rate", CommissionRate);
   }//end method ToString

}//end class CommissionEmployee


// BasePlusCommissionEmployee inherits from CommissionEmployee
public class BasePlusCommissionEmployee : CommissionEmployee
{
   /* Augmented Instance variables */
   private decimal baseSalary;

   /* Augmented Constructor */
   // Calls base class constructor
   public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
      : base(first, last, ssn, sales, rate)
   {
      BaseSalary = salary;
   }

   /* Augmented Property */
   public decimal BaseSalary
   {
      get { return baseSalary; }
      set { baseSalary = (value < 0) ? 0 : value; }
   }//end property BaseSalary

   /* Override Methods */
   // Earnings can be override because virtual access modifier is used in its base class definition
   public override decimal Earnings()
   {
      /* NOT ALLOWED: commissionRate and grossSales private in base class
      return baseSalary + (commissionRate * grossSales);
       */

      // ALLOWED: accessing public properties
      //return BaseSalary + (CommissionRate * GrossSales);

      // Better Practice: Re-using base methods
      return BaseSalary + base.Earnings();

   }//end method Earnings

   // ToString is already overriden in the base class, so this property is inherited
   public override string ToString()
   {
      return string.Format(
         "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
         "base-salaried commission employee", firstName, lastName,
         /* NOT ALLOWED: attempt to access private base class members
         "SSN", SocialSecurityNumber,
         "gross sales", grossSales, "commission rate", commissionRate,
          */
         // ALLOWED: accessing public properties
         "SSN", SocialSecurityNumber,
         "gross sales", GrossSales, "commission rate", CommissionRate,
         "base salary", BaseSalary);

   }//end method ToString

}//end class BasePlusCommissionEmployee
