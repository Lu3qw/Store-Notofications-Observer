using Store_Notofications_Observer;

Store store = new Store();

Customer oleg = new Customer("Олег");
Customer viktoria = new Customer("Вікторія");

// Олег та Вікторія підписуються на категорії
oleg.Subscribe(store, "Смартфони");
oleg.Subscribe(store, "Ноутбуки");
viktoria.Subscribe(store, "Смартфони");

// Сповіщення про знижку на "Ноутбуки"
store.NotifyDiscounts("Ноутбуки", "Знижка 20% на всі ноутбуки!");

// Олег відписується від "Ноутбуки"
oleg.Unsubscribe(store, "Ноутбуки");

// Сповіщення про знижку на "Смартфони"
store.NotifyDiscounts("Смартфони", "Знижка 15% на всі смартфони!");