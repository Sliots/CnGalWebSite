﻿using CnGalWebSite.DataModel.Helper;
using CnGalWebSite.DataModel.ViewModel.PostTools;
using CnGalWebSite.Helper.Helper;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnGalWebSite.Shared.Service
{
    public class EventService : IEventService
    {
        public event Action SavaTheme;
        public event Action TempEffectTheme;

        private readonly IMauiService _mauiService;
        private readonly IJSRuntime JS;
        private readonly ILogger<EventService> _logger;

        public EventService(IMauiService mauiService, IJSRuntime js, ILogger<EventService> logger)
        {
            _mauiService = mauiService;
            JS = js;
            _logger = logger;
        }

        /// <summary>
        /// 保存主题设置
        /// </summary>
        public void OnSavaTheme()
        {
            SavaTheme?.Invoke();
        }

        /// <summary>
        /// 临时设置主题
        /// </summary>
        public void OnTempEffectTheme()
        {
            TempEffectTheme?.Invoke();
        }

        public async Task OpenNewPage(string url)
        {
            if (ToolHelper.IsMaui)
            {
               await _mauiService.OpenNewPage(url);
            }
            else
            {
                try
                {
                    await JS.InvokeAsync<string>("openNewPage", url);
                }
                catch
                {
                    _logger.LogError( "尝试通过JS打开新标签页失败");
                }
               
            }
        }
    }
}
