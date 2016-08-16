using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Connector;

using Newtonsoft.Json;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Web;
using System.Xml.Linq;

namespace Bot_Application1
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        string data;

        public string Title { get; private set; }

        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<Message> Post([FromBody]Message message)
        {


            Message replyMessage = message.CreateReplyMessage("");
            if (message.Type == "Message")
            {

                if (Regex.IsMatch(message.Text, "help", RegexOptions.IgnoreCase))
                {

                    //return message.CreateReplyMessage("Hey! Here you can get latest news updates in Sinhala from all major news providers. Just type something and lets get started. \n" +  "Try these, \n `What are the latest local news?`  `What are the latest adaderana news?`  `Show me sports news`  `latest gossips`  `What are the newest tech news?`");

                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Local News",
                        Message = "local news"
                    });

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Sports News",
                        Message = "Latest Sports news"
                    });


                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Tech news",
                        Message = "Latest tech news"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "International News",
                        Message = "Latest world news"
                    });

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Entertainment News",
                        Message = "Latest fun news"
                    });


                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Business news",
                        Message = "biz news"
                    });


                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Latest Sinhala Songs",
                        Message = "songs"
                    });

                 actions5.Add(new Microsoft.Bot.Connector.Action
                   {
                       Title = "Latest Cinema News",
                       Message = "cinema"
                  });


                   // actions5.Add(new Microsoft.Bot.Connector.Action
                   // {
                    //    Title = "Tech news",
                    //    Message = "Latest tech news"
                   // });


                  










                    var actions1 = new List<Microsoft.Bot.Connector.Action>();

                   



                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Ada Derana news",
                        Message = "Latest adaderana news"
                    });

                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "ITN News",
                        Message = "Latest itn news"
                    });
                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Sirasa News",
                        Message = "Latest sirasa news"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                  


                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Neth News",
                        Message = "neth news"
                    });

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "BBC News",
                        Message = "Latest bbc news"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Gossips",
                        Message = "Latest gossips"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Tech Guru News",
                        Message = "Latest techguru news"
                    });

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Windows Geek News",
                        Message = "Latest windowsgeek news"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "ReadMe News",
                        Message = "readme news"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {


                        Title = "Help",
                        //TitleLink = "http://puwathbot.xyz",
                        ThumbnailUrl = "http://eapps.xyz/puwathbot/help.jpg",
                        Text = "You can get latest news updates in Sinhala from all major news providers.",
                        FallbackText = "You can get latest news updates in Sinhala from all major news providers.",
                        Actions = actions
                    });
                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "Help",
                        //TitleLink = "http://puwathbot.xyz",
                        ThumbnailUrl = "http://eapps.xyz/puwathbot/help.jpg",
                        Text = "You can try These examples",
                        FallbackText = "You can try These examples",
                        Actions = actions4
                    });

                replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "Help",
                       // TitleLink = "http://puwathbot.xyz",
                        ThumbnailUrl = "http://eapps.xyz/puwathbot/help.jpg",
                        Text = "You can try These examples",
                        FallbackText = "You can try These examples",
                        Actions = actions1
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "Help",
                        //TitleLink = "http://puwathbot.xyz",
                        ThumbnailUrl = "http://eapps.xyz/puwathbot/help.jpg",
                        Text = "You can try These examples",
                        FallbackText = "You can try These examples",
                        Actions = actions2
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "Help",
                      //  TitleLink = "http://puwathbot.xyz",
                        ThumbnailUrl = "http://eapps.xyz/puwathbot/help.jpg",
                        Text = "You can try These examples",
                        FallbackText = "You can try These examples",
                        Actions = actions3
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "Help",
                       // TitleLink = "http://puwathbot.xyz",
                        ThumbnailUrl = "http://eapps.xyz/puwathbot/help.jpg",
                        Text = "You can try These examples",
                        FallbackText = "You can try These examples",
                        Actions = actions5
                    });





                    return replyMessage;
                }

                if (Regex.IsMatch(message.Text, "master", RegexOptions.IgnoreCase))
                {


                    //string text = "![like](https://scontent-sin1-1.xx.fbcdn.net/v/t1.0-9/12508738_10207991783260052_5930237498607930959_n.jpg?oh=5fb3598ac49e4058e89424789ece5be0&oe=57D47D10)";

                    // return message.CreateReplyMessage(text);
                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "Prabhath Mannapperuma",
                        TitleLink = "http://prabhath.online",
                        ThumbnailUrl = "https://scontent-sin1-1.xx.fbcdn.net/v/t1.0-9/13055354_10205813779295373_2888056272537506095_n.jpg?oh=d1fbb4c06cc8cafbd5eb5836578b6a86&oe=57CFA679",
                        Text = "Undergraduate of Sri Lanka Institute of Information Technology",
                        FallbackText = "Prabhath Mannapperuma: https://scontent-sin1-1.xx.fbcdn.net/v/t1.0-9/13055354_10205813779295373_2888056272537506095_n.jpg?oh=d1fbb4c06cc8cafbd5eb5836578b6a86&oe=57CFA679"
                    });
                    return replyMessage;


                }











                if (Regex.IsMatch(message.Text, "adaderana", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "derana", RegexOptions.IgnoreCase))
                {




                    replyMessage.Attachments = new List<Attachment>();


                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://sinhala.adaderana.lk/rss.php");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;




















                }





                else if (Regex.IsMatch(message.Text, "itn", RegexOptions.IgnoreCase))
                {
                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://www.itnnews.lk/sinhala/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://itnnews.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://itnnews.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://itnnews.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://itnnews.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://itnnews.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://itnnews.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;




                }






                else if (Regex.IsMatch(message.Text, "sirasa", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "newsfirst", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "news first", RegexOptions.IgnoreCase))
                {









                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://newsfirst.lk/sinhala/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;



                }

                else if (Regex.IsMatch(message.Text, "neth", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "neth fm", RegexOptions.IgnoreCase))
                {









                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://nethnews.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://nethfm.com"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://nethfm.com"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://nethfm.com"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://nethfm.com"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://nethfm.com"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://nethfm.com"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        // Text = description1,
                        // FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        // Text = description2,
                        // FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        // Text = description3,
                        // FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //  Text = description4,
                        //  FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //  Text = description5,
                        // FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        // Text = description6,
                        // FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;


                }


                else if (Regex.IsMatch(message.Text, "bbc", RegexOptions.IgnoreCase))
                {









                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://feeds.bbci.co.uk/sinhala/rss.xml");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;




                }


























                else if (Regex.IsMatch(message.Text, "techguru", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "tech guru", RegexOptions.IgnoreCase))
                {










                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://techguru.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://techguru.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://techguru.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://techguru.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://techguru.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://techguru.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://techguru.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;






                    // return message.CreateReplyMessage("Day " + getDays(message.Text).ToString(), true).ConfigureAwait(false);



                }


                else if (Regex.IsMatch(message.Text, "windowsgeek", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "windows geek", RegexOptions.IgnoreCase))
                {








                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://windowsgeek.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://windowsgeek.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://windowsgeek.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://windowsgeek.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://windowsgeek.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://windowsgeek.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://windowsgeek.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;




                }


                else if (Regex.IsMatch(message.Text, "readme", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "read me", RegexOptions.IgnoreCase))
                {








                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://readme.lk/sinhala/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Read Me",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://readme.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Read Me",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://readme.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Read Me",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://readme.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Read Me",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://readme.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Read Me",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://readme.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Read Me",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://readme.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        // Text = description1,
                        // FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        //  Text = description2,
                        // FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //  Text = description3,
                        // FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        // Text = description4,
                        // FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //  Text = description5,
                        //FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        // Text = description6,
                        // FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;




                }



                //All tech

                else if (Regex.IsMatch(message.Text, "tech", RegexOptions.IgnoreCase) || (Regex.IsMatch(message.Text, "technology", RegexOptions.IgnoreCase)))
                {

                    string title = "";
                    string description = "";
                    string link = "";

                    string title1 = "";
                    string description1 = "";
                    string link1 = "";

                    string title2 = "";
                    string description2 = "";
                    string link2 = "";



                    XmlDocument rssXmlDoc = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://windowsgeek.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed = 1;
                    foreach (XmlNode rssNode in rssNodes)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description = rssSubNode != null ? rssSubNode.InnerText : "";




                        rssContent.Append("📰 " + title + "." + ">" + link + "\n\n");
                        if (++processed == 3) break;

                    }




                    // return message.CreateReplyMessage("Day " + getDays(message.Text).ToString(), true).ConfigureAwait(false);

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://techguru.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes1 = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();
                    StringBuilder rssContent78 = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed1 = 1;

                    foreach (XmlNode rssNode in rssNodes1)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title1 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link1 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description1 = rssSubNode != null ? rssSubNode.InnerText : "";




                        rssContent1.Append("📰 " + title1 + "." + ">" + link1 + "\n\n");
                        rssContent78.Append(link1);
                        if (++processed1 == 3) break;


                    }



                    XmlDocument rssXmlDoc2 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://readme.lk/sinhala/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes2 = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent2 = new StringBuilder();
                    StringBuilder rssContent789 = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed2 = 1;

                    foreach (XmlNode rssNode in rssNodes2)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title2 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link2 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description2 = rssSubNode != null ? rssSubNode.InnerText : "";




                        rssContent1.Append("📰 " + title1 + "." + ">" + link1 + "\n\n");
                        rssContent78.Append(link1);
                        if (++processed2 == 3) break;


                    }




















                    // Return the string that contain the RSS items
                    string data1 = rssContent.ToString();
                    string data2 = rssContent1.ToString();



                    // return message.CreateReplyMessage("`Here are the latest technology news,`\n\n"+"\n\n"+ "![WindowsGeek](http://windowsgeek.lk/wp-content/uploads/2016/04/logo11.png)" + "\n" + data1 +
                    // "\n" + "\n" + "[More WindowsGeek News](http://windowsgeek.lk)" + "\n"+"\n"+"\n" + "\n\n![Techguru](http://techguru.lk/wp-content/uploads/2014/07/Logo-Tech-Guru-Pngd11.png)" + "\n" + data2 + "\n" + "\n"  +"[More TechGuru News](http://techguru.lk)" + "\n\n");




                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Windows Geek",
                        Message = "windows geek"
                        //Url = "http://windowsgeek.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions1 = new List<Microsoft.Bot.Connector.Action>();

                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Tech Guru",
                        Message = "techguru",
                        // Url = "http://techguru.lk"
                    });
                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });





                    var actions2 = new List<Microsoft.Bot.Connector.Action>();


                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Readme",
                        Message = "read me",
                        //Url = "http://readme.lk/sinhala"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });





                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description,
                        FallbackText = description,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions1
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        // Text = description2,
                        // FallbackText = description2,
                        Actions = actions2
                    });






                    return replyMessage;



























                }


                //BBC Sports

                else if (Regex.IsMatch(message.Text, "bbcsports", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "bbc sports", RegexOptions.IgnoreCase))
                {









                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://feeds.bbci.co.uk/sinhala/sport/rss.xml");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;



                }



















                //All sports

                else if (Regex.IsMatch(message.Text, "sports", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "sport", RegexOptions.IgnoreCase))
                {











                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://feeds.bbci.co.uk/sinhala/sport/rss.xml");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sports",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://bbc.com/sinhala"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;




                }




















                //All Gossip

                else if (Regex.IsMatch(message.Text, "gossip", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "gossips", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "deranagossips", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "derana gossips", RegexOptions.IgnoreCase))
                {









                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://sinhala2.adaderana.lk/webgossip/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More Derana Gossips",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk/webgossip"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More Derana Gossips",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk/webgossip"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More Derana Gossips",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk/webgossip"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More Derana Gossips",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk/webgossip"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More Derana Gossips",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk/webgossip"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More Derana Gossips",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://sinhala.adaderana.lk/webgossip"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        // Text = description1,
                        // FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        //Text = description2,
                        //FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        // Text = description3,
                        //FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //  Text = description4,
                        //  FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //  Text = description5,
                        // FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        //Text = description6,
                        // FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;



                }



                //derana biz

                else if (Regex.IsMatch(message.Text, "deranabiz", RegexOptions.IgnoreCase))
                {







                    XmlDocument rssXmlDoc = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://originbiz2.adaderana.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent = new StringBuilder();

                    // Iterate through the items in the RSS file

                    foreach (XmlNode rssNode in rssNodes)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        string title = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        string link = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        string description = rssSubNode != null ? rssSubNode.InnerText : "";




                        rssContent.Append("📰 " + title + "." + ">" + link + "\n\n");


                    }






                    // Return the string that contain the RSS items
                    String data1 = rssContent.ToString();


                    //return message.CreateReplyMessage("~News from Derana Biz," + "\n" + "\n" + data1);

                    return message.CreateReplyMessage("`Here are the latest business news from Derana,`\n\n" + "\n\n" + "![biz](http://biz.adaderana.lk/wp-content/uploads/2014/04/Biz-Final2-Land-compressedgfgf.png)" + "\n" + data1 +
                 "\n" + "\n" + "[More Derana Biz News](http://biz.adaderana.lk/)");





                }


















               










                //All local

                else if (Regex.IsMatch(message.Text, "local", RegexOptions.IgnoreCase))
                {

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";
                    string image = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";

                    string title3 = "";
                    string link3 = "";
                    string description3 = "";

                    string title4 = "";
                    string link4 = "";
                    string description4 = "";

                    string title5 = "";
                    string link5 = "";
                    string description5 = "";






                    XmlDocument rssXmlDoc = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://sinhala.adaderana.lk/rss.php");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes3 = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent3 = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed = 1;
                    int f = 0;
                    foreach (XmlNode rssNode in rssNodes3)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title1 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link1 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description1 = rssSubNode != null ? rssSubNode.InnerText : "";
                        image = Regex.Match(description1, @"<img\s+src='(.+)'\s+border='0'\s+/>").Groups[1].Value;

                        f = f + 1;







                        rssContent3.Append("📰 " + ". " + title1 + "." + ">" + link1 + "\n\n");
                        if (++processed == 5) break;

                    }




                    // return message.CreateReplyMessage("Day " + getDays(message.Text).ToString(), true).ConfigureAwait(false);

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://www.itnnews.lk/sinhala/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes4 = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent4 = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed1 = 1;
                    int g = 0;
                    foreach (XmlNode rssNode in rssNodes4)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title2 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link2 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description2 = rssSubNode != null ? rssSubNode.InnerText : "";


                        g = g + 1;

                        rssContent4.Append("📰 " + ". " + title2 + "." + "\n\n");
                        if (++processed1 == 5) break;

                    }



                    XmlDocument rssXmlDoc5 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://nethnews.lk/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes5 = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent5 = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed5 = 1;
                    int j = 0;
                    foreach (XmlNode rssNode in rssNodes5)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title3 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link3 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description3 = rssSubNode != null ? rssSubNode.InnerText : "";


                        j = j + 1;

                        rssContent5.Append("📰 " + ". " + title3 + "." + ">" + link3 + "\n\n\n\n");
                        if (++processed5 == 5) break;

                    }



                    XmlDocument rssXmlDoc6 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://feeds.bbci.co.uk/sinhala/rss.xml");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes6 = rssXmlDoc.SelectNodes("rss/channel/item");

                    System.Text.StringBuilder rssContent6 = new StringBuilder();

                    // Iterate through the items in the RSS file
                    int processed6 = 1;
                    int k = 0;
                    foreach (XmlNode rssNode in rssNodes6)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title4 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link4 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description4 = rssSubNode != null ? rssSubNode.InnerText : "";



                        k = k + 1;
                        //rssContent6.Append(k + ". "+ title + "." +  "\n" + link + "\n\n");
                        rssContent6.Append("📰 " + ". " + title4 + "." + ">" + link4 + "\n\n");

                        if (++processed6 == 5) break;

                    }


                    XmlDocument rssXmlDoc7 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc.Load("http://newsfirst.lk/sinhala/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes7 = rssXmlDoc.SelectNodes("rss/channel/item");

                    StringBuilder rssContent7 = new StringBuilder();
                    int processed7 = 1;
                    // Iterate through the items in the RSS file
                    foreach (XmlNode rssNode in rssNodes7)
                    {
                        XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                        title5 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("link");
                        link5 = rssSubNode != null ? rssSubNode.InnerText : "";

                        rssSubNode = rssNode.SelectSingleNode("description");
                        description5 = rssSubNode != null ? rssSubNode.InnerText : "";




                        rssContent7.Append("📰 " + title5 + "." + "\n\n");

                        if (++processed7 == 5) break;

                    }

                    // Return the string that contain the RSS items





















                    // Return the string that contain the RSS items
                    String data3 = rssContent3.ToString();
                    String data4 = rssContent4.ToString();
                    String data5 = rssContent5.ToString();
                    String data6 = rssContent6.ToString();
                    string data7 = rssContent7.ToString();

                    // return message.CreateReplyMessage("`Here are the latest local news,`"+ "![adaderana](http://windowsgeek.lk/wp-content/uploads/2016/04/logo11.png)" + "\n" + "\n" +
                    //data3 + "\n" + "\n" + "![neth](http://windowsgeek.lk/wp-content/uploads/2016/04/logo11.png)" + "\n" + "\n" + data5 + "\n" + "\n" +
                    //"![bbc](http://windowsgeek.lk/wp-content/uploads/2016/04/logo11.png)" + "\n" + "\n" + data6 + "\n" + "\n");

                    ////
                    //            return message.CreateReplyMessage("`Here are the latest local news from various news providers,`\n\n" + "\n\n" + "![adaderana](http://a5.mzstatic.com/us/r30/Purple/v4/b3/1c/76/b31c7620-809c-915d-42d6-b6ba8f98ff10/icon175x175.jpeg)" + "\n" + data3 +
                    //           "\n" + "\n" + "[More Ada Derana News](http://sinhala.adaderana.lk)" + "\n" + "\n" +

                    //         "\n\n" + "![itn](https://upload.wikimedia.org/wikipedia/en/0/06/ITN_channel_logo.png)" + "\n" + data4 +
                    //      "\n" + "\n" + "[More ITN News](http://itnnews.lk)"+

                    //      "\n\n" + "![sirasa](https://upload.wikimedia.org/wikipedia/en/9/96/News_First_logo.png)" + "\n" + data7 +
                    //    "\n" + "\n" + "[More Sirasa News](http://newsfirst.lk/sinhala/)"+
                    //
                    //    "\n\n" + "![neth](http://www.liveradio.me/wp-content/uploads/2013/09/neth-fm-online-logo.jpg)" + "\n" + data5 +
                    //   "\n" + "\n" + "[More Neth News](http://nethfm.com)"+

                    //   "\n\n" + "![bbc](http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png)" + "\n" + data6 +
                    //  "\n" + "\n" + "[More BBC News](http://www.bbc.com/sinhala)"





























                    // );

                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Ada Derana",
                        Message = "adaderana"
                        //Url="http://sinhala.adaderana.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions1 = new List<Microsoft.Bot.Connector.Action>();

                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from ITN News",
                        Message = "itn"
                        //Url = "http://itnnews.lk"
                    });
                    actions1.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });





                    var actions2 = new List<Microsoft.Bot.Connector.Action>();


                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Neth News",
                        Message = "neth"
                        //Url = "http://nethfm.com"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });

                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });




                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from BBC Sinhala",
                        Message = "bbc"
                        //Url = "http://bbc.com/sinhala"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from News First",
                        Message = "sirasa"
                        //Url = "http://newsfirst.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });




                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions1
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions3
                    });




                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        // TitleLink = link5,
                        //ThumbnailUrl = "http://newsfirst.lk/english/wp-content/uploads/2015/11/Newsfirst.jpg",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions4
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        // TitleLink = link3,
                        //ThumbnailUrl = "http://www.listenfmradios.com/wp-content/uploads/2013/04/Neth-FM-Sri-Lanka-Logo.jpg",
                        // Text = description3,
                        // FallbackText = description3,
                        Actions = actions2
                    });




                    return replyMessage;








                }

                else if (Regex.IsMatch(message.Text, "entertainment", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "entertain", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "fun", RegexOptions.IgnoreCase))
                {

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://newsfirst.lk/sinhala/category/entertainment/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Entertainment",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/entertainment"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Entertainment",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/entertainment"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Entertainment",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/entertainment"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Entertainment",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/entertainment"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Entertainment",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/entertainment"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Entertainment",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/entertainment"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;










                }

                else if (Regex.IsMatch(message.Text, "international", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "foreign", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "world", RegexOptions.IgnoreCase))
                {

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://newsfirst.lk/sinhala/category/world/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa World News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/world"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa World News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/world"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa World News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/world"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa World News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/world"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa World News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/world"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa World News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/world"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;










                }


                else if (Regex.IsMatch(message.Text, "business", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "biz", RegexOptions.IgnoreCase))
                {

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://newsfirst.lk/sinhala/category/business/feed/");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Business News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/business"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Business News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/business"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Business News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/business"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Business News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/business"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Business News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/business"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Sirasa Business News",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://newsfirst.lk/sinhala/category/business"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;










                }

                else if (Regex.IsMatch(message.Text, "movies", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "movie", RegexOptions.IgnoreCase)  || Regex.IsMatch(message.Text, "film", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "films", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "cinema", RegexOptions.IgnoreCase))
                {

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://feeds.feedburner.com/Cinemalk?format=xml");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";



                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);



                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });



                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Cinema.lk",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://cinema.lk"
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Cinema.lk",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://cinema.lk"
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Cinema.lk",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://cinema.lk"
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Cinema.lk",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://cinema.lk"
                    });
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Cinema.lk",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://cinema.lk"
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Read Full Story",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "More from Cinema.lk",
                        //Message = "What are the latest adaderana news?"
                        Url = "http://cinema.lk"
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = description1,
                        FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                        Text = description2,
                        FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description3,
                        FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description4,
                        FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description5,
                        FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                        Text = description6,
                        FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;










                }















                else if (Regex.IsMatch(message.Text, "songs", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "song", RegexOptions.IgnoreCase))
                {

                    XmlDocument rssXmlDoc1 = new XmlDocument();

                    // Load the RSS file from the RSS URL
                    rssXmlDoc1.Load("http://www.hirufm.lk/rss-music.xml");

                    // Parse the Items in the RSS file
                    XmlNodeList rssNodes = rssXmlDoc1.SelectNodes("rss/channel/item");

                    StringBuilder rssContent1 = new StringBuilder();

                    // Iterate through the items in the RSS file


                    string title6 = "";
                    string link6 = "";
                    string description6 = "";

                    string title1 = "";
                    string link1 = "";
                    string description1 = "";

                    string title2 = "";
                    string link2 = "";
                    string description2 = "";


                    string title3 = "";
                    string link3 = "";
                    string description3 = "";


                    string title4 = "";
                    string link4 = "";
                    string description4 = "";


                    string title5 = "";
                    string link5 = "";
                    string description5 = "";

             



                    XmlNode rssNode1 = rssNodes[0];
                    XmlNode rssNode2 = rssNodes[1];
                    XmlNode rssNode3 = rssNodes[2];
                    XmlNode rssNode4 = rssNodes[3];
                    XmlNode rssNode5 = rssNodes[4];
                    XmlNode rssNode6 = rssNodes[5];


                    replyMessage.Attachments = new List<Attachment>();

                    XmlNode rssSubNode1 = rssNode1.SelectSingleNode("title");
                    title1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("link");
                    link1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";

                    rssSubNode1 = rssNode1.SelectSingleNode("description");
                    description1 = rssSubNode1 != null ? rssSubNode1.InnerText : "";





                    XmlNode rssSubNode2 = rssNode2.SelectSingleNode("title");
                    title2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("link");
                    link2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";

                    rssSubNode2 = rssNode2.SelectSingleNode("description");
                    description2 = rssSubNode2 != null ? rssSubNode2.InnerText : "";


                    XmlNode rssSubNode3 = rssNode3.SelectSingleNode("title");
                    title3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("link");
                    link3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";

                    rssSubNode3 = rssNode3.SelectSingleNode("description");
                    description3 = rssSubNode3 != null ? rssSubNode3.InnerText : "";


                    XmlNode rssSubNode4 = rssNode4.SelectSingleNode("title");
                    title4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";

                    rssSubNode3 = rssNode4.SelectSingleNode("link");
                    link4 = rssSubNode3 != null ? rssSubNode4.InnerText : "";

                    rssSubNode4 = rssNode4.SelectSingleNode("description");
                    description4 = rssSubNode4 != null ? rssSubNode4.InnerText : "";


                    XmlNode rssSubNode5 = rssNode5.SelectSingleNode("title");
                    title5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("link");
                    link5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";

                    rssSubNode5 = rssNode5.SelectSingleNode("description");
                    description5 = rssSubNode5 != null ? rssSubNode5.InnerText : "";



                    XmlNode rssSubNode6 = rssNode6.SelectSingleNode("title");
                    title6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("link");
                    link6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";

                    rssSubNode6 = rssNode6.SelectSingleNode("description");
                    description6 = rssSubNode6 != null ? rssSubNode6.InnerText : "";




                    //rssContent1.Append("📰 " + title + "." + ">" + link + "\n\n"+ title1 + "." + ">" + link1 + "\n\n");                

                    // Return the string that contain the RSS items
                    string data = rssContent1.ToString();


                    //return message.CreateReplyMessage(data);

                   string color1 = link1.Split('/')[4];
                   string color11 = color1.Split('-')[2];

                   string down1 = "http://www.hirufm.lk/music/download-" + color11 + "-ac3d3fafed2f293aa9a163b8f90b4d83";


                   


                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "View Details",
                        //Message = "What are the latest local news?",
                        Url = link1
                    });

                 

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Download",
                        //Message = "What are the latest adaderana news?"
                        Url = down1
                    });
                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                   string color2 = link2.Split('/')[4];
                    string color22 = color2.Split('-')[2];

                  string down2 = "http://www.hirufm.lk/music/download-" + color22 + "-ac3d3fafed2f293aa9a163b8f90b4d83";


                   



                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "View Details",
                        //Message = "What are the latest local news?",
                        Url = link2
                    });



                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Download",
                        //Message = "What are the latest adaderana news?"
                        Url = down2
                    });
                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                 string color3 = link3.Split('/')[4];
                 string color33 = color3.Split('-')[2];

                   string down3 = "http://www.hirufm.lk/music/download-" + color33 + "-ac3d3fafed2f293aa9a163b8f90b4d83";


                    




                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "View Details",
                        //Message = "What are the latest local news?",
                        Url = link3
                    });



                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Download",
                        //Message = "What are the latest adaderana news?"
                        Url = down3
                    });
                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


             //string color7 = link4.Split('/')[4];
             //string color77 = color7.Split('-')[2];

            //string down7 = "http://www.hirufm.lk/music/download-" + color77 + "-ac3d3fafed2f293aa9a163b8f90b4d83";

                   

                    var actions4 = new List<Microsoft.Bot.Connector.Action>();

                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "View Details",
                        //Message = "What are the latest local news?",
                        Url = link4
                    });



                 
                    actions4.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });

            string  color5 = link5.Split('/')[4];
         string color55 = color5.Split('-')[2];

            string  down5 = "http://www.hirufm.lk/music/download-" + color55 + "-ac3d3fafed2f293aa9a163b8f90b4d83";

                   
                    var actions5 = new List<Microsoft.Bot.Connector.Action>();

                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "View Details",
                        //Message = "What are the latest local news?",
                        Url = link5
                    });



                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Download",
                        //Message = "What are the latest adaderana news?"
                   Url = down5
                    });
                    actions5.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });


                 string color6 = link6.Split('/')[4];
              string color66 = color6.Split('-')[2];

             string  down6 = "http://www.hirufm.lk/music/download-" + color66 + "-ac3d3fafed2f293aa9a163b8f90b4d83";


                    var actions6 = new List<Microsoft.Bot.Connector.Action>();

                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "View Details",
                        //Message = "What are the latest local news?",
                        Url = link6
                    });



                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Download",
                        //Message = "What are the latest adaderana news?"
                     Url = down6
                    });
                    actions6.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Help",
                        Message = "Help"
                    });



                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title1,
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                       // Text = description1,
                        //FallbackText = description1,
                        Actions = actions
                    });



                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title2,
                        //TitleLink = link2,
                        // ThumbnailUrl = "https://yt3.ggpht.com/-rViQMqs9Uwk/AAAAAAAAAAI/AAAAAAAAAAA/QgivG1cJHYs/s900-c-k-no/photo.jpg",
                      //  Text = description2,
                       // FallbackText = description2,
                        Actions = actions2
                    });





                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title3,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                      //  Text = description3,
                      //  FallbackText = description3,
                        Actions = actions3
                    });


                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title4,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                      //  Text = description4,
                      //  FallbackText = description4,
                        Actions = actions4
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title5,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                      //  Text = description5,
                       // FallbackText = description5,
                        Actions = actions5
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = title6,
                        //TitleLink = link4,
                        //  ThumbnailUrl = "http://www.bbc.co.uk/news/special/2015/newsspec_11063/sinhala_1024x576.png",
                      //  Text = description6,
                      //  FallbackText = description6,
                        Actions = actions6
                    });



                    return replyMessage;










                }




                else if (Regex.IsMatch(message.Text, "latest news", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "news", RegexOptions.IgnoreCase) || Regex.IsMatch(message.Text, "latest", RegexOptions.IgnoreCase))
                {
                    var actions = new List<Microsoft.Bot.Connector.Action>();

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Local News",
                        Message = "local news",

                    });

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Sports News",
                        Message = "sports news",

                    });

                    actions.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Technology News",
                        Message = "tech news",

                    });



                    var actions2 = new List<Microsoft.Bot.Connector.Action>();

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "International News",
                        Message = "world",

                    });

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Entertainment News",
                        Message = "fun",

                    });

                    actions2.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Business News",
                        Message = "biz",

                    });



                    var actions3 = new List<Microsoft.Bot.Connector.Action>();

                    actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                        Title = "Latest Sinhala Songs",
                        Message = "songs",

                    });

                actions3.Add(new Microsoft.Bot.Connector.Action
                    {
                       Title = "Latest Cinema News",
                      Message = "cinema",

                   });

                    //actions3.Add(new Microsoft.Bot.Connector.Action
                   // {
                    //    Title = "Business News",
                    //    Message = "biz",

                   // });




                    replyMessage.Attachments = new List<Attachment>();

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "How can I help you?",
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = "Please select a news type",
                        FallbackText = "Please select a news type",
                        Actions = actions
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "How can I help you?",
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = "Please select a news type",
                        FallbackText = "Please select a news type",
                        Actions = actions2
                    });

                    replyMessage.Attachments.Add(new Attachment()
                    {
                        Title = "How can I help you?",
                        //TitleLink = link1,
                        // ThumbnailUrl = "http://adaderana.lk/news_images/1297714456ada3.jpg",
                        Text = "Please select a news type",
                        FallbackText = "Please select a news type",
                        Actions = actions3
                    });

                    return replyMessage;


                }



                else if (Regex.IsMatch(message.Text, "hey", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("Hey, Hope you are doing well. Puwath Bot brings you latest news in Sinhala. make no sence, Type help");


                }



                else if (Regex.IsMatch(message.Text, "hello", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("Hello, Hope you are doing well. Puwath Bot brings you latest news in Sinhala. make no sence, Type help");


                }
                else if (Regex.IsMatch(message.Text, "hi", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("Hi, Hope you are doing well. Puwath Bot brings you latest news in Sinhala. make no sence, Type help");


                }

                else if (Regex.IsMatch(message.Text, "how", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("I am fine, Hope you too doing well. Puwath Bot brings you latest news in Sinhala. make no sence, Type help");


                }


















                else if (Regex.IsMatch(message.Text, "commands", RegexOptions.IgnoreCase))


                {
                    return message.CreateReplyMessage("List of commands," + "\n" + "\n" +

                   "* " + "local - Latest Local News" + "\n" + "* " + "business - Latest Business News" + "\n" +
                        "* " + "International - Latest International News" + "\n" + "* " + "tech - Latest Tech News" + "\n" + "* " +
                        "gossip - Latest Gossips" + "\n" + "* " + "sport - Latest Sports News" + "\n" +
                        "\n" + "* " + "adaderana - Adaderana Sinhala News" + "\n" + "* " +
                        "sirasa - Sirasa Sinhala News" + "\n" + "* " + "neth - Neth Sinhala News" + "\n" + "* " +
                        "itn - ITN Sinhala News" + "\n" + "* " + "bbc - BBC Sinhala News" + "\n" + "* " +
                        "techguru - Techguru News" + "\n" + "* " + "windowsgeek - Windows Geek Sinhala News" + "\n" + "* " +
                        "deranabiz - Derana Business Sinhala News" + "\n" + "* " + "bbcsport - BBC Sports Sinhala News" + "\n" + "* " +
                        "deranagossip -  Derana Sinhala Gossips");




                }


                else if (Regex.IsMatch(message.Text, "thanks", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("(Y)");
                }

                else if (Regex.IsMatch(message.Text, "great", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("(Y)");
                }

                else if (Regex.IsMatch(message.Text, "(Y)", RegexOptions.IgnoreCase))
                {
                    return message.CreateReplyMessage("(Y)");
                }



                //Get attachment
            
                else
                {
                    return message.CreateReplyMessage("Sorry, I didn't get you. If you need help, Type Help");
                }



            }
            else
            {
                return HandleSystemMessage(message);
            }
        }

        private Message HandleSystemMessage(Message message)
        {
            if (message.Type == "Ping")
            {
                Message reply = message.CreateReplyMessage();
                reply.Type = "Ping";
                return reply;
            }
            else if (message.Type == "DeleteUserData")
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == "BotAddedToConversation")
            {
                return message.CreateReplyMessage("Hello, Puwath Bot brings you latest news in Sinhala.For help, Type Help");
            }
            else if (message.Type == "BotRemovedFromConversation")
            {
                return message.CreateReplyMessage("Thank you. Have a nice day");
            }
            else if (message.Type == "UserAddedToConversation")
            {
                return message.CreateReplyMessage("Hello, Puwath Bot brings you latest news in Sinhala. For help, Type Help");
            }
            else if (message.Type == "UserRemovedFromConversation")
            {
                return message.CreateReplyMessage("Thank you. Have a nice day");
            }
            else if (message.Type == "EndOfConversation")
            {
                return message.CreateReplyMessage("Thank you. Have a nice day");
            }
           

            return null;
        }
    }
   


    public class Scores
    {
        public double anger { get; set; }
        public double contempt { get; set; }
        public double disgust { get; set; }
        public double fear { get; set; }
        public double happiness { get; set; }
        public double neutral { get; set; }
        public double sadness { get; set; }
        public double surprise { get; set; }
    }

    public class EmotionResult
    {
        public Scores scores { get; set; }
    }
}
