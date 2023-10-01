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
public class GroupsViewModel :ViewModelBase
{
    public ObservableCollection<Group> Groups { get; set; }


    public GroupsViewModel()
    {
        Groups = new ObservableCollection<Group>();
        this.RefreshAll();
    }


    private void RefreshAll()
    {
        Groups.Clear();
        var groupRepository = new GroupRepository();
        var result = groupRepository.GetAll();
        foreach (var item in result)
        {
            Groups.Add(item);
        }
    }
}

