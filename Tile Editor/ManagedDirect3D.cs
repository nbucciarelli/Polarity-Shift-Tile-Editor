////////////////////////////////////////////////////////////////////////////////////////
//  File			:	"ManagedDirect3D.cs"
//
//  Author			:	David Brown (DB)
//
//  Date Created	:	6/25/2007
//
//  Purpose			:	Wrapper class for Managed Direct3D.
//
//  NOTE:   In order to use these wrapper classes you will need
//          to add References to the following assemblies to your Solution:
//
//          -Microsoft.DirectX              version: 1.0.2902.0 runtime: v1.1.4322
//          -Microsoft.DirectX.Direct3D     version: 1.0.2902.0 runtime: v1.1.4322
//          -Microsoft.DirectX.Direct3DX    version: 1.0.2902.0 runtime: v1.1.4322
////////////////////////////////////////////////////////////////////////////////////////
using System;               // for Int32
using System.Windows.Forms; // for MessageBox

using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace Tile_Editor
{
    public sealed class ManagedDirect3D
    {
        Microsoft.DirectX.Direct3D.Device device = null;
        Microsoft.DirectX.Direct3D.Sprite sprite = null;
        Microsoft.DirectX.Direct3D.Line line = null;
        Microsoft.DirectX.Direct3D.PresentParameters presentParams = null;

        Microsoft.DirectX.Direct3D.Font font = null;
        Microsoft.DirectX.Direct3D.FontDescription fontDescription;

        // thread-safe singleton
        static readonly ManagedDirect3D instance = new ManagedDirect3D();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static ManagedDirect3D()
        {
        }

        ManagedDirect3D()
        {
        }

        /// <summary>
        /// Gets the instance of the singleton.
        /// </summary>
        public static ManagedDirect3D Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Gets the Direct3D device.
        /// </summary>
        public Microsoft.DirectX.Direct3D.Device Device
        {
            get
            {
                return device;
            }
        }

        /// <summary>
        /// Gets the Sprite object.
        /// </summary>
        public Microsoft.DirectX.Direct3D.Sprite Sprite
        {
            get
            {
                return sprite;
            }
        }

        /// <summary>
        /// Initializes the Managed Direct3D Wrapper.
        /// </summary>
        /// <param name="renderWindow">Window to render to.</param>
        /// <param name="screenWidth">Width of the screen in pixels.</param>
        /// <param name="screenHeight">Height of the screen in pixels.</param>
        /// <param name="isWindowed">Is the application windowed or not (always pass true for now).</param>
        /// <param name="vsync">Should the renderer wait for a vsync before drawing?</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool InitManagedDirect3D(System.Windows.Forms.Control renderWindow, int screenWidth, int screenHeight, bool isWindowed, bool vsync)
        {
            try
            {
                // Now  setup our D3D present parameters
                presentParams = new PresentParameters();
                presentParams.BackBufferWidth = screenWidth;
                presentParams.BackBufferHeight = screenHeight;
                presentParams.BackBufferFormat = (isWindowed) ? Format.Unknown : Format.R5G6B5;
                presentParams.BackBufferCount = 1;
                presentParams.MultiSample = MultiSampleType.None;
                presentParams.MultiSampleQuality = 0;
                presentParams.SwapEffect = SwapEffect.Copy;// Discard;
                presentParams.DeviceWindow = renderWindow;
                presentParams.Windowed = isWindowed;
                presentParams.EnableAutoDepthStencil = false;
                presentParams.FullScreenRefreshRateInHz = 0;
                presentParams.PresentationInterval = (vsync) ? PresentInterval.Default : PresentInterval.Immediate;

                device = new Device(0, DeviceType.Hardware, renderWindow,
                        CreateFlags.HardwareVertexProcessing, presentParams);
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to Create D3D Device", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            try
            {
                sprite = new Microsoft.DirectX.Direct3D.Sprite(device);
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to Create the Sprite object", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            try
            {
                line = new Microsoft.DirectX.Direct3D.Line(device);

                line.Antialias = true;
                line.Width = 3.0f;
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to Create the Line Object", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            try
            {
                fontDescription.FaceName = "arial";
                fontDescription.Quality = FontQuality.Default;
                fontDescription.Weight = FontWeight.Bold;

                font = new Microsoft.DirectX.Direct3D.Font(device, fontDescription);

                line.Antialias = true;
                line.Width = 3.0f;
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to Create the font Object", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Handles resetting the device (Private utility function).
        /// </summary>
        private void Reset()
        {
            font.OnLostDevice();
            line.OnLostDevice();
            sprite.OnLostDevice();

            device.Reset(presentParams);

            font.OnResetDevice();
            sprite.OnResetDevice();
            line.OnResetDevice();
        }

        /// <summary>
        /// Clears the screen to a specific color.
        /// </summary>
        /// <param name="red">Red component of the color (0-255).</param>
        /// <param name="green">Green component of the color (0-255).</param>
        /// <param name="blue">Blue component of the color (0-255).</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool Clear(Int32 red, Int32 green, Int32 blue)
        {
            if (device == null)
                return false;

            //Clear the backbuffer to a color 
            device.Clear(ClearFlags.Target, System.Drawing.Color.FromArgb(red, green, blue), 1.0f, 0);

            // Check for alt+tab
            try
            {
                device.TestCooperativeLevel();
            }
            catch (DeviceLostException)
            {
            }
            catch (DeviceNotResetException)
            {
                Reset();
            }

            return true;
        }

        /// <summary>
        /// Begins the Device.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool DeviceBegin()
        {
            if (device == null)
                return false;

            try
            {
                device.BeginScene();
            }
            catch (InvalidCallException)
            {
                DialogResult r = MessageBox.Show("Failed to begin device scene.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Begins the Sprite.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool SpriteBegin()
        {
            if (sprite == null)
                return false;

            try
            {
                sprite.Begin(SpriteFlags.AlphaBlend);
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to begin sprite scene.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Begins the Line.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool LineBegin()
        {
            if (line == null)
                return false;

            try
            {
                line.Begin();
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to begin sprite scene.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Ends the Device.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool DeviceEnd()
        {
            if (device == null)
                return false;

            try
            {
                device.EndScene();
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to end device scene.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Ends the Sprite.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool SpriteEnd()
        {
            if (sprite == null)
                return false;

            try
            {
                sprite.End();
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to end sprite scene.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Ends the Line.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool LineEnd()
        {
            if (line == null)
                return false;

            try
            {
                line.End();
            }
            catch (Exception)
            {
                DialogResult r = MessageBox.Show("Failed to end line scene.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Present to the screen.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool Present()
        {
            if (device == null)
                return false;

            try
            {
                device.Present();
            }
            catch (Exception)
            {
                DialogResult r;
                r = MessageBox.Show("Failed to present.", "ManagedDirect3D::Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        // TODO:  Finish this function (they shouldn't be toggling window mode in C# tools though!)
        //public void ChangeDisplayParam(int screenWidth, int screenHeight, bool isWindowed)
        //{
        //    Reset();
        //}

        /// <summary>
        /// Draws a colored rectangle to the screen.
        /// </summary>
        /// <param name="rect">The rectangle holding the area to fill.</param>
        /// <param name="red">Red component of the color (0-255).</param>
        /// <param name="green">Green component of the color (0-255).</param>
        /// <param name="blue">Blue component of the color (0-255).</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool DrawRect(System.Drawing.Rectangle rect, Int32 red, Int32 green, Int32 blue)
        {
            if (device == null)
                return false;

            System.Drawing.Rectangle[] regions = new System.Drawing.Rectangle[1];
            regions[0] = rect;

            device.Clear(ClearFlags.Target, System.Drawing.Color.FromArgb(red, green, blue), 1.0f, 0, regions);

            return true;
        }

        /// <summary>
        /// Draws a colored line to the screen.
        /// </summary>
        /// <param name="x1">Starting X position.</param>
        /// <param name="y1">Starting Y position.</param>
        /// <param name="x2">Ending X position.</param>
        /// <param name="y2">Ending Y position.</param>
        /// <param name="red">Red component of the color (0-255).</param>
        /// <param name="green">Green component of the color (0-255).</param>
        /// <param name="blue">Blue component of the color (0-255).</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool DrawLine(int x1, int y1, int x2, int y2, Int32 red, Int32 green, Int32 blue)
        {
            if (line == null)
                return false;

            Vector2[] verts = new Vector2[2];

            verts[0].X = x1;
            verts[0].Y = y1;

            verts[1].X = x2;
            verts[1].Y = y2;

            line.Draw(verts, System.Drawing.Color.FromArgb(red, green, blue));

            return true;
        }

        /// <summary>
        /// Draws colored text to the screen.
        /// </summary>
        /// <param name="text">Text to print to the screen.</param>
        /// <param name="x">X position of text.</param>
        /// <param name="y">Y position of text.</param>
        /// <param name="red">Red component of the color (0-255).</param>
        /// <param name="green">Green component of the color (0-255).</param>
        /// <param name="blue">Blue component of the color (0-255).</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool DrawText(string text, int x, int y, Int32 red, Int32 green, Int32 blue)
        {
            if (font == null)
                return false;

            font.DrawText(sprite, text, new System.Drawing.Point(x, y), System.Drawing.Color.FromArgb(red, green, blue));

            return true;
        }

    } // end ManagedDirect3D
}
