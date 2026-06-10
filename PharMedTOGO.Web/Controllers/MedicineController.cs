using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Web.Extensions;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Web.Controllers;

[Authorize(Roles = AdminConstant)]
public class MedicineController(
    IMedicineService _medicineService,
    ISaleService _saleService) : BaseController
{
    [HttpGet]
    public IActionResult Add()
    {
        return View(new MedicineFormModel());
    }

    [HttpPost]
    public async Task<IActionResult> Add(MedicineFormModel model)
    {
        try
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model == null)
            {
                return BadRequest();
            }
            await _medicineService.CreateAsync(model);

            return RedirectToAction(nameof(All), "Medicine");
        }
        catch (Exception e)
        {
            return View("Error", new ErrorViewModel()
            {
                ExceptionMessage = e.Message
            });
        }
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> All([FromQuery] AllMedicinesQueryModel query)
    {
        try
        {
            var allMedicines = await _medicineService.AllAsync();
            await _saleService.CheckSaleDates(allMedicines.Medicines);

            var model = _medicineService.AllSorted(
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.MedicinesPerPage,
                allMedicines);

            query.MedicinesCount = model.MedicinesCount;
            query.Medicines = model.Medicines;

            return View(query);
        }
        catch (Exception e)
        {
            return View("Error", new ErrorViewModel()
            {
                ExceptionMessage = e.Message
            });
        }
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            if (!await _medicineService.ExistsByIdAsync(id))
            {
                return BadRequest();
            }

            var model = await _medicineService.MedicineDetails(id);

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

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        try
        {
            var medicine = await _medicineService.FindByIdAsync(id);//possible throwing

            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (medicine == null)
            {
                return BadRequest();
            }

            var formModel = new MedicineFormModel()
            {
                Name = medicine.Name,
                RequiresPrescription = medicine.RequiresPrescription,
                Price = medicine.Price,
                Category = medicine.Category,
                Description = medicine.Description,
                ImageUrl = medicine.ImageUrl
            };
            TempData.Add("medicineId", id);
            return View(formModel);
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
    public async Task<IActionResult> Edit(int id, MedicineFormModel model)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (!await _medicineService.ExistsByIdAsync(id))
            {
                return BadRequest();
            }
            if (model == null)
            {
                return BadRequest();
            }
            await _medicineService.EditAsync(id, model);

            return RedirectToAction(nameof(Details), new {id});
        }
        catch (Exception e) 
        { 
            return View("Error", new ErrorViewModel() 
            { 
                ExceptionMessage = e.Message 
            }); 
        }
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var medicine = await _medicineService.FindByIdAsync(id);//possible throwing

            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (medicine == null)
            {
                return BadRequest();
            }

            var model = new MedicineDeleteModel()
            {
                Id = medicine.Id,
                Name = medicine.Name,
                ImageUrl = medicine.ImageUrl,
                Price = medicine.Price,
                Description = medicine.Description
            };
            TempData.Add("medicineId", id);

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
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            if (!await _medicineService.ExistsByIdAsync(id))
            {
                return BadRequest();
            }
            await _medicineService.DeleteAsync(id);

            return RedirectToAction(nameof(All));
        }
        catch (Exception e)
        {
            return View("Error", new ErrorViewModel()
            {
                ExceptionMessage = e.Message
            });
        }
    }
}
