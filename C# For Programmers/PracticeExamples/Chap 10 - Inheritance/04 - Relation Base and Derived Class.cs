using System;

public class CommissionEmployee : Object
{
   /* Instance variables */
   private string firstName;
   private string lastName;
   private string socialSecurityNumber;
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
      set { CommissionRate = ((value > 0) && (value < 1)) ? value : 0; }

   }//end property CommissionRate

   /* Methods */

   // calculate commission employee's pay
   public decimal Earnings()
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

