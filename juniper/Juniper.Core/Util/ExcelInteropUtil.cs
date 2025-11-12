namespace Juniper.Core.Util
{
    using System.Data;
    using Excel = Microsoft.Office.Interop.Excel;

    public class ExcelInteropUtil
    {
        public static ExcelInteropUtil Current { get; private set; }

        public ExcelInteropUtil()
        {
            Current = this;
        }

        public List<UPCsModel> LastReadUPCList { get; } = new List<UPCsModel>();

        public async Task<List<UPCsModel>> GetFileText(string filepath, string worksheetname)
        {
            var upcjson = await MainViewModel.Current.FilesService.ReadToValueAsync<List<UPCsModel>>(MainViewModel.Current.SettingsViewModel.UpcJsonFilePath);
            if (upcjson != null)
                LastReadUPCList.AddRange(upcjson);

            //var ExcelWorkbookname = workbook.Name;           // statement get the workbookname  
            //var worksheetcount = workbook.Worksheets.Count;  // statement get the worksheet count  
            await Task.Run(async () =>
            {
                var processes = from p in Process.GetProcessesByName("EXCEL")
                                select p;

                foreach (var process in processes)
                {
                    if (process.MainWindowTitle == "Microsoft Excel - " + Path.GetFileName(filepath) ||
                    process.MainWindowTitle == Path.GetFileName(filepath) ||
                    process.MainWindowTitle == $"{Path.GetFileName(filepath)} - Excel" ||
                    process.MainWindowTitle == "")
                        process.Kill();
                }

                Excel.Application? excel = null;
                Excel.Workbook? workbook = null;
                try
                {
                    excel = new Excel.Application();       //create a instance for the Excel object  
                    excel.DisplayAlerts = false;
                    excel.Visible = false;

                    workbook = excel.Workbooks.Open(filepath);

                    MainViewModel.Current.DisplayInfobarMessage("Loading...", $"loading upc list from {filepath} this may take a minute", InfoSeverity.Informational);

                    foreach (var sheet in workbook.Worksheets)
                    {
                        Excel.Worksheet worksheet = (Excel.Worksheet)sheet;
                        if (worksheet.Name == worksheetname)
                        {
                            CancellationTokenSource cts = new CancellationTokenSource();

                            // Use ParallelOptions instance to store the CancellationToken
                            ParallelOptions po = new ParallelOptions();
                            po.CancellationToken = cts.Token;
                            po.MaxDegreeOfParallelism = Environment.ProcessorCount;

                            //Excel.Range range = worksheet.UsedRange;

                            //const String WildCard = "*";

                            //Excel.Range oFirstRow = range.Find(WildCard,
                            //    range.Cells[range.Rows.Count, 1], Excel.XlFindLookIn.xlValues,
                            //    Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows,
                            //    Excel.XlSearchDirection.xlNext, false, false, Missing.Value);


                            //Excel.Range oFirstColumn = range.Find(WildCard,
                            //    range.Cells[1, range.Columns.Count], Excel.XlFindLookIn.xlValues,
                            //    Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByColumns,
                            //    Excel.XlSearchDirection.xlNext, false, false, Missing.Value);

                            //Excel.Range oLastRow = range.Find(WildCard,
                            //    range.Cells[1, 1], Excel.XlFindLookIn.xlValues,
                            //    Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows,
                            //    Excel.XlSearchDirection.xlPrevious, false, false, Missing.Value);

                            //Excel.Range oLastColumn = range.Find(WildCard,
                            //    range.Cells[1, 1], Excel.XlFindLookIn.xlValues,
                            //    Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByColumns,
                            //    Excel.XlSearchDirection.xlPrevious, false, false, Missing.Value);

                            //Int32 iFirstRow = oFirstRow.Row;
                            //Int32 iFirstColumn = oFirstColumn.Column;
                            //Int32 iLastRow = oLastRow.Row;
                            //Int32 iLastColumn = oLastColumn.Column;

                            //Excel.Worksheet oWorksheet = range.Worksheet;

                            //Excel.Range usedRange = (Excel.Range)oWorksheet.get_Range(
                            //    (Excel.Range)oWorksheet.Cells[iFirstRow, iFirstColumn],
                            //    (Excel.Range)oWorksheet.Cells[iLastRow, iLastColumn]
                            //    );

                            Excel.Range colRange = worksheet.Columns["A:A"];
                            Excel.Range oLastRow = colRange.Find("*",
                                colRange.Cells[1, 1], Excel.XlFindLookIn.xlValues,
                                Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows,
                                Excel.XlSearchDirection.xlPrevious, false, false, Missing.Value);
                            Int32 iLastRow = oLastRow.Row;
                            var size = LastReadUPCList.Count == 0 ? 2 : LastReadUPCList.Count + 2;
                            if (iLastRow > size)
                            {
                                Parallel.For(size, iLastRow, po, i =>
                                {
                                    var product = ((Excel.Range)worksheet.Cells[i, 1]).Value ?? "";
                                    var productDescription = ((Excel.Range)worksheet.Cells[i, 2]).Value ?? "";
                                    var gtin = ((Excel.Range)worksheet.Cells[i, 3]).Value ?? "";
                                    var colorcode = ((Excel.Range)worksheet.Cells[i, 4]).Value ?? "";
                                    var colordescription = ((Excel.Range)worksheet.Cells[i, 5]).Value ?? "";
                                    var sizedescription = ((Excel.Range)worksheet.Cells[i, 6]).Value ?? "";
                                    var createdate = ((Excel.Range)worksheet.Cells[i, 7]).Value ?? "";
                                    var xs = ((Excel.Range)worksheet.Cells[i, 8]).Value ?? "";
                                    var s = ((Excel.Range)worksheet.Cells[i, 9]).Value ?? "";
                                    var m = ((Excel.Range)worksheet.Cells[i, 10]).Value ?? "";
                                    var l = ((Excel.Range)worksheet.Cells[i, 11]).Value ?? "";
                                    var xl = ((Excel.Range)worksheet.Cells[i, 12]).Value ?? "";
                                    var asst = ((Excel.Range)worksheet.Cells[i, 13]).Value ?? "";

                                    lock (LastReadUPCList)
                                        LastReadUPCList.Add(new UPCsModel()
                                        {
                                            Product = Convert.ToString(product),
                                            ProductDescription = Convert.ToString(productDescription),
                                            GTIN = Convert.ToString(gtin),
                                            ColorCode = Convert.ToString(colorcode),
                                            ColorDescripton = Convert.ToString(colordescription),
                                            SizeDescription = Convert.ToString(sizedescription),
                                            CreateDate = Convert.ToString(createdate),
                                            XS = Convert.ToString(xs),
                                            S = Convert.ToString(s),
                                            M = Convert.ToString(m),
                                            L = Convert.ToString(l),
                                            XL = Convert.ToString(xl),
                                            ASST = Convert.ToString(asst),
                                        });
                                });

                                await MainViewModel.Current.FilesService.WriteAsync(MainViewModel.Current.FilesService.SettingsFolder, SettingsViewModel.UpcJsonFileName, LastReadUPCList, true);
                            }
                            break;
                        }
                    }


                    MainViewModel.Current.DisplayInfobarMessage("Loading...", $"loading upc list from {filepath} complete", InfoSeverity.Success);
                }
                catch (Exception e)
                {
                    MainViewModel.Current.LoggerUtil.AddException(e, $"GetFileText {filepath} {worksheetname}");
                }
                finally
                {
                    workbook?.Close();
                    excel?.Quit();
                }
            });

            return LastReadUPCList;
        }
        public async Task<List<UPCsModel>> GetCsvFileText(string filepath)
        {
            var text = await MainViewModel.Current.FilesService.ReadToStringValueAsync(filepath);
            var lines = text?.Split(Environment.NewLine);

            foreach (var line in lines)
            {
                var clmn = line.Split(',');
                LastReadUPCList.Add(new UPCsModel()
                {
                    Product = clmn[0],
                    ProductDescription = clmn[1],
                    GTIN = clmn[2],
                    ColorCode = clmn[3],
                    ColorDescripton = clmn[4],
                    SizeDescription = clmn[5],
                    CreateDate = clmn[6],
                    //Category = clmn[8],
                    //Name = clmn[9],
                    //Salesprice = clmn[10],
                    //Cost = clmn[11],
                    //BloomiesSize = clmn[12]
                });
            }
            return LastReadUPCList;
        }

        public async Task ExportPackingList(List<Tuple<string, string, List<OrderPackItemModel>>> orderPackItemModels,
            string account, string? purchaseOrderNumber, string? canceldate, string? shipdate,
            List<POOrderLineModel> polines)
        {
            await Task.Run(async () =>
            {
                #region init
                orderPackItemModels = orderPackItemModels.OrderBy(o => o.Item1).ToList();

                Excel.Application excel;
                Excel.Workbook workbook;
                Excel.Worksheet sheet;
                Excel.Range range;

                // Start Excel and get Application object.
                excel = new Excel.Application();
                excel.Visible = true;

                // Get a new workbook.
                workbook = excel.Workbooks.Add(Missing.Value);
                sheet = (Excel.Worksheet)workbook.ActiveSheet;

                // Add table headers going cell by cell.
                sheet.Cells[1, 4] = "Account";
                sheet.Cells[2, 4] = account;

                sheet.Cells[1, 5] = "Order #";
                sheet.Cells[2, 5] = purchaseOrderNumber;

                //sheet.Cells[1, 4] = "ASN #";
                //sheet.Cells[2, 4] = shipmentIdentification;

                //sheet.Cells[1, 5] = "BOL #";
                //sheet.Cells[2, 5] = bol;

                //sheet.Cells[1, 6] = "Ship Date";
                //sheet.Cells[2, 6] = shipdate;
                //Excel.Range rg = (Excel.Range)sheet.Cells[2, 6];
                //rg.NumberFormat = "MM/DD/YY";

                sheet.Cells[1, 6] = "Cancel By";
                sheet.Cells[2, 6] = canceldate;
                Excel.Range rg2 = (Excel.Range)sheet.Cells[2, 6];
                rg2.NumberFormat = "MM/DD/YY";

                var tb = 0;
                foreach (var p in orderPackItemModels)
                {
                    tb += p.Item3.Sum(i => i.PackLevelList.Count);
                }
                sheet.Cells[1, 7] = "Boxes";
                sheet.Cells[2, 7] = tb;
                #endregion

                #region Title
                //Add a title
                //sheet.Cells[1, 1] = "Your title here";

                //Span the title across columns A through H
                Excel.Range startCell = sheet.Cells[1, 2];
                Excel.Range endCell = sheet.Cells[1, 7];
                Excel.Range titleRange = sheet.Range[startCell, endCell];

                // Excel.Range titleRange = sheet.get_Range(sheet.Cells[1, "A"], sheet.Cells[1, "G"]);//, sheet.get_Range(sheet.Cells[2, "A"], sheet.Cells[2, "H"]));

                //Center the title horizontally then vertically at the above defined range
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                titleRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                //Increase the font-size of the title
                titleRange.Font.Size = 14;

                //Make the title bold
                titleRange.Font.Bold = true;

                //Give the title background color
                titleRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

                //Set the title row height
                titleRange.RowHeight = 36;
                #endregion

                #region Column Headers
                var nasn = 1;
                var nbol = 2;
                var ndc = 3;
                var nstore = 4;
                var nstyle = 5;
                var nsscc = 6;
                var ncolor = 7;
                var nprice = 8;
                var npricetype = 9;
                var nsize = 10;
                var nupc = 11;
                var nqty = 12;
                sheet.Cells[4, nasn] = "ASN#";
                sheet.Cells[4, nbol] = "BOL#";
                sheet.Cells[4, ndc] = "DC";
                sheet.Cells[4, nstore] = "Store #";
                sheet.Cells[4, nsscc] = "SSCC";
                sheet.Cells[4, nstyle] = "Vendor Style";
                sheet.Cells[4, ncolor] = "Color";
                sheet.Cells[4, nprice] = "Unit Price";
                sheet.Cells[4, npricetype] = "Price Type";
                sheet.Cells[4, nsize] = "Size";
                sheet.Cells[4, nupc] = "UPC/EAN";
                sheet.Cells[4, nqty] = "Qty";

                //Select the header row (row 2 aka row[1])
                Excel.Range headerRange = sheet.Range[sheet.Cells[4, nasn], sheet.Cells[4, nqty]];
                //Set the header row fonts bold
                headerRange.Font.Bold = true;

                //Center the header row horizontally
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                //Put a border around the header row
                //headerRange.BorderAround(Excel.XlLineStyle.xlContinuous,
                //    Excel.XlBorderWeight.xlMedium,
                //    Excel.XlColorIndex.xlColorIndexAutomatic,
                //    Excel.XlColorIndex.xlColorIndexAutomatic);

                //Give the header row background color
                //headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.MediumPurple);
                #endregion

                #region Page Setup
                //Set page orientation to landscape
                sheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait;

                //Set margins
                sheet.PageSetup.TopMargin = 18;
                sheet.PageSetup.RightMargin = 0;
                sheet.PageSetup.BottomMargin = 54;
                sheet.PageSetup.LeftMargin = 0;

                sheet.PageSetup.CenterHorizontally = true;

                //excel.PrintCommunication = false;
                //sheet.PageSetup.FitToPagesWide = true;
                //sheet.PageSetup.FitToPagesTall = true;

                //Set Header and Footer (see code list below)
                //&P - the current page number.
                //&N - the total number of pages.
                //&B - use a bold font*.
                //&I - use an italic font*.
                //&U - use an underline font*.
                //&& - the '&' character.
                //&D - the current date.
                //&T - the current time.
                //&F - workbook name.
                //&A - worksheet name.
                //&"FontName" - use the specified font name*.
                //&N - use the specified font size*.
                //EXAMPLE: sheet.PageSetup.RightFooter = "&F"
                sheet.PageSetup.RightHeader = "";
                sheet.PageSetup.CenterHeader = "";// "&B &16" + string.Join(" ", account, purchaseOrderNumber, shipmentIdentification, bol);
                sheet.PageSetup.LeftHeader = "";
                sheet.PageSetup.RightFooter = "";
                sheet.PageSetup.CenterFooter = "Page &P of &N";
                sheet.PageSetup.LeftFooter = "";

                // sheet.PageSetup.PrintTitleColumns = "$A1:$I1" ;//sheet.Columns["A:I"].Address;
                sheet.PageSetup.PrintTitleRows = "$1:$4";//sheet.Rows["A:E"].Address;

                //Set gridlines
                workbook.Windows[1].DisplayGridlines = true;
                sheet.PageSetup.PrintGridlines = false;
                #endregion

                #region Worksheet Style
                /* 
                //Color every other column but skip top two
                Excel.Range workSheetMinusHeader = xlApp.get_Range("A1", "F1");
                Excel.FormatCondition format =
                    (Excel.FormatCondition)workSheetMinusHeader.EntireColumn.FormatConditions.Add(
                        Excel.XlFormatConditionType.xlExpression,
                        Excel.XlFormatConditionOperator.xlEqual,
                        "=IF(ROW()<3,,MOD(ROW(),2)=0)");
                format.Interior.Color = Excel.XlRgbColor.rgbWhiteSmoke;

                //Put a border around the entire work sheet
                workSheetMinusHeader.EntireColumn.BorderAround(Excel.XlLineStyle.xlContinuous,
                    Excel.XlBorderWeight.xlMedium,
                    Excel.XlColorIndex.xlColorIndexAutomatic,
                    Excel.XlColorIndex.xlColorIndexAutomatic);
                */
                #endregion

                #region Specific Width, Height, Wrappings, and Format Types
                //Set the font size and text wrap of columns for the entire worksheet
                string[] strColumns = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
                foreach (string s in strColumns)
                {
                    //((Excel.Range)sheet.Columns[s, Type.Missing]).Font.Size = 12;
                    ((Excel.Range)sheet.Columns[s, Type.Missing]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                //Set Width of individual columns
                //((Excel.Range)sheet.Columns["A", Type.Missing]).ColumnWidth = 7.00;
                //((Excel.Range)sheet.Columns["B", Type.Missing]).ColumnWidth = 18.00;
                //((Excel.Range)sheet.Columns["C", Type.Missing]).ColumnWidth = 18.00;
                //((Excel.Range)sheet.Columns["D", Type.Missing]).ColumnWidth = 30.00;
                //((Excel.Range)sheet.Columns["E", Type.Missing]).ColumnWidth = 40.00;
                //((Excel.Range)sheet.Columns["F", Type.Missing]).ColumnWidth = 15.00;

                //Select everything except title row (first row) and set row height for the selected rows
                //sheet.Range["a2", sheet.Range["a2"].End[Excel.XlDirection.xlDown].End[Excel.XlDirection.xlToRight]].RowHeight = 45;

                //Format ID column and prevent long numbers from showing up as scientific notation
                Excel.Range idRange = (Excel.Range)sheet.Cells[6, nupc];
                idRange.EntireColumn.NumberFormat = "#";
                Excel.Range idsccRange = (Excel.Range)sheet.Cells[6, nsscc];
                idsccRange.EntireColumn.NumberFormat = "#";

                //Format Social Security Numbers so that Excel does not drop the leading zeros
                //Excel.Range idRange = (Excel.Range)sheet.Cells[1, "C"];
                //idRange.EntireColumn.NumberFormat = "000000000";
                #endregion

                #region Save & Quit
                //Save and quit, use SaveCopyAs since SaveAs does not always work
                //string fileName = Server.MapPath("~/YourFileNameHere.xls");
                excel.DisplayAlerts = false; //Supress overwrite request
                                             //xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                                             //xlWorkBook.Close(true, misValue, misValue);
                                             //xlApp.Quit();

                //Release objects
                //releaseObject(sheet);
                //releaseObject(xlWorkBook);
                //releaseObject(xlApp);

                //Give the user the option to save the copy of the file anywhere they desire
                //String FilePath = Server.MapPath("~/YourFileNameHere.xls");
                //System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
                //response.ClearContent();
                //response.Clear();
                //response.ContentType = "text/plain";
                //response.AddHeader("Content-Disposition", "attachment; filename=YourFileNameHere-" + DateTime.Now.ToShortDateString() + ".xls;");
                //response.TransmitFile(FilePath);
                //response.Flush();
                //response.Close();

                //Delete the temporary file
                //DeleteFile(fileName);
                #endregion


                //sheet.get_Range("A1", "Z1").Font.Bold = true;
                //sheet.get_Range("A1", "Z1").Font.Size = 16;
                //Excel.Range titleRange = excel.Union(excel.get_Range(sheet.Cells[1, "A"], sheet.Cells[1, "H"]), excel.get_Range(sheet.Cells[2, "A"], sheet.Cells[2, "H"]));
                //Set the value of DifferentOddEven as 1, which indicates that headers/footers for odd and even pages are different.  
                //sheet.PageSetup.CenterHeader = "";//DifferentOddEven = 1;
                //Set header and footer string for odd pages, and format the string.  
                //sheet.PageSetup.OddHeaderString = "&\"Arial\"&12&B&KFFC000Odd_Header";

                var lines = MainViewModel.Current.ExcelUtil.LastReadUPCList;
                //grand total
                var gt = 0.0;
                //curline to write on
                var curLine = 5;
                Excel.XlRgbColor lastColor = Excel.XlRgbColor.rgbLightGray;
                //asn#,bol#,List<OrderPackItemModel>
                foreach (var tuple in orderPackItemModels)
                {
                    sheet.Cells[curLine, nasn] = tuple.Item1;
                    sheet.Cells[curLine, nbol] = tuple.Item2;

                    //List<OrderPackItemModel>
                    foreach (OrderPackItemModel opi in tuple.Item3)
                    {
                        sheet.Cells[curLine, ndc] = $"{opi.Address.DC}";// / {opi.Address.DCAddressLocationNumber}";
                        sheet.Cells[curLine, nstore] = opi.Address.AddressLocationNumber;
                        
                        var ttl = 0.0;
                        foreach (var pl in opi.PackLevelList)
                        {
                            sheet.Cells[curLine, nsscc] = pl.ShippingSerialID.RemoveInFrontTill(10);

                            foreach (var sl in pl.ItemLevel.ShipmentLines.OrderBy(ll => ll.ColorDescription).ThenBy(lll => lll.VendorPartNumber).ThenBy(l => l.SizeDescriptionNum))
                            {
                                string up = "";
                                string ptId = "";
                                if (polines.FirstOrDefault(l
                                    => l.LineItem?.OrderLine?.ConsumerPackageCode == sl.ConsumerPackageCode)?.LineItem?.PriceInformation is List<LineItemPriceInformation> piList)
                                {
                                    foreach (var pi in piList)
                                    {
                                        if (pi.UnitPrice != null)
                                        {
                                            if (up == "")
                                                up = pi.UnitPrice.ToString() ?? "";
                                            else if (up != "" && pi.UnitPrice != null)
                                                up = up + ", " + pi.UnitPrice.ToString();
                                        }

                                        if (pi.PriceTypeIdCode != null)
                                        {
                                            if (ptId == "")
                                                ptId = pi.PriceTypeIdCode.ToString() ?? "";
                                            else if (ptId != "" && pi.PriceTypeIdCode != null)
                                                ptId = ptId + ", " + pi.PriceTypeIdCode.ToString();
                                        }
                                    }
                                }
                                if (!up.Contains(", "))
                                {
                                    Excel.Range rg3 = (Excel.Range)sheet.Cells[curLine, nprice];
                                    rg3.NumberFormat = "[$$-en-US] #,##0.00";
                                }

                                sheet.Cells[curLine, nprice] = up;
                                sheet.Cells[curLine, npricetype] = ptId;

                                sheet.Cells[curLine, nstyle] = sl.VendorPartNumber;
                                sheet.Cells[curLine, ncolor] = sl.ColorDescription;
                                sheet.Cells[curLine, nupc] = sl.ConsumerPackageCode;
                                sheet.Cells[curLine, nqty] = sl.ShipQty;
                                sheet.Cells[curLine, nsize] = sl.SizeDescription;
                                sheet.Cells[curLine, nsize].Font.Bold = true;

                                sheet.Range["C" + (curLine), "K" + (curLine)].Interior.Color = lastColor; //(i + j) % 2 == 0 ? : ;
                                ttl += sl.ShipQty;
                                curLine++;
                            }
                        }
                        
                        sheet.Cells[curLine, nqty] = ttl;
                        sheet.Cells[curLine, nupc] = "Total";

                        sheet.Cells[curLine, nqty].Font.Bold = true;
                        sheet.Cells[curLine, nupc].Font.Bold = true;

                        sheet.Range["C" + (curLine), "K" + (curLine)].Interior.Color = lastColor;
                        lastColor = lastColor == Excel.XlRgbColor.rgbLightGray ? Excel.XlRgbColor.rgbAliceBlue : Excel.XlRgbColor.rgbLightGray;
                        gt += ttl;
                        curLine++;
                    }
                }
                //end
                sheet.Cells[curLine, nqty] = gt;
                sheet.Cells[curLine, nupc] = "Grand Total";
                sheet.Cells[curLine, nqty].Font.Bold = true;
                sheet.Cells[curLine, nupc].Font.Bold = true;

                // AutoFit columns A:D.
                range = sheet.Range["A1", "Z1"];
                range.EntireColumn.AutoFit();

                // Make sure Excel is visible and give the user control
                // of Microsoft Excel's lifetime.
                excel.Visible = true;
                excel.UserControl = true;
            });
        }

        public async Task ExportInvoice(params InvoiceViewModel[] ivms)
        {
            await Task.Run(async () =>
            {
                Excel.Application excel;
                Excel.Workbook workbook;
                Excel.Worksheet sheet;
                Excel.Range range;

                // Start Excel and get Application object.
                excel = new Excel.Application();
                excel.Visible = true;

                // Get a new workbook.
                workbook = excel.Workbooks.Add(Missing.Value);
                sheet = (Excel.Worksheet)workbook.ActiveSheet;

                // Add table headers going cell by cell.
                sheet.Cells[1, 1] = "Invoice Number";
                sheet.Cells[1, 2] = "Invoice Date";
                sheet.Cells[1, 3] = "PO #";
                sheet.Cells[1, 4] = "ASN #";
                sheet.Cells[1, 5] = "Invoice Total";
                sheet.Cells[1, 6] = "Account";
                sheet.Cells[1, 7] = "XS UPC";
                sheet.Cells[1, 8] = "Style #";
                sheet.Cells[1, 9] = "Color";
                sheet.Cells[1, 10] = "Store #";

                var lines = MainViewModel.Current.ExcelUtil.LastReadUPCList;
                var times = 2;

                foreach (var ivm in ivms)
                {
                    await ivm.LoadS3Data();

                    var ivmlines = ivm.InvoiceLines.ToList();
                    var ivmAddylines = ivm.InvoiceHeader.Address.ToList();
                    if (ivmlines.Count > 0 && ivmAddylines.FirstOrDefault(a => a.SelectedAddressTypeCode?.IsOneOf("BY", "BT") == true) is BaseAddressModel addy)
                    {
                        //var l = ivmlines[0];

                        sheet.Cells[times, 1] = ivm.InvoiceHeader.InvoiceNumber;
                        sheet.Cells[times, 2] = ivm.InvoiceHeader.InvoiceDate.ToString("MM/dd/yyyy");
                        sheet.Cells[times, 3] = ivm.InvoiceHeader.PurchaseOrderNumber;
                        sheet.Cells[times, 4] = ivm.ASNId;

                        sheet.Cells[times, 5] = ivm.Summary.TotalAmount;

                        sheet.Cells[times, 6] = ivm.asnvm.povm.DisplayName;

                        var productstring = "";
                        var collordescription = "";
                        var cpcs = "";
                        for (int i = 0; i < ivmlines.Count; i++)
                        {
                            var invline = ivmlines[i];
                            if (invline.InvoiceLine.ConsumerPackageCode is not null)
                            {
                                if (!cpcs.Contains(invline.InvoiceLine.ConsumerPackageCode))
                                    cpcs += i == 0 ? invline.InvoiceLine.ConsumerPackageCode : ", " + invline.InvoiceLine.ConsumerPackageCode;

                                var li = lines.FirstOrDefault(ll => ll.GTIN == invline.InvoiceLine.ConsumerPackageCode);
                                if (li != null)
                                {
                                    if (!productstring.Contains(li.Product))
                                        productstring += i == 0 ? li.Product : ", " + li.Product;
                                    if (!collordescription.Contains(li.ColorDescripton))
                                        collordescription += i == 0 ? li.ColorDescripton : ", " + li.ColorDescripton;
                                }
                            }
                            else
                            { }
                        }

                        sheet.Cells[times, 7] = cpcs;
                        sheet.Cells[times, 8] = productstring;
                        sheet.Cells[times, 9] = collordescription;

                        var addys = "";
                        for (int i = 0; i < ivmAddylines.Count; i++)
                        {
                            var a = ivmAddylines[i];
                            if (a.AddressLocationNumber is string ad && !addys.Contains(ad))
                                addys += i == 0 ? $"{ad}/{a.SelectedAddressTypeCode}" : ", " + $"{ad}/{a.SelectedAddressTypeCode}";
                        }
                        sheet.Cells[times, 10] = addys;

                        times++;
                    }
                }

                // AutoFit columns 
                range = sheet.get_Range("A1", "Z1");
                range.EntireColumn.AutoFit();

                // Make sure Excel is visible and give the user control
                // of Microsoft Excel's lifetime.
                excel.Visible = true;
                excel.UserControl = true;
            });
        }
    }
}