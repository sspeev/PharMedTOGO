namespace PharMedTOGO.Core.Models;

public class AllCartsQueryModel
{
    public decimal TotalMedicinesSum { get; set; }

    public decimal DeliveryPrice { get; set; }

    public IList<MedicineServiceModel> Medicines { get; set; } = [];

    public decimal Total { get; set; }
}
