﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ElevenNoteAPI.Startup))]

namespace ElevenNoteAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll); //why did we bother to download cors and just allow all???
            ConfigureAuth(app);
        }
    }
}
