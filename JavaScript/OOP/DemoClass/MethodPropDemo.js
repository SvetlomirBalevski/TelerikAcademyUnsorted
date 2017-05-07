class Cat {
    constructor(name) {
        this._name = name;
        this._silenced = false;
        this.age = 0; // Age se validira prez settera- vikame setera prez konstruktora
    }

    static WhatDoesTheCatSay() {
        return 'meow';
    }

    meow() {
        if (this._silenced) {
            return;
        }
        console.log(this._name + ' says ' + Cat.WhatDoesTheCatSay());

    }

    silence() {
        //this.meow = function() {};
        this._silenced = true;
    }
    get age() {
        return this._age;
    }
    set age(newAge) {
        if (newAge < 0) {
            throw new Error('This is not an apropriate age for a cat');
        }
        // TODO Validation
        this._age = newAge;
    }
    set name(x) {
        throw new Error('Name Should not be changed');
    }
}

const myCat = new Cat('TestCat');
myCat.meow();
myCat.meow();
myCat.silence();
myCat.meow();
console.log(myCat.age);
myCat.age = 5;
console.log(myCat.age);
console.log(myCat.age + 5);

console.log(Cat.WhatDoesTheCatSay());

myCat.meow();


class Point2D {
    constructor(x, y) {
        this._x = x;
        this._y = y;
    }
    static get Zero() {
        return new Point2D(0, 0);
    }
    static getDistance(pointA, pointB) {
        const sqrtDistance =
            (pointA._x - pointB._x) * (pointA._x - pointB._x) +
            (pointA._y - pointB._y) * (pointA._y - pointB._y);
        return Math.sqrt(sqrtDistance);
    }
    distanceTo(otherPoint) {
        return Point2D.getDistance(this, otherPoint);
    }
    get distanceToCenter() {
        return Point2D.getDistance(this, Point2D.Zero);
    }
}
Object.defineProperty(Point2D, 'TheAnswerOfEverythinhg', {
    value: 42,
    writable: false
});

let x = new Point2D(3, 7);
let y = new Point2D(-6, 4);

console.log(Point2D.getDistance(x, y));

console.log(x.distanceTo(y));

console.log(x.distanceToCenter);
console.log(y.distanceToCenter);

function Dog(name) {
    this._name = name;
    this._silenced = false;

    Dog.prototype.bark = function() {
        if (this._silenced) {
            return;
        }
        console.log(this._name + ' says Barking the moon');
    }
    Dog.prototype.silence = function() {
        this._silenced = true;
    }

    Object.defineProperty(Dog.prototype, 'name', {

        get: function() {
            return this._name;
        },
        set: function(newName) {
            this._name = newName;
        }
    });

    Object.defineProperty(Dog, 'whatDoesTheDogSay', {
        get: function() {
            return 'Bark';
        }
    })
}

const Kuche = new Dog('Drunkyard');
Kuche.bark();
Kuche.silence();
Kuche.bark();

console.log(Kuche.name);

console.log(Cat.prototype);

console.log(Cat.prototype.age);

console.log(Cat.prototype.meow);

Kuche.name = "Kuche's New Name ";
console.log(Kuche.name);
console.log(Dog.prototype.name);

console.log(Dog.whatDoesTheDogSay);

console.log(Point2D.TheAnswerOfEverythinhg);
Point2D.TheAnswerOfEverythinhg = 1;
console.log(Point2D.TheAnswerOfEverythinhg);