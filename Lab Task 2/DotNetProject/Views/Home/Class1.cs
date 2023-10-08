using Antlr.Runtime.Misc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace DotNetProject.Views.Home
{
    public class Class1
    {
        @{
    ViewBag.Title = "Sinup";
}
<h2 class="text-center mb-3 ">
    Registration From
</h2>
<hr />


<div class="">
    <form action = "" method="post">

        <div class="row">
            <div class="col-lg-2">
                <labb>Name :</labb>
            </div>
            <div class="col-lg-5">
                <input class="form-control" name="Name" type="text" @* pattern = "[A-Za-z\s\.\-]{4,50}" *@ required />
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-lg-2">
                <labb>User ID :</labb>
            </div>
            <div class="col-lg-5">
                <input class="form-control" name="ID" type="text" @* pattern = "\d{2}-\d{5}-\d{1}" *@ required />
            </div>
        </div>
        <span class="text-danger" asp-validation-for="ID"></span>
        <div class="row mt-3">
            <div class="col-lg-2">
                <labb>Password :</labb>
            </div>
            <div class="col-lg-5">
                <input class="form-control" name="Password" type="text" pattern="(?=.{8,})[A-Za-z]{4}[\w!#$%^&*]+\d$" required />
            </div>
        </div>


        <div class="row mt-3">
            <div class="col-lg-2">
                <labb>Email :</labb>
            </div>
            <div class="col-lg-5">
                <input class="form-control" name="Email" type="text" pattern="\d{2}-\d{5}-\d{1}[a-z]+\.[a-z]+\.[a-z]+" required />
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-lg-2">
                <labb>Date of birth :</labb>
            </div>
            <div class="col-lg-5">
                <input class="form-control" name="Date" type="text" pattern="\d{2}/\d{2}/\d{4}" required />
            </div>
        </div>


        @*<div class="row mt-4">
            <div class="col-lg-2">
                <labb>Gender</labb>
            </div>
            <div class="col-lg-5">
                <input type = "radio" name="Gender" id="male" value="Male" />Male
    <input type="radio" name="Gender" id="Femal" value="Female" /> Female
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-lg-2">
                <labb>Profession</labb>
            </div>
            <div class="col-lg-5">
                <select name = "Profession" disabled="disabled"  class="form-control">
                    <option value = "Teacher" > Teacher </ option >
                    < option value="Student" >Student</option>
                </select>
            </div>
        </div>*@

        @* <div class="row mt-2">
            <div class="col-lg-2">
                <labb>Hobbies</labb>
            </div>
            <div class="col-lg-5">
                <input type = "checkbox" name="Hobb" value="FootBall" />FootBall
                <input type="checkbox" name="Hobb" value="Cricket" /> Cricket
    <input type="checkbox" name="Hobb" value="Badminton" />Badminton
    <input type="checkbox" name="Hobb" value="Ice Hocky" /> Ice Hocky
            </div>
        </div>*@



        <input type = "submit" value= "Sin Up" class="btn btn-primary mt-4 text-center" />
    </form>
</div>


@*<h3 class="text-center">Information</h3>
    <h4>Name :@ViewBag.name</h4>
    <h4> ID :@ViewBag.id</h4>
    <h4> Gender :@ViewBag.gender</h4>
    <h4>Profession : @ViewBag.profession</h4>
    <h4>Hobbies : @ViewBag.hobb</h4>*@

@*<h3 class="text-center">Information</h3>
    @{
        if (Model != null)
        {
            <h4>Name :@Model.Name</h4>
            <h4> ID :@Model.ID</h4>
            <h4> Gender :@Model.Password</h4>
            <h4>Profession :@Model.Email</h4>
            <h4>Hobbies :@Model.Date</h4>
}
    }*@
    }
}