using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Extras
{
    public static class Vase
    {
        public static Dictionary<string, Part> getParts()
        {
            int valorX = 3;
            int valorY = 5;
            int valorZ = 5;
            Dictionary<string, Face> list_faces = new Dictionary<string, Face>();
            Dictionary<string, Part> list_parts = new Dictionary<string, Part>();
            Dictionary<string, Coordinate> back_list_points = new Dictionary<string, Coordinate>();
            back_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            back_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            back_list_points.Add("right-button", new Coordinate(+valorX- 1.5f, -valorY, -valorZ));
            back_list_points.Add("left-button", new Coordinate(-valorX+ 1.5f, -valorY, -valorZ));

            Dictionary<string, Coordinate> front_list_points = new Dictionary<string, Coordinate>();
            front_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            front_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            front_list_points.Add("right-button", new Coordinate(+valorX- 1.5f, -valorY, +valorZ));
            front_list_points.Add("left-button", new Coordinate(-valorX+ 1.5f, -valorY, +valorZ));

            Dictionary<string, Coordinate> left_list_points = new Dictionary<string, Coordinate>();
            left_list_points.Add("left-top", new Coordinate(+valorX, +valorY, -valorZ));
            left_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            left_list_points.Add("right-button", new Coordinate(+valorX- 1.5f, -valorY, +valorZ));
            left_list_points.Add("left-button", new Coordinate(+valorX- 1.5f, -valorY, -valorZ));

            Dictionary<string, Coordinate> right_list_points = new Dictionary<string, Coordinate>();
            right_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            right_list_points.Add("right-top", new Coordinate(-valorX, +valorY, +valorZ));
            right_list_points.Add("right-button", new Coordinate(-valorX+1.5f, -valorY, +valorZ));
            right_list_points.Add("left-button", new Coordinate(-valorX+1.5f, -valorY, -valorZ));

            Dictionary<string, Coordinate> top_list_points = new Dictionary<string, Coordinate>();
            top_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            top_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            top_list_points.Add("right-button", new Coordinate(+valorX, +valorY, +valorZ));
            top_list_points.Add("left-button", new Coordinate(-valorX, +valorY, +valorZ));

            

            list_faces.Add("back", new Face(back_list_points, Color.Brown, new Coordinate()));
            list_faces.Add("front", new Face(front_list_points, Color.Brown, new Coordinate()));
            list_faces.Add("left", new Face(left_list_points, Color.Gray, new Coordinate()));
            list_faces.Add("right", new Face(right_list_points, Color.Gray, new Coordinate()));
            list_faces.Add("top", new Face(top_list_points, Color.DarkRed, new Coordinate()));
            
            list_parts.Add("main", new Part(list_faces, new Coordinate()));
            return list_parts;
        }

    }
}
