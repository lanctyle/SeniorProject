﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TurnBasedGameAPI.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User/GetAll
        /// <summary>
        /// Returns all Users' usernames
        /// -Written by Garrick 1/22/18
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
            return Ok("User Controller GetAll API Call");
        }

        //POST: api/User/CreateUser
        /// <summary>
        /// Returns whether or not a user was created successfully.
        /// Handles account reactivation as well
        /// -Written by Garrick 1/23/18
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult CreateUser() //(Username, Password, Email, Name, etc)
        {
            return Ok("User Controller CreateUser API Call");
        }


        // GET: api/User
        /// <summary>
        /// Returns public information of a single user 
        /// based on passed in ID.
        /// @Michael Case, 1/23/18
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetByUserID(UserID id) // custom object, int, etc for id? implementation decision for later
        {
            
            return Ok("User Controller GetByUserID API Call");
        }

        // PUT: api/User
        /// <summary>
        /// Updates a users password, while verifying that
        /// the new password meets the minimum strength
        /// requirements.
        /// @Michael Case, 1/23/18
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public IHttpActionResult UpdatePassword(String password)
        {
            return Ok("User Controller UpdatePassword API Call");
        }


    }
}