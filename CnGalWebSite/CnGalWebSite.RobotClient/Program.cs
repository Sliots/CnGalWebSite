﻿//这是一个最简.net6版本顶级语句 [仅对于高级开发人员使用]
using MeowMiraiLib.Msg.Type;
using MeowMiraiLib;
using CnGalWebSite.RobotClient;
using CnGalWebSite.Helper.Helper;
using MeowMiraiLib.Msg.Sender;
using MeowMiraiLib.Msg;

HttpClient httpClient = new HttpClient();
CacheX cacheX = new CacheX();

OutputHelper.Repeat();
OutputHelper.WriteCenter("CnGal资料站 看板娘 v3.3.0", 1.8);
OutputHelper.Repeat();


Console.WriteLine("->读取配置文件");
SettingX settingX = new SettingX();
settingX.Init();

Console.WriteLine("->读取关注的QQ群");
GroupX groupX = new GroupX(settingX.BasicSetting, httpClient);
groupX.Init();

Console.WriteLine("->读取自动回复");
ReplyX replyX = new ReplyX(settingX.BasicSetting, httpClient,settingX.MessageArgs);
replyX.Init();

Console.WriteLine("->读取事件");
EventX eventX = new EventX(settingX.BasicSetting, httpClient, settingX.MessageArgs);
eventX.Init();

Console.WriteLine("->初始化消息处理模块");
MessageX messageX = new MessageX(settingX.BasicSetting, httpClient, replyX.Replies,cacheX.ReplyCache, settingX.MessageArgs);

ClientX clientX = new ClientX(settingX.BasicSetting);

try
{
    Console.WriteLine("->初始化 Mirai 客户端");
    clientX.Init();
}
catch (Exception ex)
{
    OutputHelper.PressError(ex, "初始化 Mirai 客户端失败", "配置文件错误或 Mirai 未正确启动");
}

var c = clientX.MiraiClient;


//定时刷新数据定时器
if (settingX.BasicSetting.IntervalTime > 0)
{
    var refreshTimer = new System.Threading.Timer(new System.Threading.TimerCallback(Refresh), null, 0, 1000 * settingX.BasicSetting.IntervalTime);
    async void Refresh(object o)
    {
        await groupX.RefreshAsync();
        await replyX.RefreshAsync();
        await eventX.RefreshAsync();
    }
}

c.Connect();

//定时刷新数据定时器
System.Timers.Timer t = new(1000 * 60); //每一分钟查看一次
t.Start(); //启动计时器
t.Elapsed +=async (s, e) =>
{
    var message = eventX.GetCurrentMessage();
    if (string.IsNullOrWhiteSpace(message) == false)
    {
        var replay = await messageX.ReplayArgument(message, null);

        var result = messageX.StringToMessageArray(replay, null);

        if (result != null)
        {
            foreach (var item in groupX.Groups)
            {
                var j = new GroupMessage(item.GroupId, result).Send(c);
                Console.WriteLine(j);
            }
        }
    }
};



//c.ConnectAsync()
c.OnFriendMessageReceive += (s, e) =>
{
    //MGetPlainStringSplit() 是一个关于Message类的数组扩展方法,
    //用于返回信息里的文字部分后按照 Splitor进行分割, splitor默认是空格
    var sx = e.MGetPlainStringSplit();
    var sendto = s.id;
    var (t, j) = sx[0] switch
    {
        //使用信息类的扩展发送方法
        "重复" => new Message[] { new Plain(sx[1]) }.SendToFriend(sendto, c),
    };
    Console.WriteLine(j);

};
//c.事件 += (s,e) => { 处理函数 }


c.OnGroupMessageReceive += async (s, e) =>
{
    try
    {

        //MGetPlainStringSplit() 是一个关于Message类的数组扩展方法,

        var text = e.MGetPlainString();
        var sendto = s.group.id;
        var at = e.FirstOrDefault(s=>s.type == "At");
        if(at != null)
        {
            long atTarget = (at as At).target;
            text += "[@" + atTarget.ToString() + "]";
        }

        if (groupX.Groups.Any(s=>s.GroupId==sendto)==false)
        {
            return;
        }

        //尝试找出所有匹配的回复
        var result = await messageX.ProcMessage(text, s);
        if (result != null)
        {
            var j = result.SendToGroup(sendto, c);
            Console.WriteLine(j);
        }
    }
    catch (Exception ex)
    {
        OutputHelper.PressError(ex);
    }

};

while (true)
{
    switch (System.Console.ReadLine()) // 控制台操作
    {
        //.....
    }
}
