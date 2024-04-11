using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Extras
{
    public static class Televisor
    {
        public static Dictionary<string,Face> getFaces()
        {
            int valorX = 10;
            int valorY = 10;
            int valorZ = 3;
            int distY = 12;
            Dictionary<string, Face> list_faces = new Dictionary<string, Face>();

            Dictionary<string, Coordinate> back_list_points = new Dictionary<string, Coordinate>();
            back_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            back_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            back_list_points.Add("right-button", new Coordinate(+valorX, -valorY, -valorZ));
            back_list_points.Add("left-button", new Coordinate(-valorX, -valorY, -valorZ));

            Dictionary<string, Coordinate> front_list_points = new Dictionary<string, Coordinate>();
            front_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            front_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            front_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
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
            bottom_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));

            valorX = 8;
            valorY = 8;
            valorZ = 4;
            Dictionary<string, Coordinate> screen_list_points = new Dictionary<string, Coordinate>();
            screen_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            screen_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            screen_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            screen_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));

            list_faces.Add("back", new Face(back_list_points, Color.Aqua));
            list_faces.Add("front", new Face(front_list_points, Color.Red));
            list_faces.Add("left", new Face(left_list_points, Color.Magenta));
            list_faces.Add("right", new Face(right_list_points, Color.LimeGreen));
            list_faces.Add("top", new Face(top_list_points, Color.Black));
            list_faces.Add("bottom", new Face(bottom_list_points, Color.Blue));
            list_faces.Add("screen", new Face(screen_list_points, Color.Gray));
            
             valorX = 2;
             valorY = 2;
             valorZ = 2;
              
            
            
            Dictionary<string, Coordinate> back_support_list_points = new Dictionary<string, Coordinate>();
            back_support_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            back_support_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            back_support_list_points.Add("right-button", new Coordinate(+valorX, -valorY -distY, -valorZ));
            back_support_list_points.Add("left-button", new Coordinate(-valorX, -valorY -distY, -valorZ));

            Dictionary<string, Coordinate> front_support_list_points = new Dictionary<string, Coordinate>();
            front_support_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            front_support_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            front_support_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            front_support_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));

            Dictionary<string, Coordinate> left_support_list_points = new Dictionary<string, Coordinate>();
            left_support_list_points.Add("left-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            left_support_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            left_support_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            left_support_list_points.Add("left-button", new Coordinate(+valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> right_support_list_points = new Dictionary<string, Coordinate>();
            right_support_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            right_support_list_points.Add("right-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            right_support_list_points.Add("right-button", new Coordinate(-valorX, -valorY - distY, +valorZ));
            right_support_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));


            list_faces.Add("back_support", new Face(back_support_list_points, Color.Black));
            list_faces.Add("front_support", new Face(front_support_list_points, Color.Black));
            list_faces.Add("left_support", new Face(left_support_list_points, Color.Black));
            list_faces.Add("right_support", new Face(right_support_list_points, Color.Black));

            valorX = 5;
            valorY = 1;
            valorZ = 2;
             distY = 15;


            Dictionary<string, Coordinate> back_base_list_points = new Dictionary<string, Coordinate>();
            back_base_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            back_base_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            back_base_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, -valorZ));
            back_base_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> front_base_list_points = new Dictionary<string, Coordinate>();
            front_base_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            front_base_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            front_base_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            front_base_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));

            Dictionary<string, Coordinate> left_base_list_points = new Dictionary<string, Coordinate>();
            left_base_list_points.Add("left-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            left_base_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            left_base_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            left_base_list_points.Add("left-button", new Coordinate(+valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> right_base_list_points = new Dictionary<string, Coordinate>();
            right_base_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            right_base_list_points.Add("right-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            right_base_list_points.Add("right-button", new Coordinate(-valorX, -valorY - distY, +valorZ));
            right_base_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));


            list_faces.Add("back_base", new Face(back_base_list_points, Color.Black));
            list_faces.Add("front_base", new Face(front_base_list_points, Color.Black));
            list_faces.Add("left_base", new Face(left_base_list_points, Color.Black));
            list_faces.Add("right_base", new Face(right_base_list_points, Color.Black));

            return list_faces;
        }
    }
}
