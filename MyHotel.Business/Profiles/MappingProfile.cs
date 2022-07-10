﻿using AutoMapper;
using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Business.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Guest, GuestModel>().ReverseMap();
            CreateMap<Reservation, ReservationModel>().ReverseMap();
            CreateMap<Room, RoomModel>().ReverseMap();
            CreateMap<Room, AddRoomModel>().ReverseMap();
            
            CreateMap<Answer, AnswerModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<Exam, ExamModel>().ReverseMap();
            CreateMap<Question, QuestionModel>().ReverseMap();
            CreateMap<StudentGroup, StudentGroupModel>().ReverseMap();
            CreateMap<Student, StudentModel>().ReverseMap();
            CreateMap<Teacher, TeacherModel>().ReverseMap();

        }
       
    }
}
