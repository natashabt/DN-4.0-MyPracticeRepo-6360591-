public class HomeAutomationTest {
    public static void main(String[] args) {
        Light livingRoomLight = new Light();

        // Commands
        Command lightOn = new LightOnCommand(livingRoomLight);
        Command lightOff = new LightOffCommand(livingRoomLight);

        // Remote
        RemoteControl remote = new RemoteControl();

        // Turn ON light
        remote.setCommand(lightOn);
        remote.pressButton();

        System.out.println("---------------------------");

        // Turn OFF light
        remote.setCommand(lightOff);
        remote.pressButton();
    }
}
