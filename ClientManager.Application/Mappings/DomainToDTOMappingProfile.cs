﻿using AutoMapper;
using ClientManager.Application.DTOs;
using ClientManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
           CreateMap<Cliente, ClienteDTO>()
    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
    .ReverseMap();
            CreateMap<ProdutoVenda, ProdutoVendaDTO>().ReverseMap();
              
            CreateMap<Venda, VendaDTO>()
                .ForMember(dest => dest.ProdutoVendaDTOs, opt => opt.MapFrom(src => src.Vendas)).ReverseMap();


        }
    }
}
