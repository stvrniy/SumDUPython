import pandas as pd

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

# Створення датафрейму зі словника
people_df = pd.DataFrame(people_data).transpose()

# Виведення датафрейму на екран
print("Датафрейм:")
print(people_df)

# Агрегація та групування за статтею
aggregated_data = people_df.groupby('Стать').agg({
    'Зріст': 'mean'
}).reset_index()

# Виведення результатів
print("\nАгреговані дані:")
print(aggregated_data)
