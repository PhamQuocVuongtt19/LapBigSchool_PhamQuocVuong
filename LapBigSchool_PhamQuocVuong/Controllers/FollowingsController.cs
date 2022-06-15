using LapBigSchool_PhamQuocVuong.DTOs;
using LapBigSchool_PhamQuocVuong.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LapBigSchool_PhamQuocVuong.Controllers
{ 
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if(_dbContext.Followings.Any(f => f.FollowerId == userId
            && f.FolloweeId == followingDto.FolooweeId))
            {
                return BadRequest("Following already exists");
            }
            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolooweeId
            };

            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
    
}
