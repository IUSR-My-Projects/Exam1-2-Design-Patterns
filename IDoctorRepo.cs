namespace Exam1_2;

public interface IDoctorRepo
{
    void Add(Doctor doctor);
    void Delete(int id);
    void Update(Doctor doctor);
    IEnumerable<Doctor> GetAll();
    IEnumerable<Doctor> GetBySpecialization(Specialization specialization);
}