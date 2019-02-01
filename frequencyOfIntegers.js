// find out if two positive integers have the same frequency of digits
// time complexity must be O(N)

// 1. check if numbers are same length, if the are, proceed
// 2. check if they contain the same numbers, if they do, proceed
// 3. check if the frequency of numbers is the same, if it is, return true, else return false

function sameFrequency(int1, int2) {
    const arr1 = int1.toString().split('').map(Number);
    const arr2 = int2.toString().split('').map(Number);

    if (arr1.length !== arr2.length)
        return false;

    let frequencyCounter1 = {};
    let frequencyCounter2 = {};

    for (const num of arr1) {
        frequencyCounter1[num] = (frequencyCounter1[num] || 0) + 1;
    }

    for (const num of arr2) {
        frequencyCounter2[num] = (frequencyCounter2[num] || 0) + 1;
    }

    for (const val in frequencyCounter1) {
        if (val in frequencyCounter2 === false)
            return false;

        if (frequencyCounter1[val] === frequencyCounter2[val] === false)
            return false;
    }

    return true;
}

