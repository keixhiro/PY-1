package bscs_2_1n;
    
    public class Employee {
    
        static String companyName = "Tech Solutions Inc.";
        String employeeName;
    
        public void showDetails() {
            double salary = 25000.00;
            System.out.println("Company Name: " + companyName);
            System.out.println("Employee Name: " + employeeName);
            System.out.println("Salary: " + salary);
            System.out.println("-----------------------------");
        }
    
        public static void main(String[] args) {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
    
            emp1.employeeName = "Francis Earl";
            emp2.employeeName = "Beatrix Zoe";
            emp1.showDetails();
            emp2.showDetails();
        }
    }

class Student {
    String name;
    int grade;

    Student(String n, int g) {
        name = n;
        grade = g;
    }
}

public class TestStudent {
    public static void main(String[] args) {
        Student s1 = new Student("John", 85);
        Student s2 = new Student("Maria", 90);
        Student s3 = s2;

        s1.grade = 95;
        s3.name = "Ana";

        System.out.println(s1.name + " " + s1.grade);
        System.out.println(s2.name + " " + s2.grade);
        System.out.println(s3.name + " " + s3.grade);
    }
}