using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccesLayer.Concrete;
using Fotuber.Models;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fotuber.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<ServiceModel> DestinationList()
        {
            List<ServiceModel> destinationModels = new List<ServiceModel>();
            using (var c = new Context())
            {
                destinationModels = c.Services.Select(x => new ServiceModel
                {
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
            //application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Paket Listesi");
                workSheet.Cell(1, 1).Value = "Paket Adı";
                workSheet.Cell(1, 2).Value = "Paket Açıklaması";
                workSheet.Cell(1, 3).Value = "Fiyat";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.Name;
                    workSheet.Cell(rowCount, 2).Value = item.Description;
                    workSheet.Cell(rowCount, 4).Value = item.Price;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }
}
