# Есть N монет, какая то часть (0) повернута одной, часть (1) другой стороной 
# (задать случайным образом) определить - сколько min монеток надо перевернуть, 
# чтоб все оказались одинаковыми 
import random
arr,orel,reshk = [],0,0
N_coins = int(input('Введите количество монеток: '))
print('вот они -')
for i in range(0,N_coins):
    arr.append(random.randint(0, 1))
    print(arr[i],end=' ')
    if arr[i] == 0:
        orel += 1
    else:
        reshk += 1
print()
if orel > reshk:
    print('Нужно перевернуть',reshk,'монеток')
else:
    print('Нужно перевернуть',orel,'монеток')