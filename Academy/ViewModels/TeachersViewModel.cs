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
public class TeachersViewModel :ViewModelBase
{
    public ObservableCollection<Teacher> Teachers { get; set; }


    public TeachersViewModel()
    {
        Teachers = new ObservableCollection<Teacher>();
        this.RefreshAll();
    }


    private void RefreshAll()
    {
        Teachers.Clear();
        TeacherRepository teacherRepository = new TeacherRepository();
        var result = teacherRepository.GetAll();
        foreach ( var item in result )
        {
            Teachers.Add( item );
        }
    }
}

