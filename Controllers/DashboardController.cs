﻿using ecommerce.Data;
using ecommerce.Enums;
using ecommerce.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize(Roles = "Admin")]
public class DashboardController : Controller
{
    private readonly DataContext _context;
    private readonly IUserHelper _userHelper;

    public DashboardController(DataContext context, IUserHelper userHelper)
    {
        _context = context;
        _userHelper = userHelper;
    }
    public async Task<IActionResult> Index()
    {
        ViewBag.UsersCount = _context.Users.Count();
        ViewBag.ProductsCount = _context.Products.Count();
        ViewBag.NewOrdersCount = _context.Orders.Where(o => o.OrderStatus == OrderStatus.Nuevo).Count();
        ViewBag.ConfirmedOrdersCount = _context.Orders.Where(o => o.OrderStatus == OrderStatus.Confirmado).Count();

        return View(await _context.TemporalSales
                .Include(u => u.User)
                .Include(p => p.Product).ToListAsync());
    }
}
