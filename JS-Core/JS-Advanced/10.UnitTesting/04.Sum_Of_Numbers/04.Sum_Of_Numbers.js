function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}

console.log(sum('pesho'));

module.exports = {sum};