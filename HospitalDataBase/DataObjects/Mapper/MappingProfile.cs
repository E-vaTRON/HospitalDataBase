﻿using AutoMapper;
using HospitalDataBase.Core.Entities;
using HospitalDataBase.Core.Entities.UnitType;
using HospitalDataBase.DataObjects.CreateDTO;
using System;
using System.Globalization;

namespace HospitalDataBase.DataObjects.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<AnalysationTestDTO, AnalysationTest>()
                .ForMember(d => d.ID, o => o.Ignore());
            CreateMap<AnalysationTest, AnalysationTestDTO>();
            CreateMap<CreateAnalysationTestDTO, AnalysationTest>()
                .ForMember(d => d.PatientID, o => o.Ignore())
                .ForMember(d => d.DeviceID, o => o.Ignore())
                .ForMember(d => d.ExamID, o => o.Ignore());

            CreateMap<DeviceServiceDTO, DeviceService>()
                .ForMember(d => d.Unit, o => o.MapFrom(s => Enum.GetName(typeof(Units), s.Unit)))
                .ForMember(d => d.DeviceID, o => o.Ignore());
            CreateMap<DeviceService, DeviceServiceDTO>()
                .ForMember(d => d.Unit, o => o.MapFrom(s => s.Unit.ToString()));

            CreateMap<DoctorListDTO, DoctorList>()
                .ForMember(d => d.DateJoin, o => o.MapFrom(s => DateTime.Parse(s.DateJoin, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.DoctorID, o => o.Ignore());
            CreateMap<DoctorList, DoctorListDTO>()
                .ForMember(d => d.DateJoin, o => o.MapFrom(s => s.DateJoin.ToString("yyyy-MM-dd")));

            CreateMap<EmployeeListDTO, EmployeeList>()
                .ForMember(d => d.DateJoin, o => o.MapFrom(s => DateTime.Parse(s.DateJoin, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.EmployeeID, o => o.Ignore());
            CreateMap<EmployeeList, EmployeeListDTO>()
                .ForMember(d => d.DateJoin, o => o.MapFrom(s => s.DateJoin.ToString("yyyy-MM-dd")));

            CreateMap<DrugDTO, Drug>()
                .ForMember(d => d.Unit,o => o.MapFrom(s => Enum.GetName(typeof(Units), s.Unit)))
                .ForMember(d => d.GoodID, o => o.Ignore());
            CreateMap<Drug, DrugDTO>()
                .ForMember(d => d.Unit, o => o.MapFrom(s => s.Unit.ToString()));

            CreateMap<GoodsExportationDTO, GoodsExportation>()
                .ForMember(d => d.RecordDay, o => o.MapFrom(s => DateTime.Parse(s.RecordDay, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.ExpiryDate, o => o.MapFrom(s => DateTime.Parse(s.ExpiryDate, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.ID, o => o.Ignore());
            CreateMap<GoodsExportation, GoodsExportationDTO>()
                .ForMember(d => d.RecordDay, o => o.MapFrom(s => s.RecordDay.ToString("yyyy-MM-dd")))
                .ForMember(d => d.ExpiryDate, o => o.MapFrom(s => s.ExpiryDate.ToString("yyyy-MM-dd")));

            CreateMap<GoodsImportationDTO, GoodsImportation>()
                .ForMember(d => d.RecordDay, o => o.MapFrom(s => DateTime.Parse(s.RecordDay, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.ReceiptDay, o => o.MapFrom(s => DateTime.Parse(s.ReceiptDay, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.ExpiryDate, o => o.MapFrom(s => DateTime.Parse(s.ExpiryDate, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.ID, o => o.Ignore());
            CreateMap<GoodsImportation, GoodsImportationDTO>()
                .ForMember(d => d.RecordDay, o => o.MapFrom(s => s.RecordDay.ToString("yyyy-MM-dd")))
                .ForMember(d => d.ReceiptDay, o => o.MapFrom(s => s.ReceiptDay.ToString("yyyy-MM-dd")))
                .ForMember(d => d.ExpiryDate, o => o.MapFrom(s => s.ExpiryDate.ToString("yyyy-MM-dd")));

            CreateMap<HistoryMedicalExamDTO, HistoryMedicalExam>()
                .ForMember(d => d.DateTakeExam, o => o.MapFrom(s => DateTime.Parse(s.DateTakeExam, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.DateReExam, o => o.MapFrom(s => DateTime.Parse(s.DateReExam, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.ExamID, o => o.Ignore());
            CreateMap<HistoryMedicalExam, HistoryMedicalExamDTO>()
                .ForMember(d => d.DateTakeExam, o => o.MapFrom(s => s.DateTakeExam.ToString("yyyy-MM-dd")))
                .ForMember(d => d.DateReExam, o => o.MapFrom(s => s.DateReExam.ToString("yyyy-MM-dd")));

            CreateMap<InventoryDTO, Inventory>()
                .ForMember(d => d.ExpiryDate, o => o.MapFrom(s => DateTime.Parse(s.ExpiryDate, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.InventoryID, o => o.Ignore());
            CreateMap<Inventory, InventoryDTO>()
                .ForMember(d => d.ExpiryDate, o => o.MapFrom(s => s.ExpiryDate.ToString("yyyy-MM-dd")));

            CreateMap<PatientDTO, Patient>()
                .ForMember(d => d.DayOfBirth, o => o.MapFrom(s => DateTime.Parse(s.DayOfBirth, null, DateTimeStyles.AssumeUniversal)))
                .ForMember(d => d.PatientID, o => o.Ignore());
            CreateMap<Patient, PatientDTO>()
                .ForMember(d => d.DayOfBirth, o => o.MapFrom(s => s.DayOfBirth.ToString("yyyy-MM-dd")));
        }
    }
}
