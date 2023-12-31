﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
	public static class BusinessEXtension
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
			services.AddScoped<IDestinantionService, DestinationManager>();
			services.AddScoped<IDestinationDal, EFDestinationDal>();

			services.AddScoped<IContactFormService,ContactFormManager>();
			services.AddScoped<IContactFormDal, EFContactFormDal>();
		}
	}
}
