num_bush = int(input('Введите количество кустов: '))
berries_on_bushes = []
for i in range(1, num_bush+1):
    berries_on_bushes.append(i)
print(f'Количество ягод на всех кустах: {berries_on_bushes}')
max_berries = berries_on_bushes[0] + berries_on_bushes[1] + berries_on_bushes[2]
for i in range(2, (len(berries_on_bushes) - 1)):
    sum_berries = berries_on_bushes[i - 1] + berries_on_bushes[i] + berries_on_bushes[i + 1]
    if max_berries < sum_berries:
        max_berries = sum_berries
print(f'За раз можно собрать максимум {max_berries} ягод')