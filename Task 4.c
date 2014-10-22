//Returns "1" if the number is positive, "-1" if number is negative and "0" if it's zero


#include <stdio.h>

int sign(int number)
{
	const int sh = sizeof(int) * 8 - 1;
	return (number >> sh) + !(number >> sh) + ~(!number + ~0);
}

int main(void)
{
	int number = 0;
	scanf("%d", &number);
	printf ("%d\n", sign(number));
	return 0;
}
