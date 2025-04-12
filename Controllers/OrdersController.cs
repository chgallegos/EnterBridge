using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using EnterBridgeApp.Models;
using EnterBridgeApp.Data;

namespace EnterBridgeApp.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase {
        private readonly AppDbContext _db;
        public OrdersController(AppDbContext db) {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders() => _db.Orders.ToList();

        [HttpPost]
        public IActionResult CreateOrder(Order order) {
            order.SubmittedAt = DateTime.UtcNow;
            _db.Orders.Add(order);
            _db.SaveChanges();
            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }
    }
}
