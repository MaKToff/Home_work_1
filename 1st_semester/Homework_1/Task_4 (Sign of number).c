/*
Определяет знак числа. Возвращает "1", если число положительно, 
"-1" - если отрицательно, и "0", если был введён 0.
=================================================================
Returns "1" if the number is positive, "-1" if number is negative 
and "0" if it's zero.

Author: Mikhail Kita, group 171
*/

#include <stdio.h>

int sign(int number)
{
	const int temp = number >> (sizeof(int) * 8 - 1);
	return temp + !temp + ~(!number + ~0);
}

int main(void)
{
	int number = 0;
	scanf("%d", &number);
	printf ("%d\n", sign(number));
	return 0;
}