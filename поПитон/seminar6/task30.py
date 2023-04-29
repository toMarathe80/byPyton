# По введенным данным (первый элемент, шаг
# и кол-во эллементов) заполнить список по формуле
# an = a1 +(n-1)* d например
# Ввод: 7 2 5
# Вывод: 7 9 11 13 15
arr_num,first = [],int(input('первый: '))
step,count = int(input('шаг: ')),int(input('колво: '))
arr_num.append(first)

for i in range(1, count):
    first += step
    arr_num.append(first)
print(arr_num)