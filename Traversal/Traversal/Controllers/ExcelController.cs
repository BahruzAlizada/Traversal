using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using Traversal.Models;

namespace Traversal.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using(var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Capacity = x.Capacity,
                    Price = x.Price
                }).ToList();
            }
            return destinationModels;
        }


        public IActionResult DestinationExcelReport()
        {
            using (var vorkBook = new XLWorkbook())
            {
                var vorkSheet = vorkBook.Worksheets.Add("Destination List");
                vorkSheet.Cell(1, 1).Value = "City";
                vorkSheet.Cell(1, 2).Value = "DayNight";
                vorkSheet.Cell(1, 3).Value = "Capacity";
                vorkSheet.Cell(1, 4).Value = "Price";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    vorkSheet.Cell(rowCount,1).Value=item.City;
                    vorkSheet.Cell(rowCount, 2).Value = item.DayNight;
                    vorkSheet.Cell(rowCount, 3).Value = item.Capacity;
                    vorkSheet.Cell(rowCount,4).Value = item.Price;
                    rowCount++;
                }

                using(var stream = new MemoryStream())
                {
                    vorkBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Destination.xlsx");
                }
            }
        }
    }
}
