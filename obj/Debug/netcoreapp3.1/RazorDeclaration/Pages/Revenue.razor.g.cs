// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VMP.Dashboard.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using VMP.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using VMP.Dashboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Horeac App\VMP.Dashboard\Pages\Revenue.razor"
using VMP.Dashboard.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Horeac App\VMP.Dashboard\Pages\Revenue.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Horeac App\VMP.Dashboard\Pages\Revenue.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Horeac App\VMP.Dashboard\Pages\Revenue.razor"
using System.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Horeac App\VMP.Dashboard\Pages\Revenue.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/revenue")]
    public partial class Revenue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "E:\Horeac App\VMP.Dashboard\Pages\Revenue.razor"
       
    public static String[] ThemeColorList = new String[] { "#816aae", "#d682b6", "#f9956b", "#fec578", "#5e8ac7", "#5ea5c7", "#50c5dd", "#5dc4b1", "#ececec" };
    public String[] RevenueOverTimepalettes = new String[] { ThemeColorList[8], ThemeColorList[1] };

    SqlDataAccess sda = new SqlDataAccess();

    private List<RevenueOverTimeGrid> revenueOverTimesModel;
    private List<CategoryDb> catSubCatDb;
    private List<RegionDb> regions;
    private List<SegmentDb> segments;
    private List<totalsales> TotalsalesDb;
    private List<productListed> ProductListedb;
    private List<CategorySale> CategorySalesdb;
    private List<CategorySaleBar> CategorySaleBarsdb;
    private List<BrandsBar> BrandsBarsdb;
    private List<RegionBar> RegionBarsdb;

    private List<OrderPivot> OrderPivotDb;

    protected override void OnInitialized()
    {
        catSubCatDb = sda.GetCategoryDbs();
        regions = sda.GetRegions();
        segments = sda.GetSegment();

        sda.SetDate(StartDate, EndDate);

        IntializeData();
    }

    public void getValues()
    {
        // var value = multiselectValue;
        IntializeData();
    }

    public DateTime? StartDate { get; set; } = new DateTime(2020, 01, 01);
    public DateTime? EndDate { get; set; } = new DateTime(2020, 12, 31);
    public DateTime? PrevStartDate { get; set; } = new DateTime(2019, 01, 01);
    public DateTime? PrevEndDate { get; set; } = new DateTime(2019, 12, 31);
    public DateTime MinDate { get; set; } = new DateTime(2019, 01, 01);
    public DateTime MaxDate { get; set; } = new DateTime(2020, 12, 31);
    public DateTime lastMonthStart { get; set; } = new DateTime(2020, 11, 01);
    public DateTime lastMonthEnd { get; set; } = new DateTime(2020, 11, 30);
    public DateTime last3MonthStart { get; set; } = new DateTime(2020, 10, 01);
    public DateTime last3MonthEnd { get; set; } = new DateTime(2020, 12, 31);
    public DateTime ytdStart { get; set; } = new DateTime(2020, 01, 01);
    public DateTime ytdEnd { get; set; } = new DateTime(2020, 12, 31);
    public DateTime oneyearStart { get; set; } = new DateTime(2020, 01, 01);
    public DateTime oneyearEnd { get; set; } = new DateTime(2020, 12, 31);
    public DateTime twoyearsStart { get; set; } = new DateTime(2019, 01, 01);
    public DateTime twoyearsEnd { get; set; } = new DateTime(2020, 12, 31);
    public string[] multiselectValue { get; set; }
    public string[] regionvalues { get; set; }
    public string[] segemntvalues { get; set; }
    private List<string> Cols = new List<string>();
    private List<ExpandoObject> Transposed { get; set; } = new List<ExpandoObject>();
    DataTable dtFlat;
//    public string selectedGroupby {​ get; set; }​ = "Month";


    public void OnDateRangeChange(RangePickerEventArgs<DateTime?> args)
    {
        sda.SetDate(args.StartDate, args.EndDate);
        //StateHasChanged();
        //IntializeData();

    }

    private void IntializeData()
    {
        sda.FilterCreation(multiselectValue, regionvalues, segemntvalues,selectedGroupby);

        revenueOverTimesModel = sda.GetRevenueOverTimesGrid();

        TotalsalesDb = sda.GetTotalsales();

        ProductListedb = sda.GetProductListedb();

        CategorySalesdb = sda.GetCategorySales();

        CategorySaleBarsdb = sda.GetCategorySaleBars();

        BrandsBarsdb = sda.GetBrandsBars();

        RegionBarsdb = sda.GetRegionBars();

        OrderPivotDb = sda.GetOrderPivots();

        dtFlat = SqlDataAccess.ToDataTable(revenueOverTimesModel);
        dtFlat = GenerateTransposedTable(dtFlat);
        Cols = new List<string>();
        foreach (DataColumn col in dtFlat.Columns)
        {
            Cols.Add(col.ColumnName);
        }
        GenerateListFromTable(dtFlat);
        //dtFlat = GenerateTransposedTable(revenueOverTimesModel);
        //Donut Db Chart

    }

    public bool ShowSelectAllCheckBox { get; set; } = true;
    public bool EnableSelectionOrders { get; set; } = false;
    public bool EnableCheckBox { get; set; } = true;

    private DataTable GenerateTransposedTable(DataTable inputTable)
    {
        DataTable outputTable = new DataTable();
        outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());
        foreach (DataRow inRow in inputTable.Rows)
        {
            string newColName = DateTime.Parse(inRow[0].ToString()).ToString("MMM-yy-dd");
            outputTable.Columns.Add(newColName);
        }
        for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
        {
            DataRow newRow = outputTable.NewRow();
            if (inputTable.Columns[rCount].ColumnName.ToString() == "PreviousSeriesValue")
            {
                newRow[0] = "Previous";
            }
            else if (inputTable.Columns[rCount].ColumnName.ToString() == "CurrentSeriesValue")
            {
                newRow[0] = "Current";
            }
            else if (inputTable.Columns[rCount].ColumnName.ToString() == "Growth")
            {
                newRow[0] = "Growth %";
            }
            else if (inputTable.Columns[rCount].ColumnName.ToString() == "GrowthAbs")
            {
                newRow[0] = "Abs Growth";
            }

            if (inputTable.Columns[rCount].ColumnName.ToString() != "Error")
            {
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    if (newRow[0].ToString() == "Growth %")
                    {
                        newRow[cCount + 1] = colValue + "%";
                    }
                    else
                    {
                        newRow[cCount + 1] = Math.Round(Convert.ToDouble(colValue), 0).ToString("$#,##0");
                    }
                }
                outputTable.Rows.Add(newRow);
            }
        }
        return outputTable;
    }

    //convert datatable to list

    public void GenerateListFromTable(DataTable input)
    {
        //Transposed = null;
        Transposed = new List<ExpandoObject>();
        foreach (DataRow row in input.Rows)
        {
            System.Dynamic.ExpandoObject e = new System.Dynamic.ExpandoObject();
            foreach (DataColumn col in input.Columns)
                e.TryAdd(col.ColumnName, row.ItemArray[col.Ordinal]);
            Transposed.Add(e);
        }
    }

    List<PivtoDrop> PivotDropDown =
    new List<PivtoDrop>() {
            new PivtoDrop { Name = "Products", Value = "Products" },
            new PivtoDrop { Name = "Category > Brands > Products", Value = "Category" },
            new PivtoDrop { Name = "Brands > Products", Value = "Brands" }
    };
    public class PivtoDrop
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    SfPivotView<OrderPivot> Pivot;

    public string selectedvalue = "Products";

    private void updatePivot()
    {
        //Pivot.LayoutRefreshAsync();
        StateHasChanged();
    }
    public class viewby
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public List<viewby> viewbydata = new List<viewby>
{
        new viewby{Id=1,Name="Year"},
        new viewby{Id=2,Name="Quarter"},
        new viewby{Id=3,Name="Month"},
        new viewby{Id=4,Name="Week"},
        new viewby{Id=5,Name="Day"}
    };
    public string selectedGroupby = "Month";

 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
