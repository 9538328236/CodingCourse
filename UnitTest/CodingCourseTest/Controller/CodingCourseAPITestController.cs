
using Moq;
using NUnit.Framework; 
using Microsoft.AspNetCore.Mvc;
using CodingTestAPI.Controllers;
using CodingTestAPI.Model;
using CodingTestAPI.Services;
using System.Collections.Generic;
using CodingTestAPI.Interfaces;

namespace CodingCourseTest.Controller
{
    public class CodingCourseAPITestController
    {
        private Mock<ICodingCourseService> _mockCodingCourseService;

        [SetUp] 
        public void Setup()
        {
            _mockCodingCourseService = new Mock<ICodingCourseService>();
        }

        [Test] 
        public void Get_AllCodingCourses()
        {
            //mock the data 
            //assert the value
        }

       
    }
}
