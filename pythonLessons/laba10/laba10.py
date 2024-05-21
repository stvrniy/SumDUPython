
filename = "student_questions.txt"

try:
    with open(filename, 'w', encoding='utf-8') as file:
        file.write("Іваненко\n")
        file.write("Як оголосити функцію у Python?\n")
except IOError as e:
    print(f"Помилка при роботі з файлом: {e}")

filename = "student_questions.txt"

try:
    with open(filename, 'a', encoding='utf-8') as file:
        file.write("\nПетров\n")
        file.write("Функцію у Python можна оголосити за допомогою ключового слова 'def'.\n")
        file.write("Як створити клас у Python?\n")
except IOError as e:
    print(f"Помилка при роботі з файлом: {e}")

filename = "student_questions.txt"

try:
    with open(filename, 'a', encoding='utf-8') as file:
        file.write("\nСидоренко\n")
        file.write("Клас у Python можна створити за допомогою ключового слова 'class'.\n")
        file.write("Що таке декоратор у Python?\n")
except IOError as e:
    print(f"Помилка при роботі з файлом: {e}")
