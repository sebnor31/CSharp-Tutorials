/* 
 */

using System;

public class ConstructorTest
{
   public static void Main()
   {
      CommissionEmployeeConst employee1 = new CommissionEmployeeConst("Nordine", "Sebkhi", "999-99-9999", 5000.00M, 0.04M);

      Console.WriteLine();

      BasePlusCommissionEmployeeConst employee2 = new BasePlusCommissionEmployeeConst("Jean", "Valjean", "111-99-9999", 2000.00M, 0.06M, 800.00M);

      Console.WriteLine();

      BasePlusCommissionEmployeeConst employee3 = new BasePlusCommissionEmployeeConst("Olive", "Tom", "222-99-9999", 8000.00M, 0.15M, 2000.00M);

      Console.ReadLine();
   }// end class Main

}// end class CommissionEmployeeTest

public class CommissionEmployeeConst
{
   /* Instance variables */
   private string firstName;           
   private string lastName;             
   private string socialSecurityNumber;   
   private decimal grossSales;      
   private decimal commissionRate; 

   /* Constructor */
   public CommissionEmployeeConst(string first, string last, string ssn, decimal sales, decimal rate)
   {
      // Implicit call to "object" constructor occurs here
      firstName = first;
      lastName = last;
      socialSecurityNumber = ssn;
      GrossSales = sales;     // validate via property
      CommissionRate = rate;  // validate via property

      Console.WriteLine("\nCommissionEmployeeConst constructor:\n" + this);   //"this" implicitly calls for ToString method
   }// end constructor CommissionEmployeeConst

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
   public virtual decimal Earnings()
   {
      return CommissionRate * GrossSales;
   }//end method Earnings

   // return string representation of CommissionEmployee object
   public override string ToString()
   {
      return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
         "commission employee", FirstName, LastName,
         "social security number", SocialSecurityNumber, 
         "gross sales", GrossSales, "commission rate", CommissionRate);
   }//end method ToString

}//end class CommissionEmployeeConst

public class BasePlusCommissionEmployeeConst : CommissionEmployeeConst
{
   /* Augmented Instance variables */
   private decimal baseSalary;

   /* Augmented Constructor */
   public BasePlusCommissionEmployeeConst(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
      : base(first, last, ssn, sales, rate)
   {
      BaseSalary = salary;
      Console.WriteLine("\nBasePlusCommissionEmployeeConst constructor:\n" + this); //"this" implicitly calls for ToString method
   }

   /* Augmented Property */
   public decimal BaseSalary
   {
      get { return baseSalary; }
      set { baseSalary = (value < 0) ? 0 : value; }
   }//end property BaseSalary

   /* Override Methods */

   public override decimal Earnings()
   {
      return BaseSalary + base.Earnings();
   }//end method Earnings

   public override string ToString()
   {
      return string.Format(
         "{0} {1}\n{2}: {3:C}",
         "base-salaried", base.ToString(),
         "base salary", BaseSalary);

   }//end method ToString

}//end class BasePlusCommissionEmployeeConst
