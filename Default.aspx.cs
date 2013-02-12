using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //show play contents
        play_background_panel.Visible = true;
        radio_play_button_panel.Visible = true;
        radio_pause_button_panel.Visible = true;
        radio_trackname_panel.Visible = true;
        radio_play_trackname_panel.Visible = true;
        radio_pause_trackname_panel.Visible = false;

        //hide video contents
        videos_background_panel.Visible = false;

        //hide news contents
        news_background_panel.Visible = false;
        
        //hide about contents
        about_background_panel.Visible = false;

        //hide contact contents
        contact_background_panel.Visible = false;
        contact_text_panel.Visible = false;

        //set buttons images
        play_button.ImageUrl = "~/Images/play_clicked.png";
        videos_button.ImageUrl = "~/Images/videos.png";
        news_button.ImageUrl = "~/Images/news.png";
        about_button.ImageUrl = "~/Images/about.png";
        contact_button.ImageUrl = "~/Images/contact.png";
    }
    protected void play_Click(object sender, ImageClickEventArgs e)
    {
        //show play contents
        play_background_panel.Visible = true;
        radio_play_button_panel.Visible = true;
        radio_pause_button_panel.Visible = true;
        radio_trackname_panel.Visible = true;
        radio_play_trackname_panel.Visible = true;
        radio_pause_trackname_panel.Visible = false;

        //hide video contents
        videos_background_panel.Visible = false;

        //hide news contents
        news_background_panel.Visible = false;

        //hide about contents
        about_background_panel.Visible = false;

        //hide contact contents
        contact_background_panel.Visible = false;
        contact_text_panel.Visible = false;

        //set buttons images
        play_button.ImageUrl = "~/Images/play_clicked.png";
        videos_button.ImageUrl = "~/Images/videos.png";
        news_button.ImageUrl = "~/Images/news.png";
        about_button.ImageUrl = "~/Images/about.png";
        contact_button.ImageUrl = "~/Images/contact.png";
    }
    protected void videos_Click(object sender, ImageClickEventArgs e)
    {
        //hide play contents
        play_background_panel.Visible = false;
        radio_play_button_panel.Visible = false;
        radio_pause_button_panel.Visible = false;
        radio_trackname_panel.Visible = false;
        radio_play_trackname_panel.Visible = false;
        radio_pause_trackname_panel.Visible = false;

        //show video contents
        videos_background_panel.Visible = true;
        videos_background.Visible = true;

        //hide news contents
        news_background_panel.Visible = false;

        //hide about contents
        about_background_panel.Visible = false;

        //hide contact contents
        contact_background_panel.Visible = false;
        contact_text_panel.Visible = false;

        //set buttons images
        play_button.ImageUrl = "~/Images/play.png";
        videos_button.ImageUrl = "~/Images/videos_clicked.png";
        news_button.ImageUrl = "~/Images/news.png";
        about_button.ImageUrl = "~/Images/about.png";
        contact_button.ImageUrl = "~/Images/contact.png";
    }
    
    protected void news_Click(object sender, ImageClickEventArgs e)
    {
        //hide play contents
        play_background_panel.Visible = false;
        radio_play_button_panel.Visible = false;
        radio_pause_button_panel.Visible = false;
        radio_trackname_panel.Visible = false;
        radio_play_trackname_panel.Visible = false;
        radio_pause_trackname_panel.Visible = false;

        //hide video contents
        videos_background_panel.Visible = false;

        //show news contents
        news_background_panel.Visible = true;

        //hide about contents
        about_background_panel.Visible = false;

        //hide contact contents
        contact_background_panel.Visible = false;
        contact_text_panel.Visible = false;

        //set buttons images
        play_button.ImageUrl = "~/Images/play.png";
        videos_button.ImageUrl = "~/Images/videos.png";
        news_button.ImageUrl = "~/Images/news_clicked.png";
        about_button.ImageUrl = "~/Images/about.png";
        contact_button.ImageUrl = "~/Images/contact.png";
    }
    protected void about_Click(object sender, ImageClickEventArgs e)
    {
        //hide play contents
        play_background_panel.Visible = false;
        radio_play_button_panel.Visible = false;
        radio_pause_button_panel.Visible = false;
        radio_trackname_panel.Visible = false;
        radio_play_trackname_panel.Visible = false;
        radio_pause_trackname_panel.Visible = false;

        //hide video contents
        videos_background_panel.Visible = false;

        //hide news contents
        news_background_panel.Visible = false;

        //show about contents
        about_background_panel.Visible = true;

        //hide contact contents
        contact_background_panel.Visible = false;
        contact_text_panel.Visible = false;

        //set buttons images
        play_button.ImageUrl = "~/Images/play.png";
        videos_button.ImageUrl = "~/Images/videos.png";
        news_button.ImageUrl = "~/Images/news.png";
        about_button.ImageUrl = "~/Images/about_clicked.png";
        contact_button.ImageUrl = "~/Images/contact.png";
    }
    protected void contact_Click(object sender, ImageClickEventArgs e)
    {
        //hide play contents
        play_background_panel.Visible = false;
        radio_play_button_panel.Visible = false;
        radio_pause_button_panel.Visible = false;
        radio_trackname_panel.Visible = false;
        radio_play_trackname_panel.Visible = false;
        radio_pause_trackname_panel.Visible = false;

        //hide video contents
        videos_background_panel.Visible = false;

        //hide news contents
        news_background_panel.Visible = false;

        //hide about contents
        about_background_panel.Visible = true;

        //show contact contents
        contact_background_panel.Visible = true;
        contact_text_panel.Visible = true;

        //set buttons images
        play_button.ImageUrl = "~/Images/play.png";
        videos_button.ImageUrl = "~/Images/videos.png";
        news_button.ImageUrl = "~/Images/news.png";
        about_button.ImageUrl = "~/Images/about.png";
        contact_button.ImageUrl = "~/Images/contact_clicked.png";
    }
    protected void play_button_Click(object sender, ImageClickEventArgs e)
    {
        radio_play_trackname_panel.Visible = true;
        radio_pause_trackname_panel.Visible = false;
    }
    protected void pause_button_Click(object sender, ImageClickEventArgs e)
    {
        radio_play_trackname_panel.Visible = false;
        radio_pause_trackname_panel.Visible = true;
    }
}