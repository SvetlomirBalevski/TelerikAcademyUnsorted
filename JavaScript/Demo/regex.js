console.log('hello Something with l inside'.replace(/l/g, '@'));
console.log(new RegExp('a'));

let telephone = /^[0-9]{10}$/; // match-va 10 poredni cifri ({10})
console.log(telephone.test(1234567890));