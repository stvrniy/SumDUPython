def insert_elements_at_even_positions(input_list, elements_to_insert):
    result_list = []

    for i, item in enumerate(input_list):
        result_list.append(item)
        
        # Вставляємо новий елемент на парну позицію
        if i % 2 == 0 and elements_to_insert:
            result_list.append(elements_to_insert.pop(0))

    # Якщо є додаткові нові елементи, додаємо їх в кінець списку
    result_list.extend(elements_to_insert)

    return result_list

# Отримуємо вхідні дані від користувача
user_input = input("Введіть елементи списку через пробіл: ")
original_list = user_input.split()

# Вводимо нові елементи для вставки на парні позиції
new_elements = input("Введіть нові елементи для вставки на парні позиції через пробіл: ").split()

# Викликаємо функцію та виводимо результат
result_list = insert_elements_at_even_positions(original_list, new_elements)
print("Результат вставки нових елементів на парні позиції:", result_list)
