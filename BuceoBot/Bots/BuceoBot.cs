// Generated with BuceoBot .NET Template version v4.22.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Azure;
using Azure.AI.OpenAI;
using System;

namespace BuceoBot.Bots
{
    public class BuceoBot : ActivityHandler
    {
        //Generar 2 propiedades para la llave y el endpoint de Azure OpenAI, con un valor predeterminado 
        private string openAIKey = "b605bdfb2f3945e1ba066c8359783ef5";
        private string openAIEndpoint = "https://oaibotbuceo.openai.azure.com/";

        //Generar un metodo asincrono que regrese un string y que reciba como parametro un texto, el metodo esta vacio
        private async Task<string> GetOpenAIResponseAsync(string text)
        {
            //generar un AzureKeyCredential con la llave de OpenAI
            var credential = new AzureKeyCredential(openAIKey);
            //inicializar el cliente de OpenAIClient con el endpoint de openai y el AzureKeyCredential
            var client = new OpenAIClient(new Uri(openAIEndpoint), credential);
            // Inicializar las opciones de ChatCompletionsOptions de forma inline indicando el parametro de DeploymentName de tipo gpt-35-turbo y Messages recibido de la variable text de tipo ChatRequestUserMessage
             var options = new ChatCompletionsOptions
            {
                  DeploymentName="gpt-35-turbo",
                  Messages = {
                      new ChatRequestUserMessage (text )
                  },                
             };

             var result = await client.GetChatCompletionsAsync(options);
             return result.Value.Choices[0].Message.Content;

            return "";
        }



        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var replyText = $"Echo: {turnContext.Activity.Text}";
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome!";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
