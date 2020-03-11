using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FS.Abp.Npoi.Mapper
{
    public interface IExportFactory:Volo.Abp.DependencyInjection.ITransientDependency
    {
        byte[] Produce<T>(string sheetName, IEnumerable<T> modelJson)
            where T : class;
    }
    public class ExportFactory : IExportFactory
    {
        public byte[] Produce<T>(string sheetName, IEnumerable<T> modelJson)
            where T:class
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet(sheetName);
            var mapper = new global::Npoi.Mapper.Mapper(workbook);
            mapper.ForHeader(cell =>
            {
                sheet.AutoSizeColumn(cell.ColumnIndex);
            });
            mapper.Put<T>(modelJson, 0);
            MemoryStream memoryStream = new MemoryStream();
            mapper.Workbook.Write(memoryStream);
            var datas = memoryStream.ToArray();
            memoryStream.Close();
            return datas;
        }
    }
}
