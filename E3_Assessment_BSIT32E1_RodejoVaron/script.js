'use strict';

document.querySelector('.btnOddEven').addEventListener('click', function () {//Check

  const input = Number(document.querySelector(`.myNum`).value);
  if (!input) {
    document.querySelector('.pResult').textContent = `Invalid Input`;
  } else {
    if (input % 2 === 0) {
      document.querySelector('.pResult').textContent = `Even`;
    } else {
      document.querySelector('.pResult').textContent = `Odd`;
    }
  }

});