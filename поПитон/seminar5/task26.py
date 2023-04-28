# Возвести число А в степень B с рекурсией.
def num_grades(a, b):
    if b == 1: 
        return a
    else: 
        c = a * num_grades(a, b - 1)
    return c


num1 = int(input('Введите число: '))
num2 = int(input('Введите степень: '))
print(f'результат {num_grades(num1, num2)}')