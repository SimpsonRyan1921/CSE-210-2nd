using System.Collections.Generic;

using System;

namespace Develop02
{
    public class Prompt
    {
        
        public string[] prompts =  {"What was one good thing from today?", "What was something new that you did today?", 
        "How did yo help soemone today or how did you grow?"};

        public string ChoosePrompt()
        {
            Random randomPrompt = new Random();
            int prompt = randomPrompt.Next(0,2);

            return prompts[prompt];
        }
        
    }
}