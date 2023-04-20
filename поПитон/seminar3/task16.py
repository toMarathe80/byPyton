# Нужно задать массив (Н) и посчитать за человека - сколько раз встречается там число (Ч)
import random
array,count = [],0
for i in range(0,6):
    array.append(random.randint(1,6))
print('Вот последовательность:',array)
num2 = int(input('Выберите число '))
for i in range(0,6):
    if array[i] == num2:
        count += 1
print('Здесь это число встречается',count,'раз')