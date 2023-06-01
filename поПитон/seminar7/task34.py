# Надо проверить, есть ли в фразах ритм. "ДА", если  
# в каждой фразе (ряд символов до пробела) число гласных букв 
# одинаково, нп "Парам пам-пам", если да и "Пам парам" - нет

keys = ['а','у','з','ы','я','е','ю','и']
arr_count = []
texts = input('enter your draft: ').split()
for i in range(len(texts)):
    print(texts[i])
    count = 0
    for j in range(len(texts[i])):
        for k in range(len(keys)):
            if keys[k] in texts[i][j]:
                count += 1
    arr_count.append(count)
ritm = False
max = arr_count[0]
for i in range(1, len(arr_count)):
    if max != arr_count[i]:
        ritm = False
    else:
        ritm = True
if ritm: print('Парам пам-пам')
else: print('Пам парам')