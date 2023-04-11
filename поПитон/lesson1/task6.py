#ДЗ-6
#Проверить, совпадает ли сумма цифр одной половины 6-ти значного, 
#числа, c другой (комбинация - счастливый билетик)
Gen_summa = input('Введите комбинацию билета: ')
part1,part2 = 0,len(Gen_summa) // 2
sumPart1,sumPart2 = 0,0

if len(Gen_summa) < 6 or len(Gen_summa) > 6:
    print("проверьте билетик, должно быть 6-ти значное число, повторитесь")
else:
    while part1 < len(Gen_summa) // 2:
        sumPart1 += int(Gen_summa[part1])
        sumPart2 += int(Gen_summa[part2+part1])
        part1 += 1
    if sumPart1 == sumPart2:
        print('у вас счастливый билетик!')
    else:
        print('это обычный билет')
    