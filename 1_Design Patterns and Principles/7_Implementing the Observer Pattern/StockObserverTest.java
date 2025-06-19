public class StockObserverTest {
    public static void main(String[] args) {
        StockMarket stockMarket = new StockMarket();

        Observer mobileUser = new MobileApp("Alice");
        Observer webUser = new WebApp("Bob");

        stockMarket.register(mobileUser);
        stockMarket.register(webUser);

        stockMarket.setPrice(105.50);
        System.out.println("-------------------------");

        stockMarket.setPrice(110.75);
        System.out.println("-------------------------");

        stockMarket.deregister(mobileUser);
        stockMarket.setPrice(102.30); // only Bob (Web) should get this update
    }
}
