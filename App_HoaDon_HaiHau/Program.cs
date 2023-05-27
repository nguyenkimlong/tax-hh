﻿using App_HoaDon_HaiHau.Screen;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App_HoaDon_HaiHau
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _host.Start();


            //Đoạn này mặc định của winform kệ nó thôi.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var form1 = _host.Services.GetRequiredService<Form1>();

            Application.Run(form1);

            //Khi form chính (form1) bị đóng <==> chương trình kết thúc ấy
            //thì dừng host
            _host.StopAsync().GetAwaiter().GetResult();

            //và giải phóng tài nguyên host đã sử dụng.
            _host.Dispose();
        }

        private static readonly IHost _host
         = Host.CreateDefaultBuilder()
                //Ilogger ở tất cả các constructor sẽ được tự động tiêm giá trị do Serilog là một
                //package sử dụng thay thế cho Logger của Microsoft. Serilog sẽ hỗ trợ lưu file,
                //hoặc viết ra console có màu nhấn mạnh dễ đọc.
                //.UseSerilog((host, loggerConfiguration) =>
                //{
                //    loggerConfiguration
                //        //Viết log hệ thống ra file test.txt, mỗi ngày tạo 1 file
                //        .WriteTo.File("test.txt", rollingInterval: RollingInterval.Day)

                //        //Đồng thời viết cả log ra SQLiteDB có tên blog.db (thích thì thay tên khác)
                //        .WriteTo.SQLite(".\\blog.db")

                //        //WriteTo Console và Debug không hoạt động ở Winform .NetCore 5.0
                //        //(mình chữa rõ lý do, cũng ko ảnh hưởng vì log này có file text dễ dùng rồi.
                //        //.WriteTo.Debug()

                //        //Level tối thiểu sẽ pass để chuyển lưu vào log hoặc hiển thị ra console 
                //        // ở các dự án web hoặc wpf khác vì console, debug ko thấy chạy ở winform này 
                //        //như đã trình bày ở trên
                //        .MinimumLevel.Debug()
                //        /*.MinimumLevel.Override("WinFormsApp3.Form1", Serilog.Events.LogEventLevel.Debug)*/;
                //})
                .ConfigureServices(services =>
                {
                    services.AddDbContext<DbContextSql>(c => {
                        c.UseSqlite("Data Source=thuedb.db");
                    });

                    services.AddSingleton<Form1>();
                    services.AddSingleton<ucCompany>();
                    services.AddSingleton<ucTaxXML>();

                    //services.AddSingleton<ICommand, MakeSandwichCommand>();

                    //services.AddSingleton<MainViewModel>();

                    //services.AddSingleton<MainWindow>(s => new MainWindow()
                    //{
                    //    DataContext = s.GetRequiredService<MainViewModel>()
                    //});
                })
                .Build();
    }
}