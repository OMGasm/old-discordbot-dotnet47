﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace discordbot.commands
{
    class Play : CommandBase
    {
        string game;

        public override async Task action(CommandEventArgs e)
        {
            game = e.GetArg("game");
            e.Channel.Client.SetGame(game);
            e.Channel.Client.GatewaySocket.Connected += (s, ev) => e.Channel.Client.SetGame(game);
            await Task.Yield();
        }

        public override bool permission(Command command, User user, Channel channel)
        {
            return user.Id == 121183247022555137;
        }

        public Play() : base("play", "play a game", null, new KeyValuePair<string, ParameterType>[] { new KeyValuePair<string, ParameterType>("game", ParameterType.Unparsed) }) { }
    }
}
