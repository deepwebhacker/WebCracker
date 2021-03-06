﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebCracker.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebCracker.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 关于 的本地化字符串。
        /// </summary>
        public static string ButtonAbout {
            get {
                return ResourceManager.GetString("ButtonAbout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 返回 的本地化字符串。
        /// </summary>
        public static string ButtonBack {
            get {
                return ResourceManager.GetString("ButtonBack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 加载 的本地化字符串。
        /// </summary>
        public static string ButtonLoad {
            get {
                return ResourceManager.GetString("ButtonLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 选择文件 的本地化字符串。
        /// </summary>
        public static string ButtonPassDict {
            get {
                return ResourceManager.GetString("ButtonPassDict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 暂停 的本地化字符串。
        /// </summary>
        public static string ButtonPause {
            get {
                return ResourceManager.GetString("ButtonPause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 保存 的本地化字符串。
        /// </summary>
        public static string ButtonSave {
            get {
                return ResourceManager.GetString("ButtonSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 开始 的本地化字符串。
        /// </summary>
        public static string ButtonStart {
            get {
                return ResourceManager.GetString("ButtonStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 结束 的本地化字符串。
        /// </summary>
        public static string ButtonStop {
            get {
                return ResourceManager.GetString("ButtonStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 详细说明建议参考https://github.com/zgjx6/WebCracker.
        ///
        ///[WebCracker](https://github.com/zgjx6/WebCracker)是一款基于C#的web后台弱口令爆破、检测工具。
        ///
        ///使用本工具需要对http有基础了解，需要先手动抓包得到登录接口、用户名及密码的键名。
        ///
        ///支持多线程、超时时间设置、Cookies、Headers、Data等参数设置。
        ///
        ///目前只支持字典模式，但是可以从中间某个密码开始，也可以暂停、保存、加载。
        ///
        ///登录成功判断暂时只支持关键字模式。
        ///
        ///部分灵感来源于`burpsuite`及https://github.com/yzddmr6/WebCrack。 的本地化字符串。
        /// </summary>
        public static string RichTextAbout1 {
            get {
                return ResourceManager.GetString("RichTextAbout1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 本工具不支持验证码.
        ///
        ///在 https://github.com/zgjx6/WebCracker releases 中下载中下载最新版本，其中免安装版本为rar自解压程序，执行后文件将自动解压到临时目录然后执行，也可以将其后缀改为rar然后解压执行`WebCracker.exe`即可。
        ///
        ///性能测试：
        ///
        ///结论：
        ///
        ///详细结论见[Github](https://github.com/zgjx6/WebCracker).
        ///
        ///发包速度：c#&gt;python&gt;&gt;Burpsuite，本工具发包速度很快，在有网络延迟时多线程优势明显，而Burpsuite虽然功能强大，但发包速度则过慢。
        ///
        ///响应速度：nodejs-express&gt;python-sanic&gt;&gt;python-flask&gt;&gt;php，nodejs太强大，而php则太慢，另外还发现php每隔几秒就会明显卡顿一会儿，性能太差。 的本地化字符串。
        /// </summary>
        public static string RichTextAbout2 {
            get {
                return ResourceManager.GetString("RichTextAbout2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 本工具为C#练手项目，大部分功能其实burpsuite都有，不过本工具使用起来更加简便。
        ///
        ///本工具为使用C#开发的WPF应用，基于.net4.7.2版本，代码开源于 https://github.com/zgjx6/WebCracker, 为防止植入木马，请在 https://github.com/zgjx6/WebCracker 上下载最新版本。
        ///
        ///依赖：在VS菜单-工具-NuGet包管理器中安装`MaterialDesignThemes`及`ShowMeTheXAML.MSBuild`。可参考 https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit . 的本地化字符串。
        /// </summary>
        public static string RichTextAbout3 {
            get {
                return ResourceManager.GetString("RichTextAbout3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 | 日期       | 版本 | 说明          |
        ///| ---------- | ---- | ------------- |
        ///| 2019-09-26 | 1.0  | 支持基本功能. |
        ///| 2019-10-18 | 1.0.1 | 修复异常返回导致崩溃的bug；&lt;br /&gt;修复保存配置无法新建文件的bug；&lt;br /&gt;对发送数据进行url编码。 | 的本地化字符串。
        /// </summary>
        public static string RichTextAbout4 {
            get {
                return ResourceManager.GetString("RichTextAbout4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 优先级：1-最高，9-最低
        ///
        ///| 优先级 | 功能                    |
        ///| ------ | ----------------------- |
        ///| 5      | 多用户扫描              |
        ///| 6      | 自动解析用户/密码关键字 |
        ///| 7      | 账号密码支持加密算法    |
        ///| 8      | 多种认证方式            |
        ///| 9      | 可选项折叠              |
        ///| 9      | 集成dirmap              |
        ///| 9      | 请求方式添加GET         |
        ///| 9      | 添加代理                | 的本地化字符串。
        /// </summary>
        public static string RichTextAbout5 {
            get {
                return ResourceManager.GetString("RichTextAbout5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 **请勿用于非法用途！否则自行承担一切后果** 的本地化字符串。
        /// </summary>
        public static string RichTextAbout6 {
            get {
                return ResourceManager.GetString("RichTextAbout6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [MIT License.](https://opensource.org/licenses/MIT) 的本地化字符串。
        /// </summary>
        public static string RichTextAbout7 {
            get {
                return ResourceManager.GetString("RichTextAbout7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 简介 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout1 {
            get {
                return ResourceManager.GetString("StringHeaderAbout1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 使用说明 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout2 {
            get {
                return ResourceManager.GetString("StringHeaderAbout2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 开发 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout3 {
            get {
                return ResourceManager.GetString("StringHeaderAbout3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 更新日志 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout4 {
            get {
                return ResourceManager.GetString("StringHeaderAbout4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 TODO 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout5 {
            get {
                return ResourceManager.GetString("StringHeaderAbout5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 警告！ 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout6 {
            get {
                return ResourceManager.GetString("StringHeaderAbout6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 开源协议 的本地化字符串。
        /// </summary>
        public static string StringHeaderAbout7 {
            get {
                return ResourceManager.GetString("StringHeaderAbout7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cookies 的本地化字符串。
        /// </summary>
        public static string StringLableCookies {
            get {
                return ResourceManager.GetString("StringLableCookies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Data 的本地化字符串。
        /// </summary>
        public static string StringLableData {
            get {
                return ResourceManager.GetString("StringLableData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 延迟时间 的本地化字符串。
        /// </summary>
        public static string StringLableDelay {
            get {
                return ResourceManager.GetString("StringLableDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Headers 的本地化字符串。
        /// </summary>
        public static string StringLableHeaders {
            get {
                return ResourceManager.GetString("StringLableHeaders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 关键字 的本地化字符串。
        /// </summary>
        public static string StringLableKey {
            get {
                return ResourceManager.GetString("StringLableKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 密码字典 的本地化字符串。
        /// </summary>
        public static string StringLablePassDict {
            get {
                return ResourceManager.GetString("StringLablePassDict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 开始密码 的本地化字符串。
        /// </summary>
        public static string StringLableStart {
            get {
                return ResourceManager.GetString("StringLableStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 线程数 的本地化字符串。
        /// </summary>
        public static string StringLableThreads {
            get {
                return ResourceManager.GetString("StringLableThreads", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 超时时间 的本地化字符串。
        /// </summary>
        public static string StringLableTimeout {
            get {
                return ResourceManager.GetString("StringLableTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 登录接口 的本地化字符串。
        /// </summary>
        public static string StringLableUrl {
            get {
                return ResourceManager.GetString("StringLableUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户名 的本地化字符串。
        /// </summary>
        public static string StringLableUsername {
            get {
                return ResourceManager.GetString("StringLableUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户/密码关键字 的本地化字符串。
        /// </summary>
        public static string StringLableUserPassKey {
            get {
                return ResourceManager.GetString("StringLableUserPassKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 key=value,多个用;分隔. 如:name=admin; sessionid=123456789;(可选) 的本地化字符串。
        /// </summary>
        public static string StringTextCookies {
            get {
                return ResourceManager.GetString("StringTextCookies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 key=value,多个用&amp;分隔. 如:CSRFName=CSRFGuard_123456&amp;CSRFToken=123456789(可选) 的本地化字符串。
        /// </summary>
        public static string StringTextData {
            get {
                return ResourceManager.GetString("StringTextData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 每次请求后等待时间，以防止请求速度过快被封(可选,默认无延迟) 的本地化字符串。
        /// </summary>
        public static string StringTextDelay {
            get {
                return ResourceManager.GetString("StringTextDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 key:value,多个用换行分隔,区分大小写,支持自定义header. 如:
        ///Referer: http://127.0.0.1
        ///User-Agent: Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36(可选) 的本地化字符串。
        /// </summary>
        public static string StringTextHeaders {
            get {
                return ResourceManager.GetString("StringTextHeaders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 User-Agent: Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36 的本地化字符串。
        /// </summary>
        public static string StringTextHeadersValue {
            get {
                return ResourceManager.GetString("StringTextHeadersValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 响应长度/关键字/状态码 的本地化字符串。
        /// </summary>
        public static string StringTextJudegType {
            get {
                return ResourceManager.GetString("StringTextJudegType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 响应长度 的本地化字符串。
        /// </summary>
        public static string StringTextJudegType1 {
            get {
                return ResourceManager.GetString("StringTextJudegType1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 关键字 的本地化字符串。
        /// </summary>
        public static string StringTextJudegType2 {
            get {
                return ResourceManager.GetString("StringTextJudegType2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 状态码 的本地化字符串。
        /// </summary>
        public static string StringTextJudegType3 {
            get {
                return ResourceManager.GetString("StringTextJudegType3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 响应长度: 根据响应长度判断是否登录成功，自动模式时长度与其他不同的请求视为成功，如果登录成功和失败的响应长度相同则不要使用此选项。也可以手动指定等于或不等于指定长度.
        ///关键字: 根据响应是否包含登录成功或失败的关键字判断是否登录成功，如果响应中有明显的可区分成功和失败的关键字，则建议使用此项。自动模式时返回值与其他不同的请求将视为请求成功。也可以手动输入 如: 登录成功.
        ///状态码: 根据响应状态码判断是否登录成功，自动模式时状态码与其他请求不同的请求视为成功，如果登录成功和失败的状态码相同则不要使用此选项。也可以手动指定状态码包含或不包含哪些，如301. 的本地化字符串。
        /// </summary>
        public static string StringTextKey1 {
            get {
                return ResourceManager.GetString("StringTextKey1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请根据判断类型填写(非自动时必填). 的本地化字符串。
        /// </summary>
        public static string StringTextKey2 {
            get {
                return ResourceManager.GetString("StringTextKey2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string StringTextKeyValue {
            get {
                return ResourceManager.GetString("StringTextKeyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 包含/排除 的本地化字符串。
        /// </summary>
        public static string StringTextModel {
            get {
                return ResourceManager.GetString("StringTextModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 自动 的本地化字符串。
        /// </summary>
        public static string StringTextModel1 {
            get {
                return ResourceManager.GetString("StringTextModel1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 包含 的本地化字符串。
        /// </summary>
        public static string StringTextModel2 {
            get {
                return ResourceManager.GetString("StringTextModel2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 排除 的本地化字符串。
        /// </summary>
        public static string StringTextModel3 {
            get {
                return ResourceManager.GetString("StringTextModel3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请选择字典(必填) 的本地化字符串。
        /// </summary>
        public static string StringTextPassDict {
            get {
                return ResourceManager.GetString("StringTextPassDict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 pass100.txt 的本地化字符串。
        /// </summary>
        public static string StringTextPassDictValue {
            get {
                return ResourceManager.GetString("StringTextPassDictValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 密码的键名,用在请求的body中. 如: password.(必填) 的本地化字符串。
        /// </summary>
        public static string StringTextPassKey {
            get {
                return ResourceManager.GetString("StringTextPassKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string StringTextPassKeyValue {
            get {
                return ResourceManager.GetString("StringTextPassKeyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 默认所有密码. 如果想从中间某个密码开始,可输入此选项.如果字典中没有此密码则从头开始.(可选) 的本地化字符串。
        /// </summary>
        public static string StringTextStart {
            get {
                return ResourceManager.GetString("StringTextStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 准备就绪 的本地化字符串。
        /// </summary>
        public static string StringTextStatus {
            get {
                return ResourceManager.GetString("StringTextStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 关键字不一致，无法自动判断，请手动设置. 的本地化字符串。
        /// </summary>
        public static string StringTextStatus10 {
            get {
                return ResourceManager.GetString("StringTextStatus10", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 状态码不一致，无法自动判断，请手动设置. 的本地化字符串。
        /// </summary>
        public static string StringTextStatus11 {
            get {
                return ResourceManager.GetString("StringTextStatus11", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请求错误, 原因: 的本地化字符串。
        /// </summary>
        public static string StringTextStatus12 {
            get {
                return ResourceManager.GetString("StringTextStatus12", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 必填项不能为空 的本地化字符串。
        /// </summary>
        public static string StringTextStatus2 {
            get {
                return ResourceManager.GetString("StringTextStatus2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 格式或参数错误 的本地化字符串。
        /// </summary>
        public static string StringTextStatus3 {
            get {
                return ResourceManager.GetString("StringTextStatus3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件不存在 的本地化字符串。
        /// </summary>
        public static string StringTextStatus4 {
            get {
                return ResourceManager.GetString("StringTextStatus4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 暂停中 的本地化字符串。
        /// </summary>
        public static string StringTextStatus5 {
            get {
                return ResourceManager.GetString("StringTextStatus5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已停止 的本地化字符串。
        /// </summary>
        public static string StringTextStatus6 {
            get {
                return ResourceManager.GetString("StringTextStatus6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已保存 的本地化字符串。
        /// </summary>
        public static string StringTextStatus7 {
            get {
                return ResourceManager.GetString("StringTextStatus7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已加载 的本地化字符串。
        /// </summary>
        public static string StringTextStatus8 {
            get {
                return ResourceManager.GetString("StringTextStatus8", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 响应长度不一致，无法自动判断，请手动设置. 的本地化字符串。
        /// </summary>
        public static string StringTextStatus9 {
            get {
                return ResourceManager.GetString("StringTextStatus9", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 正整数,线程数(可选,为空时单线程,相关性能测试见关于页面) 的本地化字符串。
        /// </summary>
        public static string StringTextThreads {
            get {
                return ResourceManager.GetString("StringTextThreads", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 1 的本地化字符串。
        /// </summary>
        public static string StringTextThreadsValue {
            get {
                return ResourceManager.GetString("StringTextThreadsValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 正整数,单位为秒.(可选,为空时无超时时间) 的本地化字符串。
        /// </summary>
        public static string StringTextTimeout {
            get {
                return ResourceManager.GetString("StringTextTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string StringTextTimeoutValue {
            get {
                return ResourceManager.GetString("StringTextTimeoutValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入URL地址(必填) 的本地化字符串。
        /// </summary>
        public static string StringTextUrl {
            get {
                return ResourceManager.GetString("StringTextUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string StringTextUrlValue {
            get {
                return ResourceManager.GetString("StringTextUrlValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户名的键名,用在请求的body中.如: username.(必填) 的本地化字符串。
        /// </summary>
        public static string StringTextUserKey {
            get {
                return ResourceManager.GetString("StringTextUserKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string StringTextUserKeyValue {
            get {
                return ResourceManager.GetString("StringTextUserKeyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 需要爆破的用户名,暂时只支持单个用户.默认为admin.(必填) 的本地化字符串。
        /// </summary>
        public static string StringTextUsername {
            get {
                return ResourceManager.GetString("StringTextUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string StringTextUsernameValue {
            get {
                return ResourceManager.GetString("StringTextUsernameValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 WEB账号暴力破解器 - 1.0.1 的本地化字符串。
        /// </summary>
        public static string StringTitle {
            get {
                return ResourceManager.GetString("StringTitle", resourceCulture);
            }
        }
    }
}
