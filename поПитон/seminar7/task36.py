# Написать функцию, принимающая функцию, вычисляющую элемент
# по номеру строки и столбца

def print_operation_table(operation, num_rows = 6, num_columns = 6):
        for y in range(1, num_rows + 1):
            for x in range(1, num_columns + 1):
                print(f'{operation(y,x):4}',end='')
            print()

print_operation_table(lambda x, y: x * y)