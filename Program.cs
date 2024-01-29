
using Automation_ML;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

//new DriverManager().SetUpDriver(new ChromeConfig());

MercadoLibre mercadoLibre = new MercadoLibre(new ChromeDriver());

mercadoLibre.AbrirPaginaPrincipal();
mercadoLibre.BuscarProducto("TV Xiaomi");
mercadoLibre.SeleccionarProducto("xiaomi tv a pro 43 - tienda oficial xiaomi");
mercadoLibre.CerrarVentana();

