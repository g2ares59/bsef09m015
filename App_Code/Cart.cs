using System; 
using System.Collections.Generic; 
using System.Web; 


public class CartItem 
{ 
public int ProductID { get; set; } 
public string Size { get; set; } 
public decimal Price { get; set; } 
} 

public class Cart 
{ 
   
   
private List<CartItem> _Items = new List<CartItem>(); 
static private decimal totalpri=0;
public List<CartItem> Items { get { return _Items; } } 
public decimal TotalValue { get { return totalpri; } } 
public void AddItem(int productID, string size, decimal price) 
{ 
_Items.Add( new CartItem { ProductID = productID, Size = size, Price = price } ); 
  totalpri=totalpri+price;
} 
public void Clear() 
{ 
_Items.Clear(); 

} 
public void RemoveItem(int index) 
{ 
totalpri=totalpri-(_Items[index].Price);
_Items.RemoveAt(index); 

 
} 
}

