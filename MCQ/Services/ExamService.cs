﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMVCApplication.Models;

namespace MyMVCApplication.Services
{
    public class ExamService
    {
        public Exam GetExam()
        {
            var exam = new Exam() { Id=100, Name = "MATH EXAM 1"};
            exam.AddQuestion(GetQuestions());

            return exam; 
        }

        private IList<Question> GetQuestions()
        {
            var questions = new List<Question>()
                {
                    new Question() { Text = "What is 2+2", Point = 10, Id = 1, OrderNumber = 0}, 
                    new Question() { Text = "What is 5+2", Point = 10, Id =2, OrderNumber = 1},
                    new Question() { Text="What is 10+2", Point =5, Id=3, OrderNumber = 2}
                };

            questions[0].AddChoice(new Choice() { IsAnswer = false, Text = "2", Id = 1});
            questions[0].AddChoice(new Choice(){ IsAnswer = true, Text = "4",Id=2});

            questions[1].AddChoice(new Choice() { IsAnswer = false, Text = "12", Id=3});
            questions[1].AddChoice(new Choice() { IsAnswer = true, Text = "7", Id=4});

            questions[2].AddChoice(new Choice() { IsAnswer = true, Text = "12", Id = 5 });
            questions[2].AddChoice(new Choice() { IsAnswer = false, Text = "15", Id = 6 });


            return questions; 
        }

        public Grade Grade(Exam toBeGradedExam)
        {
            var persistedExam = GetExam();
            var grade = new Grade() { Exam = persistedExam}; 

            foreach(var question in toBeGradedExam.Questions)
            {
                var persistedQuestion = (from q in persistedExam.Questions
                                        where q.Id == question.Id
                                        select q).SingleOrDefault(); 

                if(persistedQuestion != null)
                {
                    foreach(var choice in question.Choices)
                    {
                        var persistedChoice = (from c in persistedQuestion.Choices
                                               where c.Id == choice.Id
                                               select c).SingleOrDefault();

                        // sets the user choice in the actual exam fetched from database! 
                        persistedChoice.IsSelected = true; 

                        if(persistedChoice.IsAnswer)
                        {
                            grade.Score += persistedQuestion.Point; 
                        }
                    }
                }
            }

            return grade; 
        }
    }
}
