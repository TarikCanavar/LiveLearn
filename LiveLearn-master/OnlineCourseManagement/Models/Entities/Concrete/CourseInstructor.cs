using OnlineCourseManagement.Models.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Entities.Concrete
{
    public class CourseInstructor : IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
    }
}
