namespace AspNetMVCInterviewAssignment.Models;

public class CustomerViewModel 
{
    public int CustomerNumber {get; set;}

       
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string FullName {get {
        return FirstName + " " + LastName;
        }
    }
    public List<CustomerOrder> Orders {get; set;}

}
