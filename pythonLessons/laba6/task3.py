def find_repeated_letters(text):
    # Створюємо множину з літер тексту
    char_set = set(text)

    # Створюємо пустий список для зберігання літер, які входять не менше двох разів
    repeated_letters = []

    for char in char_set:
        # Підрахунок кількості входжень літери в текст
        count = text.count(char)
        
        # Якщо літера входить не менше двох разів, додаємо її до списку
        if count >= 2:
            repeated_letters.append(char)

    return repeated_letters

# Отримуємо вхідні дані від користувача
user_input = input("Введіть текст з латинських літер: ")

# Викликаємо функцію та отримуємо літери, які входять не менше двох разів
result = find_repeated_letters(user_input)

# Виводимо результат на екран
print("Літери, які входять в текст не менше двох разів:", result)
