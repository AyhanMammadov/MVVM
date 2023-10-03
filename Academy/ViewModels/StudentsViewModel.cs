using Academy.Models;
using Academy.Repositories;
using Academy.Repositories.Base;
using Academy.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.ViewModels;
public class StudentsViewModel:ViewModelBase
{
    private readonly IStudentRepository studentRepository;
    public ObservableCollection<Student> Students { get; set; }


    public StudentsViewModel(IStudentRepository repository)
    {
        this.studentRepository = repository;
        Students = new ObservableCollection<Student>();
        this.RefreshAll();
    }


    private void RefreshAll()
    {
        Students.Clear();
        var result = this.studentRepository.GetAll();
        foreach (var item in result)
        {
            Students.Add(item);
        }
    }
}

