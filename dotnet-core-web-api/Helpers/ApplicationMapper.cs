using AutoMapper;
using dotnet_core_web_api.Models;
using dotnet_core_web_api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_web_api.Helpers
{
	public class ApplicationMapper: Profile
	{
		public ApplicationMapper()
		{
			CreateMap<Book, BookModel>().ReverseMap();
		}
	}
}
