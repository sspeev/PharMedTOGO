using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Web.Extensions;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Web.Controllers;

[Authorize(Roles = AdminConstant)]
public class SaleController(
    ISaleService _saleService,
    IMedicineService _medicineService) : BaseController
{
    [HttpGet]
    public IActionResult Add()
    {
        return View(new SaleFormModel());
    }

    [HttpPost]
    public async Task<IActionResult> Add(SaleFormModel model)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (model == null)
            {
                return BadRequest();
            }
            await _saleService.CreateAsync(model);

            return RedirectToAction("All", "Sale");
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
    public async Task<IActionResult> All([FromQuery] AllSalesQueryModel query)
    {
        try
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            var model = await _saleService.AllAsync();

            query.TotalSales = model.TotalSales;
            query.Sales = model.Sales;
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
    public async Task<IActionResult> AttachMedicine(int saleId)
    {
        try
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (!await _saleService.ExistsByIdAsync(saleId))
            {
                return BadRequest();
            }

            var medicines = await _medicineService.AllAsync();
            var model = new AttachMedicineFormModel()
            {
                SaleId = saleId,
                Medicines = medicines.Medicines.Where(m => m.SaleId == null).ToList(),
            };
            return View(model);
        }
        catch (Exception e)
        {
            return View("Error", new ErrorViewModel()
            {
                ExceptionMessage = e.Message,
            });
        }
    }

    [HttpPost]
    public async Task<IActionResult> AttachMedicine(int saleId, int medicineId)
    {
        try
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            await _saleService.AttachMedicine(saleId, medicineId);//possible throwing

            var medicines = await _medicineService.AllAsync();
            var model = new AttachMedicineFormModel()
            {
                SaleId = saleId,
                Medicines = medicines.Medicines.Where(m => m.SaleId == null).ToList()
            };
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
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            var sale = await _saleService.FindByIdAsync(id);//possible throwing

            var model = new SaleFormModel()
            {
                Discount = sale.Discount,
                StartDate = sale.StartDate,
                EndDate = sale.EndDate
            };

            TempData.Add("saleId", id);
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
    public async Task<IActionResult> Edit(int id, SaleFormModel model)
    {
        try
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (!await _saleService.ExistsByIdAsync(id))
            {
                return BadRequest();
            }
            if (model == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _saleService.EditAsync(id, model);

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

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            var sale = await _saleService.FindByIdAsync(id);// possible throwing

            if (sale == null)
            {
                return BadRequest();
            }

            var model = new SaleDeleteModel()
            {
                Id = sale.Id,
                StartDate = sale.StartDate,
                EndDate = sale.EndDate
            };
            TempData.Add("saleId", id);

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
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (!await _saleService.ExistsByIdAsync(id))
            {
                return BadRequest();
            }
            await _saleService.DeleteAsync(id);

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
