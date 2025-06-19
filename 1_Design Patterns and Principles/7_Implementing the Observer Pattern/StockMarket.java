import java.util.ArrayList;
import java.util.List;

public class StockMarket implements Stock {
    private List<Observer> observers = new ArrayList<>();
    private double stockPrice;

    @Override
    public void register(Observer observer) {
        observers.add(observer);
    }

    @Override
    public void deregister(Observer observer) {
        observers.remove(observer);
    }

    @Override
    public void notifyObservers() {
        for (Observer o : observers) {
            o.update(stockPrice);
        }
    }

    @Override
    public void setPrice(double price) {
        this.stockPrice = price;
        System.out.println("Stock price updated to: Rs " + price);
        notifyObservers();
    }
}

