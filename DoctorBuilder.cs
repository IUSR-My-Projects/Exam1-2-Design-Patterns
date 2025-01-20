namespace Exam1_2;

public class DoctorBuilder
{
    private Doctor _doctor = new Doctor();

    public DoctorBuilder SetName(string name)
    {
        _doctor.Name = name;
        return this;
    }

    public DoctorBuilder SetSpecialization(Specialization specialization)
    {
        _doctor.Specialization = specialization;
        return this;
    }

    public DoctorBuilder SetContractType(ContractType contractType)
    {
        _doctor.ContractType = contractType;
        return this;
    }

    public Doctor build()
    {
        return _doctor;
    }
}