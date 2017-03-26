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
    public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(Utils.GetAppSetting("810fbe2afab14f299a0b6874ff217cea"), Utils.GetAppSetting("d1cf5bc3-f072-496e-bac3-da49afd29ef5"),"No good answer",0.5)))
    {
    }
}   