using System;
using System.IO;
using Demos;
using static Retyped.dom;

namespace MLEM.Demos.Web {
    public class App {

        private static GameImpl game;

        public static void Main() {
            var canvas = new HTMLCanvasElement();
            canvas.width = 1280;
            canvas.height = 720;
            canvas.id = "monogamecanvas";
            document.body.appendChild(canvas);

            game = new GameImpl();
            game.Run();
        }

    }
}