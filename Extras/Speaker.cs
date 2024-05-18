using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Extras
{
    public static class Speaker
    {
        public static Dictionary<string, Part> getParts()
        {
            float valorX = 4.4f;
            float valorY = 8.8f;
            float valorZ = 6.1f;
            float distY = 5;
            Dictionary<string, Part> parts = new Dictionary<string, Part>();
            Dictionary<string, Face> list_faces_base = new Dictionary<string, Face>();

            Dictionary<string, Coordinate> back_list_points = new Dictionary<string, Coordinate>();
            back_list_points.Add("left-top", new Coordinate(-valorX, +valorY-distY, -valorZ));
            back_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            back_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, -valorZ));
            back_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> front_list_points = new Dictionary<string, Coordinate>();
            front_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            front_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            front_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            front_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));

            Dictionary<string, Coordinate> left_list_points = new Dictionary<string, Coordinate>();
            left_list_points.Add("left-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            left_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            left_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            left_list_points.Add("left-button", new Coordinate(+valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> right_list_points = new Dictionary<string, Coordinate>();
            right_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            right_list_points.Add("right-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            right_list_points.Add("right-button", new Coordinate(-valorX, -valorY - distY, +valorZ));
            right_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> top_list_points = new Dictionary<string, Coordinate>();
            top_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            top_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            top_list_points.Add("right-button", new Coordinate(+valorX, +valorY - distY, +valorZ));
            top_list_points.Add("left-button", new Coordinate(-valorX, +valorY - distY, +valorZ));

            Dictionary<string, Coordinate> bottom_list_points = new Dictionary<string, Coordinate>();
            bottom_list_points.Add("left-top", new Coordinate(-valorX, -valorY - distY, -valorZ));
            bottom_list_points.Add("right-top", new Coordinate(+valorX, -valorY - distY, -valorZ));
            bottom_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            bottom_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));

            valorX = 2.0f;
            valorY = 2.0f;
            valorZ = 9.0f;
            distY = 6.0f;
            Dictionary<string, Coordinate> woofer_list_points = new Dictionary<string, Coordinate>();

            woofer_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            woofer_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            woofer_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            woofer_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));

            valorX = 3.50f;
            valorY = 3.50f;
            valorZ = 9.0f;
            distY = 8.0f;
            Dictionary<string, Coordinate> woofer_big_list_points = new Dictionary<string, Coordinate>();

            woofer_big_list_points.Add("left-top", new Coordinate(-valorX, +valorY-distY, +valorZ));
            woofer_big_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            woofer_big_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            woofer_big_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));


            list_faces_base.Add("back", new Face(back_list_points, Color.Black, new Coordinate()));
            list_faces_base.Add("front", new Face(front_list_points, Color.DarkGray, new Coordinate()));
            list_faces_base.Add("left", new Face(left_list_points, Color.Gray, new Coordinate()));
            list_faces_base.Add("right", new Face(right_list_points, Color.Gray, new Coordinate()));
            list_faces_base.Add("top", new Face(top_list_points, Color.Black, new Coordinate()));
            list_faces_base.Add("bottom", new Face(bottom_list_points, Color.Black, new Coordinate()));
            parts.Add("base", new Part(list_faces_base, new Coordinate()));

            Dictionary<string, Face> list_faces_woofer = new Dictionary<string, Face>();

            list_faces_woofer.Add("woofer_small", new Face(woofer_list_points, Color.LightBlue, new Coordinate()));
            list_faces_woofer.Add("woofer_big", new Face(woofer_big_list_points, Color.LightBlue, new Coordinate()));
            parts.Add("woofer", new Part(list_faces_woofer, new Coordinate()));

            return parts;
        }

    }
}
