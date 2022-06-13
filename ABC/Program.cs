/* обозначаю путь:
0-A-B-C  - r1
r1 = A0 + AB + BC
A0 = Math.Sqrt(x1*x1+y1*y1)
AB = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2))
BC = Math.Sqrt(Math.Pow(x3-x2,2)+Math.Pow(y3-y2,2))

0-A-C-B  - r2
AC = Math.Sqrt(Math.Pow(x1-x3,2)+Math.Pow(y1-y3,2))
плюс те, которые описал выше

0-B-A-C  - r3
B0 = Math.Sqrt(x2*x2+y2*y2)
плюс те, которые описал выше

0-B-C-A  - r4
те, которые описал выше

0-C-A-B  - r5
C0 = Math.Sqrt(x3*x3+y3*y3)
плюс те, которые описал выше

0-C-B-A  - r6
те, которые описал выше
*/
Random tochki = new Random ();
int x1 = tochki.Next(1, 11);
int y1 = tochki.Next(1, 11);
Console.WriteLine ($"Координаты точки А - [{x1}; {y1}]");
int x2 = tochki.Next(1, 11);
int y2 = tochki.Next(1, 11);
Console.WriteLine ($"Координаты точки B - [{x2}; {y2}]");
int x3 = tochki.Next(1, 11);
int y3 = tochki.Next(1, 11);
Console.WriteLine ($"Координаты точки C - [{x3}; {y3}]");
double A0 = Math.Sqrt(x1*x1+y1*y1);
double AB = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
double BC = Math.Sqrt(Math.Pow(x3-x2,2)+Math.Pow(y3-y2,2));
double AC = Math.Sqrt(Math.Pow(x1-x3,2)+Math.Pow(y1-y3,2));
double B0 = Math.Sqrt(x2*x2+y2*y2);
double C0 = Math.Sqrt(x3*x3+y3*y3);
double r1 = A0 + AB + BC;
double r2 = A0 + AC + BC;
double r3 = B0 + AB + AC;
double r4 = B0 + BC + AC;
double r5 = C0 + AC + AB;
double r6 = C0 + BC + AB;
double[] rasst = {r1, r2, r3, r4, r5, r6};
if (rasst.Min()==r1) Console.WriteLine("Сначала движемся к точке А, затем к точке В, затем к точке С.");
else if (rasst.Min()==r2) Console.WriteLine("Сначала движемся к точке А, затем к точке C, затем к точке B.");
else if (rasst.Min()==r3) Console.WriteLine("Сначала движемся к точке B, затем к точке A, затем к точке С.");
else if (rasst.Min()==r4) Console.WriteLine("Сначала движемся к точке B, затем к точке C, затем к точке A.");
else if (rasst.Min()==r5) Console.WriteLine("Сначала движемся к точке C, затем к точке A, затем к точке B.");
else if (rasst.Min()==r6) Console.WriteLine("Сначала движемся к точке C, затем к точке В, затем к точке A.");