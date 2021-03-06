﻿using Autofac;
using ProjectTemplate.Data;
using ProjectTemplate.Data.Common;

namespace ProjectTemplate.IOC.AutofacModules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(DataContext)).As(typeof(IDataContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
            base.Load(builder);
        }
    }
}