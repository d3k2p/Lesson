using Microsoft.VisualBasic;
using System;

class Theme_LessonType
{
    private Theme theme;
    private LessonType lessonType;
    private UInt16 hours;
    public Theme_LessonType(Theme theme, LessonType lessonType, UInt16 hours)
    {
        this.theme = theme;
        this.lessonType = lessonType;
        this.hours = hours;
    }
}
