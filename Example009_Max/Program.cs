﻿// Найти максимум из девяти чисел
int a1 = 155;
int b1 = 21;
int c1 = 39;
int a2 = 5512;
int b2 = 23;
int c2 = 3233;
int a3 = 113;
int b3 = 23;
int c3 = 33;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (b3 > max) max = c3;

Console.WriteLine(max);
