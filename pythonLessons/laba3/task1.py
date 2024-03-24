# Приклад рядка
my_string = "Присвойте змінній довільний рядок"
print(my_string)
# Отримання передостаннього символу
if len(my_string) >= 2:
    penultimate_char = my_string[-2]
    print(f"Передостанній символ рядка: {penultimate_char}")
else:
    print("Довжина рядка недостатня для отримання передостаннього символу.")
