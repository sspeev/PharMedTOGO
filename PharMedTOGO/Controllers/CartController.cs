﻿using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Extensions;
using PharMedTOGO.Infrastrucure.Data.Enums;
using PharMedTOGO.Models;

namespace PharMedTOGO.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly IMedicineService mediicineService;
        private readonly IAdminService adminService;
        private readonly IPrescriptionService prescriptionService;

        public CartController(
            ICartService _cartService,
            IMedicineService _medicineService,
            IAdminService _adminService,
            IPrescriptionService _prescriptionService)
        {
            cartService = _cartService;
            mediicineService = _medicineService;
            adminService = _adminService;
            prescriptionService = _prescriptionService;

        }

        [HttpGet]
        public async Task<IActionResult> ShoppingCart()
        {
            try
            {
                var model = await cartService.AllCartProducts(User.Id());

                return View(model);
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            try
            {
                if (!User?.Identity?.IsAuthenticated ?? false)
                {
                    return Unauthorized();
                }
                if (!await mediicineService.ExistsByIdAsync(id))
                {
                    return BadRequest();
                }
                if (await cartService.AlreadyAddedToCart(id, User.Id()))
                {
                    throw new ArgumentException("The current medicine is already added to the shopping cart!");
                
                }

                var medicine = await mediicineService.FindByIdAsync(id);
                var prescriptionId = await adminService.HasUserPrescription(User.Id());
                if (prescriptionId == 0)
                {
                    throw new ArgumentException("This medicine requires prescription which you do not have! Go to My prescription and send it to admin to validate it");
                }
                var prescription = await prescriptionService.FindByIdAsync(prescriptionId);

                if (prescription.PrescriptionState != PrescriptionState.Finished)
                {
                    throw new ArgumentException("Your prescription hasn't been validated yet!");
                }
                if (!prescription.IsValid)
                {
                    throw new ArgumentException("You have invalid prescription");
                }
                await cartService.AddToCartAsync(id, User.Id());

                return RedirectToAction(nameof(ShoppingCart), "Cart");
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel()
                {
                    ExceptionMessage = e.Message
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return Unauthorized();
            }
            await cartService.RemoveFromCartAsync(id, User.Id());

            return RedirectToAction(nameof(ShoppingCart), "Cart");
        }
    }
}
