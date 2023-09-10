
using RealEstate;

ApartmentBuilding myMozart = new ApartmentBuilding("myMozart",
    new Flat(4300000, 20, 3, "3.1"),
    new Flat(3900000, 17, 3, "3.2"),
    new Flat(5500000, 35, 3, "3.3"),
    new Flat(8000000, 65, 3, "3.4"),
    new Flat(12000000, 100, 3, "3.5"),

    new Flat(3300000, 17, 2, "2.1"),
    new Flat(4900000, 33, 2, "2.2"),
    new Flat(6500000, 50, 2, "2.3"),
    new Flat(4900000, 33, 2, "2.4"),
    new Flat(9000000, 75, 2, "2.5"),

    new Flat(3000000, 17, 1, "1.1"),
    new Flat(3000000, 17, 1, "1.2"),
    new Flat(3000000, 17, 1, "1.3"),
    new Flat(3000000, 17, 1, "1.4"),
    new Flat(4500000, 33, 1, "1.5"),
    new Flat(6000000, 50, 1, "1.6"),
    new Flat(6000000, 50, 1, "1.7")
    );
SystemApartment system = new SystemApartment(myMozart);
Administrator admin = new Administrator();
admin.system = system;

Buyer buyer = new Buyer("Adam", "Bartl", system);
buyer.BuyerInterface();