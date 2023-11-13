﻿using Microsoft.AspNetCore.Mvc;
using WalkUniq.DataAccess.Repository.IRepository;
using WalkUniq.Models;

namespace WalkUniq.Areas.Admin
{
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<OrderHeader> objOrderHeaders = _unitOfWork.OrderHeader.GetAll(includeProperties: "ApllicationUser").ToList();
            return Json(new { data = objOrderHeaders });
        }

       
        #endregion
    }
}
