namespace AspNetMVCInterviewAssignment.Models;

public class CustomerOrder 
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public string? Description { get; set; }
    public decimal Total { get; set; }

    public string s { get 
        {
            return Total.ToString();
        }
    }
    public string Curr { get
        {
            return string.Format("{0:0.00}", Convert.ToDecimal(s) * 1);
        }
    }
}