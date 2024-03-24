# Розмірність масиву
rows = 7
cols = 7

# Ініціалізація двовимірного масиву
two_dimensional_array = [[1 if (i % 2 == 0) else 0 for j in range(cols)] for i in range(rows)]

# Виведення масиву на екран
for row in two_dimensional_array:
    print(" ".join(map(str, row)))
