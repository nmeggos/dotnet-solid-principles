using OpenClosed;

IOrder storeOrder = new StoreOrder()
{
    Id = 1, 
    CustomerName = "John Doe", 
    SubTotalAmount = 100
};

storeOrder.Checkout();

IOrder onlineOrder = new OnlineOrder()
{
    Id = 2,
    CustomerName = "Jane Doe",
    SubTotalAmount = 100,
    Discount = 0.20m
};

onlineOrder.Checkout();

