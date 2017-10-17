/* 
RECURSION: In-Order Subsets (pg. 101)
Create a strSubsets(str), return an array with every possible
in-order character subset of str. The results array itself does not 
need to be in any specific order--it is the subset of letters in each 
string that must be in the same order as they were in the original.

INPUT (str) => "abc"
OUTPUT (arr) => ["", "a", "b", "c", "ab", "ac", "bc", "abc"]
*/

function strSubsets(str, results = []) {
  if (str.length === 0) {
    results.push(str);
    return results;
  }
  var arr = str.split("");
  arr.length--;
  var str1 = arr.join("");
  strSubsets(str1, results);
  var endIndex = results.length;
  for (let i = 0; i < endIndex; i++) {
    results.push(results[i] + str.charAt(str.length - 1));
  }
  return results;
}

console.log(strSubsets("hello"));