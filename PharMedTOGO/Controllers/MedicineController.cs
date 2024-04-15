using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Extensions;
using PharMedTOGO.Models;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Controllers
{
    [Authorize(Roles = AdminConstant)]
    public class MedicineController : BaseController
    {
        private readonly IMedicineService medicineService;
        private readonly ISaleService saleService;

        public MedicineController(
            IMedicineService _medicineService,
            ISaleService _saleService)
        {
            medicineService = _medicineService;
            saleService = _saleService;
        }

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
                    return Forbid();
                }

                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                if (model == null)
                {
                    return BadRequest();
                }
                await medicineService.CreateAsync(model);

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
                var allMedicines = await medicineService.AllAsync();
                await saleService.CheckSaleDates(allMedicines.Medicines);

                var model = medicineService.AllSorted(
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
                if (!await medicineService.ExistsByIdAsync(id))
                {
                    return BadRequest();
                }

                var model = await medicineService.MedicineDetails(id);

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
                var medicine = await medicineService.FindByIdAsync(id);//possible throwing

                if (!User.IsAdmin())
                {
                    return Forbid();
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
                if (!await medicineService.ExistsByIdAsync(id))
                {
                    return BadRequest();
                }
                if (model == null)
                {
                    return BadRequest();
                }
                await medicineService.EditAsync(id, model);

                return RedirectToAction(nameof(Details));
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
                var medicine = await medicineService.FindByIdAsync(id);//possible throwing

                if (!User.IsAdmin())
                {
                    return Forbid();
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
                if (!await medicineService.ExistsByIdAsync(id))
                {
                    return BadRequest();
                }
                await medicineService.DeleteAsync(id);

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
}
