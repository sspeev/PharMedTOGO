using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services;

public class CartService(PharMedDbContext _context) : ICartService
{
    public async Task<string> AddToCartAsync(int medicineId, string userId)
    {
        Cart cart = new()
        {
            PatientId = userId,
            MedicineId = medicineId
        };

        await _context.AddAsync(cart);
        await _context.SaveChangesAsync();

        return userId;
    }

    public async Task<string> RemoveFromCartAsync(int medicineId, string userId)
    {
        var cart = _context.Carts.FirstOrDefault(c => c.PatientId == userId && c.MedicineId == medicineId);

        if(cart == null) throw new ArgumentException($"cart is null {nameof(cart)}");

        _context.Carts.Remove(cart);
        await _context.SaveChangesAsync();

        return userId;
    }
    public async Task<AllCartsQueryModel> AllCartProducts(string userId)
    {
        var medicineIdsToShow = await _context.Carts
            .AsNoTracking()
            .Where(m => m.PatientId == userId)
            .Select(c => c.MedicineId)
            .ToListAsync();

        var medicines = await _context.Medicines
            .AsNoTracking()
            .ToListAsync();

        var model = new List<MedicineServiceModel>();
        decimal totalProductsPrice = 0;
        decimal deliveryPrice = 0m;

        foreach (var medicine in medicines)
        {
            if (medicineIdsToShow.Contains(medicine.Id))
            {
                model.Add(new MedicineServiceModel()
                {
                    Id = medicine.Id,
                    Name = medicine.Name,
                    Category = medicine.Category,
                    RequiresPrescription = medicine.RequiresPrescription,
                    ImageUrl = medicine.ImageUrl,
                    Price = medicine.Price,
                    Description = medicine.Description,
                    SaleId = medicine.SaleId
                });
                totalProductsPrice += medicine.Price;
            }
        }

        if (totalProductsPrice <= 50 && totalProductsPrice > 0)
        {
            deliveryPrice += 3.00m;
        }

        return new AllCartsQueryModel()
        {
            Medicines = model,
            DeliveryPrice = deliveryPrice,
            TotalMedicinesSum = totalProductsPrice,
            Total = totalProductsPrice + deliveryPrice
        };
    }

    public async Task<bool> AlreadyAddedToCart(int medicineId, string userId)
    {
        return await _context.Carts
            .AnyAsync(c => c.PatientId == userId && c.MedicineId == medicineId);
    }

    public AllCartsQueryModel DetailsAsync(AllCartsQueryModel model)
    {
        return model;
    }

    public async Task ClearCart(string userId)
    {
        var buyedMedicines = await _context.Carts.Where(c => c.PatientId == userId).ToListAsync();
        foreach (var item in buyedMedicines)
        {
            _context.Remove(item);
        }
        await _context.SaveChangesAsync();
    }
}
