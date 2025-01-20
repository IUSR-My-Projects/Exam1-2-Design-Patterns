﻿namespace Exam1_2;

public class ListDoctorRepo : IDoctorRepo
{
    private List<Doctor> _doctors = new List<Doctor>();

    public void Add(Doctor doctor)
    {
        doctor.Id = _doctors.Count + 1;
        _doctors.Add(doctor);
    }

    public void Delete(int id)
    {
        _doctors.RemoveAll(d => d.Id == id);
    }

    public void Update(Doctor doctor)
    {
        var existingDoctor = _doctors.FirstOrDefault(d => d.Id == doctor.Id);
        if (existingDoctor != null)
        {
            existingDoctor.Name = doctor.Name;
            existingDoctor.Specialization = doctor.Specialization;
            existingDoctor.ContractType = doctor.ContractType;
        }
    }

    public IEnumerable<Doctor> GetAll()
    {
        return _doctors;
    }

    public IEnumerable<Doctor> GetBySpecialization(Specialization specialization)
    {
        return _doctors.Where(d => d.Specialization == specialization);
    }
}