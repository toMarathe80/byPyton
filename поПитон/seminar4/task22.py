import random
def make_arr(q):
    arr = []
    for i in range(0, q):
        arr.append(random.randint(0, 100))
    return arr

def quicksort(array):
    if len(array) < 2:
        return array
    else:
        pivot = array[0]
        less = [i for i in array[1:] if i <= pivot]
        greater = [i for i in array[1:] if i > pivot]
        return quicksort(less) + [pivot] + quicksort(greater)

n = int(input('Введите N: '))
arr_a = make_arr(random.randint(1, n))
m = int(input('Введите M: '))
arr_b = make_arr(random.randint(1, m))
print(arr_a)
print('----------')
print(arr_b)
result_arr = []
for i in range(0, len(arr_a)):
    if arr_a[i] not in result_arr:
        result_arr.append(arr_a[i])
for i in range(0, len(arr_b)):
    if arr_b[i] not in result_arr:
        result_arr.append(arr_b[i])
print('----------')
print(result_arr)
print(quicksort(result_arr))

