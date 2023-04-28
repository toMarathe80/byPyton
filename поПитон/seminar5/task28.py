# Написать функцию sum(a, b) через рекурсию,
# операции +1 и -1. 

def sum_recurs(a, b):
    if b == 1: 
        return a + 1
    else: 
        c = sum_recurs(a, b - 1) + 1
    return c

num1 = int(input('Введите первое число: '))
num2 = int(input('Введите второе число: '))
print('Сумма чисел {} и {} равна {}'.format(num1,num2,sum_recurs(num1,num2)))