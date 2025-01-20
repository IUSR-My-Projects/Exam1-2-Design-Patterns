namespace Exam1_2;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Specialization Specialization { get; set; }
    public ContractType ContractType { get; set; }
}

public class Specialization
{
    public Specialization(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}

public enum ContractType
{
    FullTime,
    PartTime
}