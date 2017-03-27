using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

// For more information about this template visit http://aka.ms/azurebots-csharp-qnamaker
[Serializable]
public class BasicQnAMakerDialog : QnAMakerDialog
{
    // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
    public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(Utils.GetAppSetting("db9ac098-210c-4770-bd26-ed8abd4ec76a"), Utils.GetAppSetting("d1cf5bc3-f072-496e-bac3-da49afd29ef5"),"No good answer",0.5)))
    {
    }
    //protected override async Task RespondFromQnAMakerResultAsync(IDialogContext context, IMessageActivity message, QnAMakerResult result)
    //{
    //    if (result.Score == 0)
    //    {
    //        await context.PostAsync("Executing custom logic..");
    //    }
    //    else
    //    {
    //        await base.RespondFromQnAMakerResultAsync(context, message, result);
    //    }
    //}

    //protected override async Task DefaultWaitNextMessageAsync(IDialogContext context, IMessageActivity message, QnAMakerResult result)
    //{
    //    if (result != null && result.Score == 0)
    //    {
    //        PromptDialog.Confirm(context, PromptDialogResultAsync, "Do you want to see the services menu?");
    //    }
    //    else
    //    {
    //        await base.DefaultWaitNextMessageAsync(context, message, result);
    //    }
    //}

    //private async Task PromptDialogResultAsync(IDialogContext context, IAwaitable<bool> result)
    //{
    //    if (await result == true)
    //    {
    //        await context.PostAsync("Showing the menu..");

    //        // TODO: you can continue your custom logic here and finally go back to the QnA dialog loop using DefaultWaitNextMessageAsync()

    //        await this.DefaultWaitNextMessageAsync(context, null, null);
    //    }
    //    else
    //    {
    //        await this.DefaultWaitNextMessageAsync(context, null, null);
    //    }
    //}
}