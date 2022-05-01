using AutoMapper;
using Dev.Business.Models;
using DevAppMain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevAppMain.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Concessionaria, ConcessionariaViewModel>().ReverseMap();
            CreateMap<Carro, CarroViewModel>().ReverseMap();
        }

    }
}
