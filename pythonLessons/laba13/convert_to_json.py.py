import csv
import json
import os

csv_filename = 'data.csv'
json_filename = 'data.json'


try:
    with open(csv_filename, mode='w', newline='', encoding='utf-8') as file:
        writer = csv.writer(file)
        writer.writerow(["Name", "Age", "City"])
        writer.writerow(["Ivanenko", 22, "Kyiv"])
        writer.writerow(["Petrov", 30, "Lviv"])
        writer.writerow(["Sydorenko", 25, "Odessa"])
except IOError as e:
    print(f"Помилка при створенні CSV файлу: {e}")


try:
    data = []
    with open(csv_filename, mode='r', encoding='utf-8') as file:
        csv_reader = csv.DictReader(file)
        for row in csv_reader:
            data.append(row)

    with open(json_filename, mode='w', encoding='utf-8') as file:
        json.dump(data, file, indent=4)
except IOError as e:
    print(f"Помилка при конвертації у JSON файл: {e}")

try:
    data = []
    with open(csv_filename, mode='r', encoding='utf-8') as file:
        csv_reader = csv.DictReader(file)
        for row in csv_reader:
            data.append(row)

    data.append({"Name": "Bondarenko", "Age": 40, "City": "Zaporizhzhia"})
    data.append({"Name": "Tkachenko", "Age": 33, "City": "Vinnytsia"})

    with open(json_filename, mode='w', encoding='utf-8') as file:
        json.dump(data, file, indent=4)
except IOError as e:
    print(f"Помилка при роботі з файлом: {e}")

