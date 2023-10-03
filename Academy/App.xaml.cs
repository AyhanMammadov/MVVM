using Academy.Repositories;
using Academy.Repositories.Base;
using Academy.ViewModels;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Academy
{
    
    public partial class App : Application
    {
        public static Container container { get; set; } = new Container();

        protected override void OnStartup(StartupEventArgs e)
        {
            container.RegisterSingleton<IGroupRepository, GroupRepository>();
            container.RegisterSingleton<ITeacherRepository, TeacherRepository>();
            container.RegisterSingleton<IStudentRepository, StudentRepository>();


            container.RegisterSingleton<GroupsViewModel>();
            container.RegisterSingleton<TeachersViewModel>();
            container.RegisterSingleton<StudentsViewModel>();

            container.Verify();

            base.OnStartup(e);
        }
    }
}
