﻿using class_management_web_api.src.DTO.Teacher;
using class_management_web_api.src.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace class_management_web_api.src.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _managerRepository;
        public TeacherController(ITeacherRepository managerRepository){
            _managerRepository = managerRepository;
        }
        [HttpGet()]
        public Task<IEnumerable<TeacherGetDTO>> GetTeachers()
        {
            return _managerRepository.GetTeachers();
        }
    }
}
