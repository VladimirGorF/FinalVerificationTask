# FinalVerificationTask

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

At first, we should create an Array of different strings.
Then we have to create new array for strings < 4 symbols, but we don’t know a length of this new array, that’s why earlier we should write a code which will count quantity of this words. This count will give us necessary length.  We use cycle and condition is “< 4 symbols”.
 The next step is creating of new Array.
 After that we have to write a function of filling new Array by using a cycle of Array and our special condition (< 4). Every time when condition is OK, we fill new Array and increase by one index of new Array.
Then we write a function to print it good without an extra comma. 
We don’t use “try” and “catch” because our code not depends from user input.  
