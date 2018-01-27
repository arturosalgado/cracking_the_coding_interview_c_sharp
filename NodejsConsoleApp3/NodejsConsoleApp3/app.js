'use strict';



class Car {

 
    constructor(model, features = null) {

        this.model = model;
        this.features = features;

    }

    getModel() {

        if (this.features != null) {

            for (var f of this.features) {
                console.log(f);
            }
        }

        return this.model;

    }


}


var car1 = new Car("Mitsubishi L 200",["nice","red","pricy"]);

var car2 = new Car("Honda Fit");
car2.features = ["white","economy","poor"];

console.log(car1.getModel());
console.log(car2.getModel());




