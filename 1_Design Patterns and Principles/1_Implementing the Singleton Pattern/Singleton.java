public class Singleton {
    public static void main(String[] args) {

        Logger logger1 = Logger.getInstance();
        logger1.log("Application started.");

        Logger logger2 = Logger.getInstance();
        logger2.log("User logged in.");

        if (logger1 == logger2) {
            System.out.println("Both logger1 and logger2 are the SAME instance.");
        } else {
            System.out.println("Different instances. Singleton failed.");
        }
    }
}

