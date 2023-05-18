#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<time.h>
#include<stdlib.h>
void heapify(int* array, int n)
{
	int k, i, j, broj;
	for (k = 1; k < n; k++)
	{
		broj = array[k];
		i = k;
		j = (i - 1) / 2;
		while ((i > 0) && (broj > array[j]))
		{
			array[i] = array[j];
			i = j;
			j = (i - 1) / 2;
		}
		array[i] = broj;
	}
}
void podesi(int* array, int n)
{
	int i, j, broj;
	j = 0;
	broj = array[j];
	i = 2 * j + 1;
	while (i <= n - 1)
	{
		if (i + 1 <= n - 1)
		{
			if (array[i] < array[i + 1])
			{
				i++;
			}
		}
		if (broj < array[i])
		{
			array[j] = array[i];
			j = i;
			i = 2 * j + 1;
		}
		else
			break;
	}
	array[j] = broj;
}
void heapSort(int* array, int n)
{
	int i, t;
	heapify(array, n);
	for (i = n - 1; i > 0; i--)
	{
		t = array[0];
		array[0] = array[i];
		array[i] = t;
		podesi(array, i);
	}
}
void swap(int* x, int* y)
{
	int t;
	t = *x;
	*x = *y;
	*y = t;
}
void bubbleSort(int* array, int n)
{
	int i, j, chg;
	for (i = 0, chg = 1; chg; i++)
	{
		chg = 0;
		for (j = 0; j < n - 1 - i; j++)
		{
			if (array[j + 1] < array[j])
			{
				swap(&array[j], &array[j + 1]);
				chg = 1;
			}
		}
	}
}
void merge(int* array, int dg, int gg)
{
	int* T;
	int s, il, id, i;
	T = (int*)malloc((gg - dg + 1) * sizeof(int));
	s = (dg + gg) / 2;
	il = dg;
	id = s + 1;
	for (i = 0; i < gg - dg + 1; i++)
	{
		if (il <= s && id <= gg)
		{
			if (array[il] < array[id])
			{
				T[i] = array[il];
				il++;
			}
			else
			{
				T[i] = array[id];
				id++;
			}
		}
		else
		{
			if (il > s)
			{
				T[i] = array[id];
				id++;
			}
			else
			{
				T[i] = array[il];
				il++;
			}
		}
	}
	for (i = dg; i < gg; i++)
	{
		array[i] = T[i - dg];
	}
}
void mergeSort(int* array, int dg, int gg)
{
	int s;
	if (dg == gg)
	{
		return;
	}
	s = (dg + gg) / 2;
	mergeSort(array, dg, s);
	mergeSort(array, s + 1, gg);
	merge(array, dg, gg);
}
int main()
{
	srand((unsigned)time(NULL));
	int n, i;
	int* array;
	time_t t1, t2, t3, t4, t5, t6;
	scanf("%d", &n);
	array = (int*)malloc(n * sizeof(int));
	for (i = 0; i < n; i++)
	{
		array[i] = rand() % 201;
	}
	t1 = clock();
	bubbleSort(array, n);
	t2 = clock();
	printf("Vrijeme trajanja bubble sort-a: %dms\n", t2 - t1);
	t3 = clock();
	heapSort(array, n);
	t4 = clock();
	printf("Vrijeme trajanja heap sort-a: %dms\n", t4 - t3);
	t5 = clock();
	mergeSort(array, 1, n);
	t6 = clock();
	printf("Vrijeme trajanja merge sort-a: %dms\n", t6 - t5);
	return 0;
}