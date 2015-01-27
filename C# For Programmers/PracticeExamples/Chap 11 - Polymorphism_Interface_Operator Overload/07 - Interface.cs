/* Interfaces are set of common methods used by unrelated classes. An interface is firstly declared in an abstract way, then implementation is provided by
 * the client class.
 * It is used instead of an abstract class when there is no default implementations to inherit.
 * Because they are also public, they tend to be declared in its own .cs file. 
 * 
 * If a base class declare an interface, all derived classes will inherit. No need to re-declare.
 * If the base class is abstract, then the interface methods can be declared as abstract and implementation provided in derived classes. 
 * 
 * By convention, interfaces starts with an "I".
 */

using System;

namespace Chap_11_Interface
{

   // Test Application
   public class PayableInterfaceTest
   {
      public static void Main()
      {
         /* Create a 4-elt IPayable Array */
         IPayable[] payableObjects = new IPayable[4];

         /* Populate array with objects that implement IPayable */
         payableObjects[0] = new Invoice("01234", "seat", 2, 375.00M) ;
         payableObjects[1] = new Invoice("56789", "tire", 4, 79.95M);
         payableObjects[2] = new SalariedEmployee("Nordine", "Sebkhi", "111-11-1111", 800.00M);
         payableObjects[3] = new SalariedEmployee("Marwan", "Chawqi", "222-22-2222", 1200.00M);

         Console.WriteLine("Invoices and Employees processed polymorphically:\n");

         /* Generically process each element in array payableObjects */
         foreach (IPayable currentPayable in payableObjects)
         {
            Console.WriteLine("{0} \n{1}: {2:C}\n", currentPayable, "payment due", currentPayable.GetPaymentAmount());
         }//end foreach

         Console.ReadLine();

      }//end method Main

   }//end class PayableInterfaceTest

   /***** Interface *****/
   public interface IPayable
   {
      decimal GetPaymentAmount();   //Calculate payment; no implementation
   }//end interface IPayable

   /***** Class *****/
   public class Invoice : IPayable
   {
      /*** Instance variable ***/
      private string partNumber;
      private string partDescription;
      private int quantity;
      private decimal pricePerItem;

      /*** Constructor ***/
      public Invoice(string part, string description, int count, decimal price)
      {
         PartNumber = part;
         PartDescription = description;
         Quantity = count;
         PricePerItem = price;

      }//end constructor Invoice

      /*** Properties ***/
      public string PartNumber
      {
         get { return partNumber; }
         set { partNumber = value; }
      }//end property PartNumber

      public string PartDescription
      {
         get { return partDescription; }
         set { partDescription = value; }
      }//end property PartDescription
      public int Quantity
      {
         get { return quantity; }
         set { quantity = (value >= 0) ? value : 0 ; }
      }//end property Quantity
      public decimal PricePerItem
      {
         get { return pricePerItem; }
         set { pricePerItem = (value >= 0) ? value : 0; }
      }//end property PricePerItem

      /*** Methods ***/
      public override string ToString()
      {
         return string.Format("{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}",
            "invoice", "part number", PartNumber, PartDescription,
            "quantity", Quantity, "price per item", PricePerItem) ;
      }//end method ToString
 
      // Method required to carry out contract with interface IPayable
      public decimal GetPaymentAmount()
      {
 	      return Quantity * PricePerItem;  // Calculate Total cost
      }//end method GetPaymentAmount

   }//end class Invoice

   public abstract class Employee : IPayable
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

      // Note: We do not implement IPayable method here so this class must be declared abstract to avoid compilation error
      public abstract decimal GetPaymentAmount();

   } //end class Employee

   public class SalariedEmployee : Employee
   {
      /*** Instance variables ***/
      private decimal weeklySalary;

      /*** Constructor ***/
      public SalariedEmployee(string first, string last, string ssn, decimal salary)
         : base(first, last, ssn)
      {
         WeeklySalary = salary;  // Validate salary through property
      }//end constructor SalariedEmployee

      /*** Property ***/
      public decimal WeeklySalary
      {
         get { return weeklySalary; }
         set { weeklySalary = (value >= 0) ? value : 0; }  // Validation
      }//end property WeeklySalary

      /*** Methods ***/
      // Implement Interface method
      public override decimal GetPaymentAmount()
      {
         return WeeklySalary;
      }//end method GetPaymentAmount

      public override string ToString()
      {
         return string.Format("Salaried employee: {0}\n{1}: {2:C}",
            base.ToString(), "Weekly Salary", WeeklySalary);
      }//end method ToString

   }//end class SalariedEmployee

}//end namespace Chap_11