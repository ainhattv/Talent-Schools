﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSM.Data.Application;
using TSM.Data.Entities;
using TSM.Interfaces;
using TSM.Logging;
using TSM.Models;

namespace TSM.Services
{
    public class EducationProgramService : IEducationProgramService
    {
        private readonly IMapper _mapper;
        private readonly TSMContext _context;

        public EducationProgramService(
            IMapper mapper,
            TSMContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<EducationProgramModel>> GetEducationPrograms()
        {
            var programs = await _context.EducationPrograms.ToListAsync();

            return _mapper.Map<IEnumerable<EducationProgramModel>>(programs);
        }

        public async Task<EducationProgramModel> GetEducationProgram(Guid id)
        {
            var program = await _context.EducationPrograms.SingleOrDefaultAsync(x => x.Id.Equals(id));

            return _mapper.Map<EducationProgramModel>(program);
        }

        public async Task<EducationProgramModel> CreateEducationProgram(EducationProgramModel model)
        {
            EducationProgram educationProgram = new EducationProgram(model.Name, model.Description, model.Code);

            await _context.EducationPrograms.AddAsync(educationProgram);

            return _mapper.Map<EducationProgramModel>(educationProgram);
        }

        public async Task DeleteEducationProgram(Guid id)
        {
            var program = await _context.EducationPrograms.SingleOrDefaultAsync(x => x.Id.Equals(id));
            if (program != null)
            {
                _context.EducationPrograms.Remove(program);

                await _context.SaveChangesAsync();
            }
        }
    }
}
