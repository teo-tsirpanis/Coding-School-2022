// 1.
/* export */ function reverseString(str) {
    return str.split("").reverse().join("");
}

// 2.
/* export */ function isPalindrome(str) {
    return str === reverseString(str);
}

// 4.
// I see nothing wring with this function.
/* export */ function multiply(a, b) {
    return a * b;
}

// 5.
/* export */ function nextId(str) {
    const re = /^(.*?)(\d*)$/;

    const match = str.match(re);

    if (match === null)
        // The string is empty; just return "1".
        return "1";
    
    const name = match[1];
    const number = parseInt(match[2]);

    if (isNaN(number))
        // The string does not end with a number; append "1" to it.
        return name + "1";
    return name + (number + 1);
}
