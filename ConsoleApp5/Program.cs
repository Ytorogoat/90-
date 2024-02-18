// Задание №1;

using System;
using System.Data;

double G1, y1, f1;

Console.WriteLine("Введите значение пременной y1");
y1=Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значения переменной f1");
f1=Convert.ToDouble(Console.ReadLine());

G1 = Math.Exp(2 * y1) + Math.Sin(f1) / Math.Log10(3.8 * y1 + f1);

Console.WriteLine($"Значение G1 = {G1}");

// Задание №2;

double d2, y2, F2;

Console.WriteLine("Введите значение перемнной в2");
d2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y2");
y2=Convert.ToDouble(Console.ReadLine());

F2 = Math.Log10(d2) + ((3.5 * Math.Pow(d2, 2) + 1)) / (Math.Cos(2 * y2));

Console.WriteLine($"Значение F2 = {F2}");
// Задание №3;

double U3, k3, y3;

Console.WriteLine("Введите значение переменной k3");
k3=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y3");
y3=Convert.ToDouble(Console.ReadLine());

U3 = Math.Log10(k3 - y3) + Math.Pow(y3, 4) / Math.Exp(y3) + 2.355 * Math.Pow(k3, 2);

Console.WriteLine($"Введите значение переменной U3 = {U3}");


// Задание №4;

double G4, w4, y4;

Console.WriteLine("Введите значение пременной w4");
w4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите знасение перемнной y4");
y4 = Convert.ToDouble(Console.ReadLine());

G4 = 9.33 * Math.Pow(w4, 3) + Math.Sqrt(w4) / Math.Log10(y4 + 3.5) + Math.Sqrt(y4);

Console.WriteLine($"Знвчение G4 = {G4}");

// Задание "5;

double D5, a5, t5, y5;

Console.WriteLine("Введите значение переменнойa a5");
a5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t5");
t5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y5");
y5 = Convert.ToDouble(Console.ReadLine());

D5 = (7.8 * Math.Pow(a5, 2) + 3.52 * t5) / (Math.Log10(a5 + 2 * y5) + Math.Exp(y5));

Console.WriteLine($"Значение D5 = {D5}");

// Задание №6;

double L6, i6, y6;

Console.WriteLine("Введите значение переменной i6");
i6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y6");
y6 = Convert.ToDouble(Console.ReadLine());

L6 = (0.81 + Math.Cos(i6)) / (Math.Log10(y6) + 2 * Math.Pow(i6, 3));

Console.WriteLine($"Значение L6 = {L6}");

// Задание №7;

double N7, m7, y7;

Console.WriteLine("Введите значение переменной m7");
m7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y7");
y7 = Convert.ToDouble(Console.ReadLine());

N7 = (Math.Pow(m7, 2) + 2.8 * m7 + 0.355) / (Math.Cos(2 * y7) + 3.6);

Console.WriteLine($"Значение N7 = {N7}");

// Задание №8;

double T8, t8, y8;

Console.WriteLine("Введите значение переменной t8");
t8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y8");
y8 = Convert.ToDouble(Console.ReadLine());

T8 = (2.37 * Math.Sin(t8 + 1)) / (Math.Sqrt(4 * Math.Pow(y8, 2) - 0.1 * y1 + 5));

Console.WriteLine($"Значение T8 = {T8}");

//Задание #9;

double V9, w9, y9;

Console.WriteLine("Введите значение переменной t9");
w9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y9");
y9 = Convert.ToDouble(Console.ReadLine());

V9 = (Math.Pow(y9 + 2 * w9, 3)) / (Math.Log10(y9 + 0.75));

Console.WriteLine($"Значение V9 = {V9}");

// Задание №10;

double Z10, t10, y10;

Console.WriteLine("Введите значение переменной t10");
t10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y10");
y10 = Convert.ToDouble(Console.ReadLine());

Z10 = (2 * t10 + y10 * Math.Cos(t10)) / (Math.Sqrt(y10 + 4.831));

Console.WriteLine($"Значение Z10 = {Z10}");

// Задание №11; 

double D11, y11, n11;

Console.WriteLine("Введите значение переменной n11");
n11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y11");
y11 = Convert.ToDouble(Console.ReadLine());

D11 = Math.Pow(y11, 2) + (0.5 * n11 + 4.8) / (Math.Sin(y11));

Console.WriteLine($"Значение D11 = {D11}");

// Задание №12;

double R12, t12, y12;

Console.WriteLine("Введите значение переменной t12");
t12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y12");
y12 = Convert.ToDouble(Console.ReadLine());

R12 = (Math.Sin(Math.Pow((2 * t12 + 1), 2)) + 0.3) / (Math.Log10(t12 + y12));

Console.WriteLine($"Значение R12 = {R12}");

// Задание №13;

double A13, h13, y13;

Console.WriteLine("Введите значение переменной t13");
h13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y13");
y13 = Convert.ToDouble(Console.ReadLine());

A13 = (Math.Sin(2 * y13 + h13) + Math.Pow(h13, 2)) / (Math.Exp(h13) + y13);

Console.WriteLine($"Значение A13 = {A13}");

// Задание №14;

double P14, y14, h14;

Console.WriteLine("Введите значение переменной y14");
y14 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h14");
h14 = Convert.ToDouble(Console.ReadLine());

P14 = (Math.Exp(y14 + 2.5) + 7.1 * Math.Pow(h14, 3)) / (Math.Log10(Math.Sqrt(y14 + 0.04 * h14)));

Console.WriteLine($"Значение P14 = {P14}");

// Задание №15;

double F15, y15, j15;

Console.WriteLine("Введите значение переменной j15");
j15 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y15");
y15 = Convert.ToDouble(Console.ReadLine());

F15 = (2 * Math.Sin(0.354 * y15 + 1)) / (Math.Log10(y15 + 2 * j15));

Console.WriteLine($"Значение F15 = {F15}");

// Задание №16;

double W16, y16, r16, t16;

Console.WriteLine("Введите значение переменной y16");
y16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной r16");
r16 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t16");
t16 = Convert.ToDouble(Console.ReadLine());

W16 = (4 * Math.Pow(t16, 3) + Math.Log10(r16)) / (Math.Exp(y16 + r16) + 7.2 * (Math.Sin(r16)));

Console.WriteLine($"Значение W16 = {W16}");

//Задание №17;

double H17, y17, n17;

Console.WriteLine("Введите значение переменной y17");
y17 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной n17");
n17 = Convert.ToDouble(Console.ReadLine());

H17 = (Math.Pow(y17, 2) - 0.8 * y17 + Math.Sqrt(y17)) / (23.1 * Math.Pow(n17, 2) + Math.Cos(n17));

Console.WriteLine($"Значение H17 = {H17}");

// Задание №18;

double R18,  y18, k18;

Console.WriteLine("Введите значение переменной y18");
y18= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k18");
k18 = Convert.ToDouble(Console.ReadLine());

R18 = (Math.Sqrt(Math.Pow(Math.Sin(y18), 2) + 6.835)) / (Math.Log10(y18 + k18) + 3 * (Math.Pow(y18, 2)));

Console.WriteLine($"Значение R18 = {R18}");

// Заданте №19; 

double E19, y19, q19;

Console.WriteLine("Введите значение переменной y19");
y19 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной q19");
q19 = Convert.ToDouble(Console.ReadLine());

E19 = (Math.Log10(0.7 * y19 + 2 * q19)) / (Math.Sqrt(3 * Math.Pow(y19, 2) + 0.5 * y19 + 4));

Console.WriteLine($"Значение E19 = {E19}");

// Задание №20;

double K20, t20, l20, y20;

Console.WriteLine("Введите значение переменной y20");
y20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной l20");
l20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t20");
t20 = Convert.ToDouble(Console.ReadLine());

K20 = (2 * Math.Pow(t20, 2) + 3 * l20 + 7.2) / (Math.Log10(y20) + Math.Exp(2 * t20));

Console.WriteLine($"Значение K20 = {K20}");

// Задание №21;

double Q21, k21, x21, d21, p21;

Console.WriteLine("Введите значение переменной k21");
k21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x21");
x21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d21");
d21 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p21");
p21 = Convert.ToDouble(Console.ReadLine());


Q21 = (Math.Sqrt(k21 + 2.6 * p21 * Math.Sin(k21))) / (x21 - Math.Pow(d21, 3));

Console.WriteLine($"Значение Q21 = {Q21}");

// Задание №22;

double S22, y22, t22;

Console.WriteLine("Введите значение переменной y22");
y22 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t22");
t22 = Convert.ToDouble(Console.ReadLine());

S22 = (4.351 * Math.Pow(y22, 3) + 2 * t22 * Math.Log10(t22) / (Math.Sqrt(Math.Cos(2 * y22) + 4.351)));

Console.WriteLine($"Значение S22 = {S22}");

//Задание №23;

double R23, y23, d23;

Console.WriteLine("Введите значение переменной y23");
y23 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d23");
d23 = Convert.ToDouble(Console.ReadLine());

R23 = (Math.Pow(Math.Sin(y23), 2) + 0.3 * d23) / (Math.Exp(y23) + Math.Log10(d23));

Console.WriteLine($"Значение R23 = {R23}");

// Задание №24;

double U24, y24, k24;

Console.WriteLine("Введите значение переменной y24");
y24 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k24");
k24 = Convert.ToDouble(Console.ReadLine());

U24 = (Math.Log10(2 * k24 + 4.3)) / (Math.Exp(k24 + y24) + Math.Sqrt(y24));

Console.WriteLine($"Значение U24 = {U24}");

// Задание №25;

double L25, c25, t25;

Console.WriteLine("Введите значение переменной c25");
c25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменнойt t25");
t25 = Convert.ToDouble(Console.ReadLine());

L25 = Math.Pow(Math.Cos(c25), 2) + (3 * Math.Pow(t25, 2) + 4) / (Math.Sqrt(c25 + t25));

Console.WriteLine($"Значение L25 = {L25}");

//Задание №26; 

double T26, u26, y26;

Console.WriteLine("Введите значение переменной u26");
u26 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменнойt y26");
y26 = Convert.ToDouble(Console.ReadLine());

T26 = (Math.Sin(2 * u26)) / (Math.Log10(2 * y26 + u26));

Console.WriteLine($"Значение T26 = {T26}");

//Задание №27;

double Z27, p27, y27;

Console.WriteLine("Введите значение переменной p27");
p27 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменнойt y27");
y27 = Convert.ToDouble(Console.ReadLine());

Z27 = (Math.Pow(Math.Sin(p27 + 0.4), 2)) / (Math.Pow(y27, 2) + 7.325 * p27);

Console.WriteLine($"Значение Z28 = {Z27}");

// Задание#28;

double W28, v28, y28;

Console.WriteLine("Введите значение переменной v28");
v28 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменнойt y28");
y28 = Convert.ToDouble(Console.ReadLine());

W28 = (0.004 * v28 + Math.Exp(2 * y28)) / (Math.Exp(y28 / 2));

Console.WriteLine($"Значение W28 = {W28}");

// Задание№29; 

double T29, y29, h29;

Console.WriteLine("Введите значение переменной y29");
y29 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h29");
h29 = Convert.ToDouble(Console.ReadLine());

T29 = (0.355 * Math.Pow(h29, 2) - 4.355) / (Math.Exp(y29 + h29) + Math.Sqrt(2.7 * y29));

Console.WriteLine($"Значение T29 = {T29}");

// Задание №30; 

Console.WriteLine("Задание №60");

double N30, y30, p30;

Console.WriteLine("Введите значение переменной y30");
y30 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной p30");
p30 = Convert.ToDouble(Console.ReadLine());

N30 = (3 * Math.Pow(y30, 2) + Math.Sqrt(y30 + 1)) / (Math.Log10(p30 + y30) + Math.Exp(p30));

Console.WriteLine($"Значение N30 = {N30}");

// Задание №31;

double L31, x31, a31, c31, e31;

Console.WriteLine("Введите значение переменной x");
x31 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a31 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c31 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной e");
e31 = Convert.ToDouble(Console.ReadLine());

L31 = (Math.Sqrt(Math.Exp(x31) - Math.Pow(Math.Cos(Math.Pow(x31, 2) * Math.Pow(a31, 5)), 4)) + Math.Atan(a31 - Math.Pow(x31, 5))) / (e31 * Math.Sqrt(Math.Abs(a31 = x31 * Math.Pow(c31, 4))));

Console.WriteLine($"Значение L = {L31}");

// Задание №32;

double L32, c32, x32, t32;

Console.WriteLine("Введите значение переменной c");
c32 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x32 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t32 = Convert.ToDouble(Console.ReadLine());

L32 = Math.Pow((1 / (Math.Tan(c32))), 2) + (2 * Math.Pow(x32, 2) + 5) / (Math.Sqrt(c32 + t32));

Console.WriteLine($"Значение L = {L32}");

// Задание №33;

double A33, y33, h33;

Console.WriteLine("Введите значение переменной y");
y33 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной h");
h33 = Convert.ToDouble(Console.ReadLine());

A33 = (Math.Tan(Math.Pow(y33, 3) - Math.Pow(h33, 4)) + Math.Pow(h33, 2)) / (Math.Pow(Math.Sin(h33), 3) + y33);

Console.WriteLine($"Значение A = {A33}");

// Задание №34;

double F34, y34, x34;

Console.WriteLine("Введите значение переменной y");
y34 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x34 = Convert.ToDouble(Console.ReadLine());

F34 = (Math.Sqrt(Math.Pow(2 + y34, 2) + Math.Pow(Math.Sin(y34 + 5), 1 / 7)) / (Math.Log10(x34 + 1) - Math.Pow(y34, 3)));

Console.WriteLine($"Значение F = {F34}");

// Задание №35;

double G35, x35, y35, z35, c35;

Console.WriteLine("Введите значение переменной x");
x35 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y35 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c35 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z35 = Convert.ToDouble(Console.ReadLine());

G35 = (Math.Tan(Math.Pow(x35, 4) - 6) - Math.Pow(Math.Cos(z35 + x35 * y35), 3)) / (Math.Pow(Math.Cos(Math.Pow(x35, 3)), 3) * Math.Pow(c35, 2));

Console.WriteLine($"Значение G = {G35}");

// Задание №36;

double K36, x36, y36, b36, a36;

Console.WriteLine("Введите значение переменной x");
x36 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y36 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b36 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a36 = Convert.ToDouble(Console.ReadLine());

K36 = (Math.Sqrt(x36 + b36 - a36) + Math.Log10(y36)) / (Math.Atan(b36 + a36));

Console.WriteLine($"Значение K = {K36}");

// Заданте №37;

double D37, x37, y37, a37;

Console.WriteLine("Введите значение переменной y");
y37 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x37 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a37 = Convert.ToDouble(Console.ReadLine());

D37 = (Math.Cos(Math.Pow(x37, 3) + 6) - Math.Sin(y37 - a37)) / (Math.Log10(Math.Pow(x37, 4)) - 2 * Math.Pow(Math.Sin(x37), 5));

Console.WriteLine($"Значение D = {D37}");

// Задание №38;

double P38, x38, y38, c38, a38;

Console.WriteLine("Введите значение переменной x");
x38 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y38 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c38 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a38 = Convert.ToDouble(Console.ReadLine());

P38 = (Math.Pow(a38, 5) + Math.Pow(Math.Sin(y38 - c38), 4)) / (Math.Pow(Math.Sin(x38 + y38), 3) + Math.Abs(x38 - y38));

Console.WriteLine($"Значение P = {P38}");

// Задание №39;

double R39, y39, d39, x39;

Console.WriteLine("Введите значение переменной y");
y39 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x39 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d");
d39 = Convert.ToDouble(Console.ReadLine());

R39 = (Math.Pow(Math.Cos(y39), 3) + Math.Pow(2, x39) * d39) / (Math.Exp(y39) + Math.Log10(Math.Pow(Math.Sin(x39), 2)) + 7.4);

Console.WriteLine($"Значение R = {R39}");

// Задание №40;

double U40, y40, x40;

Console.WriteLine("Введите значение переменной y");
y40 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x40 = Convert.ToDouble(Console.ReadLine());

U40 = (Math.Exp(Math.Pow(x40, 3)) + Math.Pow(Math.Cos(x40 - 4), 2)) / (Math.Atan(x40) + 5.2 * y40);

Console.WriteLine($"Значение U = {U40}");

// Задание №41;

double I41, y41, x41;

Console.WriteLine("Введите значение переменной y");
y41 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x41 = Convert.ToDouble(Console.ReadLine());

I41 = (2.33 * Math.Log10(Math.Sqrt(1 + Math.Pow(Math.Cos(y41), 2)))) / (Math.Exp(y41) + Math.Pow(Math.Sin(x41), 2));

Console.WriteLine($"Значение I = {I41}");

// Задание №42;

double G42, y42, a42, x42;

Console.WriteLine("Введите значение переменной y");
y42 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x42 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a42 = Convert.ToDouble(Console.ReadLine());

G42 = (Math.Pow(Math.Cos(Math.Abs(y42 + x42)), 3) - (x42 - y42)) / (Math.Pow(Math.Atan(x42 + a42), 4) * Math.Pow(x42, 5));

Console.WriteLine($"Значение G = {G42}");

// Задание №43;

double R43, a43, b43, x43;

Console.WriteLine("Введите значение переменной a");
a43 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x43 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b43 = Convert.ToDouble(Console.ReadLine());

R43 = (a43) / (x43 - a43) + (Math.Pow(b43, x43) + Math.Pow(Math.Cos(x43), 3)) / (Math.Pow(Math.Log(a43 + 4.5), 3));

Console.WriteLine($"Значение R = {R43}");

//Задание №44;

double R44, x44;

Console.WriteLine("Введите значение переменной x");
x44 = Convert.ToDouble(Console.ReadLine());


R44 = (Math.Sin(Math.Pow(Math.Pow(x44, 2) + 4, 3) + 4.3) / (Math.Pow(Math.Sin(Math.Pow(x44, 4)), 3)));

Console.WriteLine($"Значение R74 = {R44}");

// Задание №45;

double N45, y45, m45;

Console.WriteLine("Введите значение переменной y");
y45 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной m");
m45 = Convert.ToDouble(Console.ReadLine());

N45 = (Math.Pow(m45, 2) + 2.8 * m45 + 0.355) / (Math.Cos(2 * y45) + 3.6);

Console.WriteLine($"Значение N = {N45}");

// Задание №46;

double P46, y46, t46, x46;

Console.WriteLine("Введите значение переменной y");
y46 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x46 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t46 = Convert.ToDouble(Console.ReadLine());

P46 = (Math.Pow(Math.Sin(x46), 3) + Math.Log10(2 * y46 + 3 * x46)) / (Math.Pow(t46, 2) + Math.Sqrt(x46));

Console.WriteLine($"Значение P = {P46}");

// Задание №47;

double T47, x47, y47, a47, b47;

Console.WriteLine("Введите значение переменной x");
x47 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y47 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b47 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a47 = Convert.ToDouble(Console.ReadLine());

T47 = (Math.Sqrt(x47 + b47 - a47) + Math.Log10(y47)) / (Math.Atan(b47 + a47));

Console.WriteLine($"Значение T = {T47}");

// Задание №48;

double S48, y48, t48;

Console.WriteLine("Введите значение переменной y");
y48 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной t");
t48 = Convert.ToDouble(Console.ReadLine());

S48 = (4.351 * Math.Pow(y48, 3) + 2 * t48 * Math.Log10(t48)) / (Math.Sqrt(Math.Cos(2 * y48) + 4.351));

Console.WriteLine($"Значение S = {S48}");

//Задание №49;

double D49, y49, a49, b49;

Console.WriteLine("Введите значение переменной y");
y49 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b49 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a49 = Convert.ToDouble(Console.ReadLine());

D49 = (a49 * (Math.Sqrt(b49)) - Math.Cos(3 * a49 * b49)) / (Math.Pow(Math.Sin(a49 * Math.Asin(a49) + Math.Log10(y49)), 2));

Console.WriteLine($"Значение D = {D49}");

// Задание №50;

double U50, x50, y50, c50, b50, a50;

Console.WriteLine("Введите значение переменной x");
x50 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y50 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b50 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c50 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a50 = Convert.ToDouble(Console.ReadLine());

U50 = (Math.Pow(Math.Tan(y50), 3) + Math.Pow(Math.Sin(x50 * Math.Sqrt(b50 - c50)), 5)) / (Math.Sqrt(a50 - b50 + c50));

Console.WriteLine($"Значение U = {U50}");

// Задание №51;

double N51, z51, x51, a51;

Console.WriteLine("Введите значение переменной z");
z51 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x51 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a51 = Convert.ToDouble(Console.ReadLine());

N51 = (Math.Pow(z51 + Math.Sqrt(z51 * x51), 1 / 5)) / (Math.Exp(x51) + Math.Pow(a51, 5) * Math.Atan(x51));

Console.WriteLine($"Значение N = {N51}");

// Задание №52;

double F52, y52, x52;

Console.WriteLine("Введите значение переменной y");
y52 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x52 = Convert.ToDouble(Console.ReadLine());

F52 = Math.Cos(Math.Pow(x52, 2) + 2) + (3.5 * Math.Pow(x52, 2) + 1) / (Math.Pow(Math.Cos(y52), 2));

Console.WriteLine($"Значение F = {F52}");

// Задание№53;

double F53, x53, z53, a53, b53;

Console.WriteLine("Введите значение переменной x");
x53 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z53 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b53 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a53 = Convert.ToDouble(Console.ReadLine());

F53 = (Math.Sqrt(Math.Abs(x53) + Math.Pow(Math.Cos(x53), 3)) + Math.Pow(z53, 4)) / (Math.Log10(x53) - Math.Asin(b53 * x53 - a53));

Console.WriteLine($"Значение F = {F53}");

// Задание №54;

double f54, x54, z54, a54, b54;

Console.WriteLine("Введите значение переменной x");
x54 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z54 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
b54 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a54 = Convert.ToDouble(Console.ReadLine());

f54 = (Math.Pow(Math.Cos(b54 * Math.Pow(x54, 5)), 7) - (Math.Sin(Math.Pow(a54, 2)) + Math.Cos(Math.Pow(x54, 3)) + Math.Pow(z54, 5) - Math.Pow(a54, 2))) / (Math.Asin(Math.Pow(a54, 2)) + Math.Acos(Math.Pow(x54, 7) - Math.Pow(a54, 2)));

Console.WriteLine($"Значение f = {f54}");

// Задание №55;

double J55, y55, a55, x55;

Console.WriteLine("Введите значение переменной y");
y55 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x55 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a55 = Convert.ToDouble(Console.ReadLine());

J55 = (Math.Pow(1 / Math.Tan(Math.Pow(a55, 3)), 3) + Math.Pow(Math.Atan(a55), 2)) / (Math.Sqrt(Math.Pow(y55, Math.Tan(x55))));

Console.WriteLine($"Значение J = {J55}");

//Задание №56;

double U56, y56, k56, x56;

Console.WriteLine("Введите значение переменной y");
y56 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x56 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной k");
k56 = Convert.ToDouble(Console.ReadLine());

U56 = (Math.Log10(Math.Pow(x56, 3) + y56) - Math.Pow(y56, 4)) / (Math.Exp(y56) + 5.4 * Math.Pow(k56, 3));

Console.WriteLine($"Значение U = {U56}");

//Задание №57;

double P57, x57, y57, a57, c57;

Console.WriteLine("Введите значение переменной x");
x57 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y57 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c57 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной a");
a57 = Convert.ToDouble(Console.ReadLine());

P57 = (Math.Pow(a57, 5) + Math.Acos(a57 + Math.Pow(x57, 3)) - Math.Pow(Math.Sin(y57 - c57), 4)) / (Math.Pow(Math.Sin(x57 + y57), 3) + Math.Abs(x57 - y57));

Console.WriteLine($"Значение P = {P57}");

//Задание №58;

double G58, x58, z58, y58, c58;

Console.WriteLine("Введите значение переменной x");
x58 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной z");
z58 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной y");
y58 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
c58 = Convert.ToDouble(Console.ReadLine());

G58 = (Math.Tan(Math.Pow(x58, 4) - 6) - Math.Pow(Math.Cos(z58 + Math.Pow(x58, 3) * y58), 3 * x58)) / (Math.Pow(Math.Sin(Math.Pow(x58, 3) * Math.Pow(c58, 2)), 3));

Console.WriteLine($"Значение G = {G58}");

// Задание №59;

double R59, y59, d59, x59;

Console.WriteLine("Введите значение переменной y");
y59 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной x");
x59 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение переменной d");
d59 = Convert.ToDouble(Console.ReadLine());

R59 = (Math.Pow(Math.Cos(y59), 2) + 2.4 * d59) / (Math.Exp(y59) + Math.Log10(6 * Math.Pow(x59, 2)));

Console.WriteLine($"Значение R = {R59}");

// Задание №60;

double K60, x60;

Console.WriteLine("Введите значение переменной x");
x60 = Convert.ToDouble(Console.ReadLine());

K60 = (Math.Sqrt(Math.Pow(3 + x60, 6) - Math.Log10(x60))) / (Math.Exp(x60) + Math.Asin(6 * Math.Pow(x60, 2)));

Console.WriteLine($"Значение K = {K60}");




