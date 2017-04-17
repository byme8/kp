﻿using kp.ViewModels.Clients;
using kp.ViewModels.Login;
using kp.ViewModels.PaymentsKinds;
using kp.ViewModels.UserRoles;
using kp.ViewModels.Users;
using Microsoft.Extensions.DependencyInjection;

namespace kp.ViewModels
{
    public static class RegisterViewModels
    {
        public static void AddViewModels(this IServiceCollection servoces)
        {
            servoces.AddTransient<UsersListViewModel>();
            servoces.AddTransient<NewUserViewModel>();
            servoces.AddTransient<EditUserViewModel>();
            servoces.AddTransient<UserRolesViewModel>();
            servoces.AddTransient<NewUserRoleViewModel>();
            servoces.AddTransient<MainViewModel>();
            servoces.AddTransient<LoginViewModel>();
            servoces.AddTransient<UserRolesManagmentViewModel>();
            servoces.AddTransient<ClientsViewModel>();
            servoces.AddTransient<NewClientViewModel>();
            servoces.AddTransient<EditClientViewModel>();
            servoces.AddTransient<PaymentsKindViewModel>();
            servoces.AddTransient<NewPaymentKindViewModel>();
            servoces.AddTransient<EditPaymentKindViewModel>();
        }
    }
}