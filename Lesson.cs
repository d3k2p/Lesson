using Microsoft.VisualBasic;
using System;

namespace myNameSpace;
class Lesson
{
    private object linkSubject, linkTeacher, linkAuditory, linkGroup, linkLesson;
    private DateTime? date;
    Lesson(object linkSubject, object linkTeacher, object linkAuditory, object linkGroup, object linkLesson, DateTime? date = null)
    {
        this.linkSubject = linkSubject;
        this.linkTeacher = linkTeacher;
        this.linkAuditory = linkAuditory;
        this.linkGroup = linkGroup;
        this.linkLesson = linkLesson;
        this.date = date != null ? date : DateTime.Now;
    }
}