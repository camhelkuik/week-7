# C#2ClassWeek7

Exersice information and output examples found [here](https://github.com/camhelkuik/week-7/blob/master/Assign_7.pdf)

## Exercise from the book Visual C# How to Program

18.5
Implement the bubble sort - another simple, yet inefficient, sorting technique. The technique uses nested loops to make several passes through the array. Each pass compares successive overlapping pairs of elements.

18.6
Make the following modifications to improve performance of the bubble sort

a. After the first pass, the largest number is guaranteed to be in the highest-numbered element of the array (for an array being sorted in ascending order); after the second pass, the two highest number are 'in place'; and so on. Instead of making nine comparisons on every pass of a 10 element array, modify the bubble sort to make eight comparisons on the second pass, seven on the third pass and so on.

b.The data in the array may already be in the proper order or near-proper order, so why make nine passes of a 10 element array if fewer will suffice? Modify the sort to check at the end of each pass whether any swaps have been made. If none have been made, the data must already be in the proper order, so the app should terminate. If swaps have been made, at least one more pass is needed. 
