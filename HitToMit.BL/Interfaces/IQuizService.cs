﻿using HitToMit.BL.Results;
using System.Threading.Tasks;

namespace HitToMit.BL.Interfaces
{
    public interface IQuizService
    {
        public Task<bool> HasAnimal(string userId);

        public Task ClearAnimal(string userId);

        public Task<QuizResult> GetQuiz();

        public Task AddAnimalToUser(string userId, int animalId);
    }
}
