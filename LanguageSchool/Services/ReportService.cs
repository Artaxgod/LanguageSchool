using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Services
{
    public class ReportService
    {
        public byte[] GenerateAttendanceReport(int groupID)
        {
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Посещаемость");

            worksheet.Cells[1, 1].Value = "ФИО";
            worksheet.Cells[1, 2].Value = "Дата";
            worksheet.Cells[1, 3].Value = "Статус";

            var attendances = _context.Attendances
                .Where(a => a.Schedule.GroupSchedules.Any(gs => gs.GroupID == groupID))
                .ToList();

            for (int i = 0; i < attendances.Count; i++)
            {
                worksheet.Cells[i + 2, 1].Value = attendances[i].Client.User.FullName;
                worksheet.Cells[i + 2, 2].Value = attendances[i].Schedule.LessonDate.ToString("dd.MM.yyyy");
                worksheet.Cells[i + 2, 3].Value = attendances[i].IsPresent ? "Присутствовал" : "Отсутствовал";
            }

            return package.GetAsByteArray();
        }
    }
}
