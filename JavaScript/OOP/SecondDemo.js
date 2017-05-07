// function CreateCounter() {
//     let counter = 0;

//     return function() {
//         counter += 1;
//         return counter;
//     };
// }

// let counter = CreateCounter();
// console.log(counter()); // Stava zashtoto counter si e jiv v pyrviq skope
// console.log(counter());
// console.log(counter());
// console.log(counter());

// let counter2 = CreateCounter();
// console.log(counter2());

const school = (function() {
    const people = [];

    function AddPerson(name, age, gender) {
        if (typeof name !== 'string') {
            throw 'Name shoud be string';
        }
        if (!name.match(/^[A-Z][a-z]*$/)) {
            throw 'Invalid name';
        }
        people.push({
            name: name,
            age: age,
            gender: gender
        }); // Pravim nov obekt
    }

    function getPeople() {
        return people.map(p => {
            return {
                name: p.name,
                age: p.age,
                gender: p.gender
            }
        }); //Dvete skobi sa zashoto lambdata otvarqnov skope s {}
    }

    return {
        AddPerson: AddPerson,
        getPeople: getPeople
    }; // return object, s koito moje da si rabotim
})();

school.AddPerson('Pesho', 20, true);

let peopleList = school.getPeople();
console.log(peopleList);