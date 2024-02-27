using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public CreatedCourseResponse Add(CreateCourseRequest createCourseRequest)
        {
            Course course = new Course();
            course.CourseName = createCourseRequest.CourseName;
            course.InstructorName = createCourseRequest.InstructorName;
            course.CreatedDate = DateTime.Now;

            _courseDal.Add(course);

            CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
            createdCourseResponse.CourseName = course.CourseName;
            createdCourseResponse.InstructorName = course.InstructorName;
            createdCourseResponse.Id = 9;
            createdCourseResponse.CreatedDate = course.CreatedDate;

            return createdCourseResponse;
        }

        public List<GetAllCourseResponse> GetAll()
        {
            List<Course> courses = _courseDal.GetAll();
            List<GetAllCourseResponse> getAllCourseResponses = new List<GetAllCourseResponse>();

            

            foreach (var course in courses)
            {
                GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
                getAllCourseResponse.CourseName = course.CourseName;
                getAllCourseResponse.InstructorName = course.InstructorName;
                getAllCourseResponse.CreatedDate = course.CreatedDate;
                getAllCourseResponse.Id = course.Id;

                getAllCourseResponses.Add(getAllCourseResponse);
            }
            

            return getAllCourseResponses;
        }

        public UpdatedCourseResponse Update(UpdateCourseRequest updateCourseRequest)
        {
            Course course = new Course();
            course.CourseName = updateCourseRequest.CourseName;
            course.InstructorName = updateCourseRequest.InstructorName;
            course.Id = updateCourseRequest.Id;
            course.CreatedDate = DateTime.Now;

            _courseDal.Update(course);

            UpdatedCourseResponse updatedCourseResponse = new UpdatedCourseResponse();
            updatedCourseResponse.CourseName = course.CourseName;
            updatedCourseResponse.InstructorName = course.InstructorName;
            updatedCourseResponse.Id = course.Id;
            updatedCourseResponse.UpdatedDate = DateTime.Now;

            return updatedCourseResponse;
        }
    }
}
