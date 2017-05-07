class person {
    constructor(name, age) {
        this._name = name;
        this._age = age;
    }
}
let pesho = new person("Pesho", 6);
console.log(typeof(pesho));
console.log(pesho._name);
pesho._name = 'gosho';
console.log(pesho._name);
console.log(pesho._age);
console.log(pesho);