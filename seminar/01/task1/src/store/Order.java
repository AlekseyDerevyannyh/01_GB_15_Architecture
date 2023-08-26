package store;

public class Order {
    private static int counter = 10000;
    private int id;
    private Date orderDate;
    private String address;
    private String phone;
    private Buyer buyer;
    private List<OrderItem> items = new ArrayList<>();

    {
        id = ++counter;
    }

    public Order(Date orderDate, String address, String phone, Buyer buyer, List<OrderItem> items) {

        if (buyer == null) {
            throw new RuntimeException("Покупатель должен существовать.");
        }

        if (items == null || items.size() == 0) {
            throw new RuntimeException("Заказ должен содержать минимум одну позицию.");
        }

        this.orderDate = orderDate;
        this.address = address;
        this.phone = phone;
        this.buyer = buyer;
        this.items = items;
    }
}
