﻿using AutoMapper;
using InventorySystem.Data;
using InventorySystem.Models;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using InventorySystem.helpers;

namespace InventorySystem.services
{
    public class CompanyService:ICompanyService
    {
        private readonly InventoryContext context;
        private readonly IMapper mapper;

        public CompanyService(InventoryContext _context, IMapper _mapper)
        {
            context= _context;
            mapper = _mapper;
        }

        public void Create(CompanyDTO companyDTO)
        {
            Company newCompany = mapper.Map<Company>(companyDTO);

            context.Companies.Add(newCompany);
            context.SaveChanges();
        }

        public void Update(CompanyDTO companyDTO)
        {
            Company newCompany = mapper.Map<Company>(companyDTO);

            context.Companies.Attach(newCompany);
            context.Entry(newCompany).State = EntityState.Modified;
            context.SaveChanges();
        }

        public PaginatedList<CompanyDTO> GetAll(int CurrentPage)
        {
            List<Company> allCompany = context.Companies.ToList();
            List<CompanyDTO> companies=mapper.Map<List<CompanyDTO>>(allCompany);

            PaginatedList<CompanyDTO> PaginatPatients = PaginatedList<CompanyDTO>.CreateAsync(companies, CurrentPage);

            return PaginatPatients;
        }

        public CompanyDTO Get(int Id)
        {
            Company company = context.Companies.Find(Id);
            CompanyDTO companyDTO = mapper.Map<CompanyDTO>(company);

            return companyDTO;
        }

        public void Delete(int Id)
        {
            Company company = context.Companies.Find(Id);

            context.Companies.Remove(company);
            context.SaveChanges();
        }
    }
}
