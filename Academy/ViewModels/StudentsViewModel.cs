using Academy.Models;
using Academy.Repositories;
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
    public ObservableCollection<Student> Students { get; set; }


    public StudentsViewModel()
    {
        Students = new ObservableCollection<Student>();
        this.RefreshAll();
    }


    private void RefreshAll()
    {
        Students.Clear();
        var studentRepository = new StudentRepository();
        var result = studentRepository.GetAll();
        foreach (var item in result)
        {
            Students.Add(item);
        }
    }
}

