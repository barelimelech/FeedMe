﻿using FeedMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedMe.Models
{
    public enum UserType
    {
        Client,
        rManager,
        Admin
    }

    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please insert password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please insert name")]
        public String Name { get; set; }

        // MIGRATION
        [Required(ErrorMessage = "Please insert address")]
        public String Address { get; set; }
        // MIGRATION

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Please insert phone")]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        [Display(Name = "Birthday Date")]
        //[Range(typeof(DateTime), "01/01/1966", "01/01/2022")]
        public DateTime BirthdayDate { get; set; }

        public UserType Type { get; set; } = UserType.Client;


        // MIGRATION
        public List<MyCart> MyCarts { get; set; }

        // MIGRATION
        [Display(Name = "Your Restaurant ID")]
        public int? RestaurantId { get; set; } = null;
        public Restaurant Restaurant{ get; set; }
    }
}
