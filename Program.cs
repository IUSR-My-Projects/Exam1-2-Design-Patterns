namespace Exam1_2;

class Program
{
    static void Main(string[] args)
    {
        Specialization Cardiology = new Specialization(1, "Cardiology");

        var doctorBuilder = new DoctorBuilder();
        var doctor = doctorBuilder
            .SetName("Dr. Omar")
            .SetSpecialization(Cardiology)
            .SetContractType(ContractType.FullTime)
            .build();

        IDoctorRepo repository = new ListDoctorRepo();

        repository.Add(doctor);
        LogService.GetInstance().Log($"Added doctor: {doctor.Name}");


        var cardiologists = repository.GetBySpecialization(Cardiology);
        Console.WriteLine("Cardiologists:");
        foreach (var cardiologist in cardiologists)
        {
            Console.WriteLine($"- {cardiologist.Name}");
        }


        doctor.ContractType = ContractType.PartTime;
        repository.Update(doctor);
        LogService.GetInstance().Log($"Updated doctor: {doctor.Name}");


        var allDoctors = repository.GetAll();
        Console.WriteLine("\nAll Doctors:");
        foreach (var d in allDoctors)
        {
            Console.WriteLine($"- {d.Name} ({d.Specialization}, {d.ContractType})");
        }


        repository.Delete(doctor.Id);
        LogService.GetInstance().Log($"Deleted doctor: {doctor.Name}");



        Console.WriteLine(LogService.GetInstance().GetLog());
    }
}