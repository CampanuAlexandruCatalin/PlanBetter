﻿using AutoMapper;
using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Business.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            
            
            CreateMap<Answer, AnswerModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<Exam, ExamModel>().ReverseMap();
            CreateMap<Question, QuestionModel>().ReverseMap();
            CreateMap<StudentGroup, AddStudentGroupModel>().ReverseMap();
            CreateMap<Student, StudentModel>().ReverseMap();
            CreateMap<Student, AddStudentModel>().ReverseMap();
            CreateMap<Teacher, AddTeacherModel>().ReverseMap();

        }
       
    }
}
