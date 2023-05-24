using OpenClosed;

Order storeOrder = new StoreOrder()
{
    Id = 1, 
    CustomerName = "John Doe", 
    SubTotalAmount = 100
};

storeOrder.Checkout();

Order onlineOrder = new OnlineOrder()
{
    Id = 2,
    CustomerName = "Jane Doe",
    SubTotalAmount = 100
};

onlineOrder.Checkout();

