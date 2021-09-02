using System;
namespace TaskManagementApp.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository Task { get; }
    }
}
