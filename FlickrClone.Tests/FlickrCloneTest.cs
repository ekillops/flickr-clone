using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlickrClone.Models;
using Xunit;
using FlickrClone.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Moq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FlickrClone.Tests
{
    public class FlickrCloneTest
    {

        [Fact]
        public void Tests_Run()
        {
            Assert.Equal(1, 1);
        }



        //// Account Tests
        //[Fact]
        //public void Account_View_Result_Index_Test()
        //{
        //    //Arrange, Act
        //    ViewResult indexView = new AccountController().Index() as ViewResult;

        //    //ViewResult indexView = new AccountController(new UserManager<ApplicationUser>(), new SignInManager<ApplicationUser>(), new ApplicationDbContext()).Index() as ViewResult;

        //    //Assert
        //    Assert.IsType<ViewResult>(indexView);
        //}

        //[Fact]
        //public void Account_View_Result_Login_Test()
        //{
        //    //Arrange, Act
        //    ViewResult loginView = new AccountController().Login() as ViewResult;

        //    //Assert
        //    Assert.IsType<ViewResult>(loginView);
        //}

        //[Fact]
        //public void Account_View_Result_Signup_Test()
        //{
        //    //Arrange, Act
        //    ViewResult signupView = new AccountController().Signup() as ViewResult;

        //    //Assert
        //    Assert.IsType<ViewResult>(signupView);
        //}
    }
}
