def display_all(dictionary):
    print("Усі значення словника:")
    for key, value in dictionary.items():
        print(f"{key}: {value}")

def add_entry(dictionary, last_name, first_name, height, gender):
    new_entry = {
        "Прізвище": last_name,
        "Ім'я": first_name,
        "Зріст": height,
        "Стать": gender
    }
    dictionary[last_name] = new_entry
    print("Новий запис додано до словника.")

def delete_entry(dictionary, last_name):
    try:
        del dictionary[last_name]
        print(f"Запис з прізвищем '{last_name}' видалено.")
    except KeyError:
        print(f"Запис з прізвищем '{last_name}' не знайдено.")

def view_sorted_by_keys(dictionary):
    sorted_keys = sorted(dictionary.keys())
    print("Вміст словника відсортований за ключами:")
    for key in sorted_keys:
        print(f"{key}: {dictionary[key]}")

def calculate_average_height_of_men(dictionary):
    male_heights = [entry["Зріст"] for entry in dictionary.values() if entry["Стать"].lower() == "чоловік"]
    if not male_heights:
        print("Немає даних про чоловіків.")
        return
    average_height = sum(male_heights) / len(male_heights)
    print(f"Середній зріст чоловіків: {average_height} см")

# Ініціалізація словника з прикладовими даними
people_data = {
    "Ivanov": {"Прізвище": "Ivanov", "Ім'я": "Ivan", "Зріст": 175, "Стать": "чоловік"},
    "Petrov": {"Прізвище": "Petrov", "Ім'я": "Petro", "Зріст": 180, "Стать": "чоловік"},
    # ... додайте інші записи за необхідністю
}

# Головний цикл програми
while True:
    print("\nМеню:")
    print("1. Вивести всі значення словника.")
    print("2. Додати новий запис.")
    print("3. Видалити запис.")
    print("4. Переглянути вміст словника за відсортованими ключами.")
    print("5. Розрахувати середній зріст чоловіків.")
    print("6. Вийти з програми.")

    choice = input("Введіть номер опції: ")

    if choice == "1":
        display_all(people_data)
    elif choice == "2":
        last_name = input("Введіть прізвище: ")
        first_name = input("Введіть ім'я: ")
        height = int(input("Введіть зріст: "))
        gender = input("Введіть стать (чоловік/жінка): ").lower()
        add_entry(people_data, last_name, first_name, height, gender)
    elif choice == "3":
        last_name = input("Введіть прізвище запису, який ви хочете видалити: ")
        delete_entry(people_data, last_name)
    elif choice == "4":
        view_sorted_by_keys(people_data)
    elif choice == "5":
        calculate_average_height_of_men(people_data)
    elif choice == "6":
        print("Програма завершена.")
        break
    else:
        print("Некоректний вибір. Будь ласка, виберіть правильну опцію.")
