# Требуется отгадать два числа по подсказкам -
# их сумма при сложении и умножении
import random
x = random.randint(1, 1000)
y = random.randint(1, 1000)
a,b = 0,0
print('Надо отгадать',x,'и',y)
while a != x and b != y:
    print('Сумма =',x+y)
    print('Произведение чисел =',x*y)
    a = input('Введите первое число: ')
    b = input('Введите второе число: ')
    if (a == x and b == y) or (a == y and b == x):
        print('Ура! Вы правильно угадали!')
    else:
        print('нет, давай еще раз')