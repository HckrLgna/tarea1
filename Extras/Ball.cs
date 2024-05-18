using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Extras
{
    public static class Ball
    {
        public static Dictionary<string, Part> getParts()
        {
            float valorX = 2.0f;
            float valorY = 2.0f;
            float valorZ = 2.0f;
           
            Dictionary<string, Part> parts = new Dictionary<string, Part>();
            Dictionary<string, Face> list_faces_base = new Dictionary<string, Face>();

            Dictionary<string, Coordinate> back_list_points = new Dictionary<string, Coordinate>();
            back_list_points.Add("left-top", new Coordinate(-valorX, +valorY , -valorZ));
            back_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            back_list_points.Add("right-button", new Coordinate(+valorX, -valorY   , -valorZ));
            back_list_points.Add("left-button", new Coordinate(-valorX, -valorY   , -valorZ));

            Dictionary<string, Coordinate> front_list_points = new Dictionary<string, Coordinate>();
            front_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            front_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            front_list_points.Add("right-button", new Coordinate(+valorX, -valorY   , +valorZ));
            front_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));

            Dictionary<string, Coordinate> left_list_points = new Dictionary<string, Coordinate>();
            left_list_points.Add("left-top", new Coordinate(+valorX, +valorY, -valorZ));
            left_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            left_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            left_list_points.Add("left-button", new Coordinate(+valorX, -valorY, -valorZ));

            Dictionary<string, Coordinate> right_list_points = new Dictionary<string, Coordinate>();
            right_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            right_list_points.Add("right-top", new Coordinate(-valorX, +valorY, +valorZ));
            right_list_points.Add("right-button", new Coordinate(-valorX, -valorY, +valorZ));
            right_list_points.Add("left-button", new Coordinate(-valorX, -valorY, -valorZ));

            Dictionary<string, Coordinate> top_list_points = new Dictionary<string, Coordinate>();
            top_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            top_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            top_list_points.Add("right-button", new Coordinate(+valorX, +valorY, +valorZ));
            top_list_points.Add("left-button", new Coordinate(-valorX, +valorY, +valorZ));

            Dictionary<string, Coordinate> bottom_list_points = new Dictionary<string, Coordinate>();
            bottom_list_points.Add("left-top", new Coordinate(-valorX, -valorY, -valorZ));
            bottom_list_points.Add("right-top", new Coordinate(+valorX, -valorY, -valorZ));
            bottom_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            bottom_list_points.Add("left-button", new Coordinate(-valorX, -valorY   , +valorZ));

           

            list_faces_base.Add("back", new Face(back_list_points, Color.Gray, new Coordinate()));
            list_faces_base.Add("front", new Face(front_list_points, Color.DarkGray, new Coordinate()));
            list_faces_base.Add("left", new Face(left_list_points, Color.Gray, new Coordinate()));
            list_faces_base.Add("right", new Face(right_list_points, Color.Gray, new Coordinate()));
            list_faces_base.Add("top", new Face(top_list_points, Color.Black, new Coordinate()));
            list_faces_base.Add("bottom", new Face(bottom_list_points, Color.Gray, new Coordinate()));
            parts.Add("main", new Part(list_faces_base, new Coordinate()));

            
            return parts;
        }

    }
}
