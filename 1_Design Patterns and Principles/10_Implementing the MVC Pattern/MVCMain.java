public class MVCMain {
    public static void main(String[] args) {
        // Step 1: Create Model
        Student student = new Student("Shrinkhala", "S101", "A");

        // Step 2: Create View
        StudentView view = new StudentView();

        // Step 3: Create Controller and connect Model + View
        StudentController controller = new StudentController(student, view);

        // Step 4: Display student info via controller
        controller.updateView();

        // Step 5: Modify student data
        controller.setStudentName("Shrinkhala Kumari");
        controller.setStudentGrade("A+");

        // Step 6: Display updated info
        controller.updateView();
    }
}

