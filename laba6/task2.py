def swap_elements_between_even_and_odd_indices(input_list):
    result_list = []

    for i in range(0, len(input_list) - 1, 2):
        # Змінюємо місцями елементи з парним і непарним індексами
        result_list.extend([input_list[i + 1], input_list[i]])

    # Якщо кількість елементів непарна, додаємо останній елемент в кінець списку
    if len(input_list) % 2 != 0:
        result_list.append(input_list[-1])

    return result_list

# Отримуємо вхідні дані від користувача
user_input = input("Введіть елементи списку через пробіл: ")
original_list = user_input.split()

# Викликаємо функцію та виводимо результат
result_list = swap_elements_between_even_and_odd_indices(original_list)
print("Результат заміни місцями елементів з парними і непарними індексами:", result_list)
