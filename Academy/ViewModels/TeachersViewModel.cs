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
public class TeachersViewModel :ViewModelBase
{
    private readonly ITeacherRepository teacherRepository;
    public ObservableCollection<Teacher> Teachers { get; set; }


    public TeachersViewModel(ITeacherRepository repository)
    {
        this.teacherRepository = repository;
        Teachers = new ObservableCollection<Teacher>();
        this.RefreshAll();
    }


    private void RefreshAll()
    {
        Teachers.Clear();
        var result = this.teacherRepository.GetAll();
        foreach ( var item in result )
        {
            Teachers.Add( item );
        }
    }
}

