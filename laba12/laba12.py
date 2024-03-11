import os
import json

file_path = 'people_data.json'

def load_json(file_path):
    if not os.path.exists(file_path):
        with open(file_path, 'w', encoding='utf-8') as new_file:
            json.dump([], new_file)
            print(f"Файл '{file_path}' був створений.")

    try:
        with open(file_path, 'r', encoding='utf-8') as file:
            data = json.load(file)
        return data
    except json.JSONDecodeError:
        print(f"Помилка при декодуванні JSON у файлі '{file_path}'.")
        return None

def save_json(data, file_path):
    try:
        with open(file_path, 'w', encoding='utf-8') as file:
            json.dump(data, file, indent=2)
        print(f"Дані збережено у файл '{file_path}'.")
    except Exception as e:
        print(f"Виникла помилка при збереженні даних: {e}")

def display_json(data):
    print(json.dumps(data, indent=2))

def add_record(data, record):
    data.append(record)
    print("Новий запис додано.")

def delete_record(data, index):
    try:
        del data[index]
        print("Запис видалено.")
    except IndexError:
        print("Індекс не існує.")

def search_by_field(data, field, value):
    results = [record for record in data if record.get(field) == value]
    if results:
        print("Результати пошуку:")
        display_json(results)
    else:
        print("Немає результатів.")

def calculate_average_height(data):
    male_heights = [record['height'] for record in data if record['gender'] == 'male']
    if male_heights:
        average_height = sum(male_heights) / len(male_heights)
        print(f"Середній зріст чоловіків: {average_height:.2f} см")
    else:
        print("Немає даних про чоловіків.")

# Приклад використання функцій:
data = load_json(file_path)
print("Дані зчитано з файлу.")

if data:
    while True:
        print("\n1. Вивести на екран вмісту JSON файлу.")
        print("2. Додати новий запис у JSON файл.")
        print("3. Видалити запис з JSON файлу.")
        print("4. Пошук даних за полем.")
        print("5. Обчислити середній зріст чоловіків.")
        print("6. Вийти з програми.")

        choice = input("Оберіть опцію (1-6): ")

        if choice == '1':
            display_json(data)
        elif choice == '2':
            new_record = {
                'gender': input("Введіть стать (male/female): "),
                'height': float(input("Введіть зріст (см): "))
            }
            add_record(data, new_record)
        elif choice == '3':
            index_to_delete = int(input("Введіть індекс запису для видалення: "))
            delete_record(data, index_to_delete)
        elif choice == '4':
            field_to_search = input("Введіть поле для пошуку: ")
            value_to_search = input(f"Введіть значення для поля '{field_to_search}': ")
            search_by_field(data, field_to_search, value_to_search)
        elif choice == '5':
            calculate_average_height(data)
        elif choice == '6':
            save_json(data, file_path)
            print("Вихід з програми.")
            break
        else:
            print("Невірний вибір. Спробуйте ще раз.")
