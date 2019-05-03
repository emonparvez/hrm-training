using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Employee
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }



        [Display(Name = "Employee  Code")]
        [StringLength(10)]
        public string EmployeeCode { get; set; }


        [Display(Name = "Employee Full Name")]
        [StringLength(150)]
        public string EmployeeName { get; set; }



        [Display(Name = "Nick Name")]
        [StringLength(150)]
        public string NickName { get; set; }


        [Display(Name = "Father Name")]
        [StringLength(150)]
        public string FatherName { get; set; }


        [Display(Name = "Mother Name")]
        [StringLength(150)]
        public string MotherName { get; set; }


        [Display(Name = "Mobile Number")]
        [StringLength(15)]
        public string MobileNumber { get; set; }


        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }



        [Display(Name = "Blood group")]
        [StringLength(150)]
        public string BloodGroup { get; set; }


        [Display(Name = "Address")]
        [StringLength(150)]
        public string Address { get; set; }



        public int Desig { get; set; }


        [ForeignKey("Desig")]
        public virtual Designation Designations { get; set; }


        [Display(Name = "Dept Name")]
        public int DeptId { get; set; }

        [ForeignKey("DeptId")]
        public virtual Dept Depts { get; set; }



        [Display(Name = "Upload File")]
        public string EmployeePhotoPath { get; set; }

        [NotMapped]
        public HttpPostedFileBase EmployeePhoto { get; set; }


    }




}