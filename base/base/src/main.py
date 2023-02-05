lst = [
    "Lesson", # Занятие
    "Auditory", # Аудитория
    "Discipline", # Дисциплина
    "Group", # Группа
    "Student", # Студент
    "Specialization", # Специальность
    "Pair", # Пара
    "Shift", # Смена
    "Employee", # Сотрудник
    "Post", # Должность
    "Division", # Подразделение
    "Organization", # Организация
    "Building", # Корпус
    "LessonType", # Вид занятия
    "Equipment", # Оборудование
    "KTP", # КТП
    "Theme", # Тема
    "Paragraph", # Параграф
    "Theme_LessonType", # Тема_Вид занятия
    "Content", # Материал
    "Competence", # Компетенция
    "KTPHeader", # Шапка КТП
    "ExtraActivity" # Внеурочка
]

base = """using Microsoft.VisualBasic;
using System;

class $cls$
{
    public $cls$()
    {
    }
}"""

for cls in lst:
    with open(f"{cls}.cs", "w") as f:
        f.write(base.replace("$cls$", cls))
