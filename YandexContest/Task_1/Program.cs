using System;
using System.Linq;

//Вася и Маша участвуют в субботнике и красят стволы деревьев в белый цвет. 
//Деревья растут вдоль улицы через равные промежутки в 1 метр. 
//Одно из деревьев обозначено числом ноль, деревья по одну сторону занумерованы положительными числами 1, 2
// и т.д., а в другую — отрицательными −1,−2 и т.д.
//Ведро с краской для Васи установили возле дерева P
//, а для Маши — возле дерева Q. 
//Ведра с краской очень тяжелые и Вася с Машей не могут их переставить, поэтому они окунают кисть в ведро и уже с этой кистью идут красить дерево.
// Краска на кисти из ведра Васи засыхает, когда он удаляется от ведра более чем на V метров,
//а из ведра Маши — на M метров. Определите, сколько деревьев может быть покрашено.

//формат ввода
//В первой строке содержится два целых числа P и V — номер дерева,
//у которого стоит ведро Васи и на сколько деревьев он может от него удаляться.
//В второй строке содержится два целых числа Q и M — аналогичные данные для Маши.
//Все числа целые и по модулю не превосходят 10^8.

//формат вывода
//Выведите одно число — количество деревьев, которые могут быть покрашены

var vasiliyInput = Console.ReadLine()!.Split(' ');
var mariaInput = Console.ReadLine()!.Split(' ');

int vasiliyTreeNumber = int.Parse(vasiliyInput.First());
int vasiliyRange = int.Parse(vasiliyInput.Last());
int mariaTreeNumber = int.Parse(mariaInput.First());
int mariaRange = int.Parse(mariaInput.Last());

int vasiliyRightTreeNumber = vasiliyTreeNumber + vasiliyRange;
int vasiliyLeftTreeNumber = vasiliyTreeNumber - vasiliyRange;
int mariaRightTreeNumber = mariaTreeNumber + mariaRange;
int mariaLeftTreeNumber = mariaTreeNumber - mariaRange;

int totalTreesPainted = 2 * (vasiliyRange + mariaRange + 1) - Math.Max(
    0,
    Math.Min(vasiliyRightTreeNumber, mariaRightTreeNumber) - Math.Max(vasiliyLeftTreeNumber, mariaLeftTreeNumber) + 1);

Console.WriteLine(totalTreesPainted);
Console.ReadLine();