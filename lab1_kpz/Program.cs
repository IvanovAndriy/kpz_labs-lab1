using lab1_kpz.classes;

Product ogirok = new Product("Огірок", new Money("UAH", 100, 30), "найкращий огірок", "кг", 70, DateTime.Now);
Product pomidor = new Product("Помідор", new Money("USD", 77, 20), "найкращий помідор", "кг", 100, DateTime.Now);
Warehouse sklad1 = new Warehouse();
sklad1.getReporting().addProduct(ogirok);
sklad1.getReporting().addProduct(pomidor);
sklad1.getReporting().getAllProducts();

sklad1.getReporting().decreaseProduct(pomidor, 10);
sklad1.getReporting().getAllProducts();

sklad1.getReporting().decreasePriceOnProduct(ogirok, new Money("UAH", 10, 50));