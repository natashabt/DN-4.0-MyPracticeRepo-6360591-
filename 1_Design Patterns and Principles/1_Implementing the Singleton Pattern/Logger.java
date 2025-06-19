public class Logger {

    private static volatile Logger instance;

    private Logger() {
        System.out.println("Logger created.");
    }

    //Public method to return the instance (thread-safe)
    public static Logger getInstance() {
        if (instance == null) {
            synchronized (Logger.class) {
                if (instance == null) {
                    instance = new Logger(); // only one thread can create this
                }
            }
        }
        return instance;
    }

    public void log(String message) {
        System.out.println("LOG: " + message);
    }
}
