using Lab32_Task4;

Address studentAddress = new Address("Київ", "Хрещатик", 10);
Address teacherAddress = new Address("Львів", "Шевченка", 25);

Student student = new Student("Аліна", studentAddress);
Teacher teacher = new Teacher("Роман", teacherAddress);

Console.WriteLine($"\n{student}" +
    $"\n{teacher}");