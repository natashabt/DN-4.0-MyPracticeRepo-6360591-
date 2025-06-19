public class ComputerBuilderTest {
    public static void main(String[] args) {

        // 🖥 Basic Computer
        Computer basicComputer = new Computer.Builder("Intel i3", "8GB").build();
        basicComputer.showSpecs();

        System.out.println("---------------------------");

        // 💻 Gaming Computer
        Computer gamingPC = new Computer.Builder("Intel i9", "32GB")
                .setStorage("1TB SSD")
                .setGraphicsCard("NVIDIA RTX 4080")
                .setOperatingSystem("Windows 11")
                .build();
        gamingPC.showSpecs();
    }
}

