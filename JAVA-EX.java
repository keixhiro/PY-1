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