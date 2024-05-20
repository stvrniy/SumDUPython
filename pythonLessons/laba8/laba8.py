class Student1:
    def __init__(self):
        self.group = "Group1"
        self.name = "John Doe"
        self.course = 2
        self.subjects = {
            "Math": 90,
            "Physics": 85,
            "Chemistry": 88
        }
    
    def add_data(self, subject, mark):
        self.subjects[subject] = mark

class Student2:
    def __init__(self, data):
        self.data = data

    def sort_subjects_by_marks(self):
        sorted_subjects = sorted(self.data["subjects"].items(), key=lambda x: x[1])
        return dict(sorted_subjects)

# Перевірка роботи програми
if __name__ == "__main__":
    # Створення словника першим студентом
    student1_data = {
        "group": "Group1",
        "name": "John Doe",
        "course": 2,
        "subjects": {
            "Math": 90,
            "Physics": 85,
            "Chemistry": 88
        }
    }

    # Створення екземпляра першого студента
    student1 = Student1()

    # Виведення інформації про успішність першого студента
    print("Student 1 data:")
    print("Group:", student1.group)
    print("Name:", student1.name)
    print("Course:", student1.course)
    print("Subjects and marks:", student1.subjects)

    # Додавання додаткового предмету та оцінки
    student1.add_data("Biology", 95)
    print("Subjects and marks after adding Biology:", student1.subjects)

    # Створення екземпляра другого студента з використанням даних першого студента
    student2 = Student2(student1_data)

    # Сортування предметів за оцінками
    sorted_subjects = student2.sort_subjects_by_marks()
    print("\nStudent 2 sorted subjects by marks:")
    print(sorted_subjects)
