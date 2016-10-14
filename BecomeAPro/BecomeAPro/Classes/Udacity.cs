using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BecomeAPro.Classes
{

    public class TeaserVideo
    {
        public string youtube_url { get; set; }
    }
    public class Cours
    {
        public List<object> instructors { get; set; }
        public string subtitle { get; set; }
        public string key { get; set; }
        public string image { get; set; }
        public string expected_learning { get; set; }
        public bool featured { get; set; }
        public string project_name { get; set; }
        public TeaserVideo teaser_video { get; set; }
        public string title { get; set; }
        public List<object> related_degree_keys { get; set; }
        public string required_knowledge { get; set; }
        public string syllabus { get; set; }
        public bool new_release { get; set; }
        public string homepage { get; set; }
        public string project_description { get; set; }
        public bool full_course_available { get; set; }
        public string faq { get; set; }
        public List<object> affiliates { get; set; }
        public List<object> tracks { get; set; }
        public string banner_image { get; set; }
        public string short_summary { get; set; }
        public string slug { get; set; }
        public bool starter { get; set; }
        public string level { get; set; }
        public string expected_duration_unit { get; set; }
        public string summary { get; set; }
        public int expected_duration { get; set; }
    }

    public class Track
    {
        public List<string> courses { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class TeaserVideo2
    {
        public string youtube_url { get; set; }
    }

    public class Degree
    {
        public List<object> instructors { get; set; }
        public string subtitle { get; set; }
        public string key { get; set; }
        public string image { get; set; }
        public string expected_learning { get; set; }
        public bool featured { get; set; }
        public string project_name { get; set; }
        public TeaserVideo2 teaser_video { get; set; }
        public string title { get; set; }
        public List<object> related_degree_keys { get; set; }
        public string required_knowledge { get; set; }
        public string syllabus { get; set; }
        public bool new_release { get; set; }
        public string homepage { get; set; }
        public string project_description { get; set; }
        public bool full_course_available { get; set; }
        public string faq { get; set; }
        public List<object> affiliates { get; set; }
        public List<object> tracks { get; set; }
        public string banner_image { get; set; }
        public string short_summary { get; set; }
        public string slug { get; set; }
        public bool starter { get; set; }
        public string level { get; set; }
        public string expected_duration_unit { get; set; }
        public string summary { get; set; }
        public int expected_duration { get; set; }
    }

    public class RootObject
    {
        public List<Cours> courses { get; set; }
        public List<Track> tracks { get; set; }
        public List<Degree> degrees { get; set; }
    }
    public class Udacity
    {
        
    }
}