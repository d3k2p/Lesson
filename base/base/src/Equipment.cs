using Microsoft.VisualBasic;
using System;
class Equipment {
    private string name;
    private int price;
    private DateTime registarationDate;
    
    public Equipment(string name, int price, DateTime registarationDate = DateTime.now()) {
        this.name = name;
        this.price = price;
        this.registrationDate = registrationDate;
    }
}
