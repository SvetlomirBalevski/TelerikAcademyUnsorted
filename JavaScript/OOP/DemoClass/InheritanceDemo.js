// class Animal {
//     constructor(name) {
//         this._name = name;
//     }

//     get name() {
//         return this._name;
//     }
//     eat() {
//         console.log('Eating');
//     }
// }

// class Dog extends Animal {

//     constructor(name,id) {
//         super(name); // Tova e default implementation
//         this._id = id;
//     }
//     bark() {
//         console.log("Barknig the moon", this.name);
//     }
//     eat() {
//         super.eat();
//         console.log('After the first implementation, this is going to be executed');
//     }
// }

// const kuche = new Dog('Sharo');
// kuche.eat();
// kuche.bark();

// Mixin Pattern

class Text {
    constructor(content) {
        this._content = content;
    }
    get content() {
        return this._content;
    }
}

function makeClicable(base) {


    return class extends base {
        constructor(link, ...args) {
            super(...args);
            this._link = link;
        }
        click() {
            console.log('Going to ' + this._link);
        }
    }
}
class Image {
    constructor() {}
}


const ClickableText = makeClicable(Text);
const ClickableImage = makeClicable(Image);

const el = new ClickableText('google.bg', 'Go somewhere');

console.log(el.content);
el.click();