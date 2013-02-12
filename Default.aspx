<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="styles/style.css" />
</head>
<body>
    <form id="form1" runat="server">
    
        <div style="position: absolute; float: left; width: 110px; height: 113px; top: 20px; left: 1150px; z-index: 7;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.png" />
        </div>
        <div style="position: absolute; float: left; width: 351px; height: 56px; top: 600px; left: 175px; z-index: 7;">
            <asp:Image ID="title" runat="server" ImageUrl="~/Images/title.png" />
        </div>
        <asp:Panel ID="radio_play_button_panel" runat="server" style="position: absolute; float: left; width:182px; height: 161px; top: 200px; left: 542px; z-index: 7;">
            <asp:ImageButton ID="radio_play_button" runat="server" ImageUrl="~/Images/play_button.png" OnClick="play_button_Click" />
        </asp:Panel>
        <asp:Panel ID="radio_pause_button_panel" runat="server" style="position: absolute; float: left; width:182px; height: 161px; top: 200px; left: 726px; z-index: 7;">
            <asp:ImageButton ID="radio_pause_button" runat="server" ImageUrl="~/Images/pause_button.png" OnClick="pause_button_Click" />
        </asp:Panel>
        <asp:Panel ID="radio_trackname_panel" runat="server" style="position: absolute; float: left; width: 371px; height: 69px; top: 355px; left: 542px; z-index: 7;">
            <asp:Image ID="radio_trackname" runat="server" ImageUrl="~/Images/trackname.png" />
        </asp:Panel>
        <asp:Panel ID="radio_play_trackname_panel" runat="server" style="position: absolute; float: left; width: 371px; height: 69px; top: 354px; left: 542px; z-index: 7;">
            <asp:Image ID="radio_play_trackname" runat="server" ImageUrl="~/Images/play_trackname.png" />
        </asp:Panel>
        <asp:Panel ID="radio_pause_trackname_panel" runat="server" style="position: absolute; float: left; width: 371px; height: 69px; top: 354px; left: 542px; z-index: 7;">
            <asp:Image ID="radio_pause_trackname" runat="server" ImageUrl="~/Images/pause_trackname.png" />
        </asp:Panel>

        <asp:Panel ID="contact_text_panel" runat="server" style="position: absolute; float: left;width: 704px; height: 442px; top: 148px; left: 250px; z-index: 7;">
            <p class="title">E-mail: <u class="text"><a href="mailto:merededieu.fm@gmail.com">merededieu.fm@gmail.com</a></u></p>
            <p class="text"></p>
        </asp:Panel>
        
        <asp:Panel ID="play_background_panel" runat="server" style="position: absolute; float: left; width: 1110px; height: 432px; top: 0px; left: 170px; z-index: 6;">
            <asp:Image ID="play_background" runat="server" ImageUrl="~/Images/play_background.png" />
        </asp:Panel>
        <asp:Panel ID="videos_background_panel" runat="server" style="position: absolute; float: left; width: 1110px; height: 432px; top: 0px; left: 170px; z-index: 6;">
            <asp:Image ID="videos_background" runat="server" ImageUrl="~/Images/videos_background.png" />
        </asp:Panel>
        <asp:Panel ID="news_background_panel" runat="server" style="position: absolute; float: left; width: 1110px; height: 432px; top: 0px; left: 170px; z-index: 6;">
            <asp:Image ID="news_background" runat="server" ImageUrl="~/Images/news_background.png" />
        </asp:Panel>
        <asp:Panel ID="about_background_panel" runat="server" style="position: absolute; float: left; width: 1110px; height: 432px; top: 0px; left: 170px; z-index: 6;">
            <asp:Image ID="about_background" runat="server" ImageUrl="~/Images/about_background.png" />
        </asp:Panel>
        <asp:Panel ID="contact_background_panel" runat="server" style="position: absolute; float: left; width: 1110px; height: 432px; top: 0px; left: 170px; z-index: 6;">
            <asp:Image ID="contact_background" runat="server" ImageUrl="~/Images/contact_background.png" />
        </asp:Panel>
        <asp:Panel ID="play_button_panel" runat="server" style="position: absolute; float: left; width: 170px; height: 70px; top: 0px; left:0px; z-index: 5;">
            <asp:ImageButton ID="play_button" runat="server" ImageUrl="~/Images/play_clicked.png" Height="72px" OnClick="play_Click" />
        </asp:Panel>
        <asp:Panel ID="videos_button_panel" runat="server" style="position: absolute; float: left; width: 170px; height: 70px; top: 70px; left:0px; z-index: 4;">
            <asp:ImageButton ID="videos_button" runat="server" ImageUrl="~/Images/videos.png" OnClick="videos_Click" />
        </asp:Panel>
        <asp:Panel ID="news_button_panel" runat="server" style="position: absolute; float: left; width: 170px; height: 70px; top: 140px; left:0px; z-index: 3;">
            <asp:ImageButton ID="news_button" runat="server" ImageUrl="~/Images/news.png" OnClick="news_Click" />
        </asp:Panel>
        <asp:Panel ID="about_button_panel" runat="server" style="position: absolute; float: left; width: 170px; height: 70px; top: 210px; left:0px; z-index: 2;">
            <asp:ImageButton ID="about_button" runat="server" ImageUrl="~/Images/about.png" OnClick="about_Click" />
        </asp:Panel>
        <asp:Panel ID="contact_panel" runat="server" style="position: absolute; float: left; width: 170px; height: 70px; top: 280px; left:0px; z-index: 1;">
            <asp:ImageButton ID="contact_button" runat="server" ImageUrl="~/Images/contact.png" OnClick="contact_Click" />
        </asp:Panel>
        
    </form>
</body>
</html>
