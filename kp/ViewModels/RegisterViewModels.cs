﻿using DryIoc;
using kp.ViewModels.Users;

namespace kp.ViewModels
{
	public static class RegisterViewModels
	{
		public static void AddViewModels(this IContainer container)
		{
			container.Register<UsersListViewModel>();
			container.Register<NewUserViewModel>();
			container.Register<EditUserViewModel>();
		}
	}
}