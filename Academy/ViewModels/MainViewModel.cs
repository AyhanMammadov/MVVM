using Academy.Commands.Base;
using Academy.Repositories;
using Academy.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Academy.ViewModels;
public class MainViewModel : ViewModelBase
{
    #region fields
    private ViewModelBase activeViewModel;

    public ViewModelBase ActiveViewModel
    {
        get => activeViewModel;
        set => base.PropertyChangeMethod(out activeViewModel, value);
    }
    #endregion


    #region commands
    private CommandBase infoCommand;

    public CommandBase InfoCommand => this.infoCommand ??= new CommandBase(
        execute: () => this.ActiveViewModel = new InfoViewModel(),
        canExecute: () => true);


    private CommandBase groupsCommand;

    public CommandBase GroupsCommand => this.groupsCommand ??= new CommandBase(
        execute: () => this.ActiveViewModel = App.container.GetInstance<GroupsViewModel>(),
        canExecute: () => true);


    private CommandBase studentsCommand;

    public CommandBase StudentsCommand => this.studentsCommand ??= new CommandBase(
        execute: () => this.ActiveViewModel = App.container.GetInstance<StudentsViewModel>(),
        canExecute: () => true);

    private CommandBase teachersCommand;

    public CommandBase TeachersCommand => this.teachersCommand ??= new CommandBase(
        execute: () => 
        this.ActiveViewModel = App.container.GetInstance<TeachersViewModel>(),
        canExecute: () => true);

    #endregion


    

}

