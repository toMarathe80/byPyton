# нужно найти в массиве (н) наименьшее к выбранному числу (ч) число
array_length = int(input('задайте размер ряда: '))
new_array,count = [],0
for i in range(1, array_length+1):
    new_array.append(i)
print('Вот ряд',new_array)
num = int(input('введите число из ряда: '))
if num > array_length:
    print('число не из этого ряда, повторитесь!')
elif num == 1:
    print('меньше числа нет')
else:
    for i in range(0, array_length):
        if new_array[i] == num:
            print('ближайшее наименьшее к',new_array[i],'это',i - 1)
            count += 1
