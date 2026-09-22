// Cat in a Box
// So much space! 

// Coriander, like all cats, likes boxes. She proudly announces: if I fits, I sits. 
// Your job is to decide if Coriander fits (and therefore sits) in a box. As we all know, cats behave like liquids and can
// change their body to any shape as long as they maintain their total volume. 

// Input The input contains a single line with 4 integers h, w, l, and c (1 <= h, w, l <= 1000, 1 <= c <= 10^9) 
// denoting the height, the width, and the length of the box, and the volume of Coriander respectively. 

// Output Output “COZY” if Coriander fits but wouldn’t fit if the box were any smaller, 
// “TOO TIGHT” if the box is too small for her to fit, and “SO MUCH SPACE” if there is 
// any space left after she sits in the box. 

// Sample Input 1 
// 1 1 1 1 1 
// Output 
// COZY 

// Sample Input 2
// 2 2 2 2 1 
// Output 
// SO MUCH SPACE 

// Sample Input 3 
// 3 5 5 5 200 
// Output 
// TOO TIGHT