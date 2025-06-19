public class ImageViewerTest {
    public static void main(String[] args) {
        Image img1 = new ProxyImage("logo.png");
        Image img2 = new ProxyImage("banner.jpg");

        System.out.println("--- First time viewing logo.png ---");
        img1.display(); // loads and displays

        System.out.println("--- Viewing logo.png again ---");
        img1.display(); // uses cache

        System.out.println("--- First time viewing banner.jpg ---");
        img2.display(); // loads and displays
    }
}

